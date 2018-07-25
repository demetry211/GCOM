using System.Windows.Forms;
namespace CHM_CLIENT_APP
{


    public partial class DS_GC
    {
        partial class V_ARTICLEDataTable
        {
        }

        partial class CATEGORIEDataTable
        {
        }

        partial class FAMILLEDataTable
        {
        }



        private void InitializeComponent()
        {
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // DS_GC
            // 
            this.Initialized += new System.EventHandler(this.DS_GC_Initialized);

            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        private void DS_GC_Initialized(object sender, System.EventArgs e)
        {



        }

        public BindingSource bsSociete;
        public BindingSource bsArticle;
        public BindingSource bsCategorie;
        public BindingSource bsFamille;
        public BindingSource bsFournisseur;
        public BindingSource bsMarque;
        public BindingSource bsMagasin;
        public BindingSource bsClient;
        public BindingSource bsTVA;
        public BindingSource bsUnite;

        public void chargerTVA()
        {

            this.TVA.Clear();
            this.TVA.Merge(CLIENT_APP_PARAM.gcws.GetTVA());

            this.bsTVA.DataSource = this.TVA;
        }

        public void chargerUnite()
        {

            this.UNITE.Clear();
            this.UNITE.Merge(CLIENT_APP_PARAM.gcws.GetUNITE_ARTICLE());

            this.bsUnite.DataSource = this.UNITE;
        }

        public void chargerArticles()
        {

            this.V_ARTICLE.Clear();
            this.V_ARTICLE.Merge(CLIENT_APP_PARAM.gcws.SELECT_ALL_ARTICLE());

            this.bsArticle.DataSource = this.V_ARTICLE;
        }

        public void chargerFournisseurs()
        {

            FOURNISSEUR.Clear();
            FOURNISSEUR.Merge(CLIENT_APP_PARAM.gcws.SELECT_ALL_FOURNISSEURS());

            bsFournisseur.DataSource = FOURNISSEUR;
        }

        public void chargerCategories()
        {
            Application.DoEvents();
            CATEGORIE.Clear();
            CATEGORIE.Merge(CLIENT_APP_PARAM.gcws.SELECT_ALL_CATEGORIE());

            bsCategorie.DataSource = CATEGORIE;
        }

        public void chargerMarques()
        {
            Application.DoEvents();
            MARQUE.Clear();
            MARQUE.Merge(CLIENT_APP_PARAM.gmarque.getListeMarque());
            bsMarque.DataSource = MARQUE;
        }

        public void chargerFamilles()
        {
            Application.DoEvents();
            FAMILLE.Clear();
            FAMILLE.Merge(CLIENT_APP_PARAM.gfamilleArticle.getListeFamilleArticle());
            bsFamille.DataSource = FAMILLE;
        }

        public void chargerMagasins()
        {
            Application.DoEvents();
            MAGAZIN.Clear();
            MAGAZIN.Merge(CLIENT_APP_PARAM.gcws.SELECT_ALL_MAGAZIN());
            bsMagasin.DataSource = MAGAZIN;
        }

        public void chargerClients()
        {
            Application.DoEvents();
            CLIENT.Clear();
            CLIENT.Merge(CLIENT_APP_PARAM.gcws.SELECT_ALL_CLIENTS());
            bsClient.DataSource = CLIENT;
        }

        public void chargerSociete()
        {
            Application.DoEvents();
            SOCIETE.Clear();
            SOCIETE.Merge(CLIENT_APP_PARAM.gcws.LOAD_CONFIG_SOCIETE());
            bsSociete.DataSource = SOCIETE;
        }

        public void dsInitialize()
        {
            bsArticle = new BindingSource();
            bsCategorie = new BindingSource();
            bsClient = new BindingSource();

            bsFournisseur = new BindingSource();
            bsMagasin = new BindingSource();
            bsMarque = new BindingSource();
            bsClient = new BindingSource();
            bsFamille = new BindingSource();
            bsTVA = new BindingSource();
            bsUnite = new BindingSource();
            bsSociete = new BindingSource();


            chargerSociete();
            chargerArticles();
            chargerFournisseurs();
            chargerMagasins();
            chargerMarques();
            chargerCategories();
            chargerFamilles();
            chargerClients();
            chargerTVA();
            chargerUnite();

        }
    }
}
