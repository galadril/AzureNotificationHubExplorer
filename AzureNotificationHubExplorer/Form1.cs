using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.Azure.NotificationHubs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace AzureNotificationHubExplorer
{
    /// <summary>
    /// Defines the <see cref="frmExplorer" />.
    /// </summary>
    public partial class frmExplorer : MaterialForm
    {
        #region Constructor & Destructor

        /// <summary>
        /// Initializes a new instance of the <see cref="frmExplorer"/> class.
        /// </summary>
        public frmExplorer()
        {
            InitializeComponent();

            // Create a material theme manager and add the form to manage (this)
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE
            );
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the ConnectionString.
        /// </summary>
        public string ConnectionString { get; set; }

        /// <summary>
        /// Gets or sets the HubName.
        /// </summary>
        public string HubName { get; set; }

        /// <summary>
        /// Gets or sets the DefaultMessage.
        /// </summary>
        public string DefaultMessage { get; set; }

        /// <summary>
        /// Gets or sets the Client.
        /// </summary>
        public NotificationHubClient Client { get; set; }

        /// <summary>
        /// Gets or sets the Registrations.
        /// </summary>
        public List<RegistrationDescription> Registrations { get; set; }

        /// <summary>
        /// Gets or sets the Tags.
        /// </summary>
        public DataTable Tags { get; set; }

        #endregion

        #region Private

        /// <summary>
        /// The SetupConnection.
        /// </summary>
        /// <param name="refresh">The refresh<see cref="bool"/>.</param>
        private void SetupConnection(bool refresh)
        {
            try
            {
                ConnectionString = Properties.Settings.Default.ConnectionString;
                HubName = Properties.Settings.Default.Hubname;
                if (string.IsNullOrEmpty(ConnectionString) || refresh)
                {
                    using var form = new formConnection
                    {
                        ConnectionString = ConnectionString,
                        HubName = HubName
                    };
                    var result = form.ShowDialog();
                    if (result == System.Windows.Forms.DialogResult.OK)
                    {
                        ConnectionString = form.ConnectionString;
                        HubName = form.HubName;
                        Properties.Settings.Default.ConnectionString = ConnectionString;
                        Properties.Settings.Default.Hubname = HubName;
                        Properties.Settings.Default.Save();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// The frmExplorer_Load.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="System.EventArgs"/>.</param>
        private void frmExplorer_Load(object sender, System.EventArgs e)
        {
            SetupConnection(false);
            try
            {
                Client = NotificationHubClient.CreateClientFromConnectionString(ConnectionString, HubName);
                DefaultMessage = txtMessage.Text;
            }
            catch (Exception) { MessageBox.Show("Could not connect to Azure Notification Hub"); }
        }

        /// <summary>
        /// The btnConnect_Click_1.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void btnConnect_Click_1(object sender, EventArgs e)
        {
            SetupConnection(true); try
            {
                Client = NotificationHubClient.CreateClientFromConnectionString(ConnectionString, HubName);
            }
            catch (Exception) { MessageBox.Show("Could not connect to Azure Notification Hub"); }
        }

        /// <summary>
        /// The btnSearchRegistrations.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private async void btnSearchRegistrations(object sender, EventArgs e)
        {
            if(Client==null)
            {
                MessageBox.Show("Could not connect to Azure Notification Hub");
                return;
            }
            Registrations = new List<RegistrationDescription>();
            if (int.TryParse(txtRows.Text, out int rowCount))
            {
                if (!string.IsNullOrEmpty(txtTags.Text))
                    ProcessRegistrationList(await Client.GetRegistrationsByTagAsync(txtTags.Text, rowCount));
                else if (!string.IsNullOrEmpty(txtPNSHandler.Text))
                    ProcessRegistrationList(await Client.GetRegistrationsByChannelAsync(txtPNSHandler.Text, rowCount));
                else if (!string.IsNullOrEmpty(txtRegistrationId.Text))
                {
                    var result = await Client.GetRegistrationAsync<RegistrationDescription>(txtRegistrationId.Text);
                    PrintRegistration(result);
                    Registrations.Add(result);
                }
                else
                    ProcessRegistrationList(await Client.GetAllRegistrationsAsync(rowCount));
            }
            else
            {
                MessageBox.Show("Invalid row count");
            }
            gridRegistrations.DataSource = Registrations;
        }

        /// <summary>
        /// The ProcessRegistrationList.
        /// </summary>
        /// <param name="result">The result<see cref="CollectionQueryResult{RegistrationDescription}"/>.</param>
        private void ProcessRegistrationList(CollectionQueryResult<RegistrationDescription> result)
        {
            if (result == null)
                return;
            foreach (var r in result)
            {
                PrintRegistration(r);
                Registrations.Add(r);
            }
        }

        /// <summary>
        /// The PrintRegistration.
        /// </summary>
        /// <param name="r">The r<see cref="RegistrationDescription"/>.</param>
        private static void PrintRegistration(RegistrationDescription r)
        {
            if (r == null)
                return;
            Console.WriteLine($"Registration ID: {r.RegistrationId}");
            Console.WriteLine($"PNS Handle: {r.PnsHandle}");
            Console.WriteLine($"ReadOnly: {r.IsReadOnly} ");
            Console.WriteLine($"ExpireDateTime: {r.ExpirationTime.ToString()} ");

            if (r.Tags != null)
                foreach (var t in r.Tags)
                    Console.WriteLine($"Tag: {t} ");

            Console.WriteLine($"");
        }

        /// <summary>
        /// The gridRegistrations_SelectionChanged.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void gridRegistrations_SelectionChanged(object sender, EventArgs e)
        {
            Tags = new DataTable();
            Tags.Columns.Add("Tags");
            foreach (DataGridViewRow row in gridRegistrations.SelectedRows)
            {
                var value = row.DataBoundItem as RegistrationDescription;
                foreach (var tag in value.Tags)
                    Tags.Rows.Add(new object[] { tag });
            }
            gridTags.DataSource = Tags;
        }

        /// <summary>
        /// The gridRegistrations_ColumnAdded.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="DataGridViewColumnEventArgs"/>.</param>
        private void gridRegistrations_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            //Set properties on the columns during auto-generation 
            switch (e.Column.HeaderText)
            {
                case "Tags":
                case "ExtensionData":
                    e.Column.Visible = false;
                    break;
            }
        }

        /// <summary>
        /// The cbPlatform_TextChanged.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void cbPlatform_TextChanged(object sender, EventArgs e)
        {
            switch (cbPlatform.Text)
            {
                case "Android":
                    txtMessage.Text = DefaultMessage;
                    break;
                case "Apple":
                    txtMessage.Text = "{\"aps\":{\"alert\":\"Notification Hub test notification\"}}";
                    break;
            }
        }

        /// <summary>
        /// The btnRegistrations_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void btnRegistrations_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 0;
        }

        /// <summary>
        /// The btnTest_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void btnTest_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 1;
        }

        /// <summary>
        /// The materialRaisedButton2_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private async void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            if (Client == null)
            {
                MessageBox.Show("Could not connect to Azure Notification Hub");
                return;
            }
            switch (cbPlatform.Text)
            {
                case "Android":
                    var resultFcm = await Client.SendFcmNativeNotificationAsync(txtMessage.Text);
                    MessageBox.Show($"Message send, current state is: {resultFcm.State}.");
                    break;
                case "Apple":
                    var resultApple = await Client.SendAppleNativeNotificationAsync(txtMessage.Text);
                    MessageBox.Show($"Message send, current state is: {resultApple.State}.");
                    break;
            }
        }

        #endregion
    }
}
