using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Drawing;

namespace CHM_GESTION_COMERCIALE
{

    public interface CHM_CLIENT
    {
        RESULT_QUERY INSERT_CLIENT(string CODE, string RS, string REF, string ADRESSE, string CP, string VILLE, string PAYS, string TEL, string TEL2, string FAX, string EMAIL, bool EXO, string ATTEST_EXO, string CODE_DOUANE, string CODE_TVA, bool ETAT_CLIENT, bool COMPTE, decimal MAX_CREDIT);

        RESULT_QUERY DELETE_CLIENT(string CODE);

        RESULT_QUERY UPDATE_CLIENT(string CODE, string RS, string REF, string ADRESSE, string CP, string VILLE, string PAYS, string TEL, string TEL2, string FAX, string EMAIL, bool EXO, string ATTEST_EXO, string CODE_DOUANE, string CODE_TVA, bool ETAT_CLIENT, decimal MAX_CREDIT);

        DataTable SEARCH_CLIENT(string INDICE);

        DataTable LOAD_CLIENT(string CODE);

        DataTable SELECT_ALL_CLIENTS();

        string NEW_CODE(int nbCHIFRE);

        DataTable SELECT_COMMANDE_CLIENT(string CODE);

        DataTable LOAD_COMPTE(string CODE_CLIENT);

        void BLOQUER_CLIENT(string CODE_CLIENT);

        void UPDATE_ETAT_COMPTE(string CODE_CLIENT);

        DataTable select_facture(string CODE_CLIENT);

        DataTable select_b_liv_client(string CODE_CLIENT);
    }

    public interface CHM_GESTION
    {
        string Workstation
        {
            get;
            set;
        }

        CHM_CLIENT P_CLIENT
        {
            get;            
        }

        CHM_FOURNISSEUR P_FOURNISSEUR
        {
            get;
            
        }

        CHM_ARTICLE P_ARTICLE
        {
            get;
            
        }

        CHM_COMMANDE P_COMMANDE
        {
            get;
            
        }

        CHM_EMPLOYE P_EMPLOYE
        {
            get;
            
        }

        CHM_FONCTIONNALITE P_FONCTION
        {
            get;
            
        }

        CHM_CATEGORIE_ARTICLE P_CATEGORIE
        {
            get;
            
        }

        CHM_MAGAZIN P_MAGAZIN
        {
            get;
            
        }

        CHM_SOCIETE P_SOCIETE
        {
            get;
            set;
        }

        CHM_UTILISATEUR P_UTILISATEUR
        {
            get;
            
        }

        CHM_BON_LIVRAISON P_BON_LIVRAISON
        {
            get;
            
        }

        CHM_STOCK P_STOCK
        {
            get;
            
        }

        CHM_COMPTE_CLIENT P_COMPTE_CLIENT
        {
            get;
            set;
        }

        CHM_FACTURE P_FACTURE
        {
            get;
            
        }

        CHM_REGLEMENT P_REGLEMENT
        {
            get;
            
        }

        CHM_DEVI P_DEVI
        {
            get;
            set;
        }

        CHM_BON_RECEPTION_FOURNISSEUR P_BR_FR
        {
            get;
        }

        CHM_BRETOUR_CLIENT P_BRETOUR_CL
        {
            get;
        }

        INVENTAIRE P_INVENTAIRE
        {
            get;
        }
    }

    public interface CHM_FOURNISSEUR
    {
        string INSERT_FOURNISSEUR(string CODE, string REF, string RS, string ADRESSE, string TEL, string FAX, string EMAIL, string SITEWEB, string RIB, string CODE_TVA);

        string DELETE_FOURNISSEUR(string CODE);

        string UPDATE_FOURNISSEUR(string CODE, string REF, string RS, string ADRESSE, string TEL, string FAX, string EMAIL, string SITEWEB, string RIB, string CODE_TVA);

        DataTable SEARCH_FOURNISSEUR(string INDICE);

        DataTable SELECT_ALL_FOURNISSEURS();

        DataTable LOAD_FOURNISSEUR(string CODE);

        string NEW_CODE(int nbCHIFRE);
    }

    public interface CHM_ARTICLE
    {
        DataTable LOAD_ARTICLE_BY_REF(string REF_ARTICLE);

