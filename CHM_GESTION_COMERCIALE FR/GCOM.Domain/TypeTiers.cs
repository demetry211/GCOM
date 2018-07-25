using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GCOM.Domain
{
    public class TypeTiers
    {
        [Key]
        public int TT_Id { get; set; }

        public string TT_Libelle { get; set; }

        public ICollection<Tiers> Tiers { get; set; }

    }
}