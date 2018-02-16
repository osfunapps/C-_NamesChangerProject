namespace NamesChangerProject
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
            this.button1 = new System.Windows.Forms.Button();
            this.fileNameTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.outputFolderBrowseBtn = new System.Windows.Forms.Button();
            this.outputFolderTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.outputFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(142, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Go";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fileNameTB
            // 
            this.fileNameTB.Location = new System.Drawing.Point(166, 76);
            this.fileNameTB.Name = "fileNameTB";
            this.fileNameTB.Size = new System.Drawing.Size(191, 20);
            this.fileNameTB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "file name (with extension):";
            // 
            // outputFolderBrowseBtn
            // 
            this.outputFolderBrowseBtn.Location = new System.Drawing.Point(318, 28);
            this.outputFolderBrowseBtn.Name = "outputFolderBrowseBtn";
            this.outputFolderBrowseBtn.Size = new System.Drawing.Size(81, 24);
            this.outputFolderBrowseBtn.TabIndex = 15;
            this.outputFolderBrowseBtn.Text = "Browse...";
            this.outputFolderBrowseBtn.UseVisualStyleBackColor = true;
            this.outputFolderBrowseBtn.Click += new System.EventHandler(this.outputFolderBrowseBtn_Click);
            // 
            // outputFolderTB
            // 
            this.outputFolderTB.AllowDrop = true;
            this.outputFolderTB.Location = new System.Drawing.Point(82, 28);
            this.outputFolderTB.Name = "outputFolderTB";
            this.outputFolderTB.Size = new System.Drawing.Size(230, 20);
            this.outputFolderTB.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Folder";
            // 
            // outputFolderDialog
            // 
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 187);
            this.Controls.Add(this.outputFolderBrowseBtn);
            this.Controls.Add(this.outputFolderTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fileNameTB);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Names Changet Project";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox fileNameTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button outputFolderBrowseBtn;
        private System.Windows.Forms.TextBox outputFolderTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FolderBrowserDialog outputFolderDialog;
    }
}

