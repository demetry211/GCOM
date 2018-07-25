using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CHM_CLIENT_APP
{
    public partial class CHM_SUIVI_REGLEMENT_CLIENT : Form
    {
        string CODE_COMPTE_CLIENT = "-1";
        string code_compte = "";
        public CHM_SUIVI_REGLEMENT_CLIENT(string CODE_COMPTE_CLIENT)
        {
            InitializeComponent();
            this.CODE_COMPTE_CLIENT = CODE_COMPTE_CLIENT;

        }
        DataTable dt;
        BindingSource bs = new BindingSource();
        DataTable dt_compte;
        BindingSource bs_compte = new BindingSource();
        DataTable dt_client;
        BindingSource bs_client = new BindingSource();
        private void CHM_SUIVI_REGLEMENT_CLIENT_Shown(object sender, EventArgs e)
        {
            if (CODE_COMPTE_CLIENT != "-1")
            {
                dgv_Liste_reglement.AutoGenerateColumns = false;
                //dt_compte = CLIENT_APP_PARAM.GEST.P_COMPTE_CLIENT.LOAD_COMPTE(CODE_COMPTE_CLIENT);
                dt_compte = CLIENT_APP_PARAM.gcws.LOAD_COMPTE(CODE_COMPTE_CLIENT);
                bs_compte.DataSource = dt_compte;
                if (bs_compte.Current != null)
                {
                    DataRowView drv_compte = (DataRowView)bs_compte.Current;
                    entete_Formulaire_21.windows_name.Text = "Suivi règlement du compte N° :" + drv_compte["NUM_COMPTE_CLIENT"].ToString();
                    //dt_client = CLIENT_APP_PARAM.GEST.P_CLIENT.LOAD_CLIENT(drv_compte["CODE_CLIENT"].ToString());
                    dt_client = CLIENT_APP_PARAM.gcws.LOAD_CLIENT(drv_compte["CODE_CLIENT"].ToString());
                    bs_client.DataSource = dt_client;
                    DataRowView drv_client = (DataRowView)bs_client.Current;
                    REF_CLIENT.Text = drv_client["REF_CLIENT"].ToString();
                    RS_CLIENT.Text = drv_client["RS_CLIENT"].ToString();

                    //dt = CLIENT_APP_PARAM.GEST.P_REGLEMENT.SELECT_REGLEMENT_CLIENT(CODE_COMPTE_CLIENT);
                    dt = CLIENT_APP_PARAM.gcws.SELECT_REGLEMENT_CLIENT(CODE_COMPTE_CLIENT);
                    bs.DataSource = dt;
                    dgv_Liste_reglement.DataSource = bs;
                }
            }
            if (CODE_COMPTE_CLIENT == "ALL")
            {
                //dt = CLIENT_APP_PARAM.GEST.P_REGLEMENT.SELECT_ALL_REGLEMENT();
                dt = CLIENT_APP_PARAM.gcws.SELECT_ALL_REGLEMENT();
                bs.DataSource = dt;
                dgv_Liste_reglement.DataSource = bs;
            }
        }
        int mois;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (REF_CLIENT.Text != "" && RS_CLIENT.Text != "" && code_compte != "")
            {
                mois = (int)DATE_REG.SelectedIndex + 1;
                //dt = CLIENT_APP_PARAM.GEST.P_REGLEMENT.recherche_reglement_par_date(mois.ToString(), code_compte);
                dt = CLIENT_APP_PARAM.gcws.recherche_reglement_par_date(mois.ToString(), code_compte);
                bs.DataSource = dt;
                dgv_Liste_reglement.DataSource = bs;
            }
            if (REF_CLIENT.Text == "" && RS_CLIENT.Text == "")
            {
                mois = (int)DATE_REG.SelectedIndex + 1;
                //dt = CLIENT_APP_PARAM.GEST.P_REGLEMENT.recherche_reglement_par_date(mois.ToString(), code_compte);
                dt = CLIENT_APP_PARAM.gcws.recherche_reglement_par_date(mois.ToString(), code_compte);
                bs.DataSource = dt;
                dgv_Liste_reglement.DataSource = bs;
            }

        }

    }
}
