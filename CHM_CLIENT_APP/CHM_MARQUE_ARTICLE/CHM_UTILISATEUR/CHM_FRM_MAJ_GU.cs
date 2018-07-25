using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CHM_CLIENT_APP.CHM_UTILISATEUR
{
    public partial class CHM_FRM_MAJ_GU : Form
    {
        

        public delegate void winwdows_use();
        public event winwdows_use afteruse;
        
        private decimal _code_groupe=0;
        public CHM_FRM_MAJ_GU(decimal code_groupe)
        {
            InitializeComponent();
            _code_groupe = code_groupe;
            try
            {

                if (_code_groupe == 0)
                {
                    this.Text = entete_Formulaire_21.windows_name.Text = "Ajout de groupe utilisateurs";
                    r_gestion.Checked = true;
                }
                else
                {

                    DataTable dt = CLIENT_APP_PARAM.gacces.LOAD_FONCTION_USER(_code_groupe);
                    if (dt.Rows.Count > 0)
                    {
                        txt_LIB_GROUPE.Text = dt.Rows[0]["LIB_FONCTION_USER"].ToString();
                        txt_description.Text = dt.Rows[0]["DESC_FONCTION_USER"].ToString();
                        
                            if((decimal)dt.Rows[0]["CODE_PRIVILEGE"] ==1)
                                r_gestion.Checked = true;
                                
                            if((decimal)dt.Rows[0]["CODE_PRIVILEGE"] ==2)
                                r_achat.Checked = true;
                               
                            if((decimal)dt.Rows[0]["CODE_PRIVILEGE"] ==3)
                                r_vente.Checked = true;
                                
                        
                    }
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Erreur inattendue", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.chM_CMP_VALIDATION1.button2.Click += new EventHandler(button2_Click);
            this.chM_CMP_VALIDATION1.button1.Click += new EventHandler(button1_Click);
        }

        void button1_Click(object sender, EventArgs e)
        {
            #region test des champs
            errorProvider1.SetError(txt_LIB_GROUPE, "");
            if (txt_LIB_GROUPE.Text.Trim() == "")
            {
                errorProvider1.SetError(txt_LIB_GROUPE, "Veuillez entrer la designation du groupe!");
                txt_LIB_GROUPE.Focus();
                txt_LIB_GROUPE.Select();
                return;
            }            
            #endregion
            try
            {
                if (_code_groupe == 0)
                {
                    decimal code_priv = 0;
                    if (r_achat.Checked)
                        code_priv = 2;
                    if (r_gestion.Checked)
                        code_priv = 1;
                    if (r_vente.Checked)
                        code_priv = 3;

                    CLIENT_APP_PARAM.gacces.saveGroupUser(txt_LIB_GROUPE.Text, txt_description.Text, code_priv);
                    MessageBox.Show("Groupe utilisateur ajouté avec succes", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (afteruse != null)
                        afteruse();
                    Close();
                }
                else
                {
                    decimal code_priv = 0;
                    if (r_achat.Checked)
                        code_priv = 2;
                    if (r_gestion.Checked)
                        code_priv = 1;
                    if (r_vente.Checked)
                        code_priv = 3;

                    CLIENT_APP_PARAM.gacces.updateGroupUser(_code_groupe,txt_LIB_GROUPE.Text, txt_description.Text, code_priv);
                    if (afteruse != null)
                        afteruse();
                    MessageBox.Show("Groupe utilisateur modifié avec succes", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }                
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Erreur inattendue", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txt_LIB_GROUPE_Validating(object sender, CancelEventArgs e)
        {
            if (txt_LIB_GROUPE.Text.Trim() != "")
            {
                try
                {
                    errorProvider1.SetError(txt_LIB_GROUPE, "");
                    DataTable dt = new DataTable();
                    
                        
                                dt = CLIENT_APP_PARAM.gcws.SELECT_FONCTION();
                            
                        bool exist = false;
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            if (dt.Rows[i]["LIB_FONCTION_USER"] == txt_LIB_GROUPE.Text)
                            {
                                exist = true;
                                break;
                            }
                        }
                        if (exist)
                        {
                            errorProvider1.SetError(txt_LIB_GROUPE, "Ce nom de groupe utilisateur est déja utilisé");
                            txt_LIB_GROUPE.Focus();
                            txt_LIB_GROUPE.Select();
                            return;
                        }
                    
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message, "Erreur inattendue", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
