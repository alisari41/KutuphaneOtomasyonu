namespace KutuphaneOtamasyonuu.UI.WinnForm
{
    partial class KitapAdetleriGrafikGosterimi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KitapAdetleriGrafikGosterimi));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtxeksenibaslik = new System.Windows.Forms.TextBox();
            this.txtyeksenibaslik = new System.Windows.Forms.TextBox();
            this.txtbaslik = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtxeksenibaslik2 = new System.Windows.Forms.TextBox();
            this.txtyeksenibaslik2 = new System.Windows.Forms.TextBox();
            this.txtbaslik2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.zedGraphControl2 = new ZedGraph.ZedGraphControl();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1730, 855);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.zedGraphControl1);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1722, 826);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Barkod Numarasına göre Kitapların Toplam Adetleri";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Image = global::KutuphaneOtamasyonuu.UI.WinnForm.Properties.Resources.about2;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(757, 669);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(649, 54);
            this.label7.TabIndex = 2;
            this.label7.Text = resources.GetString("label7.Text");
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtxeksenibaslik);
            this.groupBox1.Controls.Add(this.txtyeksenibaslik);
            this.groupBox1.Controls.Add(this.txtbaslik);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(17, 648);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(692, 152);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Eğer Başlıkları Değiştirmek istiyorsanız Textboxlara başlık girebilirsiniz";
            // 
            // button2
            // 
            this.button2.Image = global::KutuphaneOtamasyonuu.UI.WinnForm.Properties.Resources.temizleme30px7;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(482, 83);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(195, 56);
            this.button2.TabIndex = 7;
            this.button2.Text = "İlk Başlıkları getir";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Image = global::KutuphaneOtamasyonuu.UI.WinnForm.Properties.Resources.update_Button21;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(482, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 56);
            this.button1.TabIndex = 6;
            this.button1.Text = "Başlıkları Değiştir";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtxeksenibaslik
            // 
            this.txtxeksenibaslik.Location = new System.Drawing.Point(185, 103);
            this.txtxeksenibaslik.Name = "txtxeksenibaslik";
            this.txtxeksenibaslik.Size = new System.Drawing.Size(170, 22);
            this.txtxeksenibaslik.TabIndex = 5;
            // 
            // txtyeksenibaslik
            // 
            this.txtyeksenibaslik.Location = new System.Drawing.Point(185, 68);
            this.txtyeksenibaslik.Name = "txtyeksenibaslik";
            this.txtyeksenibaslik.Size = new System.Drawing.Size(170, 22);
            this.txtyeksenibaslik.TabIndex = 4;
            // 
            // txtbaslik
            // 
            this.txtbaslik.Location = new System.Drawing.Point(185, 34);
            this.txtbaslik.Name = "txtbaslik";
            this.txtbaslik.Size = new System.Drawing.Size(170, 22);
            this.txtbaslik.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "X Ekseni Başlık";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Y Ekseni Başlık";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Başlık";
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.IsAutoScrollRange = true;
            this.zedGraphControl1.IsScrollY2 = true;
            this.zedGraphControl1.IsShowHScrollBar = true;
            this.zedGraphControl1.IsShowPointValues = true;
            this.zedGraphControl1.IsShowVScrollBar = true;
            this.zedGraphControl1.Location = new System.Drawing.Point(4, 7);
            this.zedGraphControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(1490, 634);
            this.zedGraphControl1.TabIndex = 0;
            this.zedGraphControl1.PointValueEvent += new ZedGraph.ZedGraphControl.PointValueHandler(this.zedGraphControl1_PointValueEvent);
            this.zedGraphControl1.Load += new System.EventHandler(this.zedGraphControl1_Load);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.zedGraphControl2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1722, 826);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Kitap Adına göre Kitapların Toplam Adetleri";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Image = global::KutuphaneOtamasyonuu.UI.WinnForm.Properties.Resources.about2;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Location = new System.Drawing.Point(754, 671);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(649, 54);
            this.label8.TabIndex = 3;
            this.label8.Text = resources.GetString("label8.Text");
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.txtxeksenibaslik2);
            this.groupBox2.Controls.Add(this.txtyeksenibaslik2);
            this.groupBox2.Controls.Add(this.txtbaslik2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(17, 648);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(692, 152);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Eğer Başlıkları Değiştirmek istiyorsanız Textboxlara başlık girebilirsiniz";
            // 
            // button3
            // 
            this.button3.Image = global::KutuphaneOtamasyonuu.UI.WinnForm.Properties.Resources.temizleme30px7;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(481, 86);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(195, 56);
            this.button3.TabIndex = 7;
            this.button3.Text = "İlk Başlıkları getir";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Image = global::KutuphaneOtamasyonuu.UI.WinnForm.Properties.Resources.update_Button21;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(481, 21);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(195, 56);
            this.button4.TabIndex = 6;
            this.button4.Text = "Başlıkları Değiştir";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtxeksenibaslik2
            // 
            this.txtxeksenibaslik2.Location = new System.Drawing.Point(185, 103);
            this.txtxeksenibaslik2.Name = "txtxeksenibaslik2";
            this.txtxeksenibaslik2.Size = new System.Drawing.Size(170, 22);
            this.txtxeksenibaslik2.TabIndex = 5;
            // 
            // txtyeksenibaslik2
            // 
            this.txtyeksenibaslik2.Location = new System.Drawing.Point(185, 68);
            this.txtyeksenibaslik2.Name = "txtyeksenibaslik2";
            this.txtyeksenibaslik2.Size = new System.Drawing.Size(170, 22);
            this.txtyeksenibaslik2.TabIndex = 4;
            // 
            // txtbaslik2
            // 
            this.txtbaslik2.Location = new System.Drawing.Point(185, 34);
            this.txtbaslik2.Name = "txtbaslik2";
            this.txtbaslik2.Size = new System.Drawing.Size(170, 22);
            this.txtbaslik2.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "X Ekseni Başlık";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Y Ekseni Başlık";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Başlık";
            // 
            // zedGraphControl2
            // 
            this.zedGraphControl2.IsAutoScrollRange = true;
            this.zedGraphControl2.IsShowHScrollBar = true;
            this.zedGraphControl2.IsShowPointValues = true;
            this.zedGraphControl2.IsShowVScrollBar = true;
            this.zedGraphControl2.Location = new System.Drawing.Point(4, 7);
            this.zedGraphControl2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.zedGraphControl2.Name = "zedGraphControl2";
            this.zedGraphControl2.ScrollGrace = 0D;
            this.zedGraphControl2.ScrollMaxX = 0D;
            this.zedGraphControl2.ScrollMaxY = 0D;
            this.zedGraphControl2.ScrollMaxY2 = 0D;
            this.zedGraphControl2.ScrollMinX = 0D;
            this.zedGraphControl2.ScrollMinY = 0D;
            this.zedGraphControl2.ScrollMinY2 = 0D;
            this.zedGraphControl2.Size = new System.Drawing.Size(1490, 634);
            this.zedGraphControl2.TabIndex = 0;
            // 
            // KitapAdetleriGrafikGosterimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1617, 869);
            this.Controls.Add(this.tabControl1);
            this.Name = "KitapAdetleriGrafikGosterimi";
            this.Text = "Kitap Adetleri Grafik Gösterimi";
            this.Load += new System.EventHandler(this.KitapAdetleriGrafikGosterimi_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        public ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private ZedGraph.ZedGraphControl zedGraphControl2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtxeksenibaslik;
        private System.Windows.Forms.TextBox txtyeksenibaslik;
        private System.Windows.Forms.TextBox txtbaslik;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtxeksenibaslik2;
        private System.Windows.Forms.TextBox txtyeksenibaslik2;
        private System.Windows.Forms.TextBox txtbaslik2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}