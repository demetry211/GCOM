using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace CHM_CLIENT_APP.CHM_INVENTAIRE
{
    public partial class CHM_FRM_INVENTAIRE : Form
    {
        DataTable _dt_inventaire;
        BindingSource _bs_inventaire = new BindingSource();
        DataTable _inventaire;
        decimal _code_inventaire;
        public CHM_FRM_INVENTAIRE(decimal code_inventaire)
        {
            InitializeComponent();
            _code_inventaire = code_inventaire;
            dataGridView1.AutoGenerateColumns = false;
            //_inventaire = CLIENT_APP_PARAM.GEST.P_INVENTAIRE.LOAD_INVENTAIRE(code_inventaire);
            _inventaire = CLIENT_APP_PARAM.gcws.LOAD_INVENTAIRE(code_inventaire);
            txt_CODE_INVENTAIRE.Text = _inventaire.Rows[0]["CODE_INVENTAIRE"].ToString();
            txt_DATE_OUV_INVENTAIRE.Text = Convert.ToDateTime(_inventaire.Rows[0]["DATE_DEBUT_INVENTAIRE"]).ToShortDateString();
            txt_MAGASIN.Text = _inventaire.Rows[0]["NOM_MAG"].ToString();
            txt_UTILISATEUR_OUV.Text = _inventaire.Rows[0]["UTIL"].ToString();
            refresh_liste();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void refresh_liste()
        {
            try
            {
                //_dt_inventaire = CLIENT_APP_PARAM.GEST.P_INVENTAIRE.LOAD_LIGNE_INVENTAIRE((decimal)_inventaire.Rows[0]["CODE_INVENTAIRE"]);
                _dt_inventaire = CLIENT_APP_PARAM.gcws.LOAD_LIGNE_INVENTAIRE((decimal)_inventaire.Rows[0]["CODE_INVENTAIRE"]);
                _bs_inventaire.DataSource = _dt_inventaire;
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = _bs_inventaire;
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, this.Text);
            }
        }

        private void CHM_FRM_INVENTAIRE_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.F5)
                {
                    refresh_liste();
                }
                if (e.KeyCode == Keys.F3)
                {
                    txt_recherche.Focus();
                    txt_recherche.SelectAll();
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, this.Text);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                timer1.Enabled = false;
                string code = txt_code_barre.Text;
                txt_code_barre.Text = "";
                _bs_inventaire.Position = _bs_inventaire.Find("CODE_BARRE_ARTICLE", code);
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, this.Text);
            }
        }

        private void txt_code_barre_TextChanged(object sender, EventArgs e)
        {
            if(txt_code_barre.Text.Trim()!="")
            timer1.Enabled = true;
        }

        private void txt_recherche_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_recherche.Text == "")
                {
                    _bs_inventaire.DataSource = _dt_inventaire;
                    dataGridView1.DataSource = _bs_inventaire;
                }
                else
                {
                    _dt_inventaire.DefaultView.RowFilter = "REF_ARTICLE like '%" + txt_recherche.Text + "%' OR CODE_BARRE_ARTICLE like '%" + txt_recherche.Text + "%' OR DESIGNATION_ARTICLE like '%" + txt_recherche.Text + "%'";
                    DataTable dt = _dt_inventaire.DefaultView.ToTable();
                    _bs_inventaire.DataSource = dt;
                    _dt_inventaire.DefaultView.RowFilter = "";
                    dataGridView1.DataSource = _bs_inventaire;
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, this.Text);
            }
        }

        private void btn_code_barre_Click(object sender, EventArgs e)
        {
            txt_code_barre.Focus();
            txt_code_barre.SelectAll();
        }

        private void dataGridView1_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void txt_code_barre_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void dataGridView1_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (_bs_inventaire.Current != null)
            {
                try
                {
                    DataRowView drv = (DataRowView)_bs_inventaire.Current;
                    //CHM_GESTION_COMERCIALE.RESULT_QUERY res = CLIENT_APP_PARAM.GEST.P_INVENTAIRE.ENREGISTRER_LIGNE_INVENTAIRE(_code_inventaire, (decimal)drv["CODE_ARTICLE"], (decimal)drv["QTE_INVENTAIRE"]);
                    CHMGC.RESULT_QUERY res = CLIENT_APP_PARAM.gcws.ENREGISTRER_LIGNE_INVENTAIRE(_code_inventaire, (decimal)drv["CODE_ARTICLE"], (decimal)drv["QTE_INVENTAIRE"]);
                    if (!res.OK)
                    {
                        MessageBox.Show("Enregistré avec succès.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        _bs_inventaire.Position = _bs_inventaire.Find("CODE_BARRE_ARTICLE", (decimal)drv["CODE_ARTICLE"]);
                        return;
                    }
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message, this.Text);
                }
            }
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (_bs_inventaire.Current != null)
                {
                    if (((int)e.KeyChar >= 46 && (int)e.KeyChar <= 57) || (int)e.KeyChar == 8 || (int)e.KeyChar == 127)
                        e.Handled = false;
                    else
                        e.Handled = true;
                }
                else
                {
                    MessageBox.Show("Veuillez Sélectionner un article.");
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, this.Text);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                //CHM_GESTION_COMERCIALE.RESULT_QUERY res = new CHM_GESTION_COMERCIALE.RESULT_QUERY();
                CHMGC.RESULT_QUERY res = new CHM_CLIENT_APP.CHMGC.RESULT_QUERY();
                if (MessageBox.Show("Etes vous sûres de cloturer l'inventaire?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    //res = CLIENT_APP_PARAM.GEST.P_INVENTAIRE.CLOTURE_INVENTAIRE(_code_inventaire, Convert.ToDecimal(CLIENT_APP_PARAM.Fenetre_principale.code_user), _dt_inventaire, (decimal)_inventaire.Rows[0]["CODE_MAG"]);
                    res = CLIENT_APP_PARAM.gcws.CLOTURE_INVENTAIRE(_code_inventaire, Convert.ToDecimal(CLIENT_APP_PARAM.Fenetre_principale.code_user), _dt_inventaire, (decimal)_inventaire.Rows[0]["CODE_MAG"]);
                    if (res.OK)
                    {
                        MessageBox.Show(res.MESSAGE);
                        button1.Enabled = false;

                        
                    }
                    else
                    {
                        MessageBox.Show(res.MESSAGE);
                        return;
                    }
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, this.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReportDocument rpt = new CHM_INVENTAIRE();
            //rpt.SetDataSource(CLIENT_APP_PARAM.GEST.P_INVENTAIRE.IMPRIMER_SAISIE_INVENTAIRE(_code_inventaire));
            rpt.SetDataSource(CLIENT_APP_PARAM.gcws.IMPRIMER_SAISIE_INVENTAIRE(_code_inventaire));


            CHM_ETATS f = new CHM_ETATS();
            f.CHM_Aperçu_document.ReportSource = rpt;
            f.WindowState = FormWindowState.Maximized;
            f.ShowDialog();
        }


    }
}