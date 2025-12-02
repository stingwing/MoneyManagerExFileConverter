namespace MoneyManagerExFileConverter
{
    partial class MoneyManagerExFileConverter
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
            Infragistics.Win.UltraWinTabControl.UltraTab ultraTab1 = new Infragistics.Win.UltraWinTabControl.UltraTab();
            Infragistics.Win.UltraWinTabControl.UltraTab ultraTab2 = new Infragistics.Win.UltraWinTabControl.UltraTab();
            Infragistics.Win.UltraWinTabControl.UltraTab ultraTab3 = new Infragistics.Win.UltraWinTabControl.UltraTab();
            this.ultraTabPageControl1 = new Infragistics.Win.UltraWinTabControl.UltraTabPageControl();
            this.uiData = new System.Windows.Forms.DataGridView();
            this.ultraTabPageControl2 = new Infragistics.Win.UltraWinTabControl.UltraTabPageControl();
            this.uiListView = new Infragistics.Win.UltraWinListView.UltraListView();
            this.ultraTabPageControl3 = new Infragistics.Win.UltraWinTabControl.UltraTabPageControl();
            this.uiPath = new System.Windows.Forms.TextBox();
            this.uiOpenFile = new System.Windows.Forms.Button();
            this.uiImport = new System.Windows.Forms.Button();
            this.uiExport = new System.Windows.Forms.Button();
            this.uiUpdateRecords = new System.Windows.Forms.Button();
            this.uiAccount = new System.Windows.Forms.ComboBox();
            this.ultraTabControl1 = new Infragistics.Win.UltraWinTabControl.UltraTabControl();
            this.ultraTabSharedControlsPage1 = new Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage();
            this.uiSaveSettings = new System.Windows.Forms.Button();
            this.uiAccountsSettings = new System.Windows.Forms.DataGridView();
            this.Account = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ultraTabPageControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiData)).BeginInit();
            this.ultraTabPageControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiListView)).BeginInit();
            this.ultraTabPageControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTabControl1)).BeginInit();
            this.ultraTabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiAccountsSettings)).BeginInit();
            this.SuspendLayout();
            // 
            // ultraTabPageControl1
            // 
            this.ultraTabPageControl1.Controls.Add(this.uiData);
            this.ultraTabPageControl1.Location = new System.Drawing.Point(-10000, -10000);
            this.ultraTabPageControl1.Name = "ultraTabPageControl1";
            this.ultraTabPageControl1.Size = new System.Drawing.Size(925, 374);
            // 
            // uiData
            // 
            this.uiData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.uiData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiData.Location = new System.Drawing.Point(3, 3);
            this.uiData.Name = "uiData";
            this.uiData.Size = new System.Drawing.Size(919, 368);
            this.uiData.TabIndex = 2;
            // 
            // ultraTabPageControl2
            // 
            this.ultraTabPageControl2.Controls.Add(this.uiListView);
            this.ultraTabPageControl2.Location = new System.Drawing.Point(-10000, -10000);
            this.ultraTabPageControl2.Name = "ultraTabPageControl2";
            this.ultraTabPageControl2.Size = new System.Drawing.Size(925, 374);
            // 
            // uiListView
            // 
            this.uiListView.Location = new System.Drawing.Point(0, 0);
            this.uiListView.Name = "uiListView";
            this.uiListView.Size = new System.Drawing.Size(925, 377);
            this.uiListView.TabIndex = 0;
            this.uiListView.Text = "ultraListView1";
            // 
            // ultraTabPageControl3
            // 
            this.ultraTabPageControl3.Controls.Add(this.uiAccountsSettings);
            this.ultraTabPageControl3.Controls.Add(this.uiSaveSettings);
            this.ultraTabPageControl3.Location = new System.Drawing.Point(1, 23);
            this.ultraTabPageControl3.Name = "ultraTabPageControl3";
            this.ultraTabPageControl3.Size = new System.Drawing.Size(925, 374);
            // 
            // uiPath
            // 
            this.uiPath.Location = new System.Drawing.Point(10, 12);
            this.uiPath.Name = "uiPath";
            this.uiPath.Size = new System.Drawing.Size(477, 20);
            this.uiPath.TabIndex = 0;
            // 
            // uiOpenFile
            // 
            this.uiOpenFile.Location = new System.Drawing.Point(493, 12);
            this.uiOpenFile.Name = "uiOpenFile";
            this.uiOpenFile.Size = new System.Drawing.Size(75, 23);
            this.uiOpenFile.TabIndex = 1;
            this.uiOpenFile.Text = "...";
            this.uiOpenFile.UseVisualStyleBackColor = true;
            this.uiOpenFile.Click += new System.EventHandler(this.uiOpenFile_Click);
            // 
            // uiImport
            // 
            this.uiImport.Location = new System.Drawing.Point(574, 12);
            this.uiImport.Name = "uiImport";
            this.uiImport.Size = new System.Drawing.Size(75, 23);
            this.uiImport.TabIndex = 3;
            this.uiImport.Text = "Import";
            this.uiImport.UseVisualStyleBackColor = true;
            this.uiImport.Click += new System.EventHandler(this.uiImport_Click);
            // 
            // uiExport
            // 
            this.uiExport.Location = new System.Drawing.Point(655, 12);
            this.uiExport.Name = "uiExport";
            this.uiExport.Size = new System.Drawing.Size(75, 23);
            this.uiExport.TabIndex = 4;
            this.uiExport.Text = "Export";
            this.uiExport.UseVisualStyleBackColor = true;
            this.uiExport.Click += new System.EventHandler(this.uiExport_Click);
            // 
            // uiUpdateRecords
            // 
            this.uiUpdateRecords.Location = new System.Drawing.Point(737, 12);
            this.uiUpdateRecords.Name = "uiUpdateRecords";
            this.uiUpdateRecords.Size = new System.Drawing.Size(75, 23);
            this.uiUpdateRecords.TabIndex = 5;
            this.uiUpdateRecords.Text = "Update Records";
            this.uiUpdateRecords.UseVisualStyleBackColor = true;
            this.uiUpdateRecords.Click += new System.EventHandler(this.uiUpdateRecords_Click);
            // 
            // uiAccount
            // 
            this.uiAccount.FormattingEnabled = true;
            this.uiAccount.Location = new System.Drawing.Point(818, 12);
            this.uiAccount.Name = "uiAccount";
            this.uiAccount.Size = new System.Drawing.Size(121, 21);
            this.uiAccount.TabIndex = 6;
            // 
            // ultraTabControl1
            // 
            this.ultraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraTabControl1.Controls.Add(this.ultraTabSharedControlsPage1);
            this.ultraTabControl1.Controls.Add(this.ultraTabPageControl1);
            this.ultraTabControl1.Controls.Add(this.ultraTabPageControl2);
            this.ultraTabControl1.Controls.Add(this.ultraTabPageControl3);
            this.ultraTabControl1.Location = new System.Drawing.Point(12, 38);
            this.ultraTabControl1.Name = "ultraTabControl1";
            this.ultraTabControl1.SharedControlsPage = this.ultraTabSharedControlsPage1;
            this.ultraTabControl1.Size = new System.Drawing.Size(929, 400);
            this.ultraTabControl1.TabIndex = 7;
            ultraTab1.TabPage = this.ultraTabPageControl1;
            ultraTab1.Text = "Import";
            ultraTab2.TabPage = this.ultraTabPageControl2;
            ultraTab2.Text = "Files";
            ultraTab3.TabPage = this.ultraTabPageControl3;
            ultraTab3.Text = "Settings";
            this.ultraTabControl1.Tabs.AddRange(new Infragistics.Win.UltraWinTabControl.UltraTab[] {
            ultraTab1,
            ultraTab2,
            ultraTab3});
            // 
            // ultraTabSharedControlsPage1
            // 
            this.ultraTabSharedControlsPage1.Location = new System.Drawing.Point(-10000, -10000);
            this.ultraTabSharedControlsPage1.Name = "ultraTabSharedControlsPage1";
            this.ultraTabSharedControlsPage1.Size = new System.Drawing.Size(925, 374);
            // 
            // uiSaveSettings
            // 
            this.uiSaveSettings.Location = new System.Drawing.Point(805, 16);
            this.uiSaveSettings.Name = "uiSaveSettings";
            this.uiSaveSettings.Size = new System.Drawing.Size(75, 23);
            this.uiSaveSettings.TabIndex = 0;
            this.uiSaveSettings.Text = "Save";
            this.uiSaveSettings.UseVisualStyleBackColor = true;
            this.uiSaveSettings.Click += new System.EventHandler(this.uiSaveSettings_Click);
            // 
            // uiAccountsSettings
            // 
            this.uiAccountsSettings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiAccountsSettings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Account});
            this.uiAccountsSettings.Location = new System.Drawing.Point(153, 145);
            this.uiAccountsSettings.Name = "uiAccountsSettings";
            this.uiAccountsSettings.Size = new System.Drawing.Size(240, 150);
            this.uiAccountsSettings.TabIndex = 1;
            // 
            // Account
            // 
            this.Account.HeaderText = "Account";
            this.Account.Name = "Account";
            // 
            // MoneyManagerExFileConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 450);
            this.Controls.Add(this.ultraTabControl1);
            this.Controls.Add(this.uiAccount);
            this.Controls.Add(this.uiUpdateRecords);
            this.Controls.Add(this.uiExport);
            this.Controls.Add(this.uiImport);
            this.Controls.Add(this.uiOpenFile);
            this.Controls.Add(this.uiPath);
            this.Name = "MoneyManagerExFileConverter";
            this.Text = "Form1";
            this.ultraTabPageControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uiData)).EndInit();
            this.ultraTabPageControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uiListView)).EndInit();
            this.ultraTabPageControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ultraTabControl1)).EndInit();
            this.ultraTabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uiAccountsSettings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uiPath;
        private System.Windows.Forms.Button uiOpenFile;
        private System.Windows.Forms.DataGridView uiData;
        private System.Windows.Forms.Button uiImport;
        private System.Windows.Forms.Button uiExport;
        private System.Windows.Forms.Button uiUpdateRecords;
        private System.Windows.Forms.ComboBox uiAccount;
        private Infragistics.Win.UltraWinTabControl.UltraTabControl ultraTabControl1;
        private Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage ultraTabSharedControlsPage1;
        private Infragistics.Win.UltraWinTabControl.UltraTabPageControl ultraTabPageControl1;
        private Infragistics.Win.UltraWinTabControl.UltraTabPageControl ultraTabPageControl2;
        private Infragistics.Win.UltraWinListView.UltraListView uiListView;
        private Infragistics.Win.UltraWinTabControl.UltraTabPageControl ultraTabPageControl3;
        private System.Windows.Forms.Button uiSaveSettings;
        private System.Windows.Forms.DataGridView uiAccountsSettings;
        private System.Windows.Forms.DataGridViewTextBoxColumn Account;
    }
}

