using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HayvanTakip.Classes;

namespace HayvanTakip.Forms
{
    public partial class IslemEkrani : Form
    {
        islemler islem = new islemler();
        string islemTuru = null;
        public int mSecilenId { get; set; }
        public IslemEkrani()
        {
            InitializeComponent();

            islemSecimPaneli.Visible = true;
            islemPaneli.Visible = false;
        }

        private void giderButton_Click(object sender, EventArgs e)
        {
            //Seçime göre ekran düzenlenir.Combobox seçime göre veritabanındaki tablodan seçilerek doldurulur.
            islemTuru = "Gider";
            islemPaneli.Visible = true;
            islemSecimPaneli.Visible = false;
            comboBox1.DisplayMember = "giderKaynagi";
            comboBox1.ValueMember = "giderId";
            comboBox1.DataSource = islem.GetRecordTable("giderKaynaklari");

        }
        private void gelirbutton_Click(object sender, EventArgs e)
        {
            //Seçime göre ekran düzenlenir.Combobox seçime göre veritabanındaki tablodan seçilerek doldurulur.
            islemTuru = "Gelir";
            islemPaneli.Visible = true;
            islemSecimPaneli.Visible = false;
            comboBox1.DisplayMember = "gelirKaynagi";
            comboBox1.ValueMember = "gelirId";
            comboBox1.DataSource = islem.GetRecordTable("gelirKaynaklari");
        }
        private void onayButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(aciklamaBox.Text))
            {
                errorProvider1.SetError(aciklamaBox, "Lütfen açıklama girin");
                return;
            }
            else if (string.IsNullOrWhiteSpace(maskedTextBox1.Text))
            {
                errorProvider1.SetError(maskedTextBox1, "Lütfen açıklama girin");
                return;
            }
            else
            {                
                islem.tarih = dateTimePicker1.Value.ToShortDateString();
                islem.tutar = decimal.Parse(maskedTextBox1.Text.ToString());
                islem.aciklama = aciklamaBox.Text.ToString();
                if (islemTuru == "Gelir")
                {
                    islem.gelirId = Int32.Parse(comboBox1.SelectedValue.ToString());
                    islem.addRecord(islemTuru);
                }
                else if (islemTuru == "Gider")
                {
                    islem.giderId = Int32.Parse(comboBox1.SelectedValue.ToString());
                    islem.addRecord(islemTuru);
                }
                else if (islemTuru == null)
                {
                    int sayi = Int32.Parse(comboBox1.SelectedValue.ToString());
                    if (sayi > 10 && sayi < 15)
                    {
                        //Gelir güncelleme işlemini yapar. Biraz karışık oldu burası :)
                        islem.gelirId = Int32.Parse(comboBox1.SelectedValue.ToString());
                        islem.updateRecord("Gelir",mSecilenId);
                    }
                    else if (sayi > 20 && sayi < 25)
                    {
                        //Gider güncelleme işlemini yapar.
                        islem.giderId = Int32.Parse(comboBox1.SelectedValue.ToString());
                        islem.updateRecord("Gider",mSecilenId);
                    }
                }
            }                       
            this.Visible = false;
           
        }
        private void iptalButton_Click(object sender, EventArgs e) => this.Visible = false;

        public void TextDoldur(DataTable dataTable,string tablo)
        {
            islemSecimPaneli.Visible = false;
            islemPaneli.Visible = true;
            dateTimePicker1.Value = DateTime.Parse(dataTable.Rows[0]["Tarih"].ToString());
          
            aciklamaBox.Text = dataTable.Rows[0]["Aciklama"].ToString();
            maskedTextBox1.Text = dataTable.Rows[0]["Tutar"].ToString();

            if (tablo == "Gelir")
            {
                comboBox1.DisplayMember = "gelirKaynagi";
                comboBox1.ValueMember = "gelirId";
                comboBox1.DataSource = islem.GetRecordTable("gelirKaynaklari");
                comboBox1.SelectedValue = int.Parse(dataTable.Rows[0]["GelirTuru"].ToString());
            }
            else if (tablo == "Gider")
            {
                comboBox1.DisplayMember = "giderKaynagi";
                comboBox1.ValueMember = "giderId";
                comboBox1.DataSource = islem.GetRecordTable("giderKaynaklari");
                comboBox1.SelectedValue = int.Parse(dataTable.Rows[0]["GiderTuru"].ToString());
            }
    
        }
    }
}