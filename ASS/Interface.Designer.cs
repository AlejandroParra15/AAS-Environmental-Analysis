namespace UserInterface
{
    partial class Interface
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.backgroundWorker4 = new System.ComponentModel.BackgroundWorker();
            this.btOpenFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelLateral = new System.Windows.Forms.Panel();
            this.btApply = new System.Windows.Forms.Button();
            this.split3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbValue = new System.Windows.Forms.ComboBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbNumberOfRecords = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.split2 = new System.Windows.Forms.Label();
            this.split1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btPanel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbLink = new System.Windows.Forms.TextBox();
            this.tbCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btBack = new System.Windows.Forms.Button();
            this.btNext = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelLateral.SuspendLayout();
            this.SuspendLayout();
            // 
            // btOpenFile
            // 
            this.btOpenFile.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btOpenFile.Location = new System.Drawing.Point(813, 213);
            this.btOpenFile.Name = "btOpenFile";
            this.btOpenFile.Size = new System.Drawing.Size(452, 51);
            this.btOpenFile.TabIndex = 1;
            this.btOpenFile.Text = "Load";
            this.btOpenFile.UseVisualStyleBackColor = true;
            this.btOpenFile.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 42F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(359, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(991, 62);
            this.label1.TabIndex = 2;
            this.label1.Text = "AAS ENVIRONMENTAL ANALYSIS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(977, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Load the data:";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 697);
            this.splitter1.TabIndex = 5;
            this.splitter1.TabStop = false;
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(3, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 697);
            this.splitter2.TabIndex = 6;
            this.splitter2.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.SteelBlue;
            this.dataGridView1.Location = new System.Drawing.Point(165, 289);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Size = new System.Drawing.Size(1373, 328);
            this.dataGridView1.TabIndex = 7;
            // 
            // panelLateral
            // 
            this.panelLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.panelLateral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLateral.Controls.Add(this.btApply);
            this.panelLateral.Controls.Add(this.split3);
            this.panelLateral.Controls.Add(this.label11);
            this.panelLateral.Controls.Add(this.cbValue);
            this.panelLateral.Controls.Add(this.cbCategory);
            this.panelLateral.Controls.Add(this.label8);
            this.panelLateral.Controls.Add(this.label7);
            this.panelLateral.Controls.Add(this.tbNumberOfRecords);
            this.panelLateral.Controls.Add(this.label6);
            this.panelLateral.Controls.Add(this.split2);
            this.panelLateral.Controls.Add(this.split1);
            this.panelLateral.Controls.Add(this.label3);
            this.panelLateral.Controls.Add(this.btPanel);
            this.panelLateral.Location = new System.Drawing.Point(-260, 0);
            this.panelLateral.Name = "panelLateral";
            this.panelLateral.Size = new System.Drawing.Size(340, 697);
            this.panelLateral.TabIndex = 8;
            // 
            // btApply
            // 
            this.btApply.Location = new System.Drawing.Point(79, 475);
            this.btApply.Name = "btApply";
            this.btApply.Size = new System.Drawing.Size(184, 33);
            this.btApply.TabIndex = 17;
            this.btApply.Text = "Apply";
            this.btApply.UseVisualStyleBackColor = true;
            this.btApply.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // split3
            // 
            this.split3.AutoSize = true;
            this.split3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.split3.Location = new System.Drawing.Point(-3, 533);
            this.split3.Name = "split3";
            this.split3.Size = new System.Drawing.Size(346, 13);
            this.split3.TabIndex = 16;
            this.split3.Text = "---------------------------------------------------------------------------------" +
    "--------------------------------";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(75, 382);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(185, 23);
            this.label11.TabIndex = 15;
            this.label11.Text = "Number of records:";
            // 
            // cbValue
            // 
            this.cbValue.FormattingEnabled = true;
            this.cbValue.Location = new System.Drawing.Point(162, 219);
            this.cbValue.Name = "cbValue";
            this.cbValue.Size = new System.Drawing.Size(150, 21);
            this.cbValue.TabIndex = 12;
            this.cbValue.SelectedIndexChanged += new System.EventHandler(this.cbValue_SelectedIndexChanged);
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(162, 172);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(150, 21);
            this.cbCategory.TabIndex = 11;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCategory_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(13, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 23);
            this.label8.TabIndex = 8;
            this.label8.Text = "Value:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(13, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 23);
            this.label7.TabIndex = 7;
            this.label7.Text = "Category:";
            // 
            // tbNumberOfRecords
            // 
            this.tbNumberOfRecords.Location = new System.Drawing.Point(79, 424);
            this.tbNumberOfRecords.Name = "tbNumberOfRecords";
            this.tbNumberOfRecords.Size = new System.Drawing.Size(181, 20);
            this.tbNumberOfRecords.TabIndex = 6;
            this.tbNumberOfRecords.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(11, 321);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 33);
            this.label6.TabIndex = 5;
            this.label6.Text = "Display:";
            // 
            // split2
            // 
            this.split2.AutoSize = true;
            this.split2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.split2.Location = new System.Drawing.Point(-7, 288);
            this.split2.Name = "split2";
            this.split2.Size = new System.Drawing.Size(346, 13);
            this.split2.TabIndex = 4;
            this.split2.Text = "---------------------------------------------------------------------------------" +
    "--------------------------------";
            // 
            // split1
            // 
            this.split1.AutoSize = true;
            this.split1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.split1.Location = new System.Drawing.Point(-3, 64);
            this.split1.Name = "split1";
            this.split1.Size = new System.Drawing.Size(346, 13);
            this.split1.TabIndex = 2;
            this.split1.Text = "---------------------------------------------------------------------------------" +
    "--------------------------------";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(13, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 33);
            this.label3.TabIndex = 1;
            this.label3.Text = "Filters:";
            // 
            // btPanel
            // 
            this.btPanel.Location = new System.Drawing.Point(262, 3);
            this.btPanel.Name = "btPanel";
            this.btPanel.Size = new System.Drawing.Size(75, 47);
            this.btPanel.TabIndex = 0;
            this.btPanel.Text = "Filters";
            this.btPanel.UseVisualStyleBackColor = true;
            this.btPanel.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(476, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Link:";
            // 
            // tbLink
            // 
            this.tbLink.Location = new System.Drawing.Point(377, 177);
            this.tbLink.Name = "tbLink";
            this.tbLink.Size = new System.Drawing.Size(293, 20);
            this.tbLink.TabIndex = 10;
            this.tbLink.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbCode
            // 
            this.tbCode.Location = new System.Drawing.Point(377, 248);
            this.tbCode.Name = "tbCode";
            this.tbCode.Size = new System.Drawing.Size(293, 20);
            this.tbCode.TabIndex = 12;
            this.tbCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(476, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Code:";
            // 
            // btBack
            // 
            this.btBack.Location = new System.Drawing.Point(103, 577);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(56, 40);
            this.btBack.TabIndex = 13;
            this.btBack.Text = "<<";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // btNext
            // 
            this.btNext.Location = new System.Drawing.Point(1544, 577);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(56, 40);
            this.btNext.TabIndex = 14;
            this.btNext.Text = ">>";
            this.btNext.UseVisualStyleBackColor = true;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(674, 640);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(453, 34);
            this.progressBar1.TabIndex = 15;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1612, 697);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btNext);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.tbCode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbLink);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panelLateral);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btOpenFile);
            this.Name = "Interface";
            this.Text = " Flights Data";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelLateral.ResumeLayout(false);
            this.panelLateral.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.ComponentModel.BackgroundWorker backgroundWorker4;
        private System.Windows.Forms.Button btOpenFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panelLateral;
        private System.Windows.Forms.Button btPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label split1;
        private System.Windows.Forms.TextBox tbNumberOfRecords;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label split2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbValue;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label split3;
        private System.Windows.Forms.Button btApply;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbLink;
        private System.Windows.Forms.TextBox tbCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Button btNext;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
    }
}

