
namespace Deneme
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.BtnMalzemeEkle = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtMalzemeNotlar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtMalzemeStok = new System.Windows.Forms.TextBox();
            this.TxtMalzemeFıyat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtMalzemeAd = new System.Windows.Forms.TextBox();
            this.TxtMalzemeid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnUrunGuncelle = new System.Windows.Forms.Button();
            this.BtnUrunEkle = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtUrunSFıyat = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtUrunStok = new System.Windows.Forms.TextBox();
            this.TxtUrunMFıyat = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtUrunAd = new System.Windows.Forms.TextBox();
            this.TxtUrunID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.CmbMalzeme = new System.Windows.Forms.ComboBox();
            this.CmbUrun = new System.Windows.Forms.ComboBox();
            this.BtnUrunOlustur = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtMiktar = new System.Windows.Forms.TextBox();
            this.TxtMaliyet = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.BtnCikis = new System.Windows.Forms.Button();
            this.BtnKasa = new System.Windows.Forms.Button();
            this.BtnMalzemeListesi = new System.Windows.Forms.Button();
            this.BtnUrunListesi = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.BtnMalzemeEkle);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TxtMalzemeNotlar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtMalzemeStok);
            this.groupBox1.Controls.Add(this.TxtMalzemeFıyat);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtMalzemeAd);
            this.groupBox1.Controls.Add(this.TxtMalzemeid);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(69)))), ((int)(((byte)(100)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 493);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Malzeme Girisi";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(69)))), ((int)(((byte)(100)))));
            this.button2.Location = new System.Drawing.Point(115, 398);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 28);
            this.button2.TabIndex = 11;
            this.button2.Text = "Getir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnMalzemeEkle
            // 
            this.BtnMalzemeEkle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(69)))), ((int)(((byte)(100)))));
            this.BtnMalzemeEkle.Location = new System.Drawing.Point(115, 330);
            this.BtnMalzemeEkle.Name = "BtnMalzemeEkle";
            this.BtnMalzemeEkle.Size = new System.Drawing.Size(164, 34);
            this.BtnMalzemeEkle.TabIndex = 1;
            this.BtnMalzemeEkle.Text = "Malzeme Ekle";
            this.BtnMalzemeEkle.UseVisualStyleBackColor = true;
            this.BtnMalzemeEkle.Click += new System.EventHandler(this.BtnMalzemeEkle_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(69)))), ((int)(((byte)(100)))));
            this.label5.Location = new System.Drawing.Point(6, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "NOTLAR:";
            // 
            // TxtMalzemeNotlar
            // 
            this.TxtMalzemeNotlar.Location = new System.Drawing.Point(115, 272);
            this.TxtMalzemeNotlar.Name = "TxtMalzemeNotlar";
            this.TxtMalzemeNotlar.Size = new System.Drawing.Size(164, 30);
            this.TxtMalzemeNotlar.TabIndex = 9;
            this.TxtMalzemeNotlar.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(69)))), ((int)(((byte)(100)))));
            this.label4.Location = new System.Drawing.Point(25, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "FIYAT:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(69)))), ((int)(((byte)(100)))));
            this.label3.Location = new System.Drawing.Point(39, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "STOK:";
            // 
            // TxtMalzemeStok
            // 
            this.TxtMalzemeStok.Location = new System.Drawing.Point(115, 170);
            this.TxtMalzemeStok.Name = "TxtMalzemeStok";
            this.TxtMalzemeStok.Size = new System.Drawing.Size(164, 30);
            this.TxtMalzemeStok.TabIndex = 6;
            // 
            // TxtMalzemeFıyat
            // 
            this.TxtMalzemeFıyat.Location = new System.Drawing.Point(115, 223);
            this.TxtMalzemeFıyat.Name = "TxtMalzemeFıyat";
            this.TxtMalzemeFıyat.Size = new System.Drawing.Size(164, 30);
            this.TxtMalzemeFıyat.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(69)))), ((int)(((byte)(100)))));
            this.label2.Location = new System.Drawing.Point(66, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "AD:";
            // 
            // TxtMalzemeAd
            // 
            this.TxtMalzemeAd.Location = new System.Drawing.Point(115, 115);
            this.TxtMalzemeAd.Name = "TxtMalzemeAd";
            this.TxtMalzemeAd.Size = new System.Drawing.Size(164, 30);
            this.TxtMalzemeAd.TabIndex = 3;
            // 
            // TxtMalzemeid
            // 
            this.TxtMalzemeid.Location = new System.Drawing.Point(115, 66);
            this.TxtMalzemeid.Name = "TxtMalzemeid";
            this.TxtMalzemeid.Size = new System.Drawing.Size(164, 30);
            this.TxtMalzemeid.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(69)))), ((int)(((byte)(100)))));
            this.label1.Location = new System.Drawing.Point(70, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(12, 508);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1022, 256);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Malzemeler";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1016, 225);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.groupBox3.Controls.Add(this.BtnUrunGuncelle);
            this.groupBox3.Controls.Add(this.BtnUrunEkle);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.TxtUrunSFıyat);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.TxtUrunStok);
            this.groupBox3.Controls.Add(this.TxtUrunMFıyat);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.TxtUrunAd);
            this.groupBox3.Controls.Add(this.TxtUrunID);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(69)))), ((int)(((byte)(100)))));
            this.groupBox3.Location = new System.Drawing.Point(323, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(395, 493);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ürün Girisi";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // BtnUrunGuncelle
            // 
            this.BtnUrunGuncelle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(69)))), ((int)(((byte)(100)))));
            this.BtnUrunGuncelle.Location = new System.Drawing.Point(136, 395);
            this.BtnUrunGuncelle.Name = "BtnUrunGuncelle";
            this.BtnUrunGuncelle.Size = new System.Drawing.Size(164, 28);
            this.BtnUrunGuncelle.TabIndex = 11;
            this.BtnUrunGuncelle.Text = "Güncelle";
            this.BtnUrunGuncelle.UseVisualStyleBackColor = true;
            // 
            // BtnUrunEkle
            // 
            this.BtnUrunEkle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(69)))), ((int)(((byte)(100)))));
            this.BtnUrunEkle.Location = new System.Drawing.Point(136, 327);
            this.BtnUrunEkle.Name = "BtnUrunEkle";
            this.BtnUrunEkle.Size = new System.Drawing.Size(164, 34);
            this.BtnUrunEkle.TabIndex = 1;
            this.BtnUrunEkle.Text = "Ürün Ekle";
            this.BtnUrunEkle.UseVisualStyleBackColor = true;
            this.BtnUrunEkle.Click += new System.EventHandler(this.BtnUrunEkle_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(69)))), ((int)(((byte)(100)))));
            this.label6.Location = new System.Drawing.Point(81, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 46);
            this.label6.TabIndex = 10;
            this.label6.Text = "SATIS \r\nFIYAT";
            // 
            // TxtUrunSFıyat
            // 
            this.TxtUrunSFıyat.Location = new System.Drawing.Point(185, 272);
            this.TxtUrunSFıyat.Name = "TxtUrunSFıyat";
            this.TxtUrunSFıyat.Size = new System.Drawing.Size(164, 30);
            this.TxtUrunSFıyat.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(69)))), ((int)(((byte)(100)))));
            this.label7.Location = new System.Drawing.Point(69, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 46);
            this.label7.TabIndex = 8;
            this.label7.Text = "MALIYET\r\n   FIYAT";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(69)))), ((int)(((byte)(100)))));
            this.label8.Location = new System.Drawing.Point(81, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 23);
            this.label8.TabIndex = 7;
            this.label8.Text = "STOK:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // TxtUrunStok
            // 
            this.TxtUrunStok.Location = new System.Drawing.Point(185, 163);
            this.TxtUrunStok.Name = "TxtUrunStok";
            this.TxtUrunStok.Size = new System.Drawing.Size(164, 30);
            this.TxtUrunStok.TabIndex = 6;
            // 
            // TxtUrunMFıyat
            // 
            this.TxtUrunMFıyat.Location = new System.Drawing.Point(185, 216);
            this.TxtUrunMFıyat.Name = "TxtUrunMFıyat";
            this.TxtUrunMFıyat.Size = new System.Drawing.Size(164, 30);
            this.TxtUrunMFıyat.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(69)))), ((int)(((byte)(100)))));
            this.label9.Location = new System.Drawing.Point(95, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 23);
            this.label9.TabIndex = 4;
            this.label9.Text = "AD:";
            // 
            // TxtUrunAd
            // 
            this.TxtUrunAd.Location = new System.Drawing.Point(185, 112);
            this.TxtUrunAd.Name = "TxtUrunAd";
            this.TxtUrunAd.Size = new System.Drawing.Size(164, 30);
            this.TxtUrunAd.TabIndex = 3;
            // 
            // TxtUrunID
            // 
            this.TxtUrunID.Location = new System.Drawing.Point(185, 56);
            this.TxtUrunID.Name = "TxtUrunID";
            this.TxtUrunID.Size = new System.Drawing.Size(164, 30);
            this.TxtUrunID.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(69)))), ((int)(((byte)(100)))));
            this.label10.Location = new System.Drawing.Point(97, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 23);
            this.label10.TabIndex = 1;
            this.label10.Text = "ID: ";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.groupBox4.Controls.Add(this.CmbMalzeme);
            this.groupBox4.Controls.Add(this.CmbUrun);
            this.groupBox4.Controls.Add(this.BtnUrunOlustur);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.TxtMiktar);
            this.groupBox4.Controls.Add(this.TxtMaliyet);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(69)))), ((int)(((byte)(100)))));
            this.groupBox4.Location = new System.Drawing.Point(724, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(328, 493);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ürün Olustur";
            // 
            // CmbMalzeme
            // 
            this.CmbMalzeme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbMalzeme.FormattingEnabled = true;
            this.CmbMalzeme.Location = new System.Drawing.Point(145, 107);
            this.CmbMalzeme.Name = "CmbMalzeme";
            this.CmbMalzeme.Size = new System.Drawing.Size(162, 31);
            this.CmbMalzeme.TabIndex = 10;
            this.CmbMalzeme.SelectedIndexChanged += new System.EventHandler(this.CmbMalzeme_SelectedIndexChanged);
            // 
            // CmbUrun
            // 
            this.CmbUrun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbUrun.FormattingEnabled = true;
            this.CmbUrun.Location = new System.Drawing.Point(145, 58);
            this.CmbUrun.Name = "CmbUrun";
            this.CmbUrun.Size = new System.Drawing.Size(162, 31);
            this.CmbUrun.TabIndex = 9;
            this.CmbUrun.SelectedIndexChanged += new System.EventHandler(this.CmbUrun_SelectedIndexChanged);
            // 
            // BtnUrunOlustur
            // 
            this.BtnUrunOlustur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(69)))), ((int)(((byte)(100)))));
            this.BtnUrunOlustur.Location = new System.Drawing.Point(146, 284);
            this.BtnUrunOlustur.Name = "BtnUrunOlustur";
            this.BtnUrunOlustur.Size = new System.Drawing.Size(164, 34);
            this.BtnUrunOlustur.TabIndex = 1;
            this.BtnUrunOlustur.Text = "Ekle";
            this.BtnUrunOlustur.UseVisualStyleBackColor = true;
            this.BtnUrunOlustur.Click += new System.EventHandler(this.BtnUrunOlustur_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(69)))), ((int)(((byte)(100)))));
            this.label12.Location = new System.Drawing.Point(10, 223);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(121, 23);
            this.label12.TabIndex = 8;
            this.label12.Text = "MALIYET :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(69)))), ((int)(((byte)(100)))));
            this.label13.Location = new System.Drawing.Point(25, 177);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 23);
            this.label13.TabIndex = 7;
            this.label13.Text = "MIKTAR:";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // TxtMiktar
            // 
            this.TxtMiktar.Location = new System.Drawing.Point(145, 170);
            this.TxtMiktar.Name = "TxtMiktar";
            this.TxtMiktar.Size = new System.Drawing.Size(164, 30);
            this.TxtMiktar.TabIndex = 6;
            this.TxtMiktar.TextChanged += new System.EventHandler(this.TxtMiktar_TextChanged);
            // 
            // TxtMaliyet
            // 
            this.TxtMaliyet.Location = new System.Drawing.Point(145, 220);
            this.TxtMaliyet.Name = "TxtMaliyet";
            this.TxtMaliyet.Size = new System.Drawing.Size(164, 30);
            this.TxtMaliyet.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(69)))), ((int)(((byte)(100)))));
            this.label14.Location = new System.Drawing.Point(58, 63);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 23);
            this.label14.TabIndex = 4;
            this.label14.Text = "ÜRÜN:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(69)))), ((int)(((byte)(100)))));
            this.label15.Location = new System.Drawing.Point(10, 119);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(129, 23);
            this.label15.TabIndex = 1;
            this.label15.Text = "MALZEME: ";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.groupBox5.Controls.Add(this.BtnCikis);
            this.groupBox5.Controls.Add(this.BtnKasa);
            this.groupBox5.Controls.Add(this.BtnMalzemeListesi);
            this.groupBox5.Controls.Add(this.BtnUrunListesi);
            this.groupBox5.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.groupBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(69)))), ((int)(((byte)(100)))));
            this.groupBox5.Location = new System.Drawing.Point(1048, 508);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(434, 253);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Islemler";
            // 
            // BtnCikis
            // 
            this.BtnCikis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(69)))), ((int)(((byte)(100)))));
            this.BtnCikis.Location = new System.Drawing.Point(23, 196);
            this.BtnCikis.Name = "BtnCikis";
            this.BtnCikis.Size = new System.Drawing.Size(394, 34);
            this.BtnCikis.TabIndex = 4;
            this.BtnCikis.Text = "ÇIKIS";
            this.BtnCikis.UseVisualStyleBackColor = true;
            this.BtnCikis.Click += new System.EventHandler(this.BtnCikis_Click);
            // 
            // BtnKasa
            // 
            this.BtnKasa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(69)))), ((int)(((byte)(100)))));
            this.BtnKasa.Location = new System.Drawing.Point(23, 140);
            this.BtnKasa.Name = "BtnKasa";
            this.BtnKasa.Size = new System.Drawing.Size(394, 34);
            this.BtnKasa.TabIndex = 3;
            this.BtnKasa.Text = "KASA";
            this.BtnKasa.UseVisualStyleBackColor = true;
            this.BtnKasa.Click += new System.EventHandler(this.button8_Click);
            // 
            // BtnMalzemeListesi
            // 
            this.BtnMalzemeListesi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(69)))), ((int)(((byte)(100)))));
            this.BtnMalzemeListesi.Location = new System.Drawing.Point(23, 83);
            this.BtnMalzemeListesi.Name = "BtnMalzemeListesi";
            this.BtnMalzemeListesi.Size = new System.Drawing.Size(394, 34);
            this.BtnMalzemeListesi.TabIndex = 2;
            this.BtnMalzemeListesi.Text = "Malzeme Listesi";
            this.BtnMalzemeListesi.UseVisualStyleBackColor = true;
            this.BtnMalzemeListesi.Click += new System.EventHandler(this.BtnMalzemeListesi_Click);
            // 
            // BtnUrunListesi
            // 
            this.BtnUrunListesi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(69)))), ((int)(((byte)(100)))));
            this.BtnUrunListesi.Location = new System.Drawing.Point(23, 29);
            this.BtnUrunListesi.Name = "BtnUrunListesi";
            this.BtnUrunListesi.Size = new System.Drawing.Size(394, 34);
            this.BtnUrunListesi.TabIndex = 1;
            this.BtnUrunListesi.Text = "Ürün Listesi";
            this.BtnUrunListesi.UseVisualStyleBackColor = true;
            this.BtnUrunListesi.Click += new System.EventHandler(this.BtnUrunListesi_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.groupBox6.Controls.Add(this.listBox1);
            this.groupBox6.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.groupBox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(69)))), ((int)(((byte)(100)))));
            this.groupBox6.Location = new System.Drawing.Point(1058, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(427, 493);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Ürün Olustur";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(78)))), ((int)(((byte)(110)))));
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 23;
            this.listBox1.Location = new System.Drawing.Point(3, 26);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(421, 464);
            this.listBox1.TabIndex = 6;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(187)))), ((int)(((byte)(160)))));
            this.ClientSize = new System.Drawing.Size(1501, 786);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtMalzemeAd;
        private System.Windows.Forms.TextBox TxtMalzemeid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtMalzemeNotlar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtMalzemeStok;
        private System.Windows.Forms.TextBox TxtMalzemeFıyat;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtnMalzemeEkle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BtnUrunGuncelle;
        private System.Windows.Forms.Button BtnUrunEkle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtUrunSFıyat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtUrunStok;
        private System.Windows.Forms.TextBox TxtUrunMFıyat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtUrunAd;
        private System.Windows.Forms.TextBox TxtUrunID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button BtnUrunOlustur;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TxtMiktar;
        private System.Windows.Forms.TextBox TxtMaliyet;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button BtnCikis;
        private System.Windows.Forms.Button BtnKasa;
        private System.Windows.Forms.Button BtnMalzemeListesi;
        private System.Windows.Forms.Button BtnUrunListesi;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox CmbMalzeme;
        private System.Windows.Forms.ComboBox CmbUrun;
    }
}

