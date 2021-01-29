
namespace AzureNotificationHubExplorer
{
    partial class formConnection
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtConnectionString = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtHubName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnConnect = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // txtConnectionString
            // 
            this.txtConnectionString.Depth = 0;
            this.txtConnectionString.Hint = "Connection string";
            this.txtConnectionString.Location = new System.Drawing.Point(22, 93);
            this.txtConnectionString.MaxLength = 32767;
            this.txtConnectionString.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtConnectionString.Name = "txtConnectionString";
            this.txtConnectionString.PasswordChar = '\0';
            this.txtConnectionString.SelectedText = "";
            this.txtConnectionString.SelectionLength = 0;
            this.txtConnectionString.SelectionStart = 0;
            this.txtConnectionString.Size = new System.Drawing.Size(742, 23);
            this.txtConnectionString.TabIndex = 0;
            this.txtConnectionString.TabStop = false;
            this.txtConnectionString.UseSystemPasswordChar = false;
            // 
            // txtHubName
            // 
            this.txtHubName.Depth = 0;
            this.txtHubName.Hint = "Hub name";
            this.txtHubName.Location = new System.Drawing.Point(22, 135);
            this.txtHubName.MaxLength = 32767;
            this.txtHubName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtHubName.Name = "txtHubName";
            this.txtHubName.PasswordChar = '\0';
            this.txtHubName.SelectedText = "";
            this.txtHubName.SelectionLength = 0;
            this.txtHubName.SelectionStart = 0;
            this.txtHubName.Size = new System.Drawing.Size(742, 23);
            this.txtHubName.TabIndex = 1;
            this.txtHubName.TabStop = false;
            this.txtHubName.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(260, 189);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(504, 19);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Fill in your connection string and hub name to your Azure Notification Hub";
            // 
            // btnConnect
            // 
            this.btnConnect.AutoSize = true;
            this.btnConnect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConnect.Depth = 0;
            this.btnConnect.Icon = null;
            this.btnConnect.Location = new System.Drawing.Point(22, 198);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnConnect.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Primary = false;
            this.btnConnect.Size = new System.Drawing.Size(55, 36);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "Save";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // formConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 255);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txtHubName);
            this.Controls.Add(this.txtConnectionString);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formConnection";
            this.Sizable = false;
            this.Text = "Connection setup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txtConnectionString;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtHubName;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialFlatButton btnConnect;
    }
}