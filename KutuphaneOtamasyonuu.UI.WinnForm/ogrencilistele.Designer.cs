namespace KutuphaneOtamasyonuu.UI.WinnForm
{
    partial class ogrencilistele
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ogrencilistele));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnlistele = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(67, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(872, 325);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnlistele
            // 
            this.btnlistele.BackColor = System.Drawing.Color.Transparent;
            this.btnlistele.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnlistele.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnlistele.ForeColor = System.Drawing.Color.Lime;
            this.btnlistele.Image = global::KutuphaneOtamasyonuu.UI.WinnForm.Properties.Resources.ogrencilistelerenkli40px;
            this.btnlistele.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnlistele.Location = new System.Drawing.Point(999, 61);
            this.btnlistele.Name = "btnlistele";
            this.btnlistele.Size = new System.Drawing.Size(171, 77);
            this.btnlistele.TabIndex = 1;
            this.btnlistele.Text = "LİSTELE";
            this.btnlistele.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnlistele.UseVisualStyleBackColor = false;
            this.btnlistele.Click += new System.EventHandler(this.btnlistele_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.SkyBlue;
            this.label1.Location = new System.Drawing.Point(945, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(475, 60);
            this.label1.TabIndex = 2;
            this.label1.Text = "Eğer listeleye bastığınızda borç bilgileri 0 gözüküyorsa \r\nBiraz(3-4 saniye) bekl" +
    "eyip tekrar listeleyiniz.Çünkü \r\narkada borç bilgileri hesaplıyor.";
            // 
            // ogrencilistele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KutuphaneOtamasyonuu.UI.WinnForm.Properties.Resources.kitaplistele23;
            this.ClientSize = new System.Drawing.Size(1494, 467);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnlistele);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ogrencilistele";
            this.Text = "Öğrencileri Listele";
            this.Load += new System.EventHandler(this.ogrencilistele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnlistele;
        private System.Windows.Forms.Label label1;
    }
}