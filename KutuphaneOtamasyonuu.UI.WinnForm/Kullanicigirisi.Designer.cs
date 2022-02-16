namespace KutuphaneOtamasyonuu.UI.WinnForm
{
    partial class Kullanicigirisi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kullanicigirisi));
            this.txtkullaniciadi = new System.Windows.Forms.TextBox();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.btngiris = new System.Windows.Forms.Button();
            this.btn_PwReminder = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // txtkullaniciadi
            // 
            this.txtkullaniciadi.BackColor = System.Drawing.Color.Silver;
            this.txtkullaniciadi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtkullaniciadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtkullaniciadi.Location = new System.Drawing.Point(327, 320);
            this.txtkullaniciadi.Margin = new System.Windows.Forms.Padding(4);
            this.txtkullaniciadi.Multiline = true;
            this.txtkullaniciadi.Name = "txtkullaniciadi";
            this.txtkullaniciadi.Size = new System.Drawing.Size(175, 36);
            this.txtkullaniciadi.TabIndex = 3;
            this.txtkullaniciadi.TextChanged += new System.EventHandler(this.txtkullaniciadi_TextChanged);
            this.txtkullaniciadi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtkullaniciadi_KeyPress);
            // 
            // txtsifre
            // 
            this.txtsifre.BackColor = System.Drawing.Color.Silver;
            this.txtsifre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtsifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsifre.Location = new System.Drawing.Point(577, 320);
            this.txtsifre.Margin = new System.Windows.Forms.Padding(4);
            this.txtsifre.Multiline = true;
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.PasswordChar = '●';
            this.txtsifre.Size = new System.Drawing.Size(175, 36);
            this.txtsifre.TabIndex = 4;
            this.txtsifre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsifre_KeyPress);
            // 
            // btngiris
            // 
            this.btngiris.BackColor = System.Drawing.Color.Transparent;
            this.btngiris.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btngiris.Location = new System.Drawing.Point(829, 196);
            this.btngiris.Margin = new System.Windows.Forms.Padding(4);
            this.btngiris.Name = "btngiris";
            this.btngiris.Size = new System.Drawing.Size(123, 249);
            this.btngiris.TabIndex = 4;
            this.btngiris.UseVisualStyleBackColor = false;
            this.btngiris.Click += new System.EventHandler(this.btngiris_Click);
            // 
            // btn_PwReminder
            // 
            this.btn_PwReminder.BackColor = System.Drawing.Color.Transparent;
            this.btn_PwReminder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_PwReminder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_PwReminder.ForeColor = System.Drawing.Color.White;
            this.btn_PwReminder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_PwReminder.Location = new System.Drawing.Point(429, 416);
            this.btn_PwReminder.Margin = new System.Windows.Forms.Padding(4);
            this.btn_PwReminder.Name = "btn_PwReminder";
            this.btn_PwReminder.Size = new System.Drawing.Size(258, 29);
            this.btn_PwReminder.TabIndex = 7;
            this.btn_PwReminder.Text = "Üye değilseniz üye olunuz!!";
            this.btn_PwReminder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_PwReminder.UseVisualStyleBackColor = false;
            this.btn_PwReminder.Click += new System.EventHandler(this.btn_PwReminder_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // Kullanicigirisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KutuphaneOtamasyonuu.UI.WinnForm.Properties.Resources.LibraryLogin;
            this.ClientSize = new System.Drawing.Size(1262, 623);
            this.Controls.Add(this.btn_PwReminder);
            this.Controls.Add(this.btngiris);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.txtkullaniciadi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Kullanicigirisi";
            this.Text = "Kullanıcı Girişi";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Kullanicigirisi_FormClosed);
            this.Load += new System.EventHandler(this.Kullanicigirisi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtkullaniciadi;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.Button btngiris;
        private System.Windows.Forms.Button btn_PwReminder;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}