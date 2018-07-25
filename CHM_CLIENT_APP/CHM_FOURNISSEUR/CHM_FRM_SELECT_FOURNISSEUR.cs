using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CHM_CLIENT_APP.CHM_FOURNISSEUR
{
    public partial class CHM_FRM_SELECT_FOURNISSEUR : Form
    {
        DataTable _dt_liste_Fournisseur;
        BindingSource _bs_fournisseur;
        public delegate void Form_returns(DataRowView fournisseur);
        public event Form_returns OnSelect;
        public CHM_FRM_SELECT_FOURNISSEUR()
        {
            InitializeComponent();
            remplir_liste();
        }

        public void remplir_liste()
        {
            dgv_liste_clt.AutoGenerateColumns = false;
            //_dt_liste_Fournisseur = CLIENT_APP_PARAM.GEST.P_FOURNISSEUR.SELECT_ALL_FOURNISSEURS();
            _dt_liste_Fournisseur = CLIENT_APP_PARAM.gcws.SELECT_ALL_FOURNISSEURS();
            _bs_fournisseur.DataSource = _dt_liste_Fournisseur;
            dgv_liste_clt.DataSource = _bs_fournisseur;
            _bs_fournisseur.MoveFirst();
        }   

        private void btn_selection_Click(object sender, EventArgs e)
        {
            if (_bs_fournisseur.Current!=null)
            {
                if (OnSelect != null)
                    OnSelect((DataRowView)_bs_fournisseur.Current);
            }
        }

        private void buttonFERMER_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CHM_NV_FOURNISSEUR f = new CHM_NV_FOURNISSEUR("-1");
            f.enreg_fourn_ev += new CHM_NV_FOURNISSEUR.ENREG_FOURNISSEUR_DELEG(f_enreg_fourn_ev);
            f.ShowDialog();
        }

        void f_enreg_fourn_ev(DataRowView fournisseur, bool type)
        {
            remplir_liste();
        }

        private void CHM_FRM_SELECT_FOURNISSEUR_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void TB_RECHERCHE_CLT_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void TB_RECHERCHE_CLT_TextChanged(object sender, EventArgs e)
        {
            if (TB_RECHERCHE_CLT.Text == "")
            {
                _bs_fournisseur.DataSource = _dt_liste_Fournisseur;
                dgv_liste_clt.DataSource = _bs_fournisseur;
                _bs_fournisseur.MoveFirst();
            }
            else
            {
                DataTable dt;
                _dt_liste_Fournisseur.DefaultView.RowFilter = "(RS_FOURNISSEUR='" + TB_RECHERCHE_CLT.Text + "') OR (REF_FOURNISSEUR=='" + TB_RECHERCHE_CLT.Text + "')";
                dt = _dt_liste_Fournisseur.DefaultView.ToTable();
                _bs_fournisseur.DataSource = dt;
                dgv_liste_clt.DataSource = _bs_fournisseur;
                _bs_fournisseur.MoveFirst();
            }
        }

    }
}
