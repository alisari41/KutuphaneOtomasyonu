namespace KutuphaneOtamasyonuu.UI.WinnForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ögrenciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ekleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.güncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ekleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.düzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.araToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barkoNumarasınaGöreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapAdınaGöreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitabıKmAldıKimTeslimEttiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapAlımİadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapVerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapİadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrencininAlmışOlduğuKitaplarListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grafiklerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ögrenciToolStripMenuItem,
            this.kitapToolStripMenuItem,
            this.kitapAlımİadeToolStripMenuItem,
            this.öğrencininAlmışOlduğuKitaplarListesiToolStripMenuItem,
            this.grafiklerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1183, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ögrenciToolStripMenuItem
            // 
            this.ögrenciToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ögrenciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ekleToolStripMenuItem,
            this.silToolStripMenuItem,
            this.güncelleToolStripMenuItem,
            this.listeleToolStripMenuItem});
            this.ögrenciToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.ögrenciToolStripMenuItem.Name = "ögrenciToolStripMenuItem";
            this.ögrenciToolStripMenuItem.Size = new System.Drawing.Size(96, 29);
            this.ögrenciToolStripMenuItem.Text = "Ögrenci";
            this.ögrenciToolStripMenuItem.Click += new System.EventHandler(this.ögrenciToolStripMenuItem_Click);
            // 
            // ekleToolStripMenuItem
            // 
            this.ekleToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.ekleToolStripMenuItem.Name = "ekleToolStripMenuItem";
            this.ekleToolStripMenuItem.Size = new System.Drawing.Size(175, 30);
            this.ekleToolStripMenuItem.Text = "Ekle";
            this.ekleToolStripMenuItem.Click += new System.EventHandler(this.ekleToolStripMenuItem_Click);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(175, 30);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // güncelleToolStripMenuItem
            // 
            this.güncelleToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.güncelleToolStripMenuItem.Name = "güncelleToolStripMenuItem";
            this.güncelleToolStripMenuItem.Size = new System.Drawing.Size(175, 30);
            this.güncelleToolStripMenuItem.Text = "Güncelle";
            this.güncelleToolStripMenuItem.Click += new System.EventHandler(this.güncelleToolStripMenuItem_Click);
            // 
            // listeleToolStripMenuItem
            // 
            this.listeleToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.listeleToolStripMenuItem.Name = "listeleToolStripMenuItem";
            this.listeleToolStripMenuItem.Size = new System.Drawing.Size(175, 30);
            this.listeleToolStripMenuItem.Text = "Listele";
            this.listeleToolStripMenuItem.Click += new System.EventHandler(this.listeleToolStripMenuItem_Click);
            // 
            // kitapToolStripMenuItem
            // 
            this.kitapToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ekleToolStripMenuItem1,
            this.silToolStripMenuItem1,
            this.düzenleToolStripMenuItem,
            this.listeleToolStripMenuItem1,
            this.araToolStripMenuItem,
            this.kitabıKmAldıKimTeslimEttiToolStripMenuItem});
            this.kitapToolStripMenuItem.Name = "kitapToolStripMenuItem";
            this.kitapToolStripMenuItem.Size = new System.Drawing.Size(72, 29);
            this.kitapToolStripMenuItem.Text = "Kitap";
            // 
            // ekleToolStripMenuItem1
            // 
            this.ekleToolStripMenuItem1.Name = "ekleToolStripMenuItem1";
            this.ekleToolStripMenuItem1.Size = new System.Drawing.Size(354, 30);
            this.ekleToolStripMenuItem1.Text = "Ekle";
            this.ekleToolStripMenuItem1.Click += new System.EventHandler(this.ekleToolStripMenuItem1_Click);
            // 
            // silToolStripMenuItem1
            // 
            this.silToolStripMenuItem1.Name = "silToolStripMenuItem1";
            this.silToolStripMenuItem1.Size = new System.Drawing.Size(354, 30);
            this.silToolStripMenuItem1.Text = "Sil";
            this.silToolStripMenuItem1.Click += new System.EventHandler(this.silToolStripMenuItem1_Click);
            // 
            // düzenleToolStripMenuItem
            // 
            this.düzenleToolStripMenuItem.Name = "düzenleToolStripMenuItem";
            this.düzenleToolStripMenuItem.Size = new System.Drawing.Size(354, 30);
            this.düzenleToolStripMenuItem.Text = "Düzenle";
            this.düzenleToolStripMenuItem.Click += new System.EventHandler(this.düzenleToolStripMenuItem_Click);
            // 
            // listeleToolStripMenuItem1
            // 
            this.listeleToolStripMenuItem1.Name = "listeleToolStripMenuItem1";
            this.listeleToolStripMenuItem1.Size = new System.Drawing.Size(354, 30);
            this.listeleToolStripMenuItem1.Text = "Listele";
            this.listeleToolStripMenuItem1.Click += new System.EventHandler(this.listeleToolStripMenuItem1_Click);
            // 
            // araToolStripMenuItem
            // 
            this.araToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.barkoNumarasınaGöreToolStripMenuItem,
            this.kitapAdınaGöreToolStripMenuItem});
            this.araToolStripMenuItem.Name = "araToolStripMenuItem";
            this.araToolStripMenuItem.Size = new System.Drawing.Size(354, 30);
            this.araToolStripMenuItem.Text = "Ara";
            this.araToolStripMenuItem.Click += new System.EventHandler(this.araToolStripMenuItem_Click);
            // 
            // barkoNumarasınaGöreToolStripMenuItem
            // 
            this.barkoNumarasınaGöreToolStripMenuItem.Name = "barkoNumarasınaGöreToolStripMenuItem";
            this.barkoNumarasınaGöreToolStripMenuItem.Size = new System.Drawing.Size(322, 30);
            this.barkoNumarasınaGöreToolStripMenuItem.Text = "Barkod Numarasına göre";
            this.barkoNumarasınaGöreToolStripMenuItem.Click += new System.EventHandler(this.barkoNumarasınaGöreToolStripMenuItem_Click);
            // 
            // kitapAdınaGöreToolStripMenuItem
            // 
            this.kitapAdınaGöreToolStripMenuItem.Name = "kitapAdınaGöreToolStripMenuItem";
            this.kitapAdınaGöreToolStripMenuItem.Size = new System.Drawing.Size(322, 30);
            this.kitapAdınaGöreToolStripMenuItem.Text = "Kitap adına göre";
            this.kitapAdınaGöreToolStripMenuItem.Click += new System.EventHandler(this.kitapAdınaGöreToolStripMenuItem_Click);
            // 
            // kitabıKmAldıKimTeslimEttiToolStripMenuItem
            // 
            this.kitabıKmAldıKimTeslimEttiToolStripMenuItem.Name = "kitabıKmAldıKimTeslimEttiToolStripMenuItem";
            this.kitabıKmAldıKimTeslimEttiToolStripMenuItem.Size = new System.Drawing.Size(354, 30);
            this.kitabıKmAldıKimTeslimEttiToolStripMenuItem.Text = "Kitabı Kim aldı kim teslim etti";
            this.kitabıKmAldıKimTeslimEttiToolStripMenuItem.Click += new System.EventHandler(this.kitabıKmAldıKimTeslimEttiToolStripMenuItem_Click);
            // 
            // kitapAlımİadeToolStripMenuItem
            // 
            this.kitapAlımİadeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kitapVerToolStripMenuItem,
            this.kitapİadeToolStripMenuItem});
            this.kitapAlımİadeToolStripMenuItem.Name = "kitapAlımİadeToolStripMenuItem";
            this.kitapAlımİadeToolStripMenuItem.Size = new System.Drawing.Size(163, 29);
            this.kitapAlımİadeToolStripMenuItem.Text = "Kitap Alım-İade";
            // 
            // kitapVerToolStripMenuItem
            // 
            this.kitapVerToolStripMenuItem.Name = "kitapVerToolStripMenuItem";
            this.kitapVerToolStripMenuItem.Size = new System.Drawing.Size(187, 30);
            this.kitapVerToolStripMenuItem.Text = "Kitap Ver";
            this.kitapVerToolStripMenuItem.Click += new System.EventHandler(this.kitapVerToolStripMenuItem_Click);
            // 
            // kitapİadeToolStripMenuItem
            // 
            this.kitapİadeToolStripMenuItem.Name = "kitapİadeToolStripMenuItem";
            this.kitapİadeToolStripMenuItem.Size = new System.Drawing.Size(187, 30);
            this.kitapİadeToolStripMenuItem.Text = "Kitap İade";
            this.kitapİadeToolStripMenuItem.Click += new System.EventHandler(this.kitapİadeToolStripMenuItem_Click);
            // 
            // öğrencininAlmışOlduğuKitaplarListesiToolStripMenuItem
            // 
            this.öğrencininAlmışOlduğuKitaplarListesiToolStripMenuItem.Name = "öğrencininAlmışOlduğuKitaplarListesiToolStripMenuItem";
            this.öğrencininAlmışOlduğuKitaplarListesiToolStripMenuItem.Size = new System.Drawing.Size(371, 29);
            this.öğrencininAlmışOlduğuKitaplarListesiToolStripMenuItem.Text = "Öğrencinin almış olduğu kitaplar listesi";
            this.öğrencininAlmışOlduğuKitaplarListesiToolStripMenuItem.Click += new System.EventHandler(this.öğrencininAlmışOlduğuKitaplarListesiToolStripMenuItem_Click);
            // 
            // grafiklerToolStripMenuItem
            // 
            this.grafiklerToolStripMenuItem.Name = "grafiklerToolStripMenuItem";
            this.grafiklerToolStripMenuItem.Size = new System.Drawing.Size(104, 29);
            this.grafiklerToolStripMenuItem.Text = "Grafikler";
            this.grafiklerToolStripMenuItem.Click += new System.EventHandler(this.grafiklerToolStripMenuItem_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::KutuphaneOtamasyonuu.UI.WinnForm.Properties.Resources.ogrenciekleme22;
            this.ClientSize = new System.Drawing.Size(1183, 326);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ögrenciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ekleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem güncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ekleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem düzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem araToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitapAlımİadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitapVerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitapİadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrencininAlmışOlduğuKitaplarListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem barkoNumarasınaGöreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitapAdınaGöreToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripMenuItem grafiklerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitabıKmAldıKimTeslimEttiToolStripMenuItem;
    }
}

