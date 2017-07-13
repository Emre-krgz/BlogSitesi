using System;
using System.Collections.Generic;

namespace BlogSitesi.Models
{
    public partial class MakaleEtiket
    {
        public int MakaleId { get; set; }
        public int EtiketId { get; set; }
        public virtual Etiket Etiket { get; set; }
        public virtual Etiket Etiket1 { get; set; }
        public virtual Makale Makale { get; set; }
    }
}