        RESULT_QUERY DELETE_ARTICLE(string CODE);

        RESULT_QUERY INSERT_ARTICLE(string CODE_ARTICLE, string REF_ARTICLE, string DESIGNATION_ARTICLE, string MARQUE_ARTICLE, string DESCRIPTION_ARTICLE, string CODE_BARRE_ARTICLE, decimal QTE_ARTICLE, string UNITE, decimal QTE_MIN_ARTICLE, byte[] PHOTO_ARTICLE, decimal PRIX_HT_A_ARTICLE, decimal PRIX_HT_V_ARTICLE, decimal MAX_REMISE, decimal TVA_ARTICLE, bool ETAT_ARTICLE, string CATEGORIE, string MAGAZIN, string FOURNISSEUR, decimal PRIX_SOLDE);

        DataTable LOAD_ARTICLE(string CODE);

        DataTable SEARCH_ARTICLE(string param);

        DataTable SELECT_ALL_ARTICLE();

        RESULT_QUERY UPDATE_ARTICLE(string CODE_ARTICLE, string REF_ARTICLE, string DESIGNATION_ARTICLE, string MARQUE_ARTICLE, string DESCRIPTION_ARTICLE, string CODE_BARRE_ARTICLE, decimal QTE_ARTICLE, string UNITE, decimal QTE_MIN_ARTICLE, byte[] PHOTO_ARTICLE, decimal PRIX_HT_A_ARTICLE, decimal PRIX_HT_V_ARTICLE, decimal TVA_ARTICLE, decimal MAX_REMISE, bool ETAT_ARTICLE, string CATEGORIE, string MAGAZIN, string FOURNISSEUR, decimal PRIX_SOLDE);

        string NEW_CODE(int nbCHIFRE);

        DataTable SELECT_FOURNISSEURS();

        DataTable SELECT_CATEGORIES();

        DataTable SELECT_MAGAZINS();

        DataTable SEARCH_ARTICLE_CATEG(string param);

        DataTable SEARCH_ARTICLE_MAG(string param);

        DataTable SEARCH_ARTICLE_FOURN(string param);

        void BLOQUER_ARTICLE(string CODE_ARTICLE);

        DataTable SELECT_BY_BARCODE(string BARCODE);

        DataTable IMPRIMER_CODE_BARRE_ARTICLE(string CODE_ARTICLE, bool solde);

        DataTable LOAD_ARTICLE_BY_BARCODE(string BARCODE);
    }

    public interface CHM_COMMANDE
    {
        void REGLE_COMMANDE(string code_commande);
        DataTable RECHERCHE_CLIENT(string REF_CLIENT);
        DataTable LISTE_CLIENT();

        RESULT_QUERY SAVE(string CODE_CLIENT, DateTime DATE_COMMANDE, bool PRIORITE_COMMANDE, object DATE_EXPIRATION_COMMANDE, string CODE_USER, bool reglee, DataTable dt_lg_commande);

        DataTable LOAD_LISTE_CLIENT();

        DataTable RECHERCHE_LISTE_CLIENT(string param);

        DataTable LOAD_SCHEMA_LG_COMMANDE();

        DataTable LOAD_LISTE_ARTICLE(string NOM_MAG);

        DataTable RECHERCHE_LISTE_ARTICLE(string param);

        DataTable[] PRINT(string CODE_COMMANDE);

        DataTable LOAD_COMMANDE_CLIENT(string CODE_CLIENT);

        DataTable LOAD_LG_COMMANDE(string CODE_COMMANDE);

        DataTable LOAD_COMMANDE(string code);

        DataTable SELECT_ALL_COMMANDE();

        DataTable RECHERCHE_COMMANDES(string client, DateTime date_saisie, DateTime date_expiration);

        void SELECT_COMMANDE_NON_REGLE();

       
    }

    public interface CHM_FACTURE
    {
        RESULT_QUERY INSERT_FACTURE(DateTime DATE_FACTURE, string CODE_CLIENT, string  MONTANT_HT_FACTURE, string  MONTANT_TVA, string  MONTANT_TTC, string TAUX_REMISE, string MONTANT_BASE, string TIMBRE_FACTURE, string MONTANT_TOTAL_FACTURE, string MONTANT_LETTRE_FACTURE, bool ANNULATION_FACTURE,string  REGLER,string  CREDIT, string CODE_MAG, string CODE_USER, string PRENOM_USER, string NOM_USER, string REMARQUE, DataTable dt_lg_facture);

