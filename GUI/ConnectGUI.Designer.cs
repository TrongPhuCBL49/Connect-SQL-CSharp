namespace GUI
{
    partial class ConnectGUI
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
            this.grpInformationConnect = new DevExpress.XtraEditors.GroupControl();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.btnConnect = new DevExpress.XtraEditors.SimpleButton();
            this.txtDatabaseName = new System.Windows.Forms.TextBox();
            this.txtServerName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvTable = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grpGetData = new DevExpress.XtraEditors.GroupControl();
            this.cboTable = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.label5 = new System.Windows.Forms.Label();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDisconnect = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grpInformationConnect)).BeginInit();
            this.grpInformationConnect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpGetData)).BeginInit();
            this.grpGetData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboTable.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpInformationConnect
            // 
            this.grpInformationConnect.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInformationConnect.Appearance.Options.UseFont = true;
            this.grpInformationConnect.AppearanceCaption.Font = new System.Drawing.Font("Times New Roman", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInformationConnect.AppearanceCaption.Options.UseFont = true;
            this.grpInformationConnect.Controls.Add(this.txtPassword);
            this.grpInformationConnect.Controls.Add(this.txtUserID);
            this.grpInformationConnect.Controls.Add(this.btnDisconnect);
            this.grpInformationConnect.Controls.Add(this.btnConnect);
            this.grpInformationConnect.Controls.Add(this.txtDatabaseName);
            this.grpInformationConnect.Controls.Add(this.txtServerName);
            this.grpInformationConnect.Controls.Add(this.label3);
            this.grpInformationConnect.Controls.Add(this.label2);
            this.grpInformationConnect.Controls.Add(this.label8);
            this.grpInformationConnect.Controls.Add(this.label1);
            this.grpInformationConnect.Location = new System.Drawing.Point(43, 193);
            this.grpInformationConnect.Name = "grpInformationConnect";
            this.grpInformationConnect.Size = new System.Drawing.Size(777, 627);
            this.grpInformationConnect.TabIndex = 0;
            this.grpInformationConnect.Text = "Informatinon Connect";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(369, 411);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(370, 62);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(369, 304);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(370, 62);
            this.txtUserID.TabIndex = 3;
            // 
            // btnConnect
            // 
            this.btnConnect.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Appearance.Options.UseFont = true;
            this.btnConnect.Location = new System.Drawing.Point(66, 521);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(287, 78);
            this.btnConnect.TabIndex = 5;
            this.btnConnect.Text = "Connect";
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtDatabaseName
            // 
            this.txtDatabaseName.Location = new System.Drawing.Point(369, 199);
            this.txtDatabaseName.Name = "txtDatabaseName";
            this.txtDatabaseName.Size = new System.Drawing.Size(370, 62);
            this.txtDatabaseName.TabIndex = 2;
            // 
            // txtServerName
            // 
            this.txtServerName.Location = new System.Drawing.Point(369, 93);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(370, 62);
            this.txtServerName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 414);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 55);
            this.label3.TabIndex = 1;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 307);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 55);
            this.label2.TabIndex = 1;
            this.label2.Text = "User ID:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(28, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(325, 55);
            this.label8.TabIndex = 1;
            this.label8.Text = "Database name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "Server name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(561, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(577, 61);
            this.label4.TabIndex = 2;
            this.label4.Text = "Connect SQL vs CSharp";
            // 
            // dgvTable
            // 
            this.dgvTable.Location = new System.Drawing.Point(0, 215);
            this.dgvTable.MainView = this.gridView1;
            this.dgvTable.Name = "dgvTable";
            this.dgvTable.Size = new System.Drawing.Size(777, 706);
            this.dgvTable.TabIndex = 3;
            this.dgvTable.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.dgvTable;
            this.gridView1.Name = "gridView1";
            // 
            // grpGetData
            // 
            this.grpGetData.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpGetData.Appearance.Options.UseFont = true;
            this.grpGetData.AppearanceCaption.Font = new System.Drawing.Font("Times New Roman", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpGetData.AppearanceCaption.Options.UseFont = true;
            this.grpGetData.Controls.Add(this.cboTable);
            this.grpGetData.Controls.Add(this.dgvTable);
            this.grpGetData.Controls.Add(this.btnOK);
            this.grpGetData.Controls.Add(this.label5);
            this.grpGetData.Location = new System.Drawing.Point(846, 193);
            this.grpGetData.Name = "grpGetData";
            this.grpGetData.Size = new System.Drawing.Size(777, 928);
            this.grpGetData.TabIndex = 4;
            this.grpGetData.Text = "Get Data";
            // 
            // cboTable
            // 
            this.cboTable.Location = new System.Drawing.Point(206, 116);
            this.cboTable.Name = "cboTable";
            this.cboTable.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTable.Properties.Appearance.Options.UseFont = true;
            this.cboTable.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboTable.Size = new System.Drawing.Size(316, 60);
            this.cboTable.TabIndex = 6;
            // 
            // btnOK
            // 
            this.btnOK.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Appearance.Options.UseFont = true;
            this.btnOK.Location = new System.Drawing.Point(565, 107);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(165, 78);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 55);
            this.label5.TabIndex = 1;
            this.label5.Text = "Table:";
            // 
            // groupControl2
            // 
            this.groupControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl2.Appearance.Options.UseFont = true;
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Times New Roman", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.Controls.Add(this.label7);
            this.groupControl2.Controls.Add(this.label6);
            this.groupControl2.Location = new System.Drawing.Point(43, 849);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(777, 272);
            this.groupControl2.TabIndex = 5;
            this.groupControl2.Text = "About";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(654, 55);
            this.label7.TabIndex = 1;
            this.label7.Text = "2. Hồ Ngọc Sơn Hà   - 16110533";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(661, 55);
            this.label6.TabIndex = 1;
            this.label6.Text = "1. Nguyễn Trọng Phú - 16110540";
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisconnect.Appearance.Options.UseFont = true;
            this.btnDisconnect.Location = new System.Drawing.Point(425, 521);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(287, 78);
            this.btnDisconnect.TabIndex = 5;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // ConnectGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1669, 1147);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.grpGetData);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.grpInformationConnect);
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "ConnectGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dynamic Connection";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            ((System.ComponentModel.ISupportInitialize)(this.grpInformationConnect)).EndInit();
            this.grpInformationConnect.ResumeLayout(false);
            this.grpInformationConnect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpGetData)).EndInit();
            this.grpGetData.ResumeLayout(false);
            this.grpGetData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboTable.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grpInformationConnect;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.TextBox txtServerName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnConnect;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraGrid.GridControl dgvTable;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl grpGetData;
        private DevExpress.XtraEditors.ComboBoxEdit cboTable;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDatabaseName;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.SimpleButton btnDisconnect;
    }
}

