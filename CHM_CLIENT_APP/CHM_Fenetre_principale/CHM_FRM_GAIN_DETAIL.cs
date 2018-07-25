using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CHM_CLIENT_APP.CHM_Fenetre_principale
{
    public partial class CHM_FRM_GAIN_DETAIL : Form
    {
        DataTable _dt_liste_gain;
        BindingSource _bs_liste_gain = new BindingSource();
        DataTable dt_retour;
        BindingSource bs_retour = new BindingSource();


        public CHM_FRM_GAIN_DETAIL()
        {
            InitializeComponent();
            dgv_retour.AutoGenerateColumns = false;
            dgv_liste.AutoGenerateColumns = false;
        }

        private void dtp_du_ValueChanged(object sender, EventArgs e)
        {
            if (dtp_du.Value > dtp_au.Value)
            {
                dtp_du.Value = dtp_au.Value;
            }
            calcul();
        }

        private void dtp_au_ValueChanged(object sender, EventArgs e)
        {
            if (dtp_du.Value > dtp_au.Value)
            {
                dtp_du.Value = dtp_au.Value;
            }
            calcul();
        }

        private void calcul()
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                //_dt_liste_gain = CLIENT_APP_PARAM.GEST.P_FACTURE.LOAD_GAIN_DETAIL(dtp_du.Value, dtp_au.Value);
                _dt_liste_gain = CLIENT_APP_PARAM.gcws.LOAD_GAIN_DETAIL(dtp_du.Value, dtp_au.Value);
                _bs_liste_gain.DataSource = _dt_liste_gain;
                //dt_retour = CLIENT_APP_PARAM.GEST.P_FACTURE.LOAD_qte_retour(dtp_du.Value, dtp_au.Value);
                dt_retour = CLIENT_APP_PARAM.gcws.LOAD_qte_retour(dtp_du.Value, dtp_au.Value);
                bs_retour.DataSource = dt_retour;

                decimal total_perte = 0;
                foreach (DataRowView drv_retour in bs_retour)
                {
                    total_perte += (decimal)drv_retour["total_p"];                    
                }

                dgv_retour.DataSource = bs_retour;
                _bs_liste_gain.DataSource = _dt_liste_gain;
                dgv_liste.DataSource = _bs_liste_gain;
                decimal somme = 0;
                foreach (DataRow dr in _dt_liste_gain.Rows)
                {
                    somme += (decimal)dr["total_g"];
                }

                lb_vente.Value = somme;
                lb_retour.Value = total_perte;
                lb_gain.Value = somme-total_perte;
                Cursor = Cursors.Default;
            }
            catch (Exception er)
            {
                Cursor = Cursors.Default;
                MessageBox.Show(er.Message, this.Text);
            }
        }

        private void CHM_FRM_GAIN_DETAIL_Load(object sender, EventArgs e)
        {
            calcul();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}