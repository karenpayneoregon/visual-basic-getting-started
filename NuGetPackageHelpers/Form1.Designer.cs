namespace NuGetPackageHelpers
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
            this.ProcessCurrentSolutionButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ProjectTypeComboBox = new System.Windows.Forms.ComboBox();
            this.ProcessSelectSolutionButton = new System.Windows.Forms.Button();
            this.ExportToMarkupButton = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SolutionLabel = new System.Windows.Forms.Label();
            this.SolutionFolderLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProcessCurrentSolutionButton
            // 
            this.ProcessCurrentSolutionButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProcessCurrentSolutionButton.Location = new System.Drawing.Point(10, 12);
            this.ProcessCurrentSolutionButton.Name = "ProcessCurrentSolutionButton";
            this.ProcessCurrentSolutionButton.Size = new System.Drawing.Size(183, 23);
            this.ProcessCurrentSolutionButton.TabIndex = 0;
            this.ProcessCurrentSolutionButton.Text = "Process current solution";
            this.ProcessCurrentSolutionButton.UseVisualStyleBackColor = true;
            this.ProcessCurrentSolutionButton.Click += new System.EventHandler(this.ProcessCurrentSolutionButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.ExportToMarkupButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 311);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(488, 125);
            this.panel1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ProjectTypeComboBox);
            this.groupBox1.Controls.Add(this.ProcessSelectSolutionButton);
            this.groupBox1.Controls.Add(this.ProcessCurrentSolutionButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(207, 103);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // ProjectTypeComboBox
            // 
            this.ProjectTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProjectTypeComboBox.FormattingEnabled = true;
            this.ProjectTypeComboBox.Location = new System.Drawing.Point(10, 70);
            this.ProjectTypeComboBox.Name = "ProjectTypeComboBox";
            this.ProjectTypeComboBox.Size = new System.Drawing.Size(183, 21);
            this.ProjectTypeComboBox.TabIndex = 3;
            // 
            // ProcessSelectSolutionButton
            // 
            this.ProcessSelectSolutionButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProcessSelectSolutionButton.Location = new System.Drawing.Point(10, 41);
            this.ProcessSelectSolutionButton.Name = "ProcessSelectSolutionButton";
            this.ProcessSelectSolutionButton.Size = new System.Drawing.Size(183, 23);
            this.ProcessSelectSolutionButton.TabIndex = 2;
            this.ProcessSelectSolutionButton.Text = "Select a solution";
            this.ProcessSelectSolutionButton.UseVisualStyleBackColor = true;
            this.ProcessSelectSolutionButton.Click += new System.EventHandler(this.ProcessSelectSolutionButton_Click);
            // 
            // ExportToMarkupButton
            // 
            this.ExportToMarkupButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExportToMarkupButton.Location = new System.Drawing.Point(328, 11);
            this.ExportToMarkupButton.Name = "ExportToMarkupButton";
            this.ExportToMarkupButton.Size = new System.Drawing.Size(148, 23);
            this.ExportToMarkupButton.TabIndex = 1;
            this.ExportToMarkupButton.Text = "Export as markup";
            this.ExportToMarkupButton.UseVisualStyleBackColor = true;
            this.ExportToMarkupButton.Click += new System.EventHandler(this.ExportToMarkupButton_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(488, 266);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Information";
            this.columnHeader1.Width = 420;
            // 
            // SolutionLabel
            // 
            this.SolutionLabel.AutoSize = true;
            this.SolutionLabel.Location = new System.Drawing.Point(19, 295);
            this.SolutionLabel.Name = "SolutionLabel";
            this.SolutionLabel.Size = new System.Drawing.Size(45, 13);
            this.SolutionLabel.TabIndex = 4;
            this.SolutionLabel.Text = "Solution";
            // 
            // SolutionFolderLabel
            // 
            this.SolutionFolderLabel.AutoSize = true;
            this.SolutionFolderLabel.Location = new System.Drawing.Point(19, 282);
            this.SolutionFolderLabel.Name = "SolutionFolderLabel";
            this.SolutionFolderLabel.Size = new System.Drawing.Size(36, 13);
            this.SolutionFolderLabel.TabIndex = 5;
            this.SolutionFolderLabel.Text = "Folder";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 436);
            this.Controls.Add(this.SolutionFolderLabel);
            this.Controls.Add(this.SolutionLabel);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Raw NuGet package list to Git Table";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ProcessCurrentSolutionButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button ExportToMarkupButton;
        private System.Windows.Forms.Button ProcessSelectSolutionButton;
        private System.Windows.Forms.ComboBox ProjectTypeComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label SolutionLabel;
        private System.Windows.Forms.Label SolutionFolderLabel;
    }
}

