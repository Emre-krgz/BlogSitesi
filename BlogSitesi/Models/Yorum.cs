using System;
using System.Collections.Generic;

namespace BlogSitesi.Models
{
    public partial class Yorum
    {
        public int YorumId { get; set; }
        public string Yorum1 { get; set; }
        public int MakaleId { get; set; }
        public System.DateTime EklenmeTarihi { get; set; }
        public string AdSoyad { get; set; }
        public int Begeni { get; set; }
        public virtual Makale Makale { get; set; }
    }
}
