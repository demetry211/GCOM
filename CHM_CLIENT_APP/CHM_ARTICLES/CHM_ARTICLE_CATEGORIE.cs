using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CHM_CLIENT_APP
{
    public partial class CHM_ARTICLE_CATEGORIE : Form
    {
        public delegate void select_deleg(decimal code_categ, decimal codeFamille);
        public event select_deleg selection;
        string Mode = string.Empty;
        BindingSource bs_categ = new BindingSource();
        public CHM_ARTICLE_CATEGORIE(string mode)
        {
            InitializeComponent();
            bs_categ = CLIENT_APP_PARAM.ds_param.bsCategorie;
            gridControl1.DataSource = bs_categ;
            Mode = mode;

            switch (Mode)
            {
                case "s":
                    chM_CMP_CONTROL1.btn_afficher.Visible = true;
                    chM_CMP_CONTROL1.btn_afficher.Text = "Sélectionner";
                    break;
                case "l":
                    chM_CMP_CONTROL1.btn_afficher.Visible = false;
                    break;
            }

            entete_Formulaire_21.btn_refresh.Click += new EventHandler(btn_refresh_Click);
            chM_CMP_CONTROL1.btn_afficher.Click += new EventHandler(btn_afficher_Click);
            chM_CMP_CONTROL1.btn_ajout.Click += new EventHandler(btn_ajout_Click);
            chM_CMP_CONTROL1.btn_modifier.Click += new EventHandler(btn_modifier_Click);
            chM_CMP_CONTROL1.btn_supprimer.Click += new EventHandler(BTN_SUPPRIMER_Click);
        }

        void btn_refresh_Click(object sender, EventArgs e)
        {
            CLIENT_APP_PARAM.ds_param.chargerCategories();
        }

        void btn_modifier_Click(object sender, EventArgs e)
        {            
            if (bs_categ.Current != null)
            {
                CHM_NV_CATEGORIE nv = new CHM_NV_CATEGORIE(bs_categ);
                nv.enreg_event += new CHM_NV_CATEGORIE.enreg_deleg(nv_enreg_event);
                nv.ShowDialog();
            }
        }

        void btn_ajout_Click(object sender, EventArgs e)
        {
            bs_categ.AddNew();
            (bs_categ.Current as DataRowView)["CODE_CATEG"] = "-1";
            CHM_NV_CATEGORIE nv = new CHM_NV_CATEGORIE(bs_categ);
            nv.enreg_event += new CHM_NV_CATEGORIE.enreg_deleg(nv_enreg_event);
            nv.ShowDialog();
        }

        void btn_afficher_Click(object sender, EventArgs e)
        {
            if (bs_categ.Current != null)
            {
                DataRowView drv = (DataRowView)bs_categ.Current;
                if (selection != null)
                    selection((decimal)drv["CODE_CATEG"], (decimal)drv["CODE_FAMILLE"]);

            }
            this.Close();
        }

        
        private void CHM_ARTICLE_CATEGORIE_Shown(object sender, EventArgs e)
        {
            
            try
            {
                Application.DoEvents();
                
                
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Connexion serveur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void nv_enreg_event(DataRowView categ, bool etat)
        {
            //if (etat)
            //    bs_categ.AddNew();
            //DataRowView drv = (DataRowView)bs_categ.Current;
            //drv["CODE_CATEG"] = categ["CODE_CATEG"];
            //drv["LIB_CATEG"] = categ["LIB_CATEG"];
            //drv["DESCRIPTION_CATEG"] = categ["DESCRIPTION_CATEG"];
            //drv["CODE_FAMILLE"] = categ["CODE_FAMILLE"];
            //drv["REF_CATEG"] = categ["REF_CATEG"];
            bs_categ.EndEdit();
            (bs_categ.DataSource as DataTable).AcceptChanges();
        }

        
        
        private void BTN_SUPPRIMER_Click(object sender, EventArgs e)
        {
            try
            {
                if (bs_categ.Current != null)
                {
                    if (MessageBox.Show("Etes vous sûres de supprimer la catégorie", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        //if (CLIENT_APP_PARAM.GEST.P_CATEGORIE.SELECT_CATEG_PRODUCTS(((DataRowView)bs_categ.Current)["CODE_CATEG"].ToString()).Rows.Count > 0)
                            if (CLIENT_APP_PARAM.gcws.SELECT_CATEG_PRODUCTS(((DataRowView)bs_categ.Current)["CODE_CATEG"].ToString()).Rows.Count > 0)
                        {
                            MessageBox.Show("Cette catégorie ne peut pas etre supprimée car elle contient des articles!");
                        }
                        else
                        {
                            //CHM_GESTION_COMERCIALE.RESULT_QUERY res;
                            CHMGC.RESULT_QUERY res;
                            //res = CLIENT_APP_PARAM.GEST.P_CATEGORIE.DELETE_CATEGORIE(((DataRowView)bs_categ.Current)["CODE_CATEG"].ToString());
                            res = CLIENT_APP_PARAM.gcws.DELETE_CATEGORIE(((DataRowView)bs_categ.Current)["CODE_CATEG"].ToString());
                            bs_categ.RemoveCurrent();
                            
                            if (res.OK)
                            {
                                MessageBox.Show(res.MESSAGE, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                
                            }
                            else
                                MessageBox.Show(res.MESSAGE, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        

        

        private void CHM_ARTICLE_CATEGORIE_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
                CLIENT_APP_PARAM.ds_param.chargerCategories();
        }
    }
}
