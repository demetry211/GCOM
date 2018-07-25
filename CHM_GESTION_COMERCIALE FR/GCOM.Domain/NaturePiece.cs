using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCOM.Domain
{
    public enum NatureMvt { }

    public enum SensMvt { Entrée, Sortie, Mixte};



    public class ParamPiece
    {
        public int ParamPieceId { get; set; }
        [Display (Name ="Code")]
        public string PP_Code { get; set; }
        [Display (Name ="Libellé")]
        public string PP_Libelle { get; set; }
        [Display (Name = "Sens Mouvement")]
        public SensMvt PP_SensMvt { get; set; }

        public int PP_PieceSuivanteId { get; set; }
        [ForeignKey ("PP_PieceSuivanteId")]
        public ParamPiece PP_PieceSuivante { get; set; }

        public bool PP_RegroupArt { get; set; }

        public bool PP_InsertLigne { get; set; }

        public bool PP_SaisiePrix { get; set; }

        public bool PP_PrixNull { get; set; }

        public int PP_NbrExemplaire { get; set; }

        public ICollection<Compteur> Compteurs { get; set; }

        public TypeTiers TypeTiers { get; set; }


        public ICollection<Piece> Pieces { get; set; }

    }

    
}
