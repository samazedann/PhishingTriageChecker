namespace PhishingTriageChecker
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSub = new System.Windows.Forms.Label();
            this.btnBEC = new System.Windows.Forms.Button();
            this.btnMicrosoft = new System.Windows.Forms.Button();
            this.btnHR = new System.Windows.Forms.Button();
            this.labelll = new System.Windows.Forms.Label();
            this.lebell = new System.Windows.Forms.Label();
            this.labeel = new System.Windows.Forms.Label();
            this.l = new System.Windows.Forms.Label();
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.lblRisk = new System.Windows.Forms.Label();
            this.lstFlags = new System.Windows.Forms.ListBox();
            this.la = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSender = new System.Windows.Forms.TextBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.txtBody = new System.Windows.Forms.RichTextBox();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUnsafe = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(340, 41);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "PhishingTriageChecker";
            // 
            // lblSub
            // 
            this.lblSub.AutoSize = true;
            this.lblSub.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblSub.Location = new System.Drawing.Point(20, 60);
            this.lblSub.Name = "lblSub";
            this.lblSub.Size = new System.Drawing.Size(372, 17);
            this.lblSub.TabIndex = 1;
            this.lblSub.Text = "DecodeLabs Project 3 — paste a suspicious email to analyze it";
            // 
            // btnBEC
            // 
            this.btnBEC.BackColor = System.Drawing.SystemColors.MenuText;
            this.btnBEC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBEC.ForeColor = System.Drawing.Color.White;
            this.btnBEC.Location = new System.Drawing.Point(109, 106);
            this.btnBEC.Name = "btnBEC";
            this.btnBEC.Size = new System.Drawing.Size(117, 31);
            this.btnBEC.TabIndex = 2;
            this.btnBEC.Text = "BEC wire transfer";
            this.btnBEC.UseVisualStyleBackColor = false;
            this.btnBEC.Click += new System.EventHandler(this.btnBEC_Click);
            // 
            // btnMicrosoft
            // 
            this.btnMicrosoft.BackColor = System.Drawing.SystemColors.MenuText;
            this.btnMicrosoft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMicrosoft.ForeColor = System.Drawing.Color.White;
            this.btnMicrosoft.Location = new System.Drawing.Point(252, 106);
            this.btnMicrosoft.Name = "btnMicrosoft";
            this.btnMicrosoft.Size = new System.Drawing.Size(150, 31);
            this.btnMicrosoft.TabIndex = 3;
            this.btnMicrosoft.Text = "Fake Microsoft alert";
            this.btnMicrosoft.UseVisualStyleBackColor = false;
            this.btnMicrosoft.Click += new System.EventHandler(this.btnMicrosoft_Click);
            // 
            // btnHR
            // 
            this.btnHR.BackColor = System.Drawing.SystemColors.MenuText;
            this.btnHR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHR.ForeColor = System.Drawing.Color.White;
            this.btnHR.Location = new System.Drawing.Point(428, 106);
            this.btnHR.Name = "btnHR";
            this.btnHR.Size = new System.Drawing.Size(132, 31);
            this.btnHR.TabIndex = 4;
            this.btnHR.Text = "HR policy update";
            this.btnHR.UseVisualStyleBackColor = false;
            this.btnHR.Click += new System.EventHandler(this.btnHR_Click);
            // 
            // labelll
            // 
            this.labelll.AutoSize = true;
            this.labelll.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelll.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelll.ForeColor = System.Drawing.Color.White;
            this.labelll.Location = new System.Drawing.Point(27, 166);
            this.labelll.Name = "labelll";
            this.labelll.Size = new System.Drawing.Size(182, 25);
            this.labelll.TabIndex = 5;
            this.labelll.Text = "From / sender address";
            // 
            // lebell
            // 
            this.lebell.AutoSize = true;
            this.lebell.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lebell.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lebell.ForeColor = System.Drawing.Color.White;
            this.lebell.Location = new System.Drawing.Point(27, 230);
            this.lebell.Name = "lebell";
            this.lebell.Size = new System.Drawing.Size(100, 25);
            this.lebell.TabIndex = 6;
            this.lebell.Text = "Subject line";
            // 
            // labeel
            // 
            this.labeel.AutoSize = true;
            this.labeel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labeel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeel.ForeColor = System.Drawing.Color.White;
            this.labeel.Location = new System.Drawing.Point(27, 302);
            this.labeel.Name = "labeel";
            this.labeel.Size = new System.Drawing.Size(96, 25);
            this.labeel.TabIndex = 7;
            this.labeel.Text = "Email body";
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.l.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l.ForeColor = System.Drawing.Color.White;
            this.l.Location = new System.Drawing.Point(36, 450);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(276, 25);
            this.l.TabIndex = 8;
            this.l.Text = "Links / URLs in the email (optional)";
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAnalyze.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnalyze.ForeColor = System.Drawing.Color.White;
            this.btnAnalyze.Location = new System.Drawing.Point(27, 524);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(506, 34);
            this.btnAnalyze.TabIndex = 9;
            this.btnAnalyze.Text = "Analyze Email";
            this.btnAnalyze.UseVisualStyleBackColor = false;
            this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);
            // 
            // lblRisk
            // 
            this.lblRisk.AutoSize = true;
            this.lblRisk.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRisk.ForeColor = System.Drawing.Color.White;
            this.lblRisk.Location = new System.Drawing.Point(31, 571);
            this.lblRisk.Name = "lblRisk";
            this.lblRisk.Size = new System.Drawing.Size(200, 28);
            this.lblRisk.TabIndex = 10;
            this.lblRisk.Text = "Risk Level:Waiting...";
            // 
            // lstFlags
            // 
            this.lstFlags.BackColor = System.Drawing.SystemColors.MenuText;
            this.lstFlags.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstFlags.ForeColor = System.Drawing.Color.Red;
            this.lstFlags.FormattingEnabled = true;
            this.lstFlags.ItemHeight = 28;
            this.lstFlags.Location = new System.Drawing.Point(36, 661);
            this.lstFlags.Name = "lstFlags";
            this.lstFlags.Size = new System.Drawing.Size(324, 116);
            this.lstFlags.TabIndex = 11;
            // 
            // la
            // 
            this.la.AutoSize = true;
            this.la.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.la.ForeColor = System.Drawing.Color.White;
            this.la.Location = new System.Drawing.Point(370, 622);
            this.la.Name = "la";
            this.la.Size = new System.Drawing.Size(110, 23);
            this.la.TabIndex = 12;
            this.la.Text = "Why Unsafe:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Load Example:";
            // 
            // txtSender
            // 
            this.txtSender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSender.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSender.Location = new System.Drawing.Point(23, 194);
            this.txtSender.Name = "txtSender";
            this.txtSender.Size = new System.Drawing.Size(510, 30);
            this.txtSender.TabIndex = 15;
            // 
            // txtSubject
            // 
            this.txtSubject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubject.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubject.Location = new System.Drawing.Point(27, 258);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(506, 30);
            this.txtSubject.TabIndex = 16;
            // 
            // txtBody
            // 
            this.txtBody.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBody.Location = new System.Drawing.Point(27, 330);
            this.txtBody.Name = "txtBody";
            this.txtBody.Size = new System.Drawing.Size(506, 117);
            this.txtBody.TabIndex = 17;
            this.txtBody.Text = "";
            // 
            // txtURL
            // 
            this.txtURL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtURL.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtURL.Location = new System.Drawing.Point(27, 478);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(506, 30);
            this.txtURL.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(32, 622);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 23);
            this.label2.TabIndex = 19;
            this.label2.Text = "Red Flags Found:";
            // 
            // lblUnsafe
            // 
            this.lblUnsafe.AutoSize = true;
            this.lblUnsafe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUnsafe.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnsafe.ForeColor = System.Drawing.Color.Black;
            this.lblUnsafe.Location = new System.Drawing.Point(374, 661);
            this.lblUnsafe.MaximumSize = new System.Drawing.Size(500, 500);
            this.lblUnsafe.Name = "lblUnsafe";
            this.lblUnsafe.Size = new System.Drawing.Size(170, 25);
            this.lblUnsafe.TabIndex = 20;
            this.lblUnsafe.Text = "Waiting for analysis";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(772, 812);
            this.Controls.Add(this.lblUnsafe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.txtBody);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.txtSender);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.la);
            this.Controls.Add(this.lstFlags);
            this.Controls.Add(this.lblRisk);
            this.Controls.Add(this.btnAnalyze);
            this.Controls.Add(this.l);
            this.Controls.Add(this.labeel);
            this.Controls.Add(this.lebell);
            this.Controls.Add(this.labelll);
            this.Controls.Add(this.btnHR);
            this.Controls.Add(this.btnMicrosoft);
            this.Controls.Add(this.btnBEC);
            this.Controls.Add(this.lblSub);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PhishingTriageChecker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSub;
        private System.Windows.Forms.Button btnBEC;
        private System.Windows.Forms.Button btnMicrosoft;
        private System.Windows.Forms.Button btnHR;
        private System.Windows.Forms.Label labelll;
        private System.Windows.Forms.Label lebell;
        private System.Windows.Forms.Label labeel;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.Button btnAnalyze;
        private System.Windows.Forms.Label lblRisk;
        private System.Windows.Forms.ListBox lstFlags;
        private System.Windows.Forms.Label la;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSender;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.RichTextBox txtBody;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUnsafe;
    }
}