        void CANCEL_FACTURE(string CODE_FACTURE);

        DataTable SELECT_FACTURE_REGLEE();

        DataTable SELECT_FACTURE_NON_REGLEE();

        DataTable SELECT_FACTURE_PARTIELLEMENT_REGLEE();

        RESULT_QUERY UPDATE_ETAT_FACTURE(string CODE_FACTURE, string MONTANT_PAYE);

        DataTable SELECT_FACTURE_ANNULEE();

        DataTable LOAD_REGLEMENT_FACTURE(string CODE_FACTURE);

        DataTable LOAD_B_LIV_CLIENT(string CODE_CLIENT);

        DataTable LOAD_B_LIV_FACTURE(string CODE_B_LIV);

        DataTable LOAD_LG_B_LIV(string CODE_B_LIV);

        DataTable LOAD_CLIENT_FACTURE(string CODE_CLIENT);

        DataTable LOAD_SCHEMA_LG_FACTURE();

        void FACTURATION(string CODE_FACTURE, string CODE_B_LIV, DateTime DATE_FACTURE);

        DataTable LOAD_FACTURE(string CODE_CLIENT);

        DataTable SELECT_ALL_FACTURES();

        DataTable LOAD_FACTURE_PAR_CODE(string CODE_FATCURE);

        DataTable LOAD_LIGNES_FACTURE(string CODE_FATCURE);

        DataTable RECHERCHE_FACTURE(string param, string etat);

        DataTable LOAD_SCHEMA_LIGNE_B_LIV_FACTURE();

        RESULT_QUERY INSERT_FACTURE_DIRECTE(DateTime DATE_FACTURE, string CODE_CLIENT, string MONTANT_HT_FACTURE, string MONTANT_TVA, string MONTANT_TTC, string TAUX_REMISE, string MONTANT_BASE, string TIMBRE_FACTURE, string MONTANT_TOTAL_FACTURE, string MONTANT_LETTRE_FACTURE, bool ANNULATION_FACTURE, string REGLER, string CREDIT, string CODE_MAG, string CODE_USER, string PRENOM_USER, string NOM_USER, string REMARQUE, DataTable dt_lg_facture);

        DataTable LOAD_SCHEMA_LG_FACTURE_DIRECTE();

        DataTable ImprimerTICET_FACTURE_CLIENT(string CODE_FACTURE);

        DataTable GET_LISTE_VENTE_PAR_DATE(DateTime date_debut, DateTime date_fin);

        DataTable GET_LISTE_VENTE_PAR_DATE_PAR_UTILISATEUR(DateTime date_debut, DateTime date_fin, decimal code_user);

        DataTable GET_LISTE_VENTE_PAR_FACTURE_PAR_DATE_PAR_UTILISATEUR(DateTime date_debut, DateTime date_fin, decimal code_user);

        DataTable GET_LISTE_VENTE_PAR_FACTURE_PAR_DATE(DateTime date_debut, DateTime date_fin);

        DataTable LOAD_GAIN_DETAIL(DateTime datedebut, DateTime datefin);

        DataTable LOAD_qte_retour(DateTime datedebut, DateTime datefin);
    }

    public interface CHM_EMPLOYE
    {
        RESULT_QUERY INSERT_EMPLOYE(string CODE, string Nom, string PRENOM, DateTime DATE_NAIS, string ADRESSE, string TEL, string EMAIL, DateTime DATE_EMB, bool ETAT, string AGENCE);

        RESULT_QUERY DELETE_EMPLOYE(string CODE);

        RESULT_QUERY UPDATE_EMPLOYE(string CODE, string Nom, string PRENOM, DateTime DATE_NAIS, string ADRESSE, string TEL, string EMAIL, DateTime DATE_EMB, bool ETAT, string AGENCE);

        DataTable SELECT_ALL_EMPLOYES();

        DataTable SEARCH_EMPLOYE(string INDICE);

        DataTable LOAD_EMPLOYE(string CODE);

        string NEW_CODE(int nbCHIFRE);
    }

    public interface CHM_FONCTIONNALITE
    {
        string INSERT_FONCTION(string CODE, string LABEL );

