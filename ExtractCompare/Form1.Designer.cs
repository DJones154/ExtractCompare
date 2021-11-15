
namespace ExtractCompare
{
    partial class Form1
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
            this.Pathbox = new System.Windows.Forms.TextBox();
            this.vFy = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.resultBox = new System.Windows.Forms.ListBox();
            this.uzipBox = new System.Windows.Forms.ListBox();
            this.existBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.mfgCode = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dupClean = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pathbox
            // 
            this.Pathbox.Location = new System.Drawing.Point(6, 13);
            this.Pathbox.Name = "Pathbox";
            this.Pathbox.Size = new System.Drawing.Size(492, 23);
            this.Pathbox.TabIndex = 1;
            // 
            // vFy
            // 
            this.vFy.Location = new System.Drawing.Point(449, 39);
            this.vFy.Name = "vFy";
            this.vFy.Size = new System.Drawing.Size(81, 38);
            this.vFy.TabIndex = 2;
            this.vFy.Text = "Run";
            this.vFy.UseVisualStyleBackColor = true;
            this.vFy.Click += new System.EventHandler(this.vFy_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(13, 338);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(258, 10);
            this.progressBar1.TabIndex = 3;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(277, 338);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(268, 10);
            this.progressBar2.TabIndex = 4;
            // 
            // resultBox
            // 
            this.resultBox.ForeColor = System.Drawing.Color.Red;
            this.resultBox.FormattingEnabled = true;
            this.resultBox.HorizontalScrollbar = true;
            this.resultBox.ItemHeight = 15;
            this.resultBox.Location = new System.Drawing.Point(12, 354);
            this.resultBox.Name = "resultBox";
            this.resultBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.resultBox.Size = new System.Drawing.Size(533, 154);
            this.resultBox.TabIndex = 6;
            // 
            // uzipBox
            // 
            this.uzipBox.FormattingEnabled = true;
            this.uzipBox.HorizontalScrollbar = true;
            this.uzipBox.ItemHeight = 15;
            this.uzipBox.Location = new System.Drawing.Point(13, 103);
            this.uzipBox.Name = "uzipBox";
            this.uzipBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.uzipBox.Size = new System.Drawing.Size(258, 229);
            this.uzipBox.TabIndex = 7;
            // 
            // existBox
            // 
            this.existBox.FormattingEnabled = true;
            this.existBox.HorizontalScrollbar = true;
            this.existBox.ItemHeight = 15;
            this.existBox.Location = new System.Drawing.Point(277, 103);
            this.existBox.Name = "existBox";
            this.existBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.existBox.Size = new System.Drawing.Size(268, 229);
            this.existBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Files Unzipped";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(277, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Existing Files";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(498, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mfgCode
            // 
            this.mfgCode.Location = new System.Drawing.Point(6, 54);
            this.mfgCode.Name = "mfgCode";
            this.mfgCode.Size = new System.Drawing.Size(90, 23);
            this.mfgCode.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dupClean);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.mfgCode);
            this.groupBox1.Controls.Add(this.Pathbox);
            this.groupBox1.Controls.Add(this.vFy);
            this.groupBox1.Location = new System.Drawing.Point(12, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(533, 80);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zip File Path";
            // 
            // dupClean
            // 
            this.dupClean.AutoSize = true;
            this.dupClean.Checked = true;
            this.dupClean.CheckState = System.Windows.Forms.CheckState.Checked;
            this.dupClean.Location = new System.Drawing.Point(112, 56);
            this.dupClean.Name = "dupClean";
            this.dupClean.Size = new System.Drawing.Size(114, 19);
            this.dupClean.TabIndex = 15;
            this.dupClean.Text = "Clean Duplicates";
            this.dupClean.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "MFR Code";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(12, 527);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(339, 18);
            this.label4.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(357, 527);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 18);
            this.label5.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(459, 527);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 18);
            this.label6.TabIndex = 17;
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(12, 513);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(533, 10);
            this.progressBar3.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 548);
            this.Controls.Add(this.progressBar3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.existBox);
            this.Controls.Add(this.uzipBox);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.progressBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "ImageExtractCompare";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Pathbox;
        private System.Windows.Forms.Button vFy;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.ListBox resultBox;
        private System.Windows.Forms.ListBox uzipBox;
        private System.Windows.Forms.ListBox existBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox mfgCode;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox dupClean;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ProgressBar progressBar3;
    }
}

