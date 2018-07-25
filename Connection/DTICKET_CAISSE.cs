using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Connection
{
    [Serializable]
    public class DTICKET_CAISSE
    {
        protected string _CODE_TC;
        protected DateTime _DATE_TC;
        protected decimal _CODE_CAISSE;
        protected decimal _CODE_CLIENT;
        protected decimal _MONTANT_HT;
        protected decimal _REMISE;
        protected decimal _MONTANT_TVA;
        protected decimal _MONTANT_TTC;
        protected decimal _MONTANT_RECU;
        protected decimal _RESTE;
        protected decimal _MAGASIN;
        protected decimal _CODE_USER;
        protected decimal _CODE_REGLEMENT;
        protected string _CODE_FACTURE;



        public virtual string CODE_TC
        {
            get
            {
                return _CODE_TC;
            }
            set
            {
                _CODE_TC = value;
            }
        }


        public virtual DateTime DATE_TC
        {
            get
            {
                return _DATE_TC;
            }
            set
            {
                _DATE_TC = value;
            }
        }


        public virtual decimal CODE_CAISSE
        {
            get
            {
                return _CODE_CAISSE;
            }
            set
            {
                _CODE_CAISSE = value;
            }
        }


        public virtual decimal CODE_CLIENT
        {
            get
            {
                return _CODE_CLIENT;
            }
            set
            {
                _CODE_CLIENT = value;
            }
        }


        public virtual decimal MONTANT_HT
        {
            get
            {
                return _MONTANT_HT;
            }
            set
            {
                _MONTANT_HT = value;
            }
        }


        public virtual decimal REMISE
        {
            get
            {
                return _REMISE;
            }
            set
            {
                _REMISE = value;
            }
        }


        public virtual decimal MONTANT_TVA
        {
            get
            {
                return _MONTANT_TVA;
            }
            set
            {
                _MONTANT_TVA = value;
            }
        }


        public virtual decimal MONTANT_TTC
        {
            get
            {
                return _MONTANT_TTC;
            }
            set
            {
                _MONTANT_TTC = value;
            }
        }


        public virtual decimal MONTANT_RECU
        {
            get
            {
                return _MONTANT_RECU;
            }
            set
            {
                _MONTANT_RECU = value;
            }
        }


        public virtual decimal RESTE
        {
            get
            {
                return _RESTE;
            }
            set
            {
                _RESTE = value;
            }
        }


        public virtual decimal MAGASIN
        {
            get
            {
                return _MAGASIN;
            }
            set
            {
                _MAGASIN = value;
            }
        }


        public virtual decimal CODE_USER
        {
            get
            {
                return _CODE_USER;
            }
            set
            {
                _CODE_USER = value;
            }
        }


        public virtual decimal CODE_REGLEMENT
        {
            get
            {
                return _CODE_REGLEMENT;
            }
            set
            {
                _CODE_REGLEMENT = value;
            }
        }


        public virtual string CODE_FACTURE
        {
            get
            {
                return _CODE_FACTURE;
            }
            set
            {
                _CODE_FACTURE = value;
            }
        }
    }
}