        string DELETE_FONCTION(string CODE);

        string UPDATE_FONCTION(string CODE, string LABEL);

        DataTable SELECT_ALL_FONTIONS();

        DataTable LOAD_FONCTION(string CODE);

        string NEW_CODE(int nbCHIFRE);
    }

    public interface CHM_MAGAZIN
    {
        RESULT_QUERY DELETE_MAGAZIN(string CODE);

        RESULT_QUERY INSERT_MAGAZIN(string CODE, string NOM, string ADRESSE, string TEL, string CODE_SOCIETE, string AGENCE);

        RESULT_QUERY UPDATE_MAGAZIN(string CODE, string NOM, string ADRESSE, string TEL, string CODE_SOCIETE, string AGENCE);

        DataTable LOAD_MAGAZIN(string CODE);

        DataTable SEARCH_MAGAZIN(string INDICE);

        DataTable SELECT_ALL_MAGAZIN();

       

        string NEW_CODE(int nbCHIFRE);
    }

    public interface CHM_CATEGORIE_ARTICLE
    {
        RESULT_QUERY DELETE_CATEGORIE(string CODE);

        RESULT_QUERY INSERT_CATEGORIE(string CODE, string LABEL, string DESC);

        RESULT_QUERY UPDATE_CATEGORIE(string CODE, string LABEL, string DESC);

        DataTable SEARCH_CATEGORIE(string INDICE);

        DataTable LOAD_CATEGORIE(string CODE);

        DataTable SELECT_ALL_CATEGORIE();

        DataTable SELECT_LISTE_CATEGORIE();

        string NEW_CODE(int nbCHIFRE);

        DataTable SELECT_CATEG_PRODUCTS(string param);

        DataTable LOAD_SCHEMA_ARTICLE();

        DataTable LOAD_ARTICLE_PAR_REF( string REF);
    }
    [Serializable]
    public class RESULT_QUERY
    {
        public string CODE = "";
        public bool OK = true;
        public string MESSAGE = "";
    }

    public interface CHM_SOCIETE
    {
        RESULT_QUERY ENREGISTRER(string CODE, string RS_SOCIETE, string DESCRIPTION_SOCIETE, string ADRESSE_SOCIETE, string CP_SOCIETE, string TEL_SOCIETE, string FAX_SOCIETE, string EMAIL_SOCIETE, string SITE_WEB_SOCETE, byte[] LOGO_SOCIETE, string CODE_TVA_SOCIETE, string RIB_SOCIETE, decimal NUM_COMMANDE, string PREFIX1_COMMANDE, string PREFIX2_COMMANDE, decimal NUM_FACTURE, string PREFIX1_FACTURE, string PREFIXE2_FACTURE);

        DataTable LOAD();

        DataTable SELECT_ALL_SOCIETE();

        DataTable VIEW_SOCIETE(string CODE_SOCIETE);
    }

    public interface CHM_UTILISATEUR
    {
        RESULT_QUERY INSERT_UTILISATEUR(string CODE_USER, string NOM_USER, string PRENOM_USER, byte[] PHOTO_USER, string LOGIN_USER, string PASSWORD_USER, bool ETAT_USER, string SOCIETE, string FONCTION);

        RESULT_QUERY UPDATE_UTILISATEUR(string CODE_USER, string NOM_USER, string PRENOM_USER, byte[] PHOTO_USER, string LOGIN_USER, string PASSWORD_USER, bool ETAT_USER, string SOCIETE, string FONCTION);

        RESULT_QUERY DELETE_UTILISATEUR(string CODE_USER);

        DataTable LOAD_UTILISATEUR(string CODE_USER);

        DataTable RECHERCHE_UTILISATEUR(string param);

        DataTable SELECT_ALL_UTILISATEUR();

        RESULTAT_UTILISATEUR IDENTIFIER(string LOGIN_USER, string PASSWORD_USER);

        DataTable SELECT_FONCTION();

        DataTable SELECT_COMMANDE(string CODE_USER);

        DataTable SELECT_FACTURE(string CODE_USER);

        DataTable SELECT_B_LIV(string CODE_USER);

        DataTable SELECT_REGLEMENT(string CODE_USER);

