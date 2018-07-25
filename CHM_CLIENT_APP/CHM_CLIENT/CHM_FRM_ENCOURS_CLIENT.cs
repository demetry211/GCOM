using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CHM_CLIENT_APP.Properties;

namespace CHM_CLIENT_APP.CHM_CLIENT
{
    public partial class CHM_FRM_ENCOURS_CLIENT : Form
    {
        public CHM_FRM_ENCOURS_CLIENT()
        {
            InitializeComponent();

            entete_Formulaire_21.btn_refresh.Click += new EventHandler(btn_refresh_Click);
            chM_CMP_CONTROL1.btn_afficher.Text = "Imprimer Liste";
            chM_CMP_CONTROL1.btn_afficher.Image = Resources.Preview_32x32;
            chM_CMP_CONTROL1.btn_afficher.Click += new EventHandler(btn_afficher_Click);
            chM_CMP_CONTROL1.btn_ajout.Visible = false;
            chM_CMP_CONTROL1.btn_modifier.Visible = false;
            chM_CMP_CONTROL1.btn_supprimer.Visible = false;
            chargerListe();
        }

        void btn_afficher_Click(object sender, EventArgs e)
        {
            try
            {
                gridView12.OptionsView.ShowViewCaption = true;
                gridView12.ViewCaption = "Liste des encours client";
                gcEncours.ViewCollection[0].ShowPrintPreview();
                gridView12.OptionsView.ShowViewCaption = false;
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, this.Text);
            }
            
        }

        void btn_refresh_Click(object sender, EventArgs e)
        {
            chargerListe();
        }

        private void chargerListe()
        {
            try
            {
                dS_MOUV1.V_ENCOURS_VENTE.Clear();
                dS_MOUV1.V_ENCOURS_VENTE.Merge(CLIENT_APP_PARAM.gcws.select_encoursVente());
            }
            catch (Exception er)
            {
                MessageBox.Show(string.Format("Erreur lors du chargement des détails.\n{0}", er.Message), this.Text);
            }
        }
    }
}
