using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace Connection
{
    [Serializable]
    public class DFICHE_INTERVENTION
    {
        protected string _NUM_FI;
        protected DateTime _DATE_FI;
        protected decimal _CODE_VEHICULE;
        protected decimal _KILOMETRAGE;
        protected string _CODE_B_LIV;
        protected decimal _USER_CR;
        protected DateTime _DATE_MODIF;
        protected decimal _USER_MODIF;
        protected int _CLOTURE;
        protected DateTime _DATE_CLOTURE;
        protected decimal _USER_CLOTURE;
        protected List<DARTICLE> _DETAIL;
        protected decimal _CODE_MAG;


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

        public virtual List<DARTICLE> DETAIL
        {
            get
            {
                return _DETAIL;
            }
            set
            {
            	_DETAIL = value;
            }
        }


        public virtual string NUM_FI
        {
            get
            {
                return _NUM_FI;
            }
            set
            {
                _NUM_FI = value;
            }
        }


        public virtual DateTime DATE_FI
        {
            get
            {
                return _DATE_FI;
            }
            set
            {
                _DATE_FI = value;
            }
        }


        public virtual decimal CODE_VEHICULE
        {
            get
            {
                return _CODE_VEHICULE;
            }
            set
            {
                _CODE_VEHICULE = value;
            }
        }


        public virtual decimal KILOMETRAGE
        {
            get
            {
                return _KILOMETRAGE;
            }
            set
            {
                _KILOMETRAGE = value;
            }
        }


        public virtual string CODE_B_LIV
        {
            get
            {
                return _CODE_B_LIV;
            }
            set
            {
                _CODE_B_LIV = value;
            }
        }


        public virtual decimal USER_CR
        {
            get
            {
                return _USER_CR;
            }
            set
            {
                _USER_CR = value;
            }
        }


        public virtual DateTime DATE_MODIF
        {
            get
            {
                return _DATE_MODIF;
            }
            set
            {
                _DATE_MODIF = value;
            }
        }


        public virtual decimal USER_MODIF
        {
            get
            {
                return _USER_MODIF;
            }
            set
            {
                _USER_MODIF = value;
            }
        }


        public virtual int CLOTURE
        {
            get
            {
                return _CLOTURE;
            }
            set
            {
                _CLOTURE = value;
            }
        }


        public virtual DateTime DATE_CLOTURE
        {
            get
            {
                return _DATE_CLOTURE;
            }
            set
            {
                _DATE_CLOTURE = value;
            }
        }


        public virtual decimal USER_CLOTURE
        {
            get
            {
                return _USER_CLOTURE;
            }
            set
            {
                _USER_CLOTURE = value;
            }
        }
    }
}
