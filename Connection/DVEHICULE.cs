using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Connection
{
    [Serializable]
    public class DVEHICULE
    {
        protected decimal _CODE_VEHICULE;
        protected string _MATRICULE;
        protected decimal _CODE_MARQUE;
        protected decimal _CODE_CLIENT;
        protected string _GAMME;
        protected string _TYPE;
        protected int _PUISSANCE;
        protected int _CYLINDRE;
        protected string _REF_CLIENT;
        protected string _RS_CLIENT;
        protected string _TEL_CLIENT;
        protected string _REF_MARQUE;
        protected string _DESIGNATION_MARQUE;

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


        public virtual string MATRICULE
        {
            get
            {
                return _MATRICULE;
            }
            set
            {
                _MATRICULE = value;
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


        public virtual string GAMME
        {
            get
            {
                return _GAMME;
            }
            set
            {
                _GAMME = value;
            }
        }


        public virtual string TYPE
        {
            get
            {
                return _TYPE;
            }
            set
            {
                _TYPE = value;
            }
        }


        public virtual int PUISSANCE
        {
            get
            {
                return _PUISSANCE;
            }
            set
            {
                _PUISSANCE = value;
            }
        }


        public virtual int CYLINDRE
        {
            get
            {
                return _CYLINDRE;
            }
            set
            {
                _CYLINDRE = value;
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

        public virtual string REF_MARQUE
        {
            get
            {
                return _REF_MARQUE;
            }
            set
            {
                _REF_MARQUE = value;
            }
        }


        public virtual string DESIGNATION_MARQUE
        {
            get
            {
                return _DESIGNATION_MARQUE;
            }
            set
            {
                _DESIGNATION_MARQUE = value;
            }
        }
    }
}
