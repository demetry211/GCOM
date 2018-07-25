using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GCOM.Domain
{
    public class Tiers
    {
        [Key]
        public int T_Id { get; set; }

        public int T_TypeTiersId { get; set; }

        [ForeignKey ("T_TypeTiersId")]
        public TypeTiers T_TypeTiers { get; set; }

        public string T_RaisonSociale { get; set; }

        public string T_Auxiliaire { get; set; }

        public string T_General { get; set; }

        public Adresse T_Adresse { get; set; }

        public string T_MatriculeFiscal { get; set; }

        public string T_Tel { get; set; }

        [DataType(DataType.EmailAddress)]
        public string T_Mail { get; set; }

        public string T_Responsable { get; set; }

        public string T_TelResponsable { get; set; }

        public string T_MailResponsable { get; set; }

        

    }
}