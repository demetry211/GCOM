using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CHM_CLIENT_APP.CHM_STOCK
{
    public partial class CHM_FRM_RUPTURE_STOCK : Form
    {

        DataTable _dt_source ;
        BindingSource _bs_source = new BindingSource();
        public CHM_FRM_RUPTURE_STOCK()
        {
            InitializeComponent();
            chargerListe();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void chargerListe()
        {
            try
            {
                _dt_source = CLIENT_APP_PARAM.gcstat.SELECT_DETAIL_ARTICLE_EN_RUPTURE_STOCK();
                _bs_source.DataSource = _dt_source;
                dgv_liste.AutoGenerateColumns = false;
                dgv_liste.DataSource = _bs_source;
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, CLIENT_APP_PARAM.Fenetre_principale.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_liste_DoubleClick(object sender, EventArgs e)
        {
            if (_bs_source.Current != null)
            {
                DataRowView drv = (DataRowView)_bs_source.Current;
                CHM_ARTICLE f = new CHM_ARTICLE((decimal)drv["CODE_ARTICLE"]);
                f.ShowDialog();

            }
        }
    }
}