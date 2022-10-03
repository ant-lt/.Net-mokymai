using System;
using System.Collections.Generic;

namespace P060_DB_MUSIC_SHOP_EXAM
{
    public partial class InvoiceItem
    {
        public long InvoiceLineId { get; set; }
        public long InvoiceId { get; set; }
        public long TrackId { get; set; }
        public decimal UnitPrice { get; set; } 
        public long Quantity { get; set; }

        public virtual Invoice Invoice { get; set; } = null!;
        public virtual Track Track { get; set; } = null!;
    }
}
