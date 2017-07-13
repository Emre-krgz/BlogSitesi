using System;
using System.Collections.Generic;

namespace BlogSitesi.Models
{
    public partial class Resim
    {
        public Resim()
        {
            this.Makales = new List<Makale>();
        }

        public int ResimId { get; set; }
        public string KucukBoyut { get; set; }
        public string OrtaBoyut { get; set; }
        public string BuyukByout { get; set; }
        public string Video { get; set; }
        public Nullable<int> MakaleId { get; set; }
        public virtual ICollection<Makale> Makales { get; set; }
        public virtual Makale Makale { get; set; }
    }
}
