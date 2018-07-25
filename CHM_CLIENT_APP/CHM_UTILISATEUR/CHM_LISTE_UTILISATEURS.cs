using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CHM_CLIENT_APP
{
    public partial class CHM_LISTE_UTILISATEURS : Form
    {
        
        BindingSource srcb = new BindingSource();

        public CHM_LISTE_UTILISATEURS()
        {
            InitializeComponent();

            srcb.DataSource = dS_MOUV1.UTILISATEUR;
            gridControl1.DataSource = srcb;


            pictureEdit1.DataBindings.Add("Image", srcb, "PHOTO_USER", true);

            srcb.PositionChanged += new EventHandler(srcb_PositionChanged);

            chargerListe();

            entete_Formulaire_21.btn_refresh.Click += new EventHandler(btn_refresh_Click);
            chM_CMP_CONTROL1.btn_ajout.Click += new EventHandler(btn_ajout_Click);
            chM_CMP_CONTROL1.btn_modifier.Click += new EventHandler(btn_modifier_Click);
            chM_CMP_CONTROL1.btn_supprimer.Click += new EventHandler(btn_supprimer_Click);
        }

        void btn_supprimer_Click(object sender, EventArgs e)
        {
            if (srcb.Current != null)
            {
                if (MessageBox.Show("Voulez vous confirmer la supression ?", "Supression", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    CHM_GESTION_COMERCIALE.RESULT_QUERY res;
                    try
                    {
                        DataRowView drv = (DataRowView)srcb.Current;
                        Application.DoEvents();
                        res = CLIENT_APP_PARAM.GEST.P_UTILISATEUR.DELETE_UTILISATEUR(drv["CODE_USER"].ToString());
                        if (res.OK)
                        {
                            srcb.RemoveCurrent();
                            (srcb.DataSource as DataTable).AcceptChanges();
                        }
                        else
                            MessageBox.Show(res.MESSAGE, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception er)
                    {
                        MessageBox.Show(er.Message, "Connexion serveur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        void btn_modifier_Click(object sender, EventArgs e)
        {
            if (srcb.Current != null)
            {
                DataRowView drv = (DataRowView)srcb.Current;
                CHM_NV_UTILISATEUR fiche = new CHM_NV_UTILISATEUR(drv["CODE_USER"].ToString());
                fiche.ENREG_EV += new CHM_NV_UTILISATEUR.ENREG_DELEG(fiche_ENREG_EV);
                fiche.ShowDialog();
            }
        }

        void btn_ajout_Click(object sender, EventArgs e)
        {
            CHM_NV_UTILISATEUR fiche = new CHM_NV_UTILISATEUR("-1");
            fiche.ENREG_EV += new CHM_NV_UTILISATEUR.ENREG_DELEG(fiche_ENREG_EV);
            fiche.ShowDialog();
        }

        void btn_refresh_Click(object sender, EventArgs e)
        {
            chargerListe();
        }

        void srcb_PositionChanged(object sender, EventArgs e)
        {
            
        }

        private void chargerListe()
        {
            try
            {
                dS_MOUV1.UTILISATEUR.Clear();
                dS_MOUV1.UTILISATEUR.Merge(CLIENT_APP_PARAM.gcws.SELECT_ALL_UTILISATEUR());
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
            
        }

        
        

        

        void fiche_ENREG_EV(DataRowView user, bool type_ev)
        {
            if (type_ev)
            {
                srcb.AddNew();
                DataRowView drv = (DataRowView)srcb.Current;
                drv["CODE_USER"] = user["CODE_USER"];
                drv["NOM_USER"] = user["NOM_USER"];
                drv["PRENOM_USER"] = user["PRENOM_USER"];
                drv["PHOTO_USER"] = user["PHOTO_USER"];
                drv["LOGIN_USER"] = user["LOGIN_USER"];
                drv["PASSWORD_USER"] = user["PASSWORD_USER"];
                drv["ETAT_USER"] = user["ETAT_USER"];
                drv["CODE_SOCIETE"] = user["CODE_SOCIETE"];
                drv["CODE_FONCTION_USER"] = user["CODE_FONCTION_USER"];
                srcb.EndEdit();
                (srcb.DataSource as DataTable).AcceptChanges();
            }
        }

        

        

    }
}
