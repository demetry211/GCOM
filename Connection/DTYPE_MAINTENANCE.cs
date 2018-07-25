using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Connection
{
    [Serializable]
    public class DTYPE_MAINTENANCE
    {
        protected int _CODE_TYPE_MNT;
        protected string _LIB_MNT;
        protected string _TYPE_CALCUL;
        protected decimal _CODE_UNITE;
        protected int _NB_JOUR;
        protected decimal _VAL_MNT;



        public virtual int CODE_TYPE_MNT
        {
            get
            {
                return _CODE_TYPE_MNT;
            }
            set
            {
                _CODE_TYPE_MNT = value;
            }
        }


        public virtual string LIB_MNT
        {
            get
            {
                return _LIB_MNT;
            }
            set
            {
                _LIB_MNT = value;
            }
        }


        public virtual string TYPE_CALCUL
        {
            get
            {
                return _TYPE_CALCUL;
            }
            set
            {
                _TYPE_CALCUL = value;
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


        public virtual int NB_JOUR
        {
            get
            {
                return _NB_JOUR;
            }
            set
            {
                _NB_JOUR = value;
            }
        }


        public virtual decimal VAL_MNT
        {
            get
            {
                return _VAL_MNT;
            }
            set
            {
                _VAL_MNT = value;
            }
        }
    }
}
