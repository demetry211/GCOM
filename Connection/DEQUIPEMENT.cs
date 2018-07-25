using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Connection
{
    [Serializable]
    public class DEQUIPEMENT
    {
        protected decimal _CODE_EQP;
        protected string _LIBELLE_EQP;
        protected string _NUM_SERIE;
        protected DateTime _DATE_FAB_EQP;
        protected DateTime _DATE_MISE_SERVICE_EQP;
        protected string _FABRIQUANT;
        protected decimal _CODE_CLIENT;
        protected string _REF_CLIENT;
        protected string _RS_CLIENT;
        protected string _TEL_CLIENT;


        public virtual decimal CODE_EQP
        {
            get
            {
                return _CODE_EQP;
            }
            set
            {
                _CODE_EQP = value;
            }
        }


        public virtual string LIBELLE_EQP
        {
            get
            {
                return _LIBELLE_EQP;
            }
            set
            {
                _LIBELLE_EQP = value;
            }
        }


        public virtual string NUM_SERIE
        {
            get
            {
                return _NUM_SERIE;
            }
            set
            {
                _NUM_SERIE = value;
            }
        }


        public virtual DateTime DATE_FAB_EQP
        {
            get
            {
                return _DATE_FAB_EQP;
            }
            set
            {
                _DATE_FAB_EQP = value;
            }
        }


        public virtual DateTime DATE_MISE_SERVICE_EQP
        {
            get
            {
                return _DATE_MISE_SERVICE_EQP;
            }
            set
            {
                _DATE_MISE_SERVICE_EQP = value;
            }
        }


        public virtual string FABRIQUANT
        {
            get
            {
                return _FABRIQUANT;
            }
            set
            {
                _FABRIQUANT = value;
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

        public virtual string REF_CLIENT
        {
            get
            {
                return _REF_CLIENT;
            }
            set
            {
                _REF_CLIENT = value;
            }
        }


        public virtual string RS_CLIENT
        {
            get
            {
                return _RS_CLIENT;
            }
            set
            {
                _RS_CLIENT = value;
            }
        }


        public virtual string TEL_CLIENT
        {
            get
            {
                return _TEL_CLIENT;
            }
            set
            {
                _TEL_CLIENT = value;
            }
        }
    }
}
