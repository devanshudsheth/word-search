namespace Asg4_dds160030
{
    partial class TextSearch
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblFileName = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.ctlKeyword = new System.Windows.Forms.TextBox();
            this.ctlFilePath = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.listNames = new System.Windows.Forms.ListView();
            this.listlineNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listLine = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.lblstatusbar = new System.Windows.Forms.ToolStripStatusLabel();
            this.FileDialog = new System.Windows.Forms.OpenFileDialog();
            this.backWorker = new System.ComponentModel.BackgroundWorker();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.ctlWholeWords = new System.Windows.Forms.CheckBox();
            this.ctlIgnoreCase = new System.Windows.Forms.CheckBox();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.StatusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(837, 40);
            this.panel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Controls.Add(this.ctlIgnoreCase);
            this.panel5.Controls.Add(this.ctlWholeWords);
            this.panel5.Controls.Add(this.lblSearch);
            this.panel5.Controls.Add(this.lblFileName);
            this.panel5.Controls.Add(this.btnSearch);
            this.panel5.Controls.Add(this.btnBrowse);
            this.panel5.Controls.Add(this.ctlKeyword);
            this.panel5.Controls.Add(this.ctlFilePath);
            this.panel5.Location = new System.Drawing.Point(37, 42);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(766, 165);
            this.panel5.TabIndex = 4;
            // 
            // lblSearch
            // 
            this.lblSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(12, 80);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(92, 20);
            this.lblSearch.TabIndex = 5;
            this.lblSearch.Text = "Search for:";
            // 
            // lblFileName
            // 
            this.lblFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFileName.AutoSize = true;
            this.lblFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileName.Location = new System.Drawing.Point(12, 32);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(85, 20);
            this.lblFileName.TabIndex = 4;
            this.lblFileName.Text = "File Name";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(638, 66);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(125, 34);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Location = new System.Drawing.Point(638, 18);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(125, 34);
            this.btnBrowse.TabIndex = 4;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // ctlKeyword
            // 
            this.ctlKeyword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctlKeyword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ctlKeyword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.ctlKeyword.Location = new System.Drawing.Point(128, 78);
            this.ctlKeyword.MaxLength = 20;
            this.ctlKeyword.Name = "ctlKeyword";
            this.ctlKeyword.Size = new System.Drawing.Size(480, 22);
            this.ctlKeyword.TabIndex = 1;
            this.ctlKeyword.TextChanged += new System.EventHandler(this.ctlKeyword_TextChanged);
            // 
            // ctlFilePath
            // 
            this.ctlFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctlFilePath.Location = new System.Drawing.Point(128, 30);
            this.ctlFilePath.Name = "ctlFilePath";
            this.ctlFilePath.Size = new System.Drawing.Size(480, 22);
            this.ctlFilePath.TabIndex = 0;
            this.ctlFilePath.TextChanged += new System.EventHandler(this.ctlFilePath_TextChanged);
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.Controls.Add(this.listNames);
            this.panel6.Location = new System.Drawing.Point(37, 213);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(766, 388);
            this.panel6.TabIndex = 5;
            // 
            // listNames
            // 
            this.listNames.AllowColumnReorder = true;
            this.listNames.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.listlineNo,
            this.listLine});
            this.listNames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.listNames.FullRowSelect = true;
            this.listNames.Location = new System.Drawing.Point(0, 0);
            this.listNames.Name = "listNames";
            this.listNames.Size = new System.Drawing.Size(766, 388);
            this.listNames.TabIndex = 4;
            this.listNames.UseCompatibleStateImageBehavior = false;
            this.listNames.View = System.Windows.Forms.View.Details;
            // 
            // listlineNo
            // 
            this.listlineNo.Text = "Line No.";
            this.listlineNo.Width = 100;
            // 
            // listLine
            // 
            this.listLine.Text = "Line";
            this.listLine.Width = 1375;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.progressBar);
            this.panel3.Controls.Add(this.StatusBar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 607);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(837, 36);
            this.panel3.TabIndex = 2;
            // 
            // StatusBar
            // 
            this.StatusBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StatusBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblstatusbar});
            this.StatusBar.Location = new System.Drawing.Point(0, 0);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(837, 36);
            this.StatusBar.TabIndex = 0;
            this.StatusBar.Text = "statusStrip1";
            // 
            // lblstatusbar
            // 
            this.lblstatusbar.Name = "lblstatusbar";
            this.lblstatusbar.Size = new System.Drawing.Size(0, 31);
            // 
            // backWorker
            // 
            this.backWorker.WorkerReportsProgress = true;
            this.backWorker.WorkerSupportsCancellation = true;
            this.backWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backWorker_DoWork);
            this.backWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backWorker_ProgressChanged);
            this.backWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backWorker_RunWorkerCompleted);
            // 
            // progressBar
            // 
            this.progressBar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.progressBar.Location = new System.Drawing.Point(430, 3);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(373, 30);
            this.progressBar.TabIndex = 1;
            // 
            // ctlWholeWords
            // 
            this.ctlWholeWords.AutoSize = true;
            this.ctlWholeWords.Checked = true;
            this.ctlWholeWords.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ctlWholeWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ctlWholeWords.Location = new System.Drawing.Point(128, 121);
            this.ctlWholeWords.Name = "ctlWholeWords";
            this.ctlWholeWords.Size = new System.Drawing.Size(183, 24);
            this.ctlWholeWords.TabIndex = 2;
            this.ctlWholeWords.Text = "Match Whole Words";
            this.ctlWholeWords.UseVisualStyleBackColor = true;
            // 
            // ctlIgnoreCase
            // 
            this.ctlIgnoreCase.AutoSize = true;
            this.ctlIgnoreCase.Checked = true;
            this.ctlIgnoreCase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ctlIgnoreCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ctlIgnoreCase.Location = new System.Drawing.Point(393, 121);
            this.ctlIgnoreCase.Name = "ctlIgnoreCase";
            this.ctlIgnoreCase.Size = new System.Drawing.Size(121, 24);
            this.ctlIgnoreCase.TabIndex = 3;
            this.ctlIgnoreCase.Text = "Ignore Case";
            this.ctlIgnoreCase.UseVisualStyleBackColor = true;
            // 
            // FileSearch
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 643);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "FileSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text Search";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ctlKeyword_TextChanged);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.StatusBar.ResumeLayout(false);
            this.StatusBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox ctlKeyword;
        private System.Windows.Forms.TextBox ctlFilePath;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ListView listNames;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.StatusStrip StatusBar;
        private System.Windows.Forms.ToolStripStatusLabel lblstatusbar;
        private System.Windows.Forms.OpenFileDialog FileDialog;
        private System.ComponentModel.BackgroundWorker backWorker;
        private System.Windows.Forms.ColumnHeader listlineNo;
        private System.Windows.Forms.ColumnHeader listLine;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.CheckBox ctlIgnoreCase;
        private System.Windows.Forms.CheckBox ctlWholeWords;
    }
}

