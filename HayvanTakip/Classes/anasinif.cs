using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanTakip.Classes
{
    public abstract class anasinif
    {
        public int islemId { get; set; }
        public string tarih { get; set; }
        public int gelirId { get; set; }
        public int giderId { get; set; }
        public string aciklama { get; set; }
        public decimal tutar { get; set; }
    }
}
