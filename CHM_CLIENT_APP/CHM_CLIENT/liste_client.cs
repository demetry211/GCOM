using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CHM_CLIENT_APP
{
    public partial class liste_client : Form
    {
        public delegate void Selection(decimal codeClient);
        public event Selection OnSelect;
        DataTable dt;
        BindingSource srcb = new BindingSource();
        string Mode = string.Empty;

        public liste_client(string mode )
        {
            InitializeComponent();

            srcb = CLIENT_APP_PARAM.ds_param.bsClient;
            gridControl1.DataSource = srcb;

            Mode = mode;
            switch (Mode)
            {
                case "s":
                    chM_CMP_CONTROL1.btn_afficher.Text = "Sélectionner";
                    chM_CMP_CONTROL1.btn_afficher.Click += new EventHandler(selection);
                    break;
                case "l":
                    chM_CMP_CONTROL1.btn_afficher.Click += new EventHandler(client_to_form_Click);
                    break;
            }

            entete_Formulaire_21.btn_refresh.Click += new EventHandler(btn_refresh_Click);
            chM_CMP_CONTROL1.btn_ajout.Click += new EventHandler(CMS_NV_CLT_Click);
            chM_CMP_CONTROL1.btn_modifier.Click += new EventHandler(CMS_MODIFIER_CLT_Click);
            chM_CMP_CONTROL1.btn_supprimer.Click += new EventHandler(CMS_SUPP_CLT_Click);
        }

        void selection(object sender, EventArgs e)
        {
            if (OnSelect != null)
                OnSelect((decimal)(srcb.Current as DataRowView)["CODE_CLIENT"]);
            Close();
        }

        void btn_refresh_Click(object sender, EventArgs e)
        {
            CLIENT_APP_PARAM.ds_param.chargerClients();
        }

        
        private void liste_client_Shown(object sender, EventArgs e)
        {
            try
            {
                Application.DoEvents();
                if(CLIENT_APP_PARAM.ds_param.CLIENT.Rows.Count==0)
                    CLIENT_APP_PARAM.ds_param.chargerClients();

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Connexion serveur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void client_to_form_Click(object sender, EventArgs e)
        {
            CHM_FICHE_CLIENT fiche = new CHM_FICHE_CLIENT(CLIENT_APP_PARAM.ds_param.bsClient);
            fiche.StartPosition = FormStartPosition.CenterScreen;
            fiche.ShowDialog();
            //this.Close();
        }

        private void CMS_NV_CLT_Click(object sender, EventArgs e)
        {
            CHM_NOUVEAU_CLIENT nv_clt = new CHM_NOUVEAU_CLIENT("-1");
            nv_clt.ENREG_EV += new CHM_NOUVEAU_CLIENT.ENREG_DEL(nv_clt_ENREG_EV);
            nv_clt.ShowDialog();

        }

        void nv_clt_ENREG_EV(DataRowView client, bool type_ev)
        {
            //if (type_ev == true)
            //    srcb.AddNew();

            //DataRowView drv = (DataRowView)srcb.Current;
            //drv["CODE_CLIENT"] = client["CODE_CLIENT"];
            //drv["REF_CLIENT"] = client["REF_CLIENT"];
            //drv["RS_CLIENT"] = client["RS_CLIENT"];
            //drv["ADRESSE_CLIENT"] = client["ADRESSE_CLIENT"];
            //drv["CP_CLIENT"] = client["CP_CLIENT"];
            //drv["TEL_CLIENT"] = client["TEL_CLIENT"];
            //drv["FAX_CLIENT"] = client["FAX_CLIENT"];
            //drv["EMAIL_CLIENT"] = client["EMAIL_CLIENT"];
            //drv["EXO_CLIENT"] = client["EXO_CLIENT"];
            //drv["ATTEST_EXO_CLIENT"] = client["ATTEST_EXO_CLIENT"];
            //drv["CODE_DOUANE_CLIENT"] = client["CODE_DOUANE_CLIENT"];
            //drv["CODE_TVA_CLIENT"] = client["CODE_TVA_CLIENT"];
            //drv["ETAT_CLIENT"] = client["ETAT_CLIENT"];
            //drv["MAX_CREDIT"] = client["MAX_CREDIT"];
            //srcb.EndEdit();
            //dt.AcceptChanges();
        }

        
        private void CMS_MODIFIER_CLT_Click(object sender, EventArgs e)
        {
            if (srcb.Current != null)
            {
                DataRowView drv = (DataRowView)srcb.Current;
                CHM_NOUVEAU_CLIENT nv_clt = new CHM_NOUVEAU_CLIENT(drv["CODE_CLIENT"].ToString());
                nv_clt.ENREG_EV += new CHM_NOUVEAU_CLIENT.ENREG_DEL(nv_clt_ENREG_EV);
                nv_clt.ShowDialog();
            }
        }

        
        private void CMS_SUPP_CLT_Click(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)srcb.Current;
            //DataTable dt1 = CLIENT_APP_PARAM.GEST.P_CLIENT.select_b_liv_client(drv["CODE_CLIENT"].ToString());
            //DataTable dt2 = CLIENT_APP_PARAM.GEST.P_CLIENT.SELECT_COMMANDE_CLIENT(drv["CODE_CLIENT"].ToString());
            //DataTable dt3 = CLIENT_APP_PARAM.GEST.P_CLIENT.select_facture(drv["CODE_CLIENT"].ToString());
            DataTable dt1 = CLIENT_APP_PARAM.gcws.select_b_liv_client(drv["CODE_CLIENT"].ToString());
            DataTable dt2 = CLIENT_APP_PARAM.gcws.SELECT_COMMANDE_CLIENT(drv["CODE_CLIENT"].ToString());
            DataTable dt3 = CLIENT_APP_PARAM.gcws.select_facture(drv["CODE_CLIENT"].ToString());
            if (dt1.Rows.Count > 0 || dt2.Rows.Count > 0 || dt3.Rows.Count > 0)
            {
                MessageBox.Show("Vous ne pouvez pas supprimer ce client .");
            }
            else
            {
                //CHM_GESTION_COMERCIALE.RESULT_QUERY res = new CHM_GESTION_COMERCIALE.RESULT_QUERY();
                CHMGC.RESULT_QUERY res = new CHM_CLIENT_APP.CHMGC.RESULT_QUERY();
                if (srcb.Current != null)
                {
                    if (MessageBox.Show("Etes vous sûres de supprimer ce client?", "Confirmation de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        try
                        {

                            //res = CLIENT_APP_PARAM.GEST.P_CLIENT.DELETE_CLIENT(drv["CODE_CLIENT"].ToString());
                            res = CLIENT_APP_PARAM.gcws.DELETE_CLIENT(drv["CODE_CLIENT"].ToString());
                            if (res.OK)
                            {
                                srcb.RemoveCurrent();
                                (srcb.DataSource as DataTable).AcceptChanges();
                            }
                            else
                                MessageBox.Show(res.MESSAGE, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        catch (Exception er)
                        {
                            MessageBox.Show(er.Message, "Connection error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void MENU_CLIENT_Opening(object sender, CancelEventArgs e)
        {
            CMS_SUPP_CLT.Enabled = true;
            CMS_MODIFIER_CLT.Enabled = true;
            CMS_IMPRIMER_CLT.Enabled = true;
            CMS_STATISTIQUE_CLT.Enabled = true;
            if (srcb.Current == null)
            {
                CMS_MODIFIER_CLT.Enabled = false;
                CMS_SUPP_CLT.Enabled = false;
                CMS_IMPRIMER_CLT.Enabled = false;
                CMS_STATISTIQUE_CLT.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listeCommandesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (srcb.Current != null)
            {
                DataRowView drv = (DataRowView)srcb.Current;
                CHM_LISTE_COMMANDE nv_clt = new CHM_LISTE_COMMANDE(3, drv["CODE_CLIENT"].ToString());
                nv_clt.ShowDialog();
            }
        }

        private void listeFacturesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (srcb.Current != null)
            {
                DataRowView drv = (DataRowView)srcb.Current;
                CHM_LISTE_FACTURES l = new CHM_LISTE_FACTURES(3, drv["CODE_CLIENT"].ToString());
                l.ShowDialog();
            }
        }

        private void liste_client_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                btn_refresh_Click(null, null);
            }
            if (e.KeyCode == Keys.Escape)
                Close();
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            chM_CMP_CONTROL1.btn_afficher.PerformClick();  
        }

    }
}
