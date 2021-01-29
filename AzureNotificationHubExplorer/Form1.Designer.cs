
namespace AzureNotificationHubExplorer
{
    partial class frmExplorer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExplorer));
            this.tabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.tabRegistrations = new System.Windows.Forms.TabPage();
            this.gridTags = new System.Windows.Forms.DataGridView();
            this.gridRegistrations = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRows = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRegistrationId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPNSHandler = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTags = new System.Windows.Forms.TextBox();
            this.tabTest = new System.Windows.Forms.TabPage();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbPlatform = new System.Windows.Forms.ComboBox();
            this.materialContextMenuStrip1 = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.btnConnect = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRegistrations = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnTest = new MaterialSkin.Controls.MaterialFlatButton();
            this.tabControl.SuspendLayout();
            this.tabRegistrations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTags)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRegistrations)).BeginInit();
            this.tabTest.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabRegistrations);
            this.tabControl.Controls.Add(this.tabTest);
            this.tabControl.Depth = 0;
            this.tabControl.Location = new System.Drawing.Point(12, 93);
            this.tabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1305, 833);
            this.tabControl.TabIndex = 1;
            // 
            // tabRegistrations
            // 
            this.tabRegistrations.Controls.Add(this.gridTags);
            this.tabRegistrations.Controls.Add(this.gridRegistrations);
            this.tabRegistrations.Controls.Add(this.label6);
            this.tabRegistrations.Controls.Add(this.txtRows);
            this.tabRegistrations.Controls.Add(this.label4);
            this.tabRegistrations.Controls.Add(this.materialRaisedButton1);
            this.tabRegistrations.Controls.Add(this.label3);
            this.tabRegistrations.Controls.Add(this.txtRegistrationId);
            this.tabRegistrations.Controls.Add(this.label2);
            this.tabRegistrations.Controls.Add(this.txtPNSHandler);
            this.tabRegistrations.Controls.Add(this.label1);
            this.tabRegistrations.Controls.Add(this.txtTags);
            this.tabRegistrations.Location = new System.Drawing.Point(4, 24);
            this.tabRegistrations.Name = "tabRegistrations";
            this.tabRegistrations.Padding = new System.Windows.Forms.Padding(3);
            this.tabRegistrations.Size = new System.Drawing.Size(1297, 805);
            this.tabRegistrations.TabIndex = 0;
            this.tabRegistrations.Text = "Registrations";
            this.tabRegistrations.UseVisualStyleBackColor = true;
            // 
            // gridTags
            // 
            this.gridTags.AllowUserToAddRows = false;
            this.gridTags.AllowUserToDeleteRows = false;
            this.gridTags.AllowUserToResizeRows = false;
            this.gridTags.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridTags.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTags.Location = new System.Drawing.Point(12, 622);
            this.gridTags.Name = "gridTags";
            this.gridTags.RowTemplate.Height = 25;
            this.gridTags.Size = new System.Drawing.Size(1282, 192);
            this.gridTags.TabIndex = 12;
            // 
            // gridRegistrations
            // 
            this.gridRegistrations.AllowUserToAddRows = false;
            this.gridRegistrations.AllowUserToDeleteRows = false;
            this.gridRegistrations.AllowUserToResizeRows = false;
            this.gridRegistrations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridRegistrations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRegistrations.Location = new System.Drawing.Point(12, 169);
            this.gridRegistrations.MultiSelect = false;
            this.gridRegistrations.Name = "gridRegistrations";
            this.gridRegistrations.RowTemplate.Height = 25;
            this.gridRegistrations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridRegistrations.Size = new System.Drawing.Size(1282, 447);
            this.gridRegistrations.TabIndex = 11;
            this.gridRegistrations.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.gridRegistrations_ColumnAdded);
            this.gridRegistrations.SelectionChanged += new System.EventHandler(this.gridRegistrations_SelectionChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Rows:";
            // 
            // txtRows
            // 
            this.txtRows.Location = new System.Drawing.Point(164, 115);
            this.txtRows.Name = "txtRows";
            this.txtRows.Size = new System.Drawing.Size(88, 23);
            this.txtRows.TabIndex = 9;
            this.txtRows.Text = "100";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1018, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Only fill one of these search fields!";
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.AutoSize = true;
            this.materialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Icon = null;
            this.materialRaisedButton1.Location = new System.Drawing.Point(1221, 111);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(73, 36);
            this.materialRaisedButton1.TabIndex = 6;
            this.materialRaisedButton1.Text = "Search";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.btnSearchRegistrations);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Registration ID:";
            // 
            // txtRegistrationId
            // 
            this.txtRegistrationId.Location = new System.Drawing.Point(164, 82);
            this.txtRegistrationId.Name = "txtRegistrationId";
            this.txtRegistrationId.Size = new System.Drawing.Size(1130, 23);
            this.txtRegistrationId.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "PNS Handler:";
            // 
            // txtPNSHandler
            // 
            this.txtPNSHandler.Location = new System.Drawing.Point(164, 51);
            this.txtPNSHandler.Name = "txtPNSHandler";
            this.txtPNSHandler.Size = new System.Drawing.Size(1130, 23);
            this.txtPNSHandler.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tag:";
            // 
            // txtTags
            // 
            this.txtTags.Location = new System.Drawing.Point(164, 22);
            this.txtTags.Name = "txtTags";
            this.txtTags.Size = new System.Drawing.Size(1130, 23);
            this.txtTags.TabIndex = 0;
            // 
            // tabTest
            // 
            this.tabTest.Controls.Add(this.materialRaisedButton2);
            this.tabTest.Controls.Add(this.txtMessage);
            this.tabTest.Controls.Add(this.label7);
            this.tabTest.Controls.Add(this.cbPlatform);
            this.tabTest.Location = new System.Drawing.Point(4, 24);
            this.tabTest.Name = "tabTest";
            this.tabTest.Padding = new System.Windows.Forms.Padding(3);
            this.tabTest.Size = new System.Drawing.Size(1297, 805);
            this.tabTest.TabIndex = 1;
            this.tabTest.Text = "Send";
            this.tabTest.UseVisualStyleBackColor = true;
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.AutoSize = true;
            this.materialRaisedButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Icon = null;
            this.materialRaisedButton2.Location = new System.Drawing.Point(340, 18);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(56, 36);
            this.materialRaisedButton2.TabIndex = 7;
            this.materialRaisedButton2.Text = "Send";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            this.materialRaisedButton2.Click += new System.EventHandler(this.materialRaisedButton2_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(21, 67);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(1263, 731);
            this.txtMessage.TabIndex = 2;
            this.txtMessage.Text = resources.GetString("txtMessage.Text");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "Platform:";
            // 
            // cbPlatform
            // 
            this.cbPlatform.FormattingEnabled = true;
            this.cbPlatform.Items.AddRange(new object[] {
            "Android",
            "Apple"});
            this.cbPlatform.Location = new System.Drawing.Point(83, 24);
            this.cbPlatform.Name = "cbPlatform";
            this.cbPlatform.Size = new System.Drawing.Size(236, 23);
            this.cbPlatform.TabIndex = 0;
            this.cbPlatform.Text = "Android";
            this.cbPlatform.TextChanged += new System.EventHandler(this.cbPlatform_TextChanged);
            // 
            // materialContextMenuStrip1
            // 
            this.materialContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialContextMenuStrip1.Depth = 0;
            this.materialContextMenuStrip1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialContextMenuStrip1.Name = "materialContextMenuStrip1";
            this.materialContextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnConnect
            // 
            this.btnConnect.AutoSize = true;
            this.btnConnect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConnect.BackColor = System.Drawing.Color.Transparent;
            this.btnConnect.Depth = 0;
            this.btnConnect.FlatAppearance.BorderSize = 0;
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnect.Icon = null;
            this.btnConnect.Location = new System.Drawing.Point(1229, 28);
            this.btnConnect.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Primary = true;
            this.btnConnect.Size = new System.Drawing.Size(85, 36);
            this.btnConnect.TabIndex = 6;
            this.btnConnect.Text = "Settings";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(634, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tag:";
            // 
            // btnRegistrations
            // 
            this.btnRegistrations.AutoSize = true;
            this.btnRegistrations.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRegistrations.Depth = 0;
            this.btnRegistrations.Icon = null;
            this.btnRegistrations.Location = new System.Drawing.Point(12, 67);
            this.btnRegistrations.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRegistrations.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRegistrations.Name = "btnRegistrations";
            this.btnRegistrations.Primary = false;
            this.btnRegistrations.Size = new System.Drawing.Size(125, 36);
            this.btnRegistrations.TabIndex = 7;
            this.btnRegistrations.Text = "Registrations";
            this.btnRegistrations.UseVisualStyleBackColor = true;
            this.btnRegistrations.Click += new System.EventHandler(this.btnRegistrations_Click);
            // 
            // btnTest
            // 
            this.btnTest.AutoSize = true;
            this.btnTest.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTest.Depth = 0;
            this.btnTest.Icon = null;
            this.btnTest.Location = new System.Drawing.Point(145, 67);
            this.btnTest.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnTest.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTest.Name = "btnTest";
            this.btnTest.Primary = false;
            this.btnTest.Size = new System.Drawing.Size(54, 36);
            this.btnTest.TabIndex = 8;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // frmExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 927);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnRegistrations);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.tabControl);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmExplorer";
            this.ShowIcon = false;
            this.Sizable = false;
            this.Text = "Azure Notification Hub Explorer";
            this.Load += new System.EventHandler(this.frmExplorer_Load);
            this.tabControl.ResumeLayout(false);
            this.tabRegistrations.ResumeLayout(false);
            this.tabRegistrations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTags)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRegistrations)).EndInit();
            this.tabTest.ResumeLayout(false);
            this.tabTest.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl tabControl;
        private System.Windows.Forms.TabPage tabRegistrations;
        private System.Windows.Forms.TabPage tabTest;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRegistrationId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPNSHandler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTags;
        private MaterialSkin.Controls.MaterialContextMenuStrip materialContextMenuStrip1;
        private MaterialSkin.Controls.MaterialRaisedButton btnConnect;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRows;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView gridRegistrations;
        private System.Windows.Forms.DataGridView gridTags;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbPlatform;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
        private MaterialSkin.Controls.MaterialFlatButton btnRegistrations;
        private MaterialSkin.Controls.MaterialFlatButton btnTest;
    }
}

