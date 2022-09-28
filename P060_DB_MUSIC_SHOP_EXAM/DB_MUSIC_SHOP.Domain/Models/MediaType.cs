using System;
using System.Collections.Generic;

namespace P060_DB_MUSIC_SHOP_EXAM
{
    public partial class MediaType
    {
        public MediaType()
        {
            Tracks = new HashSet<Track>();
        }

        public long MediaTypeId { get; set; }
        public string? Name { get; set; }

        public virtual ICollection<Track> Tracks { get; set; }
    }
}
