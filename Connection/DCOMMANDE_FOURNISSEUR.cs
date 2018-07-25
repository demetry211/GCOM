using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Connection
{
    [Serializable]
    public class DCOMMANDE_FOURNISSEUR
    {
        protected string _CODE_COMMANDE_FOURNISSEUR;
        protected DateTime _DATE_COMMANDE_FOURNISSEUR;
        protected decimal _CODE_USER;
        protected bool _PRIORITE_COMMANDE_FOURNISSEUR;
        protected DateTime _DATE_EXPIRATION_COMMANDE_FOURNISSEUR;
        protected decimal _CODE_FOURNISSEUR;
        protected int _ANNEE_CMDFR;
        protected int _MOIS_CMDFR;
        protected decimal _CODE_MAG;
        protected string _ADRESSE_LIVRAISON;
        protected string _CONTACT;
        protected string _TEL_CONTACT;
        protected string _REMARQUE;
        protected bool _VALIDE;
        protected decimal _USER_VALIDATION;
        protected DateTime _DATE_VALIDATION;


        public virtual string CODE_COMMANDE_FOURNISSEUR
        {
            get
            {
                return _CODE_COMMANDE_FOURNISSEUR;
            }
            set
            {
                _CODE_COMMANDE_FOURNISSEUR = value;
            }
        }


        public virtual DateTime DATE_COMMANDE_FOURNISSEUR
        {
            get
            {
                return _DATE_COMMANDE_FOURNISSEUR;
            }
            set
            {
                _DATE_COMMANDE_FOURNISSEUR = value;
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


        public virtual bool PRIORITE_COMMANDE_FOURNISSEUR
        {
            get
            {
                return _PRIORITE_COMMANDE_FOURNISSEUR;
            }
            set
            {
                _PRIORITE_COMMANDE_FOURNISSEUR = value;
            }
        }


        public virtual DateTime DATE_EXPIRATION_COMMANDE_FOURNISSEUR
        {
            get
            {
                return _DATE_EXPIRATION_COMMANDE_FOURNISSEUR;
            }
            set
            {
                _DATE_EXPIRATION_COMMANDE_FOURNISSEUR = value;
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


        public virtual int ANNEE_CMDFR
        {
            get
            {
                return _ANNEE_CMDFR;
            }
            set
            {
                _ANNEE_CMDFR = value;
            }
        }


        public virtual int MOIS_CMDFR
        {
            get
            {
                return _MOIS_CMDFR;
            }
            set
            {
                _MOIS_CMDFR = value;
            }
        }


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


        public virtual string ADRESSE_LIVRAISON
        {
            get
            {
                return _ADRESSE_LIVRAISON;
            }
            set
            {
                _ADRESSE_LIVRAISON = value;
            }
        }


        public virtual string CONTACT
        {
            get
            {
                return _CONTACT;
            }
            set
            {
                _CONTACT = value;
            }
        }


        public virtual string TEL_CONTACT
        {
            get
            {
                return _TEL_CONTACT;
            }
            set
            {
                _TEL_CONTACT = value;
            }
        }


        public virtual string REMARQUE
        {
            get
            {
                return _REMARQUE;
            }
            set
            {
                _REMARQUE = value;
            }
        }

        public virtual decimal USER_VALIDATION
        {
            get
            {
                return _USER_VALIDATION;
            }
            set
            {
                _USER_VALIDATION = value;
            }
        }


        public virtual bool VALIDE
        {
            get
            {
                return _VALIDE;
            }
            set
            {
                _VALIDE = value;
            }
        }


        public virtual DateTime DATE_VALIDATION
        {
            get
            {
                return _DATE_VALIDATION;
            }
            set
            {
                _DATE_VALIDATION = value;
            }
        }
    }
}
