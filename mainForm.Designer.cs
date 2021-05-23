namespace Arma3ConfigExtractorGUI
{
    partial class mainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.listPBO = new System.Windows.Forms.ListBox();
            this.btnSetPBODir = new System.Windows.Forms.Button();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.btnSetOutDir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOutputAll = new System.Windows.Forms.Button();
            this.btnOutputOne = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxPBOManagerDir = new System.Windows.Forms.TextBox();
            this.btnPBOManagerDir = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxArma3ConfigExtractorDir = new System.Windows.Forms.TextBox();
            this.btnArma3ConfigExtractorDir = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBoxCfgConvertDir = new System.Windows.Forms.TextBox();
            this.btnCfgConvertDir = new System.Windows.Forms.Button();
            this.textBoxPboDir = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBoxStringTable = new System.Windows.Forms.TextBox();
            this.buttonStringTable = new System.Windows.Forms.Button();
            this.checkGetStringTable = new System.Windows.Forms.CheckBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listPBO
            // 
            this.listPBO.FormattingEnabled = true;
            this.listPBO.ItemHeight = 12;
            this.listPBO.Location = new System.Drawing.Point(12, 64);
            this.listPBO.Name = "listPBO";
            this.listPBO.Size = new System.Drawing.Size(220, 124);
            this.listPBO.TabIndex = 0;
            // 
            // btnSetPBODir
            // 
            this.btnSetPBODir.Location = new System.Drawing.Point(12, 10);
            this.btnSetPBODir.Name = "btnSetPBODir";
            this.btnSetPBODir.Size = new System.Drawing.Size(220, 23);
            this.btnSetPBODir.TabIndex = 2;
            this.btnSetPBODir.Text = "PBOフォルダ選択";
            this.btnSetPBODir.UseVisualStyleBackColor = true;
            this.btnSetPBODir.Click += new System.EventHandler(this.btnSetPBODir_Click);
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Location = new System.Drawing.Point(6, 47);
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.Size = new System.Drawing.Size(208, 19);
            this.textBoxOutput.TabIndex = 3;
            // 
            // btnSetOutDir
            // 
            this.btnSetOutDir.Location = new System.Drawing.Point(6, 18);
            this.btnSetOutDir.Name = "btnSetOutDir";
            this.btnSetOutDir.Size = new System.Drawing.Size(208, 23);
            this.btnSetOutDir.TabIndex = 4;
            this.btnSetOutDir.Text = "出力フォルダ選択";
            this.btnSetOutDir.UseVisualStyleBackColor = true;
            this.btnSetOutDir.Click += new System.EventHandler(this.btnSetOutDir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxOutput);
            this.groupBox1.Controls.Add(this.btnSetOutDir);
            this.groupBox1.Location = new System.Drawing.Point(12, 194);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 76);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "出力csvフォルダ指定";
            // 
            // btnOutputAll
            // 
            this.btnOutputAll.Location = new System.Drawing.Point(28, 287);
            this.btnOutputAll.Name = "btnOutputAll";
            this.btnOutputAll.Size = new System.Drawing.Size(67, 45);
            this.btnOutputAll.TabIndex = 6;
            this.btnOutputAll.Text = "全PBO\r\n解析";
            this.btnOutputAll.UseVisualStyleBackColor = true;
            this.btnOutputAll.Click += new System.EventHandler(this.btnOutputAll_Click);
            // 
            // btnOutputOne
            // 
            this.btnOutputOne.Location = new System.Drawing.Point(151, 287);
            this.btnOutputOne.Name = "btnOutputOne";
            this.btnOutputOne.Size = new System.Drawing.Size(67, 45);
            this.btnOutputOne.TabIndex = 7;
            this.btnOutputOne.Text = "選択PBO\r\n解析";
            this.btnOutputOne.UseVisualStyleBackColor = true;
            this.btnOutputOne.Click += new System.EventHandler(this.btnOutputOne_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxPBOManagerDir);
            this.groupBox2.Controls.Add(this.btnPBOManagerDir);
            this.groupBox2.Location = new System.Drawing.Point(270, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(220, 76);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PBOConsole.exe指定";
            // 
            // textBoxPBOManagerDir
            // 
            this.textBoxPBOManagerDir.Location = new System.Drawing.Point(6, 47);
            this.textBoxPBOManagerDir.Name = "textBoxPBOManagerDir";
            this.textBoxPBOManagerDir.Size = new System.Drawing.Size(208, 19);
            this.textBoxPBOManagerDir.TabIndex = 3;
            // 
            // btnPBOManagerDir
            // 
            this.btnPBOManagerDir.Location = new System.Drawing.Point(6, 18);
            this.btnPBOManagerDir.Name = "btnPBOManagerDir";
            this.btnPBOManagerDir.Size = new System.Drawing.Size(208, 23);
            this.btnPBOManagerDir.TabIndex = 4;
            this.btnPBOManagerDir.Text = "PBOConsole.exe選択";
            this.btnPBOManagerDir.UseVisualStyleBackColor = true;
            this.btnPBOManagerDir.Click += new System.EventHandler(this.btnPBOManagerDir_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxArma3ConfigExtractorDir);
            this.groupBox3.Controls.Add(this.btnArma3ConfigExtractorDir);
            this.groupBox3.Location = new System.Drawing.Point(270, 176);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(220, 76);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Arma3ConfigExtractor.exe指定";
            // 
            // textBoxArma3ConfigExtractorDir
            // 
            this.textBoxArma3ConfigExtractorDir.Location = new System.Drawing.Point(6, 47);
            this.textBoxArma3ConfigExtractorDir.Name = "textBoxArma3ConfigExtractorDir";
            this.textBoxArma3ConfigExtractorDir.Size = new System.Drawing.Size(208, 19);
            this.textBoxArma3ConfigExtractorDir.TabIndex = 3;
            // 
            // btnArma3ConfigExtractorDir
            // 
            this.btnArma3ConfigExtractorDir.Location = new System.Drawing.Point(6, 18);
            this.btnArma3ConfigExtractorDir.Name = "btnArma3ConfigExtractorDir";
            this.btnArma3ConfigExtractorDir.Size = new System.Drawing.Size(208, 23);
            this.btnArma3ConfigExtractorDir.TabIndex = 4;
            this.btnArma3ConfigExtractorDir.Text = "Arma3ConfigExtractor.exe選択";
            this.btnArma3ConfigExtractorDir.UseVisualStyleBackColor = true;
            this.btnArma3ConfigExtractorDir.Click += new System.EventHandler(this.btnArma3ConfigExtractorDir_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBoxCfgConvertDir);
            this.groupBox4.Controls.Add(this.btnCfgConvertDir);
            this.groupBox4.Location = new System.Drawing.Point(270, 94);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(220, 76);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "BINToCPP.bat指定";
            // 
            // textBoxCfgConvertDir
            // 
            this.textBoxCfgConvertDir.Location = new System.Drawing.Point(6, 47);
            this.textBoxCfgConvertDir.Name = "textBoxCfgConvertDir";
            this.textBoxCfgConvertDir.Size = new System.Drawing.Size(208, 19);
            this.textBoxCfgConvertDir.TabIndex = 3;
            // 
            // btnCfgConvertDir
            // 
            this.btnCfgConvertDir.Location = new System.Drawing.Point(6, 18);
            this.btnCfgConvertDir.Name = "btnCfgConvertDir";
            this.btnCfgConvertDir.Size = new System.Drawing.Size(208, 23);
            this.btnCfgConvertDir.TabIndex = 4;
            this.btnCfgConvertDir.Text = "BINToCPP.bat選択";
            this.btnCfgConvertDir.UseVisualStyleBackColor = true;
            this.btnCfgConvertDir.Click += new System.EventHandler(this.btnCfgConvertDir_Click);
            // 
            // textBoxPboDir
            // 
            this.textBoxPboDir.Location = new System.Drawing.Point(12, 39);
            this.textBoxPboDir.Name = "textBoxPboDir";
            this.textBoxPboDir.Size = new System.Drawing.Size(220, 19);
            this.textBoxPboDir.TabIndex = 11;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBoxStringTable);
            this.groupBox5.Controls.Add(this.buttonStringTable);
            this.groupBox5.Enabled = false;
            this.groupBox5.Location = new System.Drawing.Point(270, 287);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(220, 76);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "StringTable.xml指定";
            // 
            // textBoxStringTable
            // 
            this.textBoxStringTable.Location = new System.Drawing.Point(6, 47);
            this.textBoxStringTable.Name = "textBoxStringTable";
            this.textBoxStringTable.Size = new System.Drawing.Size(208, 19);
            this.textBoxStringTable.TabIndex = 3;
            // 
            // buttonStringTable
            // 
            this.buttonStringTable.Location = new System.Drawing.Point(6, 18);
            this.buttonStringTable.Name = "buttonStringTable";
            this.buttonStringTable.Size = new System.Drawing.Size(208, 23);
            this.buttonStringTable.TabIndex = 4;
            this.buttonStringTable.Text = "StringTable.xml選択";
            this.buttonStringTable.UseVisualStyleBackColor = true;
            this.buttonStringTable.Click += new System.EventHandler(this.buttonStringTable_Click);
            // 
            // checkGetStringTable
            // 
            this.checkGetStringTable.AutoSize = true;
            this.checkGetStringTable.Checked = true;
            this.checkGetStringTable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkGetStringTable.Location = new System.Drawing.Point(270, 265);
            this.checkGetStringTable.Name = "checkGetStringTable";
            this.checkGetStringTable.Size = new System.Drawing.Size(154, 16);
            this.checkGetStringTable.TabIndex = 13;
            this.checkGetStringTable.Text = "StringTable.xmlを取得する";
            this.checkGetStringTable.UseVisualStyleBackColor = true;
            this.checkGetStringTable.CheckedChanged += new System.EventHandler(this.checkGetStringTable_CheckedChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 360);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(506, 22);
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 382);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.checkGetStringTable);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.textBoxPboDir);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnOutputOne);
            this.Controls.Add(this.btnOutputAll);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSetPBODir);
            this.Controls.Add(this.listPBO);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.Text = "Arma3ConfigExtractorGUI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listPBO;
        private System.Windows.Forms.Button btnSetPBODir;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.Button btnSetOutDir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOutputAll;
        private System.Windows.Forms.Button btnOutputOne;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxPBOManagerDir;
        private System.Windows.Forms.Button btnPBOManagerDir;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxArma3ConfigExtractorDir;
        private System.Windows.Forms.Button btnArma3ConfigExtractorDir;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBoxCfgConvertDir;
        private System.Windows.Forms.Button btnCfgConvertDir;
        private System.Windows.Forms.TextBox textBoxPboDir;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBoxStringTable;
        private System.Windows.Forms.Button buttonStringTable;
        private System.Windows.Forms.CheckBox checkGetStringTable;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
    }
}

