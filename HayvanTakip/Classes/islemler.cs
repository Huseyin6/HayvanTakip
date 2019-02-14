using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanTakip.Classes
{
    public class islemler:anasinif
    {
        private string sqlQuery = null;
        public DataTable GetRecordTable(string tablo)
        {           
            if (tablo == "Gelir") { 
                sqlQuery = "SELECT id [İşlem No], Tarih, case "+tablo+"Turu " +
                " when 11 then 'Süt Satışı'" +
                " when 12 then 'Et Satışı' " +
                "when 13 then 'Teşvik'  " +
                "when 14 then 'Diğer' " +
                "end ["+tablo+"], " +
                "Aciklama [Açıklama] , format (Tutar, '#,###') [Tutar] FROM " + tablo;
            }
            else if(tablo=="Gider")
            {
                sqlQuery = "SELECT id [İşlem No], Tarih, case " + tablo + "Turu " +
                " when 21 then 'Yem'" +
                " when 22 then 'İlaç' " +
                "when 23 then 'Veteriner'  " +
                "when 24 then 'Diğer' " +
                "end [" + tablo + "], " +
                "Aciklama [Açıklama] ,format (Tutar, '#,###') [Tutar] FROM " + tablo;
            }
            else if(tablo=="")
            {
                sqlQuery = "select  Tarih,case GelirTuru " +
                        "when 11 then 'Süt Satışı' " +
                        "when 12 then 'Et Satışı' " +
                        "when 13 then 'Teşvik'  " +
                        "when 14 then 'Diğer' " +
                        "end [Gelir/Gider], Aciklama [Açıklama], format (Tutar, '#,###') [Tutar] from Gelir " +
                        "union all " +
                        "select Tarih,case GiderTuru " +
                        "when 21 then 'Yem' " +
                        "when 22 then 'İlaç' " +
                        "when 23 then 'Veteriner'  " +
                        "when 24 then 'Diğer' " +
                        "end [Gelir/Gider], Aciklama[Açıklama],format (Tutar, '#,###') [Tutar] from Gider " +
                        "order by Tarih";
            }        
            else if (tablo == "giderKaynaklari" || tablo=="gelirKaynaklari")
            {
                sqlQuery = "SELECT * FROM " + tablo;
            }
            return sqlslemler.GetDatatable(sqlQuery);
        }
        public object ExecuteScalar(string tablo)
        {
            if(tablo!="")
                sqlQuery = "SELECT format(sum(Tutar),'#,##') [Tutar] from "+ tablo;
            else
                sqlQuery = "EXECUTE spKarZarar";
            return sqlslemler.ExecuteScalar(sqlQuery);
        }
        public void addRecord(string tablo)
        {
            string[] tokens = tarih.Split(' ');
            if (tablo == "Gelir")
            {
                sqlQuery = "INSERT INTO " + tablo + " VALUES(" +
                                "'"+tokens[0]+"' ,"+
                                gelirId+" ,"+
                                "'"+aciklama+"' ,"+
                                tutar+
                                ")";
            }
            else if (tablo == "Gider")
            {
                sqlQuery = "INSERT INTO " + tablo + " VALUES(" +
                               "'" + tokens[0] + "' ," +
                               giderId + " ," +
                               "'" + aciklama + "' ," +
                               tutar +
                               ")";
            }          
            sqlslemler.ExecuteNonQuery(sqlQuery);
        }
        public void updateRecord(string tablo,int argSecilenId)
        {
            string[] tokens = tarih.Split(' ');
            if (tablo == "Gelir")
            {
                sqlQuery = "UPDATE " + tablo + " SET Tarih='" + tokens[0] + "', " + tablo + "Turu=" + gelirId + ", Aciklama='" + aciklama + "', Tutar=" +
                                        tutar + " WHERE id=" + argSecilenId ;
            }
            else
            {
                sqlQuery = "UPDATE " + tablo + " SET Tarih='" + tokens[0] + "', " + tablo + "Turu=" + giderId + ", Aciklama='" + aciklama + "', Tutar=" +
                                        tutar + " WHERE id=" + argSecilenId;
            }
            
            sqlslemler.ExecuteNonQuery(sqlQuery);
        }
        public DataTable SearchRecordDT(string tablo,int argSecilenKayitId)
        {
            sqlQuery = "SELECT * FROM "+tablo+" WHERE id="+argSecilenKayitId;
            return sqlslemler.GetDatatable(sqlQuery);
        }
        
        public void deleteSelectedRecord(string tablo,int argSecilenId)
        {
            sqlQuery = "DELETE FROM " + tablo + " WHERE id=" + argSecilenId;
            sqlslemler.ExecuteNonQuery(sqlQuery);
        }     
    }
}
