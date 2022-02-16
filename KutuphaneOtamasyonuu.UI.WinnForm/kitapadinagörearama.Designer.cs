namespace KutuphaneOtamasyonuu.UI.WinnForm
{
    partial class kitapadinagörearama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kitapadinagörearama));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtkitapadi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnarama = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.DimGray;
            this.dataGridView1.Location = new System.Drawing.Point(170, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(738, 233);
            this.dataGridView1.TabIndex = 7;
            // 
            // txtkitapadi
            // 
            this.txtkitapadi.BackColor = System.Drawing.Color.MistyRose;
            this.txtkitapadi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtkitapadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtkitapadi.Location = new System.Drawing.Point(321, 41);
            this.txtkitapadi.Multiline = true;
            this.txtkitapadi.Name = "txtkitapadi";
            this.txtkitapadi.Size = new System.Drawing.Size(199, 32);
            this.txtkitapadi.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Fuchsia;
            this.label1.Location = new System.Drawing.Point(165, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kitabın Adı";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Image = global::KutuphaneOtamasyonuu.UI.WinnForm.Properties.Resources.delete_Button;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(601, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 55);
            this.button1.TabIndex = 8;
            this.button1.Text = "Temizle";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnarama
            // 
            this.btnarama.BackColor = System.Drawing.Color.Transparent;
            this.btnarama.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnarama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnarama.Image = global::KutuphaneOtamasyonuu.UI.WinnForm.Properties.Resources.kitaparama48px;
            this.btnarama.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnarama.Location = new System.Drawing.Point(782, 31);
            this.btnarama.Name = "btnarama";
            this.btnarama.Size = new System.Drawing.Size(126, 55);
            this.btnarama.TabIndex = 2;
            this.btnarama.Text = "Ara";
            this.btnarama.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnarama.UseVisualStyleBackColor = false;
            this.btnarama.Click += new System.EventHandler(this.btnarama_Click);
            // 
            // kitapadinagörearama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KutuphaneOtamasyonuu.UI.WinnForm.Properties.Resources.kitaplisteme3;
            this.ClientSize = new System.Drawing.Size(1061, 447);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtkitapadi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnarama);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "kitapadinagörearama";
            this.Text = "Kitap adina göre arama";
            this.Load += new System.EventHandler(this.kitapadinagörearama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtkitapadi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnarama;
        private System.Windows.Forms.Button button1;
    }
}