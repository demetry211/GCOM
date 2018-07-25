using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CHM_CLIENT_APP.CHM_FAMILLES_ART;

namespace CHM_CLIENT_APP
{
    public partial class CHM_NV_CATEGORIE : Form
    {
        public delegate void enreg_deleg(DataRowView categ, bool etat);
        public event enreg_deleg enreg_event;
        string CODE_CATEG = "-1";
        BindingSource bs = new BindingSource();
        public CHM_NV_CATEGORIE(BindingSource bs)
        {
            InitializeComponent();
            
            this.bs = bs;

            cbxFamille.DataSource = CLIENT_APP_PARAM.ds_param.FAMILLE;
            cbxFamille.ValueMember = "CODE_FAMILLE";
            cbxFamille.DisplayMember = "DESIGNATION_FAMILLE";
            cbxFamille.SelectedValueChanged += new EventHandler(cbxFamille_SelectedValueChanged);

            LIB_CATEG.DataBindings.Add("Text", bs, "LIB_CATEG", true);
            DESCRIPTION_CATEG.DataBindings.Add("Text", bs, "DESCRIPTION_CATEG", true);
            txt_REF_CATEG.DataBindings.Add("Text", bs, "REF_CATEG", true);
            cbxFamille.DataBindings.Add("SelectedValue", bs, "CODE_FAMILLE", true);
            lb_REF_FAMILLE.DataBindings.Add("Text", bs, "REF_FAMILLE", true);
            cbxFamille.DataBindings.Add("Text", bs, "DESIGNATION_FAMILLE", true);
            CODE_CATEG = (bs.Current as DataRowView)["CODE_CATEG"].ToString();
            
            if (CODE_CATEG != "-1")
            {
                this.Text=entete_Formulaire_21.windows_name.Text = "Modification de catégorie";
                
            }
            else
            {
                this.Text = entete_Formulaire_21.windows_name.Text = "Nouvelle catégorie";
                
            }
        }

        void cbxFamille_SelectedValueChanged(object sender, EventArgs e)
        {
            //lb_REF_FAMILLE.Text = CLIENT_APP_PARAM.ds_param.FAMILLE.Select("CODE_FAMILLE = '" + cbxFamille.SelectedValue.ToString() + "'")[0]["REF_FAMILLE"].ToString();
        }       
        
        
        private void BTN_ENREG_MAG_Click(object sender, EventArgs e)
        {
            
            try
            {
                //CHM_GESTION_COMERCIALE.RESULT_QUERY res;
                CHMGC.RESULT_QUERY res;
                if (CODE_CATEG == "-1")
                {
                    Application.DoEvents();
                    //res = CLIENT_APP_PARAM.GEST.P_CATEGORIE.INSERT_CATEGORIE(CODE_CATEG, LIB_CATEG.Text, DESCRIPTION_CATEG.Text);
                    res = CLIENT_APP_PARAM.gcws.INSERT_CATEGORIE(CODE_CATEG, LIB_CATEG.Text, DESCRIPTION_CATEG.Text, (decimal)cbxFamille.SelectedValue, txt_REF_CATEG.Text);
                    if (res.OK)
                    {
                        MessageBox.Show(res.MESSAGE, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CODE_CATEG = res.CODE;
                        ((DataRowView)this.bs.Current)["CODE_CATEG"] = CODE_CATEG;
                        if (enreg_event != null)
                            enreg_event((DataRowView)bs.Current, true);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(res.MESSAGE, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);

                        return;
                    }
                    
                    
                }
                else
                {
                    Application.DoEvents();
                    //res = CLIENT_APP_PARAM.GEST.P_CATEGORIE.UPDATE_CATEGORIE(CODE_CATEG, LIB_CATEG.Text, DESCRIPTION_CATEG.Text);
                    res = CLIENT_APP_PARAM.gcws.UPDATE_CATEGORIE(CODE_CATEG, LIB_CATEG.Text, DESCRIPTION_CATEG.Text, (decimal)cbxFamille.SelectedValue, txt_REF_CATEG.Text);
                    if (res.OK)
                    {
                        MessageBox.Show(res.MESSAGE, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CODE_CATEG = res.CODE;
                        ((DataRowView)this.bs.Current)["CODE_CATEG"] = CODE_CATEG;
                        if (enreg_event != null)
                            enreg_event((DataRowView)bs.Current, true);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(res.MESSAGE, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    
                }

                
            }
            catch (Exception er)
            {

                MessageBox.Show(er.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void BTN_FERMER_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbxFamille_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
        }

        private void CHM_NV_CATEGORIE_FormClosing(object sender, FormClosingEventArgs e)
        {
            bs.CancelEdit();
        }

        private void btn_select_famille_Click(object sender, EventArgs e)
        {
            CHM_FRM_LISTE_FAMILLE f = new CHM_FRM_LISTE_FAMILLE("s");

        }

    }
}
