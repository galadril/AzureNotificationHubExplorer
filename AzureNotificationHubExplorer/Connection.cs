using MaterialSkin.Controls;
using System;

namespace AzureNotificationHubExplorer
{
    /// <summary>
    /// Defines the <see cref="formConnection" />.
    /// </summary>
    public partial class formConnection : MaterialForm
    {
        #region Constructor & Destructor

        /// <summary>
        /// Initializes a new instance of the <see cref="formConnection"/> class.
        /// </summary>
        public formConnection()
        {
            InitializeComponent();
            txtConnectionString.Text = ConnectionString;
            txtHubName.Text = HubName;
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

        #endregion

        #region Private

        /// <summary>
        /// The btnConnect_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void btnConnect_Click(object sender, EventArgs e)
        {
            ConnectionString = txtConnectionString.Text;
            HubName = txtHubName.Text;

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        #endregion
    }
}
