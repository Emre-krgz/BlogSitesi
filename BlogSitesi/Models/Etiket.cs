using System;
using System.Collections.Generic;

namespace BlogSitesi.Models
{
    public partial class Etiket
    {
        public Etiket()
        {
            this.MakaleEtikets = new List<MakaleEtiket>();
            this.MakaleEtikets1 = new List<MakaleEtiket>();
        }

        public int EtiketId { get; set; }
        public string Adi { get; set; }
        public virtual ICollection<MakaleEtiket> MakaleEtikets { get; set; }
        public virtual ICollection<MakaleEtiket> MakaleEtikets1 { get; set; }
    }
}