        DataTable SELECT_ALL_NOM_UTILISATEUR();
    }
    [Serializable]
    public class RESULTAT_UTILISATEUR
    {
        public bool IDENTIFIER = false;
        public string FONCTION = "";
        public string MESSAGE = "";

        public bool COMMANDE_CLIENT = false;
        public bool COMMANDE_FOURNISSEUR = false;
        public bool FACTURE_CLIENT= false;
         public bool   FACTURE_FOURNISSEUR = false;
        public bool COMPTE_USER = false;
        public bool    AJOUT_STOCK = false;
         public bool       CONSULT_STOCK = false;
        
    }

    public interface CHM_BON_LIVRAISON
    {
        RESULT_QUERY SAVE(DateTime DATE_B_LIV, string CODE_CLIENT, string CODE_COMMANDE, string CODE_USER, DataTable dt_lg_b_liv);

        DataTable LOAD_LG_BON_LIVRAISON(string CODE_COMMANDE);

        DataTable SELECT_CLIENT(string CODE_CLIENT);

        DataTable LOAD_COMMANDE(string CODE_COMMANDE);

        DataTable LOAD_SCHEMA_LG_BON_LIVRAISON();

        DataTable[] PRINT(string CODE_B_LIV);

        DataTable SELECT_B_LIV_NON_FACTURE();

        DataTable SELECT_B_LIV_NON_PREPARE();

        DataTable SELECT_B_LIV_PREPARE();

        DataTable SELECT_B_LIV_FACTURE();

        DataTable SELECT_B_LIV_LIVRE();

        DataTable SELECT_B_LIV_NON_LIVRE();

        void UPDATE_LIVRE(string CODE_B_LIV);

        void UPDATE_PREPARE(string CODE_B_LIV);

        void UPDATE_FACTURE(string CODE_B_LIV, bool param);

        DataTable SELECT_ALL_BON_LIVRAISON();

        DataTable RECHERCHE(string param);
    }

    public interface CHM_STOCK
    {
        DataTable SEARCH_ARTICLE_STOCK(string param);

        DataTable SELECT_ALL_ARTICLE_EN_STOCK();

        DataTable SELECT_ALL_ARTICLE_EN_STOCK_PAR_MAGAZIN(decimal CODE_MAG);

        RESULT_QUERY ADD_ARTICLE_EN_STOCK();

        DataTable SELECT_ARTICLE_EN_RUPTURE_DE_STOCK();
    }

    public interface CHM_COMPTE_CLIENT
    {
        RESULT_QUERY CREER_COMPTE_CLIENT(string CODE_CLIENT);

        RESULT_QUERY UPDATE_COMPTE_CLIENT( string CODE_COMPTE_CLIENT, decimal TOTAL_PAYE);

        DataTable SELECT_ALL_COMPTES_CLIENTS();

        DataTable SELECT_COMPTE_NON_REGLE();

        DataTable SELECT_REGLEMENTS(string CODE_COMPTE_CLIENT);

        DataTable LOAD_COMPTE_CLIENT(string CODE_CLIENT);

        void actualiser_compte(string CODE_CLIENT);

        DataTable LOAD_COMPTE(string CODE_COMPTE_CLIENT);
    }

    public interface CHM_REGLEMENT
    {
        RESULT_QUERY INSERT_REGLEMENT(string CODE_FACTURE, DateTime DATE_REG_CLT, string MODE_REGLEMENT_CLIENT, string  MONTANT_REGLEMENT_CLIENT, string NUM_PIECE_CLIENT, string BANQUE_CLIENT, string OBSERVATION, string CODE_CLIENT);

        DataTable SELECT_ALL_REGLEMENT();

        DataTable SELECT_REGLEMENT_CLIENT(string CODE_COMPTE_CLIENT);

        DataTable recherche_facture(string param);

        DataTable recherche_reglement_par_date(string param, string CODE_COMPTE_CLIENT);

        DataTable recherche_reg_par_date(string param);
    }

    public interface CHM_DEVI
    {
        RESULT_QUERY SAVE_DEVI(string CODE_CLIENT, DateTime DATE_DEVIS, object DATE_EXPIRATION_DEVIS, string CODE_USER, DataTable dt_lg_devis);

        RESULT_QUERY INSERT_ARTICLE();

        DataTable SELECT_ALL_DEVIS();

