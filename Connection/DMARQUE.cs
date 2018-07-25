using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Connection
{
    [Serializable]
    public class DMARQUE
    {
        protected decimal _CODE_MARQUE;
        protected string _REF_MARQUE;
        protected string _DESIGNATION_MARQUE;
        protected string _DESCRIPTION_MARQUE;



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


        public virtual string DESCRIPTION_MARQUE
        {
            get
            {
                return _DESCRIPTION_MARQUE;
            }
            set
            {
                _DESCRIPTION_MARQUE = value;
            }
        }
    }
}
