using System.Drawing;
using System.Windows.Forms;
using HayvanTakip.Classes;
using HayvanTakip.Forms;

namespace HayvanTakip
{
    public partial class Form1 : Form
    {
        islemler islem = new islemler();
        public Form1()
        {
            InitializeComponent();

            gelirgiderIslem("Gelir");
            label3.ForeColor = System.Drawing.Color.Blue;
            
            label1.ForeColor = System.Drawing.Color.Blue;
            contextMenuStrip1.Items.Add("Kayıt Ekle").Name = "Ekle";
            contextMenuStrip1.Items.Add("Kaydı Sil").Name="Sil";
            contextMenuStrip1.Items.Add("Kaydı Güncelle").Name="Guncelle";
            contextMenuStrip1.Items.Add("Ekranı Yenile").Name = "Refresh";
        }

        private void gelirButton_Click(object sender, System.EventArgs e)
        {
            gelirgiderIslem("Gelir");
            label3.ForeColor = System.Drawing.Color.Blue;
        }
        private void giderButton_Click(object sender, System.EventArgs e)
        {
            gelirgiderIslem("Gider");
            label3.ForeColor = System.Drawing.Color.Red;

        }
        private void karZararButton_Click(object sender, System.EventArgs e)
        {
            gelirgiderIslem("");
            decimal netDurum = 0;
            netDurum = decimal.Parse(islem.ExecuteScalar("").ToString());
            if (netDurum >= 0)
            {
                //Kardaysak net durum mavi 
                label3.ForeColor = System.Drawing.Color.Blue;
            }
            else
            {
                //Zarardaysak net durum kırmızı ve eksi değerde
                label3.ForeColor = System.Drawing.Color.Red;
            }
        }
        public void gelirgiderIslem(string yapilacakis)
        {
            // Sol paneldeki buttonlar tıklandığında yapılacak genel işlemleri karşılayan metod
            dataGridView1.DataSource = null;

            label1.Visible = true;
            if(yapilacakis=="") label1.Text = "Gelir/Gider Tablosu";
            else label1.Text = yapilacakis + " Tablosu";
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.Aqua;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.DataSource = islem.GetRecordTable(yapilacakis);
            dataGridView1.Refresh();
            dataGridView1.Columns["Tutar"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            label3.Text = islem.ExecuteScalar(yapilacakis).ToString();
            label3.Visible = true;       
        }
        private void add_Click(object sender, System.EventArgs e)
        {
            IslemEkrani islemEkrani = new IslemEkrani();
            islemEkrani.Visible = true;
        }       
        private void aramaButton_Click(object sender, System.EventArgs e)
        {
            AramaEkrani aramaEkrani = new AramaEkrani();
            aramaEkrani.Visible = true;
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            //Seçilen satırda sağ tıklandığında contextmenü açılır.
            if (e.Button== MouseButtons.Right && label1.Text.ToString()!="Gelir/Gider Tablosu") {             
                contextMenuStrip1.Show(dataGridView1, new System.Drawing.Point(e.X, e.Y));
            }           
        }
        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //Menü açılınca seçili olan kaydın id değeri tutulur. Bu id üzerinden işlem yapılır.
            islem.islemId = int.Parse(dataGridView1.SelectedCells[0].Value.ToString());
            string[] tabloAdi = label1.Text.Split(null);

            if (e.ClickedItem.Name.ToString() == "Sil")
            {
                contextMenuStrip1.Close();
                DialogResult dialogResult = MessageBox.Show("İşlem Numarası "+islem.islemId+" Olan Kayıt Siliniyor.\nİşlemi Onaylıyor musunuz?", "Kayıt Sil", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                
                if (dialogResult == DialogResult.Yes)
                {
                    islem.deleteSelectedRecord(tabloAdi[0],islem.islemId);
                    
                    // Listeyi sildikten sonra yenileme işlemi 
                    dataGridView1.DataSource = null;
                    gelirgiderIslem(tabloAdi[0]);
                    dataGridView1.Refresh();
                }
            }
            else if(e.ClickedItem.Name.ToString() == "Guncelle")
            {
                //Güncelleme yapılacak.                
                IslemEkrani islemEkrani = new IslemEkrani();
                islemEkrani.onayButton.Text = "Güncelle";
                islemEkrani.mSecilenId = islem.islemId;
                islemEkrani.TextDoldur(islem.SearchRecordDT(tabloAdi[0], islem.islemId),tabloAdi[0]);
                
                //Açılacak ekranın tıklanılan yerde açılması sağlar
                islemEkrani.Location = new Point(Cursor.Position.X, Cursor.Position.Y);
                islemEkrani.StartPosition = FormStartPosition.Manual;
                islemEkrani.Show();
            }
            else if(e.ClickedItem.Name.ToString() == "Refresh")
            {
                dataGridView1.DataSource = null;
                gelirgiderIslem(tabloAdi[0]);
                dataGridView1.Refresh();
            }
            else if (e.ClickedItem.Name.ToString() == "Ekle")
            {
                IslemEkrani islemEkrani = new IslemEkrani();
                islemEkrani.Visible = true;
            }
        }

    }
}
