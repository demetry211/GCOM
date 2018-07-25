using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Connection
{
    [Serializable]
    public class DCONFIG_EQUIP_MAINT
    {
        protected decimal _CODE_CONF_MAINT;
        protected decimal _CODE_EQP;
        protected int _CODE_TYPE_MAINT;
        protected decimal _CODE_UNITE;
        protected DateTime _DATE_DEBUT_COMPTE;
        protected decimal _VAL_MAINT;
        protected decimal _COMPTEUR;
        protected decimal _VAL_MAINT_SUIV;
        protected int _NB_JOUR;
        protected DateTime _DATE_ECHEANCE;



        public virtual decimal CODE_CONF_MAINT
        {
            get
            {
                return _CODE_CONF_MAINT;
            }
            set
            {
                _CODE_CONF_MAINT = value;
            }
        }


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


        public virtual int CODE_TYPE_MAINT
        {
            get
            {
                return _CODE_TYPE_MAINT;
            }
            set
            {
                _CODE_TYPE_MAINT = value;
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


        public virtual DateTime DATE_DEBUT_COMPTE
        {
            get
            {
                return _DATE_DEBUT_COMPTE;
            }
            set
            {
                _DATE_DEBUT_COMPTE = value;
            }
        }


        public virtual decimal VAL_MAINT
        {
            get
            {
                return _VAL_MAINT;
            }
            set
            {
                _VAL_MAINT = value;
            }
        }


        public virtual decimal COMPTEUR
        {
            get
            {
                return _COMPTEUR;
            }
            set
            {
                _COMPTEUR = value;
            }
        }


        public virtual decimal VAL_MAINT_SUIV
        {
            get
            {
                return _VAL_MAINT_SUIV;
            }
            set
            {
                _VAL_MAINT_SUIV = value;
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


        public virtual DateTime DATE_ECHEANCE
        {
            get
            {
                return _DATE_ECHEANCE;
            }
            set
            {
                _DATE_ECHEANCE = value;
            }
        }
    }
}
