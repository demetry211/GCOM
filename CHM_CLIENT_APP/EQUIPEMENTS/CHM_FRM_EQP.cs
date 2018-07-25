using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CHM_CLIENT_APP.CHMGC;
using CHM_CLIENT_APP.EQUIPEMENTS.TYPE_MAINTENANCE;

namespace CHM_CLIENT_APP.EQUIPEMENTS
{
    public partial class CHM_FRM_EQP : Form
    {
        BindingSource bsEqp;
        public delegate void Equipement(DEQUIPEMENT eqp, bool validation);
        public event Equipement OnMaj;
        bool valide = false;
        DEQUIPEMENT equipement = new DEQUIPEMENT();

        int mode;
        public CHM_FRM_EQP(BindingSource bs)
        {
            InitializeComponent();
            bsEqp = bs;
            mode = 1;
            txt_REF_CLIENT.DataBindings.Add("Text", bsEqp, "REF_CLIENT", true);
            txt_REF_CLIENT.DataBindings.Add("Tag", bsEqp, "CODE_CLIENT", true);
            txt_RS_CLIENT.DataBindings.Add("Text", bsEqp, "RS_CLIENT", true);
            txtFabriquant.DataBindings.Add("Text", bsEqp, "FABRIQUANT", true);
            txtLibelle.DataBindings.Add("Text", bsEqp, "LIBELLE_EQP", true);
            txtSerie.DataBindings.Add("Text", bsEqp, "NUM_SERIE", true);
            lbAdresseClient.DataBindings.Add("Text", bsEqp, "ADRESSE_CLIENT", true);
            lbCode.DataBindings.Add("Text", bsEqp, "CODE_EQP", true);
            dtpDateFabrication.DataBindings.Add("Value", bsEqp, "DATE_FAB_EQP", true);
            dtpDateService.DataBindings.Add("Value", bsEqp, "DATE_MISE_SERVICE_EQP", true);
            lbCodeTVAClient.DataBindings.Add("Text", bsEqp, "CODE_TVA_CLIENT", true);
            bsEqp.PositionChanged += new EventHandler(bsEqp_PositionChanged);
            bsEqp_PositionChanged(null, null);
            chM_CMP_VALIDATION1.button1.Click += new EventHandler(button1_Click);
            chM_CMP_VALIDATION1.button2.Click += new EventHandler(Fermeture);
            chM_CMP_FICHE1.btn_dernier.Click += new EventHandler(btn_dernier_Click);
            chM_CMP_FICHE1.btn_precedent.Click += new EventHandler(btn_precedent_Click);
            chM_CMP_FICHE1.btn_premier.Click += new EventHandler(btn_premier_Click);
            chM_CMP_FICHE1.btn_suivant.Click += new EventHandler(btn_suivant_Click);
            chM_CMP_FICHE1.button1.Visible = false;
            entete_Formulaire_21.btn_refresh.Visible = false;
        }

        void bsEqp_PositionChanged(object sender, EventArgs e)
        {
            if (bsEqp.Current != null)
            {
                DataRowView drv = (DataRowView)bsEqp.Current;
                if (drv["CODE_EQP"].ToString().Trim() != string.Empty)
                {
                    this.Text = entete_Formulaire_21.windows_name.Text = "Nouvel équipement";
                }
                else
                {
                    this.Text = entete_Formulaire_21.windows_name.Text = string.Format("Fiche équipement {0} {1}", drv["CODE_EQP"], drv["LIBELLE_EQP"]);
                }
            }
        }

        public CHM_FRM_EQP()
        {
            InitializeComponent();
            mode = 0;
            bsEqp = new BindingSource();
            bsEqp.DataSource = dS_MOUV1.V_EQUIPEMENT;
            bsEqp.PositionChanged+=new EventHandler(bsEqp_PositionChanged);
            bsEqp.AddNew();
            txt_REF_CLIENT.DataBindings.Add("Text", bsEqp, "REF_CLIENT", true);
            txt_REF_CLIENT.DataBindings.Add("Tag", bsEqp, "CODE_CLIENT", true);
            txt_RS_CLIENT.DataBindings.Add("Text", bsEqp, "RS_CLIENT", true);
            txtFabriquant.DataBindings.Add("Text", bsEqp, "FABRIQUANT", true);
            txtLibelle.DataBindings.Add("Text", bsEqp, "LIBELLE_EQP", true);
            txtSerie.DataBindings.Add("Text", bsEqp, "NUM_SERIE", true);
            lbAdresseClient.DataBindings.Add("Text", bsEqp, "ADRESSE_CLIENT", true);
            lbCode.DataBindings.Add("Text", bsEqp, "CODE_EQP", true);
            dtpDateFabrication.DataBindings.Add("Value", bsEqp, "DATE_FAB_EQP", true);
            dtpDateService.DataBindings.Add("Value", bsEqp, "DATE_MISE_SERVICE_EQP", true);
            lbCodeTVAClient.DataBindings.Add("Text", bsEqp, "CODE_TVA_CLIENT", true);

            chM_CMP_VALIDATION1.button1.Click += new EventHandler(button1_Click);
            chM_CMP_VALIDATION1.button2.Click += new EventHandler(Fermeture);
            entete_Formulaire_21.btn_refresh.Visible = false;
            bsEqp_PositionChanged(null, null);
        }

