namespace KarakterDonusum
{
    partial class AnaSayfa
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rdFile = new System.Windows.Forms.RadioButton();
            this.rdDirectory = new System.Windows.Forms.RadioButton();
            this.clbSources = new System.Windows.Forms.CheckedListBox();
            this.lblHighlight = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mtbCharValue = new System.Windows.Forms.MaskedTextBox();
            this.lblTarget = new System.Windows.Forms.Label();
            this.btnSelectTarget = new System.Windows.Forms.Button();
            this.btnSelectSource = new System.Windows.Forms.Button();
            this.pbWordProg = new System.Windows.Forms.ProgressBar();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblSource = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.textBSyc = new System.Windows.Forms.TextBox();
            this.textBGirdi = new System.Windows.Forms.TextBox();
            this.tbChar = new System.Windows.Forms.TextBox();
            this.tbAsciiCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.rdFile);
            this.tabPage2.Controls.Add(this.rdDirectory);
            this.tabPage2.Controls.Add(this.clbSources);
            this.tabPage2.Controls.Add(this.lblHighlight);
            this.tabPage2.Controls.Add(this.lblStatus);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.mtbCharValue);
            this.tabPage2.Controls.Add(this.lblTarget);
            this.tabPage2.Controls.Add(this.btnSelectTarget);
            this.tabPage2.Controls.Add(this.btnSelectSource);
            this.tabPage2.Controls.Add(this.pbWordProg);
            this.tabPage2.Controls.Add(this.btnStart);
            this.tabPage2.Controls.Add(this.lblSource);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1031, 494);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "Kelime Seçici";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // rdFile
            // 
            this.rdFile.AutoSize = true;
            this.rdFile.Location = new System.Drawing.Point(364, 275);
            this.rdFile.Name = "rdFile";
            this.rdFile.Size = new System.Drawing.Size(93, 20);
            this.rdFile.TabIndex = 12;
            this.rdFile.TabStop = true;
            this.rdFile.Text = "Dosya seç";
            this.rdFile.UseVisualStyleBackColor = true;
            this.rdFile.CheckedChanged += new System.EventHandler(this.rdSelector);
            // 
            // rdDirectory
            // 
            this.rdDirectory.AutoSize = true;
            this.rdDirectory.Location = new System.Drawing.Point(364, 249);
            this.rdDirectory.Name = "rdDirectory";
            this.rdDirectory.Size = new System.Drawing.Size(92, 20);
            this.rdDirectory.TabIndex = 11;
            this.rdDirectory.TabStop = true;
            this.rdDirectory.Text = "Klasör seç";
            this.rdDirectory.UseVisualStyleBackColor = true;
            this.rdDirectory.CheckedChanged += new System.EventHandler(this.rdSelector);
            // 
            // clbSources
            // 
            this.clbSources.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.clbSources.FormattingEnabled = true;
            this.clbSources.Location = new System.Drawing.Point(34, 15);
            this.clbSources.Name = "clbSources";
            this.clbSources.Size = new System.Drawing.Size(422, 228);
            this.clbSources.TabIndex = 10;
            // 
            // lblHighlight
            // 
            this.lblHighlight.AutoSize = true;
            this.lblHighlight.Font = new System.Drawing.Font("Verdana", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHighlight.ForeColor = System.Drawing.Color.Crimson;
            this.lblHighlight.Location = new System.Drawing.Point(848, 206);
            this.lblHighlight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHighlight.Name = "lblHighlight";
            this.lblHighlight.Size = new System.Drawing.Size(110, 116);
            this.lblHighlight.TabIndex = 9;
            this.lblHighlight.Text = "5";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(842, 379);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(116, 16);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "x / x kelime kaldı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(817, 190);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "harf Sayısı:";
            // 
            // mtbCharValue
            // 
            this.mtbCharValue.Location = new System.Drawing.Point(906, 187);
            this.mtbCharValue.Mask = "0";
            this.mtbCharValue.Name = "mtbCharValue";
            this.mtbCharValue.Size = new System.Drawing.Size(26, 23);
            this.mtbCharValue.TabIndex = 6;
            this.mtbCharValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbCharValue.ValidatingType = typeof(int);
            // 
            // lblTarget
            // 
            this.lblTarget.AutoSize = true;
            this.lblTarget.Location = new System.Drawing.Point(165, 356);
            this.lblTarget.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTarget.Name = "lblTarget";
            this.lblTarget.Size = new System.Drawing.Size(161, 16);
            this.lblTarget.TabIndex = 5;
            this.lblTarget.Text = "Hedef dosya: Seçilmedi";
            // 
            // btnSelectTarget
            // 
            this.btnSelectTarget.Location = new System.Drawing.Point(34, 350);
            this.btnSelectTarget.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectTarget.Name = "btnSelectTarget";
            this.btnSelectTarget.Size = new System.Drawing.Size(100, 28);
            this.btnSelectTarget.TabIndex = 4;
            this.btnSelectTarget.Text = "Hedef seç";
            this.btnSelectTarget.UseVisualStyleBackColor = true;
            this.btnSelectTarget.Click += new System.EventHandler(this.selectFolder);
            // 
            // btnSelectSource
            // 
            this.btnSelectSource.Location = new System.Drawing.Point(34, 314);
            this.btnSelectSource.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectSource.Name = "btnSelectSource";
            this.btnSelectSource.Size = new System.Drawing.Size(100, 28);
            this.btnSelectSource.TabIndex = 3;
            this.btnSelectSource.Text = "Kaynak seç";
            this.btnSelectSource.UseVisualStyleBackColor = true;
            this.btnSelectSource.Click += new System.EventHandler(this.btnSelectSource_Click);
            // 
            // pbWordProg
            // 
            this.pbWordProg.Location = new System.Drawing.Point(441, 399);
            this.pbWordProg.Margin = new System.Windows.Forms.Padding(4);
            this.pbWordProg.Name = "pbWordProg";
            this.pbWordProg.Size = new System.Drawing.Size(542, 28);
            this.pbWordProg.Step = 1;
            this.pbWordProg.TabIndex = 2;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(674, 435);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 28);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Başlat";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Location = new System.Drawing.Point(165, 320);
            this.lblSource.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(170, 16);
            this.lblSource.TabIndex = 0;
            this.lblSource.Text = "Kaynak dosya: Seçilmedi";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.textBSyc);
            this.tabPage1.Controls.Add(this.textBGirdi);
            this.tabPage1.Controls.Add(this.tbChar);
            this.tabPage1.Controls.Add(this.tbAsciiCode);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1031, 494);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ascii & Karakter";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(319, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "Kaç karakter var?";
            // 
            // textBSyc
            // 
            this.textBSyc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBSyc.Location = new System.Drawing.Point(531, 117);
            this.textBSyc.Margin = new System.Windows.Forms.Padding(4);
            this.textBSyc.Name = "textBSyc";
            this.textBSyc.ReadOnly = true;
            this.textBSyc.Size = new System.Drawing.Size(124, 38);
            this.textBSyc.TabIndex = 12;
            // 
            // textBGirdi
            // 
            this.textBGirdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBGirdi.Location = new System.Drawing.Point(275, 47);
            this.textBGirdi.Margin = new System.Windows.Forms.Padding(4);
            this.textBGirdi.Name = "textBGirdi";
            this.textBGirdi.Size = new System.Drawing.Size(380, 38);
            this.textBGirdi.TabIndex = 11;
            // 
            // tbChar
            // 
            this.tbChar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbChar.Location = new System.Drawing.Point(21, 143);
            this.tbChar.Margin = new System.Windows.Forms.Padding(4);
            this.tbChar.Name = "tbChar";
            this.tbChar.Size = new System.Drawing.Size(244, 38);
            this.tbChar.TabIndex = 8;
            this.tbChar.Click += new System.EventHandler(this.tbChar_Click);
            this.tbChar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbChar_KeyDown);
            // 
            // tbAsciiCode
            // 
            this.tbAsciiCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbAsciiCode.Location = new System.Drawing.Point(21, 47);
            this.tbAsciiCode.Margin = new System.Windows.Forms.Padding(4);
            this.tbAsciiCode.Name = "tbAsciiCode";
            this.tbAsciiCode.Size = new System.Drawing.Size(244, 38);
            this.tbAsciiCode.TabIndex = 7;
            this.tbAsciiCode.Click += new System.EventHandler(this.tbAsciiCode_Click);
            this.tbAsciiCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbAsciiCode_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(27, 117);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Karakter";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(27, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "ASCII Kodu";
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabPage1);
            this.tabMain.Controls.Add(this.tabPage2);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Margin = new System.Windows.Forms.Padding(4);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(1039, 523);
            this.tabMain.TabIndex = 7;
            this.tabMain.SelectedIndexChanged += new System.EventHandler(this.tabMain_SelectedIndexChanged);
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 523);
            this.Controls.Add(this.tabMain);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AnaSayfa";
            this.Text = "Araç Kutusu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AnaSayfa_FormClosing);
            this.Load += new System.EventHandler(this.AnaSayfa_Load);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ProgressBar pbWordProg;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBSyc;
        private System.Windows.Forms.TextBox textBGirdi;
        private System.Windows.Forms.TextBox tbChar;
        private System.Windows.Forms.TextBox tbAsciiCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.Button btnSelectSource;
        private System.Windows.Forms.Button btnSelectTarget;
        private System.Windows.Forms.MaskedTextBox mtbCharValue;
        private System.Windows.Forms.Label lblTarget;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblHighlight;
        private System.Windows.Forms.CheckedListBox clbSources;
        private System.Windows.Forms.RadioButton rdFile;
        private System.Windows.Forms.RadioButton rdDirectory;
    }
}

