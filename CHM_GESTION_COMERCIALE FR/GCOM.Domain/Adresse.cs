using System.ComponentModel.DataAnnotations.Schema;

namespace GCOM.Domain
{
    [ComplexType]
    public class Adresse
    {
        public string Rue { get; set; }

        public string CodePostal { get; set; }

        public string Ville { get; set; }

        public string Pays { get; set; }
    }
}