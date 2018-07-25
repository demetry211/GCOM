using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Connection
{
    [Serializable]
    public class DCLIENT
    {
        protected decimal _CODE_CLIENT;
        protected string _REF_CLIENT;
        protected string _RS_CLIENT;
        protected string _ADRESSE_CLIENT;
        protected string _CP_CLIENT;
        protected string _TEL_CLIENT;
        protected string _FAX_CLIENT;
        protected string _EMAIL_CLIENT;
        protected int _EXO_CLIENT;
        protected string _ATTEST_EXO_CLIENT;
        protected string _CODE_DOUANE_CLIENT;
        protected string _CODE_TVA_CLIENT;
        protected int _ETAT_CLIENT;
        protected int _COMPTE;
        protected string _VILLE_CLIENT;
        protected string _PAYS_CLIENT;
        protected decimal _MAX_CREDIT;
        protected string _TEL2_CLIENT;



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


        public virtual string ADRESSE_CLIENT
        {
            get
            {
                return _ADRESSE_CLIENT;
            }
            set
            {
                _ADRESSE_CLIENT = value;
            }
        }


        public virtual string CP_CLIENT
        {
            get
            {
                return _CP_CLIENT;
            }
            set
            {
                _CP_CLIENT = value;
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


        public virtual string FAX_CLIENT
        {
            get
            {
                return _FAX_CLIENT;
            }
            set
            {
                _FAX_CLIENT = value;
            }
        }


        public virtual string EMAIL_CLIENT
        {
            get
            {
                return _EMAIL_CLIENT;
            }
            set
            {
                _EMAIL_CLIENT = value;
            }
        }


        public virtual int EXO_CLIENT
        {
            get
            {
                return _EXO_CLIENT;
            }
            set
            {
                _EXO_CLIENT = value;
            }
        }


        public virtual string ATTEST_EXO_CLIENT
        {
            get
            {
                return _ATTEST_EXO_CLIENT;
            }
            set
            {
                _ATTEST_EXO_CLIENT = value;
            }
        }


        public virtual string CODE_DOUANE_CLIENT
        {
            get
            {
                return _CODE_DOUANE_CLIENT;
            }
            set
            {
                _CODE_DOUANE_CLIENT = value;
            }
        }


        public virtual string CODE_TVA_CLIENT
        {
            get
            {
                return _CODE_TVA_CLIENT;
            }
            set
            {
                _CODE_TVA_CLIENT = value;
            }
        }


        public virtual int ETAT_CLIENT
        {
            get
            {
                return _ETAT_CLIENT;
            }
            set
            {
                _ETAT_CLIENT = value;
            }
        }


        public virtual int COMPTE
        {
            get
            {
                return _COMPTE;
            }
            set
            {
                _COMPTE = value;
            }
        }


        public virtual string VILLE_CLIENT
        {
            get
            {
                return _VILLE_CLIENT;
            }
            set
            {
                _VILLE_CLIENT = value;
            }
        }


        public virtual string PAYS_CLIENT
        {
            get
            {
                return _PAYS_CLIENT;
            }
            set
            {
                _PAYS_CLIENT = value;
            }
        }


        public virtual decimal MAX_CREDIT
        {
            get
            {
                return _MAX_CREDIT;
            }
            set
            {
                _MAX_CREDIT = value;
            }
        }


        public virtual string TEL2_CLIENT
        {
            get
            {
                return _TEL2_CLIENT;
            }
            set
            {
                _TEL2_CLIENT = value;
            }
        }
    }
}
