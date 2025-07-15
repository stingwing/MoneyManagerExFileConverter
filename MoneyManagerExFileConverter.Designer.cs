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
            this.uiPath = new System.Windows.Forms.TextBox();
            this.uiOpenFile = new System.Windows.Forms.Button();
            this.uiData = new System.Windows.Forms.DataGridView();
            this.uiImport = new System.Windows.Forms.Button();
            this.uiExport = new System.Windows.Forms.Button();
            this.uiUpdateRecords = new System.Windows.Forms.Button();
            this.uiAccount = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.uiData)).BeginInit();
            this.SuspendLayout();
            // 
            // uiPath
            // 
            this.uiPath.Location = new System.Drawing.Point(30, 12);
            this.uiPath.Name = "uiPath";
            this.uiPath.Size = new System.Drawing.Size(477, 20);
            this.uiPath.TabIndex = 0;
            // 
            // uiOpenFile
            // 
            this.uiOpenFile.Location = new System.Drawing.Point(513, 12);
            this.uiOpenFile.Name = "uiOpenFile";
            this.uiOpenFile.Size = new System.Drawing.Size(75, 23);
            this.uiOpenFile.TabIndex = 1;
            this.uiOpenFile.Text = "...";
            this.uiOpenFile.UseVisualStyleBackColor = true;
            this.uiOpenFile.Click += new System.EventHandler(this.uiOpenFile_Click);
            // 
            // uiData
            // 
            this.uiData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.uiData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiData.Location = new System.Drawing.Point(30, 38);
            this.uiData.Name = "uiData";
            this.uiData.Size = new System.Drawing.Size(930, 400);
            this.uiData.TabIndex = 2;
            // 
            // uiImport
            // 
            this.uiImport.Location = new System.Drawing.Point(594, 12);
            this.uiImport.Name = "uiImport";
            this.uiImport.Size = new System.Drawing.Size(75, 23);
            this.uiImport.TabIndex = 3;
            this.uiImport.Text = "Import";
            this.uiImport.UseVisualStyleBackColor = true;
            this.uiImport.Click += new System.EventHandler(this.uiImport_Click);
            // 
            // uiExport
            // 
            this.uiExport.Location = new System.Drawing.Point(675, 12);
            this.uiExport.Name = "uiExport";
            this.uiExport.Size = new System.Drawing.Size(75, 23);
            this.uiExport.TabIndex = 4;
            this.uiExport.Text = "Export";
            this.uiExport.UseVisualStyleBackColor = true;
            this.uiExport.Click += new System.EventHandler(this.uiExport_Click);
            // 
            // uiUpdateRecords
            // 
            this.uiUpdateRecords.Location = new System.Drawing.Point(756, 12);
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
            this.uiAccount.Location = new System.Drawing.Point(837, 12);
            this.uiAccount.Name = "uiAccount";
            this.uiAccount.Size = new System.Drawing.Size(121, 21);
            this.uiAccount.TabIndex = 6;
            // 
            // MoneyManagerExFileConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 450);
            this.Controls.Add(this.uiAccount);
            this.Controls.Add(this.uiUpdateRecords);
            this.Controls.Add(this.uiExport);
            this.Controls.Add(this.uiImport);
            this.Controls.Add(this.uiData);
            this.Controls.Add(this.uiOpenFile);
            this.Controls.Add(this.uiPath);
            this.Name = "MoneyManagerExFileConverter";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.uiData)).EndInit();
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
    }
}

