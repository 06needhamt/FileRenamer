namespace FileRenamer
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
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.pgbProgress = new System.Windows.Forms.ProgressBar();
            this.btnRenameFiles = new System.Windows.Forms.Button();
            this.dirSelect = new System.Windows.Forms.FolderBrowserDialog();
            this.cboOperation = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCharacter = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(37, 85);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(140, 20);
            this.txtPath.TabIndex = 0;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(227, 85);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // pgbProgress
            // 
            this.pgbProgress.Location = new System.Drawing.Point(37, 227);
            this.pgbProgress.Name = "pgbProgress";
            this.pgbProgress.Size = new System.Drawing.Size(230, 23);
            this.pgbProgress.TabIndex = 2;
            // 
            // btnRenameFiles
            // 
            this.btnRenameFiles.Location = new System.Drawing.Point(93, 273);
            this.btnRenameFiles.Name = "btnRenameFiles";
            this.btnRenameFiles.Size = new System.Drawing.Size(99, 23);
            this.btnRenameFiles.TabIndex = 3;
            this.btnRenameFiles.Text = "Rename Files";
            this.btnRenameFiles.UseVisualStyleBackColor = true;
            this.btnRenameFiles.Click += new System.EventHandler(this.btnRenameFiles_Click);
            // 
            // cboOperation
            // 
            this.cboOperation.FormattingEnabled = true;
            this.cboOperation.Items.AddRange(new object[] {
            "All Lower Case",
            "All Upper Case",
            "Spaces To Underscores",
            "Underscores To Spaces",
            "Dashes To Underscores",
            "Add String to start of name"});
            this.cboOperation.Location = new System.Drawing.Point(181, 139);
            this.cboOperation.Name = "cboOperation";
            this.cboOperation.Size = new System.Drawing.Size(121, 21);
            this.cboOperation.TabIndex = 4;
            this.cboOperation.SelectedValueChanged += new System.EventHandler(this.cboOperation_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "How should files be renamed";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Stringto add to filename";
            // 
            // txtCharacter
            // 
            this.txtCharacter.Enabled = false;
            this.txtCharacter.Location = new System.Drawing.Point(181, 188);
            this.txtCharacter.Name = "txtCharacter";
            this.txtCharacter.Size = new System.Drawing.Size(100, 20);
            this.txtCharacter.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 339);
            this.Controls.Add(this.txtCharacter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboOperation);
            this.Controls.Add(this.btnRenameFiles);
            this.Controls.Add(this.pgbProgress);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtPath);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.ProgressBar pgbProgress;
        private System.Windows.Forms.Button btnRenameFiles;
        private System.Windows.Forms.FolderBrowserDialog dirSelect;
        private System.Windows.Forms.ComboBox cboOperation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCharacter;
    }
}

