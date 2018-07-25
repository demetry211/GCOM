using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CHM_CLIENT_APP
{
    public partial class CHM_LISTE_MAGAZIN : Form
    {
        DataTable dt;
        BindingSource bs = new BindingSource();
        public CHM_LISTE_MAGAZIN()
        {
            InitializeComponent();
            bs.CurrentItemChanged += new EventHandler(bs_CurrentItemChanged);
            entete_Formulaire_21.btn_refresh.Click += new EventHandler(btn_refresh_Click);
        }

        void btn_refresh_Click(object sender, EventArgs e)
        {
            try
            {
                chargerListe();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, this.Text);
            }
        }

        void bs_CurrentItemChanged(object sender, EventArgs e)
        {
            try
            {
                if (bs.Current != null && dt.Rows.Count > 0)
                {
                    DataRowView drv = (DataRowView)bs.Current;
                    //if(((CHM_GESTION_COMERCIALE.RESULT_QUERY)CLIENT_APP_PARAM.GEST.P_INVENTAIRE.VERIFIER_INVENTAIRE_MAGAZIN((decimal)drv["CODE_MAG"])).OK)
                    
                    if ((CLIENT_APP_PARAM.gcws.VERIFIER_INVENTAIRE_MAGAZIN((decimal)drv["CODE_MAG"]) as CHMGC.RESULT_QUERY).OK)
                    {
                        btn_inventaire.Text = "Inventaire";
                        btn_inventaire.Tag = "o";//Si le bouton a pour tag 'o' alors il sert a ouvrir un nouvel inventaire sur le magasin sélectionné
                        btn_stock.Enabled = true;
                    }
                    else
                    {
                        btn_inventaire.Text = "Afficher l'inventaire";
                        btn_inventaire.Tag = "v";//Si 'v' le bouton sert a visualiser l'inventaire acruel sur le magasin sélectionné
                        btn_stock.Enabled = false;
                    }
                }
            }
            catch (Exception er)
            {
                
            }
        }

        private void CHM_LISTE_MAGAZIN_Shown(object sender, EventArgs e)
        {
            dgv_magazin.AutoGenerateColumns = false;
            try
            {
                Application.DoEvents();
                //dt = CLIENT_APP_PARAM.GEST.P_MAGAZIN.SELECT_ALL_MAGAZIN();
                chargerListe();    
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Connexion serveur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void chargerListe()
        {
            try
            {
                dt = CLIENT_APP_PARAM.gcws.SELECT_ALL_MAGAZIN();
                bs.DataSource = dt;
                dgv_magazin.DataSource = bs;
                bs_CurrentItemChanged(null, null);
            }
            catch (Exception er)
            {
                throw er;
            }
        }

        private void RECHERCHE_MAG_TextChanged(object sender, EventArgs e)
        {
            dgv_magazin.AutoGenerateColumns = false;
            try
            {
                Application.DoEvents();
                if (RECHERCHE_MAG.Text == "")
                {
                    bs.DataSource = dt;
                    dgv_magazin.DataSource = bs;
                }
                else
                {
                    dt.DefaultView.RowFilter = "NOM_MAG like '%"+RECHERCHE_MAG.Text+"%'";
                    DataTable dt_search = dt.DefaultView.ToTable();
                    dt.DefaultView.RowFilter = "";
                    bs.DataSource = dt_search;
                    dgv_magazin.DataSource = bs;
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Connection error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void nouveauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CHM_NV_MAGAZIN nv = new CHM_NV_MAGAZIN("-1");
            nv.enreg_event += new CHM_NV_MAGAZIN.enreg_deleg(nv_enreg_event);
            nv.ShowDialog();
        }

        void nv_enreg_event(DataRowView mag, bool etat)
        {
            if (etat)
                bs.AddNew();
            DataRowView drv = (DataRowView)bs.Current;
            drv["CODE_MAG"] = mag["CODE_MAG"];
            drv["NOM_MAG"] = mag["NOM_MAG"];
            drv["ADRESSE_MAG"] = mag["ADRESSE_MAG"];
            drv["TEL_MAG"] = mag["TEL_MAG"];
            drv["CODE_SOCIETE"] = mag["CODE_SOCIETE"];
            drv["RS_SOCIETE"] = mag["RS_SOCIETE"];
            bs.EndEdit();
            dt.AcceptChanges();
        }

        private void CHM_LISTE_MAGAZIN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
            if (e.KeyCode == Keys.F5)
            {
                try
                {
                    chargerListe();
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message, this.Text);
                }
            }
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bs.Current != null)
            {
                DataRowView drv = (DataRowView)bs.Current;
                CHM_NV_MAGAZIN nv = new CHM_NV_MAGAZIN(drv["CODE_MAG"].ToString());
                nv.enreg_event += new CHM_NV_MAGAZIN.enreg_deleg(nv_enreg_event);
                nv.ShowDialog();
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (bs.Current != null)
            {
                if (MessageBox.Show("Voulez vous confirmer la supression ?", "Supression", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    //CHM_GESTION_COMERCIALE.RESULT_QUERY res;
                    CHMGC.RESULT_QUERY res;
                    try
                    {
                        DataRowView drv = (DataRowView)bs.Current;
                        Application.DoEvents();
                        //res = CLIENT_APP_PARAM.GEST.P_MAGAZIN.DELETE_MAGAZIN(drv["CODE_MAG"].ToString());
                        res = CLIENT_APP_PARAM.gcws.DELETE_MAGAZIN(drv["CODE_MAG"].ToString());
                        if (res.OK)
                        {
                            bs.RemoveCurrent();
                            dt.AcceptChanges();
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

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (bs.Current != null)
                {
                    
                    DataRowView drv = (DataRowView)bs.Current;
                    if (btn_inventaire.Tag.ToString() == "o")
                    {
                        if (MessageBox.Show("Etes vous sûres d'ouvrir un inventaire sur ce magasin?\nDans le cas de confirmation vous ne serez pas capable de faire aucune manipulation ni ed vente ni d'achat ni d'affichage de quantité de stock.", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                        {
                            //CHM_GESTION_COMERCIALE.RESULT_QUERY res = new CHM_GESTION_COMERCIALE.RESULT_QUERY();
                            CHMGC.RESULT_QUERY res = new CHM_CLIENT_APP.CHMGC.RESULT_QUERY();
                            try
                            {
                                //res = CLIENT_APP_PARAM.GEST.P_INVENTAIRE.OUVERTURE_INVENTAIRE(Convert.ToDecimal(CLIENT_APP_PARAM.Fenetre_principale.code_user), (decimal)drv["CODE_MAG"]);
                                res = CLIENT_APP_PARAM.gcws.OUVERTURE_INVENTAIRE(Convert.ToDecimal(CLIENT_APP_PARAM.Fenetre_principale.code_user), (decimal)drv["CODE_MAG"]);
                                if (res.OK)
                                {
                                    bs_CurrentItemChanged(null, null);
                                    MessageBox.Show(res.MESSAGE);

                                    CHM_INVENTAIRE.CHM_FRM_INVENTAIRE f = new CHM_CLIENT_APP.CHM_INVENTAIRE.CHM_FRM_INVENTAIRE(Convert.ToDecimal(res.CODE));
                                    f.MdiParent = CLIENT_APP_PARAM.Fenetre_principale;
                                    f.WindowState = FormWindowState.Maximized;
                                    f.Show();
                                    
                                }
                            }
                            catch (Exception er)
                            {
                                MessageBox.Show(res.MESSAGE, this.Text);
                            }
                        }
                    }
                    else
                    {
                        //decimal code_inv = CLIENT_APP_PARAM.GEST.P_INVENTAIRE.GET_INVENTAIRE_COURANT_PAR_MAGAZIN((decimal)drv["CODE_MAG"]);
                        decimal code_inv = CLIENT_APP_PARAM.gcws.GET_INVENTAIRE_COURANT_PAR_MAGAZIN((decimal)drv["CODE_MAG"]);
                        CHM_INVENTAIRE.CHM_FRM_INVENTAIRE f = new CHM_CLIENT_APP.CHM_INVENTAIRE.CHM_FRM_INVENTAIRE(code_inv);
                        f.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Veuillez sélectionner un magasin tout d'abord.");
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_stock_Click(object sender, EventArgs e)
        {
            if (bs.Current != null)
            {
                DataRowView drv = (DataRowView)bs.Current;
                CHM_MAGAZIN.CHM_LISTE_STOCK_PAR_MAGAZIN f = new CHM_CLIENT_APP.CHM_MAGAZIN.CHM_LISTE_STOCK_PAR_MAGAZIN((decimal)drv["CODE_MAG"]);
                f.WindowState = FormWindowState.Maximized;
                f.MdiParent = CLIENT_APP_PARAM.Fenetre_principale;
                f.Show();
            }
        }

    }
}
