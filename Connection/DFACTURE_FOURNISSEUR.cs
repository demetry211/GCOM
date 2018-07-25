using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Connection
{
    [Serializable]
    public class DFACTURE_FOURNISSEUR
    {
        protected string _CODE_FACTURE_FOURNISSEUR;
        protected string _NUM_FACT_FR;
        protected DateTime _DATE_FACTURE_FOURNISSEUR;
        protected decimal _CODE_FOURNISSEUR;
        protected decimal _USER_CREATION;
        protected DateTime _DATE_CREATION;
        protected decimal _USER_MODIFICATION;
        protected DateTime _DATE_MODIFICATION;
        protected int _ANNULEE;
        protected decimal _USER_ANNULATION;
        protected DateTime _DATE_ANNULATION;



        public virtual string CODE_FACTURE_FOURNISSEUR
        {
            get
            {
                return _CODE_FACTURE_FOURNISSEUR;
            }
            set
            {
                _CODE_FACTURE_FOURNISSEUR = value;
            }
        }


        public virtual string NUM_FACT_FR
        {
            get
            {
                return _NUM_FACT_FR;
            }
            set
            {
                _NUM_FACT_FR = value;
            }
        }


        public virtual DateTime DATE_FACTURE_FOURNISSEUR
        {
            get
            {
                return _DATE_FACTURE_FOURNISSEUR;
            }
            set
            {
                _DATE_FACTURE_FOURNISSEUR = value;
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


        public virtual decimal USER_CREATION
        {
            get
            {
                return _USER_CREATION;
            }
            set
            {
                _USER_CREATION = value;
            }
        }


        public virtual DateTime DATE_CREATION
        {
            get
            {
                return _DATE_CREATION;
            }
            set
            {
                _DATE_CREATION = value;
            }
        }


        public virtual decimal USER_MODIFICATION
        {
            get
            {
                return _USER_MODIFICATION;
            }
            set
            {
                _USER_MODIFICATION = value;
            }
        }


        public virtual DateTime DATE_MODIFICATION
        {
            get
            {
                return _DATE_MODIFICATION;
            }
            set
            {
                _DATE_MODIFICATION = value;
            }
        }


        public virtual int ANNULEE
        {
            get
            {
                return _ANNULEE;
            }
            set
            {
                _ANNULEE = value;
            }
        }


        public virtual decimal USER_ANNULATION
        {
            get
            {
                return _USER_ANNULATION;
            }
            set
            {
                _USER_ANNULATION = value;
            }
        }


        public virtual DateTime DATE_ANNULATION
        {
            get
            {
                return _DATE_ANNULATION;
            }
            set
            {
                _DATE_ANNULATION = value;
            }
        }
    }
}
