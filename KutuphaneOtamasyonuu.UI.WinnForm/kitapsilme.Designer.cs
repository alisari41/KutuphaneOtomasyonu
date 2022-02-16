namespace KutuphaneOtamasyonuu.UI.WinnForm
{
    partial class kitapsilme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kitapsilme));
            this.btnsilme = new System.Windows.Forms.Button();
            this.txtbarkodno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnsilme
            // 
            this.btnsilme.BackColor = System.Drawing.Color.Transparent;
            this.btnsilme.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsilme.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsilme.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnsilme.Image = global::KutuphaneOtamasyonuu.UI.WinnForm.Properties.Resources.kitapsilrenkli;
            this.btnsilme.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsilme.Location = new System.Drawing.Point(528, 54);
            this.btnsilme.Name = "btnsilme";
            this.btnsilme.Size = new System.Drawing.Size(125, 49);
            this.btnsilme.TabIndex = 0;
            this.btnsilme.Text = "SİL";
            this.btnsilme.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsilme.UseVisualStyleBackColor = false;
            this.btnsilme.Click += new System.EventHandler(this.btnsilme_Click);
            // 
            // txtbarkodno
            // 
            this.txtbarkodno.BackColor = System.Drawing.Color.Sienna;
            this.txtbarkodno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbarkodno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtbarkodno.ForeColor = System.Drawing.Color.White;
            this.txtbarkodno.Location = new System.Drawing.Point(245, 69);
            this.txtbarkodno.Multiline = true;
            this.txtbarkodno.Name = "txtbarkodno";
            this.txtbarkodno.Size = new System.Drawing.Size(192, 25);
            this.txtbarkodno.TabIndex = 1;
            this.txtbarkodno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbarkodno_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(47, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Barkod Numarası";
            // 
            // kitapsilme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KutuphaneOtamasyonuu.UI.WinnForm.Properties.Resources.kütüphanekitapsil;
            this.ClientSize = new System.Drawing.Size(703, 143);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbarkodno);
            this.Controls.Add(this.btnsilme);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "kitapsilme";
            this.Text = "Kitap Silme";
            this.Load += new System.EventHandler(this.kitapsilme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsilme;
        private System.Windows.Forms.TextBox txtbarkodno;
        private System.Windows.Forms.Label label1;
    }
}