        RESULT_QUERY DELETE_DEVIS(string CODE_DEVIS);

        DataTable LOAD_SCHEMA_LG_DEVIS();

        
    }
    [Serializable]
    public class PLACE
    {
        public int locationX = 0;
        public int locationY = 0;
        
        public string REF = "";
        public string CODE = "";
        public int width = 0;
        public int height = 0;
        public PLACE(int locationX, int locationY, int width, int height, string CODE, string REF)
        {
            this.locationX = locationX;
            this.locationY = locationY;
            this.width = width;
            this.height = height;

            this.CODE = CODE;
            this.REF = REF;
        }
        
    }

    public interface CHM_BON_RECEPTION_FOURNISSEUR
    {
        RESULT_QUERY INSERT_BR_FR(string CODE_BR_FR, decimal CODE_FOURNISSEUR, decimal CODE_MAG, DateTime DATE_BR_FR, decimal CODE_USER, decimal MNT_BR, decimal REMISE, DataTable dt_lg_br);

        DataTable LOAD_BR_FR(decimal CODE_BR_FR);

        DataTable SELECT_ALL_BR_FR();

        DataTable LOAD_SCHEMA_LIGNE_BR();

        DataTable IMPRIMER_BRECEP_FR(decimal CODE_BRECEP);

        DataTable LOAD_LIGNES_BR_FR(decimal CODE_BRECEP);

        RESULT_QUERY UPDATE_BR_FR(decimal CODE_BRECEP, string CODE_BR_FR, decimal CODE_FOURNISSEUR, decimal CODE_MAG, DateTime DATE_BR_FR, decimal CODE_USER, decimal MNT_BR, decimal REMISE, DataTable dt_lg_br);

        RESULT_QUERY DELETE_BR_FR(decimal CODE_BRECEP);

        decimal GET_SOMME_RECEP(DateTime datedebut, DateTime datefin);
    }

    public interface FACTURE_FOURNISSEUR
    {
        void INSERT_FACTURE_FR();

        void LOAD_FACTURE_FR();

        void SELECT_BR_FR();
    }

    public interface CHM_BRETOUR_CLIENT
    {
        RESULT_QUERY INSERT_BRETOUR_CLIENT(DateTime DATE_BRETOUR_CLIENT, decimal CODE_USER, decimal MNT_BRETOUR, string CODE_FACTURE, decimal CODE_MAG, DataTable dt_lg_bretour);

        DataTable LOAD_BRETOUR_CLIENT(string CODE_BRETOUR_CLIENT);

        DataTable LOAD_LIGNES_BRETOUR_CLIENT(string CODE_BRETOUR_CLIENT);

        DataTable SELECT_ALL_BRETOUR_CLIENT();

        DataTable LOAD_SCHEMA_LIGNE_BRETOUR_CLIENT();

        DataTable IMPRIMER_BRETOUR_CLIENT(string CODE_BRETOUR_CLIENT);

        DataTable IMPRIMER_BR_CL_PAR_DATE(DateTime date_debut, DateTime date_fin);

        DataTable IMPRIMER_BR_CL_PAR_DATE_PAR_UTILISATEUR(DateTime date_debut, DateTime date_fin, decimal CODE_USER);
    }

    public interface INVENTAIRE
    {
        DataTable  LOAD_INVENTAIRE(decimal code_inventaire);

        RESULT_QUERY OUVERTURE_INVENTAIRE(decimal code_user, decimal code_mag);

        RESULT_QUERY CLOTURE_INVENTAIRE(decimal code_inventaire, decimal code_user, DataTable dt_inventaire, decimal CODE_MAG);

        DataTable IMPRIMER_SAISIE_INVENTAIRE(decimal code_inventaire);

        DataTable LOAD_LIGNE_INVENTAIRE(decimal code_inventaire);

        RESULT_QUERY ENREGISTRER_LIGNE_INVENTAIRE(decimal code_inventaire, decimal code_article, decimal qte);

        RESULT_QUERY VERIFIER_INVENTAIRE_MAGAZIN(decimal CODE_MAG);

        DataTable SELECT_ALL_INVENTAIRE();

        decimal GET_INVENTAIRE_COURANT_PAR_MAGAZIN(decimal CODE_MAG);
    }

}
