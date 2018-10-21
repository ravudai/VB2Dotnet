namespace VB2DotNet
{
    partial class frmMain
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
            this.butProcess = new System.Windows.Forms.Button();
            this.lvwProcessedFiles = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.butBrowsePatternFile = new System.Windows.Forms.Button();
            this.txtSrcFolderName = new System.Windows.Forms.TextBox();
            this.lblPattern = new System.Windows.Forms.Label();
            this.lblSource = new System.Windows.Forms.Label();
            this.txtPatternFileName = new System.Windows.Forms.TextBox();
            this.butBrowseSourceFolderPath = new System.Windows.Forms.Button();
            this.lvwPatterns = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblPatterns = new System.Windows.Forms.Label();
            this.lblSrcCode = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lvwFile2 = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.txtCompareFile2 = new System.Windows.Forms.TextBox();
            this.butBrowseCompareFile2 = new System.Windows.Forms.Button();
            this.lvwFile1 = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.txtCompareFile1 = new System.Windows.Forms.TextBox();
            this.butBrowseCompareFile1 = new System.Windows.Forms.Button();
            this.butCompareFiles = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblLinesChanged = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // butProcess
            // 
            this.butProcess.Location = new System.Drawing.Point(614, 20);
            this.butProcess.Name = "butProcess";
            this.butProcess.Size = new System.Drawing.Size(59, 62);
            this.butProcess.TabIndex = 3;
            this.butProcess.Text = "Process";
            this.butProcess.UseVisualStyleBackColor = true;
            this.butProcess.Click += new System.EventHandler(this.butProcess_Click);
            // 
            // lvwProcessedFiles
            // 
            this.lvwProcessedFiles.AllowColumnReorder = true;
            this.lvwProcessedFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader12});
            this.lvwProcessedFiles.FullRowSelect = true;
            this.lvwProcessedFiles.GridLines = true;
            this.lvwProcessedFiles.LabelEdit = true;
            this.lvwProcessedFiles.Location = new System.Drawing.Point(6, 291);
            this.lvwProcessedFiles.Name = "lvwProcessedFiles";
            this.lvwProcessedFiles.Size = new System.Drawing.Size(667, 158);
            this.lvwProcessedFiles.TabIndex = 4;
            this.lvwProcessedFiles.UseCompatibleStateImageBehavior = false;
            this.lvwProcessedFiles.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "File #";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "File Name";
            this.columnHeader3.Width = 500;
            // 
            // butBrowsePatternFile
            // 
            this.butBrowsePatternFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butBrowsePatternFile.Location = new System.Drawing.Point(561, 19);
            this.butBrowsePatternFile.Name = "butBrowsePatternFile";
            this.butBrowsePatternFile.Size = new System.Drawing.Size(26, 20);
            this.butBrowsePatternFile.TabIndex = 1;
            this.butBrowsePatternFile.Text = "...";
            this.butBrowsePatternFile.UseVisualStyleBackColor = true;
            this.butBrowsePatternFile.Click += new System.EventHandler(this.butBrowsePatternFile_Click);
            // 
            // txtSrcFolderName
            // 
            this.txtSrcFolderName.Location = new System.Drawing.Point(6, 62);
            this.txtSrcFolderName.Name = "txtSrcFolderName";
            this.txtSrcFolderName.Size = new System.Drawing.Size(549, 20);
            this.txtSrcFolderName.TabIndex = 0;
            this.txtSrcFolderName.Text = "C:\\Users\\392563\\Documents\\All Local\\Programming\\Powershell";
            // 
            // lblPattern
            // 
            this.lblPattern.AutoSize = true;
            this.lblPattern.Location = new System.Drawing.Point(3, 4);
            this.lblPattern.Name = "lblPattern";
            this.lblPattern.Size = new System.Drawing.Size(63, 13);
            this.lblPattern.TabIndex = 7;
            this.lblPattern.Text = "Pattern File:";
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Location = new System.Drawing.Point(3, 46);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(88, 13);
            this.lblSource.TabIndex = 8;
            this.lblSource.Text = "Source File Path:";
            // 
            // txtPatternFileName
            // 
            this.txtPatternFileName.Location = new System.Drawing.Point(6, 20);
            this.txtPatternFileName.Name = "txtPatternFileName";
            this.txtPatternFileName.Size = new System.Drawing.Size(549, 20);
            this.txtPatternFileName.TabIndex = 9;
            this.txtPatternFileName.Text = "C:\\Users\\392563\\Documents\\All Local\\Programming\\Powershell\\pattern.txt";
            // 
            // butBrowseSourceFolderPath
            // 
            this.butBrowseSourceFolderPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butBrowseSourceFolderPath.Location = new System.Drawing.Point(561, 59);
            this.butBrowseSourceFolderPath.Name = "butBrowseSourceFolderPath";
            this.butBrowseSourceFolderPath.Size = new System.Drawing.Size(26, 20);
            this.butBrowseSourceFolderPath.TabIndex = 10;
            this.butBrowseSourceFolderPath.Text = "...";
            this.butBrowseSourceFolderPath.UseVisualStyleBackColor = true;
            this.butBrowseSourceFolderPath.Click += new System.EventHandler(this.butBrowseSourceFolderPath_Click);
            // 
            // lvwPatterns
            // 
            this.lvwPatterns.AllowColumnReorder = true;
            this.lvwPatterns.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader4,
            this.columnHeader5});
            this.lvwPatterns.FullRowSelect = true;
            this.lvwPatterns.GridLines = true;
            this.lvwPatterns.LabelEdit = true;
            this.lvwPatterns.Location = new System.Drawing.Point(6, 106);
            this.lvwPatterns.Name = "lvwPatterns";
            this.lvwPatterns.Size = new System.Drawing.Size(667, 163);
            this.lvwPatterns.TabIndex = 11;
            this.lvwPatterns.UseCompatibleStateImageBehavior = false;
            this.lvwPatterns.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Pattern #";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "From Pattern";
            this.columnHeader4.Width = 300;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "To Pattern";
            this.columnHeader5.Width = 300;
            // 
            // lblPatterns
            // 
            this.lblPatterns.AutoSize = true;
            this.lblPatterns.Location = new System.Drawing.Point(3, 90);
            this.lblPatterns.Name = "lblPatterns";
            this.lblPatterns.Size = new System.Drawing.Size(49, 13);
            this.lblPatterns.TabIndex = 12;
            this.lblPatterns.Text = "Patterns:";
            // 
            // lblSrcCode
            // 
            this.lblSrcCode.AutoSize = true;
            this.lblSrcCode.Location = new System.Drawing.Point(6, 275);
            this.lblSrcCode.Name = "lblSrcCode";
            this.lblSrcCode.Size = new System.Drawing.Size(84, 13);
            this.lblSrcCode.TabIndex = 13;
            this.lblSrcCode.Text = "Processed Files:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(6, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(940, 481);
            this.tabControl1.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblLinesChanged);
            this.tabPage1.Controls.Add(this.lblPattern);
            this.tabPage1.Controls.Add(this.txtPatternFileName);
            this.tabPage1.Controls.Add(this.butBrowseSourceFolderPath);
            this.tabPage1.Controls.Add(this.butBrowsePatternFile);
            this.tabPage1.Controls.Add(this.lblSrcCode);
            this.tabPage1.Controls.Add(this.lblSource);
            this.tabPage1.Controls.Add(this.lvwPatterns);
            this.tabPage1.Controls.Add(this.butProcess);
            this.tabPage1.Controls.Add(this.lvwProcessedFiles);
            this.tabPage1.Controls.Add(this.lblPatterns);
            this.tabPage1.Controls.Add(this.txtSrcFolderName);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(932, 455);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Match and Replace";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblMessage);
            this.tabPage2.Controls.Add(this.lvwFile2);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.txtCompareFile2);
            this.tabPage2.Controls.Add(this.butBrowseCompareFile2);
            this.tabPage2.Controls.Add(this.lvwFile1);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.txtCompareFile1);
            this.tabPage2.Controls.Add(this.butBrowseCompareFile1);
            this.tabPage2.Controls.Add(this.butCompareFiles);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(932, 455);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Simple Compare";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lvwFile2
            // 
            this.lvwFile2.AllowColumnReorder = true;
            this.lvwFile2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.lvwFile2.FullRowSelect = true;
            this.lvwFile2.GridLines = true;
            this.lvwFile2.LabelEdit = true;
            this.lvwFile2.Location = new System.Drawing.Point(473, 73);
            this.lvwFile2.Name = "lvwFile2";
            this.lvwFile2.Size = new System.Drawing.Size(448, 361);
            this.lvwFile2.TabIndex = 23;
            this.lvwFile2.UseCompatibleStateImageBehavior = false;
            this.lvwFile2.View = System.Windows.Forms.View.Details;
            this.lvwFile2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvwFile2_KeyDown);
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Line#";
            this.columnHeader9.Width = 50;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Code";
            this.columnHeader10.Width = 350;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "In File";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(472, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "File 2:";
            // 
            // txtCompareFile2
            // 
            this.txtCompareFile2.Location = new System.Drawing.Point(473, 19);
            this.txtCompareFile2.Name = "txtCompareFile2";
            this.txtCompareFile2.Size = new System.Drawing.Size(420, 20);
            this.txtCompareFile2.TabIndex = 22;
            this.txtCompareFile2.Text = "C:\\Users\\392563\\Documents\\All Local\\Programming\\Powershell\\Output\\frmMain.Designe" +
    "r.vb";
            // 
            // butBrowseCompareFile2
            // 
            this.butBrowseCompareFile2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butBrowseCompareFile2.Location = new System.Drawing.Point(895, 19);
            this.butBrowseCompareFile2.Name = "butBrowseCompareFile2";
            this.butBrowseCompareFile2.Size = new System.Drawing.Size(26, 20);
            this.butBrowseCompareFile2.TabIndex = 20;
            this.butBrowseCompareFile2.Text = "...";
            this.butBrowseCompareFile2.UseVisualStyleBackColor = true;
            this.butBrowseCompareFile2.Click += new System.EventHandler(this.butBrowseCompareFile2_Click);
            // 
            // lvwFile1
            // 
            this.lvwFile1.AllowColumnReorder = true;
            this.lvwFile1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lvwFile1.FullRowSelect = true;
            this.lvwFile1.GridLines = true;
            this.lvwFile1.LabelEdit = true;
            this.lvwFile1.Location = new System.Drawing.Point(11, 73);
            this.lvwFile1.Name = "lvwFile1";
            this.lvwFile1.Size = new System.Drawing.Size(448, 361);
            this.lvwFile1.TabIndex = 18;
            this.lvwFile1.UseCompatibleStateImageBehavior = false;
            this.lvwFile1.View = System.Windows.Forms.View.Details;
            this.lvwFile1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvwFile1_KeyDown);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Line#";
            this.columnHeader6.Width = 50;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Code";
            this.columnHeader7.Width = 350;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "In File";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "File 1:";
            // 
            // txtCompareFile1
            // 
            this.txtCompareFile1.Location = new System.Drawing.Point(11, 20);
            this.txtCompareFile1.Name = "txtCompareFile1";
            this.txtCompareFile1.Size = new System.Drawing.Size(420, 20);
            this.txtCompareFile1.TabIndex = 16;
            this.txtCompareFile1.Text = "C:\\Users\\392563\\Documents\\All Local\\Programming\\Powershell\\frmMain.Designer.vb";
            // 
            // butBrowseCompareFile1
            // 
            this.butBrowseCompareFile1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butBrowseCompareFile1.Location = new System.Drawing.Point(433, 20);
            this.butBrowseCompareFile1.Name = "butBrowseCompareFile1";
            this.butBrowseCompareFile1.Size = new System.Drawing.Size(26, 20);
            this.butBrowseCompareFile1.TabIndex = 12;
            this.butBrowseCompareFile1.Text = "...";
            this.butBrowseCompareFile1.UseVisualStyleBackColor = true;
            this.butBrowseCompareFile1.Click += new System.EventHandler(this.butBrowseCompareFile1_Click);
            // 
            // butCompareFiles
            // 
            this.butCompareFiles.Location = new System.Drawing.Point(433, 43);
            this.butCompareFiles.Name = "butCompareFiles";
            this.butCompareFiles.Size = new System.Drawing.Size(59, 24);
            this.butCompareFiles.TabIndex = 13;
            this.butCompareFiles.Text = "Compare";
            this.butCompareFiles.UseVisualStyleBackColor = true;
            this.butCompareFiles.Click += new System.EventHandler(this.butCompareFiles_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.Red;
            this.lblMessage.Location = new System.Drawing.Point(257, 437);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 15);
            this.lblMessage.TabIndex = 24;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "# Lined Changed";
            this.columnHeader12.Width = 100;
            // 
            // lblLinesChanged
            // 
            this.lblLinesChanged.AutoSize = true;
            this.lblLinesChanged.Location = new System.Drawing.Point(596, 274);
            this.lblLinesChanged.Name = "lblLinesChanged";
            this.lblLinesChanged.Size = new System.Drawing.Size(13, 13);
            this.lblLinesChanged.TabIndex = 14;
            this.lblLinesChanged.Text = "0";
            this.lblLinesChanged.Visible = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 485);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmMain";
            this.Text = "VB2DotNet";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button butProcess;
        private System.Windows.Forms.ListView lvwProcessedFiles;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button butBrowsePatternFile;
        private System.Windows.Forms.TextBox txtSrcFolderName;
        private System.Windows.Forms.Label lblPattern;
        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.TextBox txtPatternFileName;
        private System.Windows.Forms.Button butBrowseSourceFolderPath;
        private System.Windows.Forms.ListView lvwPatterns;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label lblPatterns;
        private System.Windows.Forms.Label lblSrcCode;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCompareFile1;
        private System.Windows.Forms.Button butBrowseCompareFile1;
        private System.Windows.Forms.Button butCompareFiles;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCompareFile2;
        private System.Windows.Forms.Button butBrowseCompareFile2;
        private System.Windows.Forms.ListView lvwFile1;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ListView lvwFile2;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.Label lblLinesChanged;
    }
}

