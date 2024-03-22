using System;
using System.Collections.Generic;

namespace Firma.Data.Models
{
    public partial class Status
    {
        public Status()
        {
            Reklamacje = new HashSet<Reklamacje>();
        }

        public int IdStatusu { get; set; }
        public string? NazwaStatusu { get; set; }
        public bool? CzyAktywny { get; set; }

        public virtual ICollection<Reklamacje> Reklamacje { get; set; }
    }
}