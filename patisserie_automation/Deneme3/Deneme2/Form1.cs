using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Deneme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Data Source=DESKTOP-10UJKPB\SQLEXPRESS;Initial Catalog=Malıyet;Integrated Security=True

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-10UJKPB\SQLEXPRESS;Initial Catalog=Malıyet;Integrated Security=True");

        void MalzemeListe()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select* from TBLMALZEMELER", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void UrunListesi()
        {
            SqlDataAdapter da2 = new SqlDataAdapter("Select* From TBLURUNLER", baglanti);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dataGridView1.DataSource = dt2;
        }
        void Kasa()
        {
            SqlDataAdapter da3 = new SqlDataAdapter("Select * From TBLKASA", baglanti);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            dataGridView1.DataSource = dt3;
        }
        void Urunler()
        {
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select* from TBLURUNLER", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CmbUrun.ValueMember = "URUNID";
            CmbUrun.DisplayMember = "AD";
            CmbUrun.DataSource = dt;
            baglanti.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            MalzemeListe();

            Urunler();

            Malzemeler();
        }

        void Malzemeler()
        {
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select* from TBLMALZEMELER", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CmbMalzeme.ValueMember = "MALZEMEID";
            CmbMalzeme.DisplayMember = "AD";
            CmbMalzeme.DataSource = dt;
            baglanti.Close();

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void BtnUrunListesi_Click(object sender, EventArgs e)
        {
            UrunListesi();
        }

        private void BtnMalzemeListesi_Click(object sender, EventArgs e)
        {
            MalzemeListe();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Kasa();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnMalzemeEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLMALZEMELER(AD,STOK,FIYAT,NOTLAR) values(@p1,@p2,@p3,@p4)", baglanti);
            komut.Parameters.AddWithValue("@p1", TxtMalzemeAd.Text);
            komut.Parameters.AddWithValue("@p2", decimal.Parse(TxtMalzemeStok.Text));
            komut.Parameters.AddWithValue("@p3", decimal.Parse(TxtMalzemeFıyat.Text));
            komut.Parameters.AddWithValue("@p4", TxtMalzemeNotlar.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Malzeme Sistem Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MalzemeListe();


        }

        private void BtnUrunEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLURUNLER (ad) values (@p1)", baglanti);
            komut.Parameters.AddWithValue("@P1", TxtUrunAd.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürün sisteme eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            UrunListesi();

        }

        private void CmbUrun_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnUrunOlustur_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLFIRIN(urunıd,malzemeıd,mıktar,malıyet) values(@p1,@p2,@p3,@p4)", baglanti);
            komut.Parameters.AddWithValue("@p1", CmbUrun.SelectedValue);
            komut.Parameters.AddWithValue("@p2", CmbMalzeme.SelectedValue);
            komut.Parameters.AddWithValue("@p3", decimal.Parse(TxtMiktar.Text));
            komut.Parameters.AddWithValue("@p4", decimal.Parse(TxtMaliyet.Text));
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Malzemeniz Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            listBox1.Items.Add(CmbMalzeme.Text + "-" + TxtMaliyet.Text);
        }

        private void TxtMiktar_TextChanged(object sender, EventArgs e)
        {
            double maliyet;
            if (TxtMiktar.Text == "  ")
            {
                TxtMiktar.Text = "0";
            }
            baglanti.Open();
            SqlCommand komut = new SqlCommand(" Select * From TBLMALZEMELER where MalzemeId=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", CmbMalzeme.SelectedValue);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                TxtMaliyet.Text = dr[3].ToString();
        }
            baglanti.Close();
            maliyet = Convert.ToDouble(TxtMaliyet.Text) / 1000 * Convert.ToDouble(TxtMiktar.Text);

            TxtMaliyet.Text = maliyet.ToString();
        }

        private void CmbMalzeme_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            TxtUrunID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtUrunAd.Text=  dataGridView1.Rows[secilen].Cells[1].Value.ToString();

            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select sum(Malıyet) from TBLFIRIN where urunıd=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", TxtUrunID.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                TxtUrunMFıyat.Text = dr[0].ToString();
            }
            baglanti.Close();
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

