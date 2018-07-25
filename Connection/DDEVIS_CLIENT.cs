using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Connection
{
    [Serializable]
    public class DDEVIS_CLIENT
    {
        protected string _CODE_DC;
        protected DateTime _DATE_DC;
        protected decimal _DATE_VALIDITE;
        protected decimal _CODE_CLIENT;
        protected string _MODE_PAIEMENT;
        protected string _OBSERVATION;
        protected decimal _UTILISATEUR_CREATION;
        protected DateTime _DATE_CREATION;
        protected string _RESPONSABLE;
        protected decimal _NB_IMPRIME;
        protected decimal _TIMBRE;


        public virtual string CODE_DC
        {
            get
            {
                return _CODE_DC;
            }
            set
            {
                _CODE_DC = value;
            }
        }


        public virtual DateTime DATE_DC
        {
            get
            {
                return _DATE_DC;
            }
            set
            {
                _DATE_DC = value;
            }
        }


        public virtual decimal DATE_VALIDITE
        {
            get
            {
                return _DATE_VALIDITE;
            }
            set
            {
                _DATE_VALIDITE = value;
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


        public virtual string MODE_PAIEMENT
        {
            get
            {
                return _MODE_PAIEMENT;
            }
            set
            {
                _MODE_PAIEMENT = value;
            }
        }


        public virtual string OBSERVATION
        {
            get
            {
                return _OBSERVATION;
            }
            set
            {
                _OBSERVATION = value;
            }
        }


        public virtual decimal UTILISATEUR_CREATION
        {
            get
            {
                return _UTILISATEUR_CREATION;
            }
            set
            {
                _UTILISATEUR_CREATION = value;
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


        public virtual string RESPONSABLE
        {
            get
            {
                return _RESPONSABLE;
            }
            set
            {
                _RESPONSABLE = value;
            }
        }


        public virtual decimal NB_IMPRIME
        {
            get
            {
                return _NB_IMPRIME;
            }
            set
            {
                _NB_IMPRIME = value;
            }
        }

        public virtual decimal TIMBRE
        {
            get
            {
                return _TIMBRE;
            }
            set
            {
                _TIMBRE = value;
            }
        }
    }
}
