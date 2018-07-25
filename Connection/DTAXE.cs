using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Connection
{
    [Serializable]
    public class DTAXE
    {
        public decimal TAX_ID { get; set; }

        public decimal CODE_TVA { get; set; }

        public string TAX_LIBELLE { get; set; }

        public decimal? TAX_TAUX { get; set; }

        public DateTime? TAX_DEB_APPLIC { get; set; }

        public DateTime? TAX_DATE_CREATION { get; set; }

        public decimal? TAX_CREATEUR { get; set; }

        public DateTime? TAX_DATE_MODIF { get; set; }

        public decimal? TAX_MODIFICATEUR { get; set; }

    }
}