        void Fermeture(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes vous sûres d'annuler l'opération?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                Close();
        }

        void button1_Click(object sender, EventArgs e)
        {
            #region Verfification champs
            errorProvider1.SetError(PARCOURIR_LISTE_CLIENT, "");
            if (txt_REF_CLIENT.Text.Trim() == string.Empty)
            {
                errorProvider1.SetError(PARCOURIR_LISTE_CLIENT, "Veuillez sélectioner le client propriétaire de l'équipement!");
                PARCOURIR_LISTE_CLIENT.Focus();
                return;
            }
            errorProvider1.Clear();

            errorProvider1.SetError(txtLibelle, "");
            if (txtLibelle.Text.Trim() == string.Empty)
            {
                errorProvider1.SetError(txtLibelle, "Veuillez saisir un libellé pour l'équipement!");
                txtLibelle.Focus();
                return;
            }
            errorProvider1.Clear();
            #endregion

            if (mode == 0)
            {
                equipement = new DEQUIPEMENT();
                equipement.CODE_CLIENT = (decimal)txt_REF_CLIENT.Tag;
                equipement.DATE_FAB_EQP = dtpDateFabrication.Value;
                equipement.DATE_MISE_SERVICE_EQP = dtpDateService.Value;
                equipement.FABRIQUANT = txtFabriquant.Text;
                equipement.LIBELLE_EQP = txtLibelle.Text;
                equipement.NUM_SERIE = txtSerie.Text;

                try
                {
                    CLIENT_APP_PARAM.gcws.ajouteEQUIPEMENT(equipement);
                    MessageBox.Show("Equipement enregistré avec succes.");
                    valide = true;
                    Close();
                }
                catch (Exception er)
                {
                    valide = false;
                    MessageBox.Show(er.Message, this.Text);
                    return;
                }
            }
            else
            {
                equipement = new DEQUIPEMENT();
                equipement.CODE_EQP = Convert.ToDecimal( lbCode.Text);
                equipement.CODE_CLIENT = (decimal)txt_REF_CLIENT.Tag;
                equipement.DATE_FAB_EQP = dtpDateFabrication.Value;
                equipement.DATE_MISE_SERVICE_EQP = dtpDateService.Value;
                equipement.FABRIQUANT = txtFabriquant.Text;
                equipement.LIBELLE_EQP = txtLibelle.Text;
                equipement.NUM_SERIE = txtSerie.Text;

                try
                {
                    CLIENT_APP_PARAM.gcws.modifieEQUIPEMENT(equipement);
                    MessageBox.Show("Equipement enregistré avec succes.");
                    valide = true;
                    Close();
                }
                catch (Exception er)
                {
                    valide = false;
                    MessageBox.Show(er.Message, this.Text);
                    return;
                }
            }
        }

        

        private void PARCOURIR_LISTE_CLIENT_Click(object sender, EventArgs e)
        {
            CHM_COMMANDE_CLIENT c_clt = new CHM_COMMANDE_CLIENT();
            c_clt.client_selection_event += new CHM_COMMANDE_CLIENT.client_selection(c_clt_client_selection_event);
            c_clt.ShowDialog();
        }

        void c_clt_client_selection_event(DCLIENT client)
        {
            txt_REF_CLIENT.Text = client.REF_CLIENT;
            txt_REF_CLIENT.Tag = client.CODE_CLIENT;
            txt_RS_CLIENT.Text = client.RS_CLIENT;
            lbAdresseClient.Text = client.ADRESSE_CLIENT;
            lbCodeTVAClient.Text = client.CODE_TVA_CLIENT;
        }


        void btn_suivant_Click(object sender, EventArgs e)
        {
            bsEqp.MoveNext();
        }

        void btn_premier_Click(object sender, EventArgs e)
        {
            bsEqp.MoveFirst();
        }

        void btn_precedent_Click(object sender, EventArgs e)
        {
            bsEqp.MovePrevious();
        }

        void btn_dernier_Click(object sender, EventArgs e)
        {
            bsEqp.MoveLast();
        }

        private void CHM_FRM_EQP_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(OnMaj!=null)
                OnMaj(equipement, valide);
            bsEqp.PositionChanged -= bsEqp_PositionChanged;
        }

        
    }
}
