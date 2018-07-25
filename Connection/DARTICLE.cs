using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Connection
{
    [Serializable]
    public class DARTICLE
    {
        protected decimal _CODE_ARTICLE;
        protected string _REF_ARTICLE;
        protected string _DESIGNATION_ARTICLE;
        protected decimal _CODE_MARQUE;
        protected string _MARQUE_ARTICLE;
        protected string _DESCRIPTION_ARTICLE;
        protected string _CODE_BARRE_ARTICLE;
        protected decimal _QTE_ARTICLE;
        protected decimal _CODE_UNITE;
        protected string _UNITE_QTE_ARTICLE;
        protected decimal _QTE_MIN_ARTICLE;
        protected byte[] _PHOTO_ARTICLE;
        protected decimal _PRIX_HT_A_ARTICLE;
        protected decimal _TAUX_MAJORATION;
        protected decimal _PRIX_HT_V_ARTICLE;
        protected decimal _CODE_TVA;
        protected decimal _TVA_ARTICLE;
        protected int _ETAT_ARTICLE;
        protected decimal _CODE_FAMILLE;
        protected decimal _CODE_CATEG;
        protected decimal _CODE_MAG;
        protected decimal _CODE_FOURNISSEUR;
        protected string _LIB_CATEG;
        protected string _NOM_MAG;
        protected string _RS_FOURNISSEUR;
        protected decimal _MAX_REMISE;
        protected decimal _PRIX_SOLDE;
        protected string _CODE_BARRE_ARTICLE_SOLDE;
        protected string _REF_FOURNISSEUR;
        protected int _STOCKABLE;



        public virtual decimal CODE_ARTICLE
        {
            get
            {
                return _CODE_ARTICLE;
            }
            set
            {
                _CODE_ARTICLE = value;
            }
        }


        public virtual string REF_ARTICLE
        {
            get
            {
                return _REF_ARTICLE;
            }
            set
            {
                _REF_ARTICLE = value;
            }
        }


        public virtual string DESIGNATION_ARTICLE
        {
            get
            {
                return _DESIGNATION_ARTICLE;
            }
            set
            {
                _DESIGNATION_ARTICLE = value;
            }
        }


        public virtual decimal CODE_MARQUE
        {
            get
            {
                return _CODE_MARQUE;
            }
            set
            {
                _CODE_MARQUE = value;
            }
        }


        public virtual string MARQUE_ARTICLE
        {
            get
            {
                return _MARQUE_ARTICLE;
            }
            set
            {
                _MARQUE_ARTICLE = value;
            }
        }


        public virtual string DESCRIPTION_ARTICLE
        {
            get
            {
                return _DESCRIPTION_ARTICLE;
            }
            set
            {
                _DESCRIPTION_ARTICLE = value;
            }
        }


        public virtual string CODE_BARRE_ARTICLE
        {
            get
            {
                return _CODE_BARRE_ARTICLE;
            }
            set
            {
                _CODE_BARRE_ARTICLE = value;
            }
        }


        public virtual decimal QTE_ARTICLE
        {
            get
            {
                return _QTE_ARTICLE;
            }
            set
            {
                _QTE_ARTICLE = value;
            }
        }


        public virtual decimal CODE_UNITE
        {
            get
            {
                return _CODE_UNITE;
            }
            set
            {
                _CODE_UNITE = value;
            }
        }


        public virtual string UNITE_QTE_ARTICLE
        {
            get
            {
                return _UNITE_QTE_ARTICLE;
            }
            set
            {
                _UNITE_QTE_ARTICLE = value;
            }
        }


        public virtual decimal QTE_MIN_ARTICLE
        {
            get
            {
                return _QTE_MIN_ARTICLE;
            }
            set
            {
                _QTE_MIN_ARTICLE = value;
            }
        }


        public virtual byte[] PHOTO_ARTICLE
        {
            get
            {
                return _PHOTO_ARTICLE;
            }
            set
            {
                _PHOTO_ARTICLE = value;
            }
        }


        public virtual decimal PRIX_HT_A_ARTICLE
        {
            get
            {
                return _PRIX_HT_A_ARTICLE;
            }
            set
            {
                _PRIX_HT_A_ARTICLE = value;
            }
        }


        public virtual decimal TAUX_MAJORATION
        {
            get
            {
                return _TAUX_MAJORATION;
            }
            set
            {
                _TAUX_MAJORATION = value;
            }
        }


        public virtual decimal PRIX_HT_V_ARTICLE
        {
            get
            {
                return _PRIX_HT_V_ARTICLE;
            }
            set
            {
                _PRIX_HT_V_ARTICLE = value;
            }
        }


        public virtual decimal CODE_TVA
        {
            get
            {
                return _CODE_TVA;
            }
            set
            {
                _CODE_TVA = value;
            }
        }


        public virtual decimal TVA_ARTICLE
        {
            get
            {
                return _TVA_ARTICLE;
            }
            set
            {
                _TVA_ARTICLE = value;
            }
        }


        public virtual int ETAT_ARTICLE
        {
            get
            {
                return _ETAT_ARTICLE;
            }
            set
            {
                _ETAT_ARTICLE = value;
            }
        }


        public virtual decimal CODE_FAMILLE
        {
            get
            {
                return _CODE_FAMILLE;
            }
            set
            {
                _CODE_FAMILLE = value;
            }
        }


        public virtual decimal CODE_CATEG
        {
            get
            {
                return _CODE_CATEG;
            }
            set
            {
                _CODE_CATEG = value;
            }
        }


        public virtual decimal CODE_MAG
        {
            get
            {
                return _CODE_MAG;
            }
            set
            {
                _CODE_MAG = value;
            }
        }


        public virtual decimal CODE_FOURNISSEUR
        {
            get
            {
                return _CODE_FOURNISSEUR;
            }
            set
            {
                _CODE_FOURNISSEUR = value;
            }
        }


        public virtual string LIB_CATEG
        {
            get
            {
                return _LIB_CATEG;
            }
            set
            {
                _LIB_CATEG = value;
            }
        }


        public virtual string NOM_MAG
        {
            get
            {
                return _NOM_MAG;
            }
            set
            {
                _NOM_MAG = value;
            }
        }


        public virtual string RS_FOURNISSEUR
        {
            get
            {
                return _RS_FOURNISSEUR;
            }
            set
            {
                _RS_FOURNISSEUR = value;
            }
        }


        public virtual decimal MAX_REMISE
        {
            get
            {
                return _MAX_REMISE;
            }
            set
            {
                _MAX_REMISE = value;
            }
        }


        public virtual decimal PRIX_SOLDE
        {
            get
            {
                return _PRIX_SOLDE;
            }
            set
            {
                _PRIX_SOLDE = value;
            }
        }


        public virtual string CODE_BARRE_ARTICLE_SOLDE
        {
            get
            {
                return _CODE_BARRE_ARTICLE_SOLDE;
            }
            set
            {
                _CODE_BARRE_ARTICLE_SOLDE = value;
            }
        }


        public virtual string REF_FOURNISSEUR
        {
            get
            {
                return _REF_FOURNISSEUR;
            }
            set
            {
                _REF_FOURNISSEUR = value;
            }
        }


        public virtual int STOCKABLE
        {
            get
            {
                return _STOCKABLE;
            }
            set
            {
                _STOCKABLE = value;
            }
        }
    }
}
