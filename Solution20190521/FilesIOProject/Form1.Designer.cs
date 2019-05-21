namespace FilesIOProject
{
    partial class Form1
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
            this.ofDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnOpen = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.lbFF = new System.Windows.Forms.ListBox();
            this.txtFFName = new System.Windows.Forms.TextBox();
            this.btnCreateFolder = new System.Windows.Forms.Button();
            this.btnCreateFile = new System.Windows.Forms.Button();
            this.rtbFileContent = new System.Windows.Forms.RichTextBox();
            this.btnSaveFileContent = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // ofDialog
            // 
            this.ofDialog.FileName = "openFileDialog1";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(12, 12);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // lbFF
            // 
            this.lbFF.FormattingEnabled = true;
            this.lbFF.Location = new System.Drawing.Point(12, 102);
            this.lbFF.Name = "lbFF";
            this.lbFF.Size = new System.Drawing.Size(294, 329);
            this.lbFF.TabIndex = 1;
            this.lbFF.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbFF_MouseDoubleClick);
            // 
            // txtFFName
            // 
            this.txtFFName.Location = new System.Drawing.Point(12, 41);
            this.txtFFName.Name = "txtFFName";
            this.txtFFName.Size = new System.Drawing.Size(294, 20);
            this.txtFFName.TabIndex = 3;
            // 
            // btnCreateFolder
            // 
            this.btnCreateFolder.Location = new System.Drawing.Point(12, 67);
            this.btnCreateFolder.Name = "btnCreateFolder";
            this.btnCreateFolder.Size = new System.Drawing.Size(124, 23);
            this.btnCreateFolder.TabIndex = 4;
            this.btnCreateFolder.Text = "Create Folder";
            this.btnCreateFolder.UseVisualStyleBackColor = true;
            this.btnCreateFolder.Click += new System.EventHandler(this.btnCreateFolder_Click);
            // 
            // btnCreateFile
            // 
            this.btnCreateFile.Location = new System.Drawing.Point(182, 67);
            this.btnCreateFile.Name = "btnCreateFile";
            this.btnCreateFile.Size = new System.Drawing.Size(124, 23);
            this.btnCreateFile.TabIndex = 5;
            this.btnCreateFile.Text = "Create File";
            this.btnCreateFile.UseVisualStyleBackColor = true;
            this.btnCreateFile.Click += new System.EventHandler(this.btnCreateFile_Click);
            // 
            // rtbFileContent
            // 
            this.rtbFileContent.Location = new System.Drawing.Point(350, 41);
            this.rtbFileContent.Name = "rtbFileContent";
            this.rtbFileContent.Size = new System.Drawing.Size(483, 390);
            this.rtbFileContent.TabIndex = 6;
            this.rtbFileContent.Text = "";
            // 
            // btnSaveFileContent
            // 
            this.btnSaveFileContent.Location = new System.Drawing.Point(720, 437);
            this.btnSaveFileContent.Name = "btnSaveFileContent";
            this.btnSaveFileContent.Size = new System.Drawing.Size(113, 34);
            this.btnSaveFileContent.TabIndex = 7;
            this.btnSaveFileContent.Text = "Save";
            this.btnSaveFileContent.UseVisualStyleBackColor = true;
            this.btnSaveFileContent.Click += new System.EventHandler(this.btnSaveFileContent_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 514);
            this.Controls.Add(this.btnSaveFileContent);
            this.Controls.Add(this.rtbFileContent);
            this.Controls.Add(this.btnCreateFile);
            this.Controls.Add(this.btnCreateFolder);
            this.Controls.Add(this.txtFFName);
            this.Controls.Add(this.lbFF);
            this.Controls.Add(this.btnOpen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofDialog;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.ListBox lbFF;
        private System.Windows.Forms.TextBox txtFFName;
        private System.Windows.Forms.Button btnCreateFolder;
        private System.Windows.Forms.Button btnCreateFile;
        private System.Windows.Forms.RichTextBox rtbFileContent;
        private System.Windows.Forms.Button btnSaveFileContent;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

