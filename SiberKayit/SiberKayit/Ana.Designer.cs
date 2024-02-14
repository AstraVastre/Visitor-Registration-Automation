
namespace SiberKayit
{
    partial class Ana
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ana));
            this.txt_tc = new System.Windows.Forms.TextBox();
            this.lbl_tc = new System.Windows.Forms.Label();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.txt_soyadi = new System.Windows.Forms.TextBox();
            this.txt_adi = new System.Windows.Forms.TextBox();
            this.lbl_adi = new System.Windows.Forms.Label();
            this.lbl_soyadi = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_arama = new System.Windows.Forms.TextBox();
            this.lbl_kayitara = new System.Windows.Forms.Label();
            this.lbl_tarih = new System.Windows.Forms.Label();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_hepsinikaydet = new System.Windows.Forms.Button();
            this.btn_hepsinisil = new System.Windows.Forms.Button();
            this.lbl_saat = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_tc
            // 
            this.txt_tc.Location = new System.Drawing.Point(138, 222);
            this.txt_tc.MaxLength = 11;
            this.txt_tc.Name = "txt_tc";
            this.txt_tc.Size = new System.Drawing.Size(164, 22);
            this.txt_tc.TabIndex = 0;
            this.txt_tc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_tc_KeyPress);
            // 
            // lbl_tc
            // 
            this.lbl_tc.AutoSize = true;
            this.lbl_tc.Location = new System.Drawing.Point(53, 226);
            this.lbl_tc.Name = "lbl_tc";
            this.lbl_tc.Size = new System.Drawing.Size(47, 16);
            this.lbl_tc.TabIndex = 2;
            this.lbl_tc.Text = "Tc No:";
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(34, 422);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(75, 23);
            this.btn_ekle.TabIndex = 4;
            this.btn_ekle.Text = "Kaydet";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_soyadi
            // 
            this.txt_soyadi.Location = new System.Drawing.Point(138, 325);
            this.txt_soyadi.Name = "txt_soyadi";
            this.txt_soyadi.Size = new System.Drawing.Size(164, 22);
            this.txt_soyadi.TabIndex = 5;
            // 
            // txt_adi
            // 
            this.txt_adi.Location = new System.Drawing.Point(138, 279);
            this.txt_adi.Name = "txt_adi";
            this.txt_adi.Size = new System.Drawing.Size(164, 22);
            this.txt_adi.TabIndex = 6;
            // 
            // lbl_adi
            // 
            this.lbl_adi.AutoSize = true;
            this.lbl_adi.Location = new System.Drawing.Point(53, 284);
            this.lbl_adi.Name = "lbl_adi";
            this.lbl_adi.Size = new System.Drawing.Size(24, 16);
            this.lbl_adi.TabIndex = 7;
            this.lbl_adi.Text = "Ad";
            // 
            // lbl_soyadi
            // 
            this.lbl_soyadi.AutoSize = true;
            this.lbl_soyadi.Location = new System.Drawing.Point(53, 328);
            this.lbl_soyadi.Name = "lbl_soyadi";
            this.lbl_soyadi.Size = new System.Drawing.Size(50, 16);
            this.lbl_soyadi.TabIndex = 8;
            this.lbl_soyadi.Text = "Soyad:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(138, 422);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Sil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(366, 328);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(986, 323);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick_1);
            // 
            // txt_arama
            // 
            this.txt_arama.Location = new System.Drawing.Point(798, 121);
            this.txt_arama.MaxLength = 11;
            this.txt_arama.Name = "txt_arama";
            this.txt_arama.Size = new System.Drawing.Size(479, 22);
            this.txt_arama.TabIndex = 12;
            this.txt_arama.TextChanged += new System.EventHandler(this.txt_arama_TextChanged);
            // 
            // lbl_kayitara
            // 
            this.lbl_kayitara.AutoSize = true;
            this.lbl_kayitara.Location = new System.Drawing.Point(710, 124);
            this.lbl_kayitara.Name = "lbl_kayitara";
            this.lbl_kayitara.Size = new System.Drawing.Size(63, 16);
            this.lbl_kayitara.TabIndex = 13;
            this.lbl_kayitara.Text = "Kayıt Ara:";
            // 
            // lbl_tarih
            // 
            this.lbl_tarih.AutoSize = true;
            this.lbl_tarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_tarih.Location = new System.Drawing.Point(29, 41);
            this.lbl_tarih.Name = "lbl_tarih";
            this.lbl_tarih.Size = new System.Drawing.Size(64, 25);
            this.lbl_tarih.TabIndex = 15;
            this.lbl_tarih.Text = "label6";
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Location = new System.Drawing.Point(257, 422);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(85, 23);
            this.btn_guncelle.TabIndex = 16;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_hepsinikaydet
            // 
            this.btn_hepsinikaydet.Location = new System.Drawing.Point(34, 516);
            this.btn_hepsinikaydet.Name = "btn_hepsinikaydet";
            this.btn_hepsinikaydet.Size = new System.Drawing.Size(155, 23);
            this.btn_hepsinikaydet.TabIndex = 17;
            this.btn_hepsinikaydet.Text = "Seçilenleri Kaydet";
            this.btn_hepsinikaydet.UseVisualStyleBackColor = true;
            this.btn_hepsinikaydet.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_hepsinisil
            // 
            this.btn_hepsinisil.Location = new System.Drawing.Point(205, 516);
            this.btn_hepsinisil.Name = "btn_hepsinisil";
            this.btn_hepsinisil.Size = new System.Drawing.Size(155, 23);
            this.btn_hepsinisil.TabIndex = 18;
            this.btn_hepsinisil.Text = "Seçilenleri Sil";
            this.btn_hepsinisil.UseVisualStyleBackColor = true;
            this.btn_hepsinisil.Click += new System.EventHandler(this.button3_Click);
            // 
            // lbl_saat
            // 
            this.lbl_saat.AutoSize = true;
            this.lbl_saat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_saat.Location = new System.Drawing.Point(29, 9);
            this.lbl_saat.Name = "lbl_saat";
            this.lbl_saat.Size = new System.Drawing.Size(64, 25);
            this.lbl_saat.TabIndex = 19;
            this.lbl_saat.Text = "label6";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(601, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Isparta Gençlik Merkezi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(916, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 21;
            // 
            // Ana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1429, 838);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_saat);
            this.Controls.Add(this.btn_hepsinisil);
            this.Controls.Add(this.btn_hepsinikaydet);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.lbl_tarih);
            this.Controls.Add(this.lbl_kayitara);
            this.Controls.Add(this.txt_arama);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lbl_soyadi);
            this.Controls.Add(this.lbl_adi);
            this.Controls.Add(this.txt_adi);
            this.Controls.Add(this.txt_soyadi);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.lbl_tc);
            this.Controls.Add(this.txt_tc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ana";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Ana_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Ana_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_tc;
        private System.Windows.Forms.Label lbl_tc;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.TextBox txt_soyadi;
        private System.Windows.Forms.TextBox txt_adi;
        private System.Windows.Forms.Label lbl_adi;
        private System.Windows.Forms.Label lbl_soyadi;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_arama;
        private System.Windows.Forms.Label lbl_kayitara;
        private System.Windows.Forms.Label lbl_tarih;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_hepsinikaydet;
        private System.Windows.Forms.Button btn_hepsinisil;
        private System.Windows.Forms.Label lbl_saat;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

