using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CHM_CLIENT_APP.CHMGC;

namespace CHM_CLIENT_APP
{
    public partial class CHM_COMMANDE_CLIENT : Form
    {
        DataTable dt;
        BindingSource srcb = new BindingSource();
        public  delegate void client_selection(DCLIENT client) ;
        public event client_selection client_selection_event;
        public CHM_COMMANDE_CLIENT()
        {
            InitializeComponent();
            dt = new DataTable();
            srcb.DataSource = dt;
            dgv_liste_clt.DataSource = srcb;
        }

        private void CHM_COMMANDE_CLIENT_Shown(object sender, EventArgs e)
        {
            dgv_liste_clt.AutoGenerateColumns = false;
            try
            {
                Application.DoEvents();
                //dt = CLIENT_APP_PARAM.GEST.P_CLIENT.SELECT_ALL_CLIENTS();
                dt = CLIENT_APP_PARAM.gcws.SELECT_ALL_CLIENTS();
                srcb.DataSource = dt;
                dgv_liste_clt.DataSource = srcb;

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Connexion serveur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TB_RECHERCHE_CLT_TextChanged(object sender, EventArgs e)
        {
            

            try
            {
                //dgv_liste_clt.DataSource = CLIENT_APP_PARAM.GEST.P_CLIENT.SEARCH_CLIENT(TB_RECHERCHE_CLT.Text);
                srcb.DataSource = CLIENT_APP_PARAM.gcws.SEARCH_CLIENT(TB_RECHERCHE_CLT.Text);
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Connexion serveur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_selection_Click(object sender, EventArgs e)
        {
            DCLIENT client = new DCLIENT();
            if (srcb.Current != null)
            {
                DataRowView drv = (DataRowView)srcb.Current;
                if (client_selection_event != null)
                {
                    client.CODE_CLIENT = (decimal)drv["CODE_CLIENT"];
                    client = CLIENT_APP_PARAM.gcws.obtenirInstanceCLIENT(client);
                    client_selection_event(client);
                }
                this.Close();
            }
        }

        private void buttonFERMER_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_liste_clt_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DCLIENT client = new DCLIENT();
            if (srcb.Current != null)
            {
                DataRowView drv = (DataRowView)srcb.Current;
                if (client_selection_event != null)
                {
                    client.CODE_CLIENT = (decimal)drv["CODE_CLIENT"];
                    client = CLIENT_APP_PARAM.gcws.obtenirInstanceCLIENT(client);
                    client_selection_event(client);
                }
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CHM_NOUVEAU_CLIENT nv = new CHM_NOUVEAU_CLIENT("-1");
            nv.ENREG_EV += new CHM_NOUVEAU_CLIENT.ENREG_DEL(nv_ENREG_EV);
            nv.ShowDialog();
        }

        void nv_ENREG_EV(DataRowView client, bool type_ev)
        {
            if (type_ev == true)
                srcb.AddNew();

            DataRowView drv = (DataRowView)srcb.Current;
            drv["CODE_CLIENT"] = client["CODE_CLIENT"];
            drv["REF_CLIENT"] = client["REF_CLIENT"];
            drv["RS_CLIENT"] = client["RS_CLIENT"];
            drv["ADRESSE_CLIENT"] = client["ADRESSE_CLIENT"];
            drv["CP_CLIENT"] = client["CP_CLIENT"];
            drv["TEL_CLIENT"] = client["TEL_CLIENT"];
            drv["FAX_CLIENT"] = client["FAX_CLIENT"];
            drv["EMAIL_CLIENT"] = client["EMAIL_CLIENT"];
            drv["EXO_CLIENT"] = client["EXO_CLIENT"];
            drv["ATTEST_EXO_CLIENT"] = client["ATTEST_EXO_CLIENT"];
            drv["CODE_DOUANE_CLIENT"] = client["CODE_DOUANE_CLIENT"];
            drv["CODE_TVA_CLIENT"] = client["CODE_TVA_CLIENT"];
            drv["ETAT_CLIENT"] = client["ETAT_CLIENT"];
            drv["MAX_CREDIT"] = client["MAX_CREDIT"];
            srcb.EndEdit();
            dt.AcceptChanges();
            dgv_liste_clt.Focus();
        }

    }
}
