using System;
using System.Collections.Generic;

namespace BlogSitesi.Models
{
    public partial class Makale
    {
        public Makale()
        {
            this.MakaleEtikets = new List<MakaleEtiket>();
            this.Resims = new List<Resim>();
            this.Yorums = new List<Yorum>();
        }

        public int MakaleId { get; set; }
        public string Baslik { get; set; }
        public string Icerik { get; set; }
        public System.DateTime EklenmeTarihi { get; set; }
        public int KategoriId { get; set; }
        public int GoruntulenmeSayisi { get; set; }
        public int BegeniSayisi { get; set; }
        public int YazarId { get; set; }
        public Nullable<int> ResimId { get; set; }
        public virtual Kategori Kategori { get; set; }
        public virtual Resim Resim { get; set; }
        public virtual Yazar Yazar { get; set; }
        public virtual ICollection<MakaleEtiket> MakaleEtikets { get; set; }
        public virtual ICollection<Resim> Resims { get; set; }
        public virtual ICollection<Yorum> Yorums { get; set; }
    }
}
