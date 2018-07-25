using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace CHM_CLIENT_APP.BON_RECEPTION
{
    public partial class CHM_LISTE_BONRECEPTION_FR : Form
    {
        DataTable _dt_liste_br_fr;
        BindingSource _bs_liste_br_fr = new BindingSource();
        public CHM_LISTE_BONRECEPTION_FR()
        {
            InitializeComponent();
            dgv_liste.AutoGenerateColumns = false;
            entete_Formulaire_21.btn_refresh.Click += new EventHandler(btn_refresh_Click);
        }

        void btn_refresh_Click(object sender, EventArgs e)
        {
            try
            {
                //_dt_liste_br_fr = CLIENT_APP_PARAM.GEST.P_BR_FR.SELECT_ALL_BR_FR();
                _dt_liste_br_fr = CLIENT_APP_PARAM.gcws.SELECT_ALL_BR_FR();
                _bs_liste_br_fr.DataSource = _dt_liste_br_fr;
                dgv_liste.DataSource = _bs_liste_br_fr;
                calcul_total();

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, this.Text);
            }
        }

        private void CHM_LISTE_BONRECEPTION_FR_Load(object sender, EventArgs e)
        {
            try
            {
                //_dt_liste_br_fr = CLIENT_APP_PARAM.GEST.P_BR_FR.SELECT_ALL_BR_FR();
                _dt_liste_br_fr = CLIENT_APP_PARAM.gcws.SELECT_ALL_BR_FR();
                _bs_liste_br_fr.DataSource = _dt_liste_br_fr;
                dgv_liste.DataSource = _bs_liste_br_fr;
                calcul_total();
                
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, this.Text);
            }
        }

        private void calcul_total()
        {
            decimal somme = 0;
            foreach (DataRowView drv in _bs_liste_br_fr)
            {
                somme += (decimal)drv["RESTE"];
            }
            NP.Value = somme;

            somme = 0;
            foreach (DataRowView drv in _bs_liste_br_fr)
            {
                somme += (decimal)drv["MNT_BR_FR"];
            }
            lbn_total.Value = somme;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                CHMGC.RESULT_QUERY res = CLIENT_APP_PARAM.gcws.VERIFIER_INVENTAIRE_MAGAZIN(Convert.ToDecimal(CLIENT_APP_PARAM.CODE_MAG));
                if (res.OK)
                {
                    BON_RECEPTION.CHM_FRM_BR_FOURNISSEUR f = new CHM_FRM_BR_FOURNISSEUR(-1);
                    f.WindowState = FormWindowState.Normal;
                    //f.MdiParent = CLIENT_APP_PARAM.Fenetre_principale;
                    f.OnSave += new CHM_FRM_BR_FOURNISSEUR.EnregistrementBR(f_OnSave);
                    f.Show();
                    //_dt_liste_br_fr = CLIENT_APP_PARAM.GEST.P_BR_FR.SELECT_ALL_BR_FR();
                    
                }
                else
                {
                    MessageBox.Show("Magasin encours d'inventaire.", this.Text);
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, this.Text);
            }
        }

        void f_OnSave(decimal Code)
        {
            try
            {
                _dt_liste_br_fr = CLIENT_APP_PARAM.gcws.SELECT_ALL_BR_FR();
                _bs_liste_br_fr.DataSource = _dt_liste_br_fr;
                dgv_liste.DataSource = _bs_liste_br_fr;
                calcul_total();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, this.Text);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (_bs_liste_br_fr.Current != null)
                {
                    ReportDocument rpt = new BON_RECEPTION.RPT_BR_FR();
                    //DataTable dt = CLIENT_APP_PARAM.GEST.P_BR_FR.IMPRIMER_BRECEP_FR((decimal)(_bs_liste_br_fr.Current as DataRowView)["CODE_BRECEP"]);
                    DataTable dt = CLIENT_APP_PARAM.gcws.IMPRIMER_BRECEP_FR((decimal)(_bs_liste_br_fr.Current as DataRowView)["CODE_BRECEP"]);
                    //rpt.SetDataSource(CLIENT_APP_PARAM.GEST.P_BR_FR.IMPRIMER_BRECEP_FR((decimal)(_bs_liste_br_fr.Current as DataRowView)["CODE_BRECEP"]));
                    rpt.SetDataSource(CLIENT_APP_PARAM.gcws.IMPRIMER_BRECEP_FR((decimal)(_bs_liste_br_fr.Current as DataRowView)["CODE_BRECEP"]));

                    CHM_ETATS f = new CHM_ETATS();
                    f.CHM_Aperçu_document.ReportSource = rpt;
                    f.MdiParent = CLIENT_APP_PARAM.Fenetre_principale;
                    f.Show();
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            try
            {
                if (_bs_liste_br_fr.Current != null)
                {
                    DataRowView drv = (DataRowView)_bs_liste_br_fr.Current;

                    if (CLIENT_APP_PARAM.gccnx.getDate() <= Convert.ToDateTime(drv["DATE_BR_FR"]).AddHours(9))
                    {
                        BON_RECEPTION.CHM_FRM_BR_FOURNISSEUR f = new CHM_FRM_BR_FOURNISSEUR((decimal)drv["CODE_BRECEP"]);
                        f.WindowState = FormWindowState.Normal;
                        //f.MdiParent = CLIENT_APP_PARAM.Fenetre_principale;
                        f.ShowDialog();
                        //_dt_liste_br_fr = CLIENT_APP_PARAM.GEST.P_BR_FR.SELECT_ALL_BR_FR();
                        _dt_liste_br_fr = CLIENT_APP_PARAM.gcws.SELECT_ALL_BR_FR();
                        _bs_liste_br_fr.DataSource = _dt_liste_br_fr;
                        dgv_liste.DataSource = _bs_liste_br_fr;
                        calcul_total();
                    }
                    else
                    {
                        MessageBox.Show("Vous avez dépasser 9 heures de l'enregistrement de ce Bon de livraison,\nvous ne pouvez pas le modifier.", this.Text);
                    }
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void btn_annuler_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (_bs_liste_br_fr.Current != null)
                {
                    DataRowView drv = (DataRowView)_bs_liste_br_fr.Current;

                    //if (DateTime.Now <= Convert.ToDateTime(drv["DATE_BR_FR"]).AddHours(1))
                    //{
                    //CHM_GESTION_COMERCIALE.RESULT_QUERY res = CLIENT_APP_PARAM.GEST.P_BR_FR.DELETE_BR_FR((decimal)drv["CODE_BRECEP"]);
                    CHMGC.RESULT_QUERY res = CLIENT_APP_PARAM.gcws.DELETE_BR_FR((decimal)drv["CODE_BRECEP"]);
                    if (res.OK)
                    {
                        //_dt_liste_br_fr = CLIENT_APP_PARAM.GEST.P_BR_FR.SELECT_ALL_BR_FR();
                        _dt_liste_br_fr = CLIENT_APP_PARAM.gcws.SELECT_ALL_BR_FR();
                        _bs_liste_br_fr.DataSource = _dt_liste_br_fr;
                        dgv_liste.DataSource = _bs_liste_br_fr;
                        calcul_total();
                        MessageBox.Show(res.MESSAGE, this.Text);
                    }
                    else
                        MessageBox.Show(res.MESSAGE, "Error");
                    //}
                    //else
                    //{
                    //    MessageBox.Show("áÞÏ ÊÌÇæÒÊ ÃßËÑ ãä ÓÇÚÉ ãäÐ ÅÏÎÇá ÅÐä ÇáÅÓÊáÇã. áÇ íãßä ÅÌÑÇÁ ÇáÊÚÏíá.", this.Text);
                    //}
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void CHM_LISTE_BONRECEPTION_FR_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.F5)
                btn_refresh_Click(null, null);
            if (e.KeyCode == Keys.Escape)
                Close();
        }
    }
}