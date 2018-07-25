using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CHM_CLIENT_APP
{
    public partial class CHM_COMPTE_CREDIT_CLIENT : Form
    {
        string CODE_CLIENT = "";
        public CHM_COMPTE_CREDIT_CLIENT(string CODE_CLIENT)
        {
            InitializeComponent();
            this.CODE_CLIENT = CODE_CLIENT;
        }
        DataTable dt;
        BindingSource bs = new BindingSource();
        DataTable dt_clt;
        BindingSource bs_clt = new BindingSource();
        string CODE_COMPTE = "";
        private void CHM_COMPTE_CREDIT_CLIENT_Shown(object sender, EventArgs e)
        {
            try
            {
                //CLIENT_APP_PARAM.GEST.P_COMPTE_CLIENT.actualiser_compte(CODE_CLIENT);
                if (CODE_CLIENT == null || CODE_CLIENT == string.Empty)
                    throw new Exception("Code client invalid!");
                CLIENT_APP_PARAM.gcws.actualiser_compte(CODE_CLIENT);
                //dt = CLIENT_APP_PARAM.GEST.P_COMPTE_CLIENT.LOAD_COMPTE_CLIENT(CODE_CLIENT);
                dt = CLIENT_APP_PARAM.gcws.LOAD_COMPTE_CLIENT(CODE_CLIENT);
                bs.DataSource = dt;
                bs.MoveFirst();
                if (bs.Current != null)
                {
                    DataRowView drv = (DataRowView)bs.Current;
                    CODE_COMPTE = drv["CODE_COMPTE_CLIENT"].ToString();
                    NUM_COMPTE.Text = drv["NUM_COMPTE_CLIENT"].ToString();
                    CREDIT.Text = drv["TOTAl_CREDIT_CLT"].ToString();
                    PAYE.Text = drv["TOTAL_PAYE_CLT"].ToString();
                }
                //dt_clt = CLIENT_APP_PARAM.GEST.P_CLIENT.LOAD_CLIENT(CODE_CLIENT);
                dt_clt = CLIENT_APP_PARAM.gcws.LOAD_CLIENT(CODE_CLIENT);
                bs_clt.DataSource = dt_clt;
                DataRowView dr = (DataRowView)bs_clt.Current;
                CLIENT.Text = dr["RS_CLIENT"].ToString();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, this.Text);
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_FERME_Click(object sender, EventArgs e)
        {
            if (CODE_COMPTE != "")
            {
                CHM_SUIVI_REGLEMENT_CLIENT f = new CHM_SUIVI_REGLEMENT_CLIENT(CODE_COMPTE);
                f.ShowDialog();
            }
        }

        private void CHM_COMPTE_CREDIT_CLIENT_Load(object sender, EventArgs e)
        {

        }
    }
}
