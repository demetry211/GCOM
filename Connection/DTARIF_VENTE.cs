using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Connection
{
    public class DTARIF_VENTE
    {
        public decimal TRV_ID { get; set; }

        public string TRV_LIBELLE { get; set; }

        public decimal? TRV_CODE_ARTICLE { get; set; }

        public decimal? TRV_CODE_CLIENT { get; set; }

        public decimal TRV_CODE_UNITE { get; set; }

        public decimal TRV_PRIX_HT { get; set; }

        public decimal TRV_TX_REMISE { get; set; }

        public DateTime TRV_DEBUT_VALID { get; set; }

        public DateTime TRV_FIN_VALID { get; set; }

        public DateTime? TRV_DATE_CREATION { get; set; }

        public decimal? TRV_CREATEUR { get; set; }

        public DateTime? TRV_DATE_MODIF { get; set; }

        public decimal? TRV_MODIFICATEUR { get; set; }
    }
}
