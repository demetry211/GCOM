using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CHM_CLIENT_APP
{
    public partial class CHM_NOUVEAU_CLIENT : Form
    {
        public delegate void ENREG_DEL(DataRowView client, bool type_ev);
        public event ENREG_DEL ENREG_EV;
        string CODE_CLIENT = "-1";
        DataTable client_param;
        BindingSource bs = new BindingSource();
        public CHM_NOUVEAU_CLIENT(string CODE_CLIENT)
        {
            InitializeComponent();
            this.CODE_CLIENT = CODE_CLIENT;
            NV_ATTEST_EXO_CLIENT.Enabled = NV_EXO_CLIENT.Checked;
        }

        private void BTN_ANNULER_NV_CLT_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BTN_ENREG_NV_CLT_Click(object sender, EventArgs e)
        {
            #region Test
            errorProvider1.SetError(NV_REF_CLIENT, "");
            if (NV_RS_CLIENT.Text.Trim() == "")
            {
                errorProvider1.SetError(NV_REF_CLIENT, "Reference client requise.");
                NV_REF_CLIENT.Focus();
                NV_REF_CLIENT.SelectAll();
                return;
            }
            errorProvider1.SetError(NV_RS_CLIENT, "");
            if (NV_RS_CLIENT.Text.Trim() == "")
            {
                errorProvider1.SetError(NV_RS_CLIENT, "Raison sociale manquante");
                NV_RS_CLIENT.Focus();
                NV_RS_CLIENT.SelectAll();
                return;
            }
            errorProvider1.SetError(NV_MAX_CREDIT, "");
            if (NV_MAX_CREDIT.Text == "")
            {
                errorProvider1.SetError(NV_RS_CLIENT, "«·—Ã«¡ ≈œŒ«· «·Õœ «·√ﬁ’Ï ··œÌ‰");
                NV_MAX_CREDIT.Focus();
                NV_MAX_CREDIT.SelectAll();
                return;
            }

            #endregion
            try
            {
                //CHM_GESTION_COMERCIALE.RESULT_QUERY res = new CHM_GESTION_COMERCIALE.RESULT_QUERY();
                CHMGC.RESULT_QUERY res = new CHM_CLIENT_APP.CHMGC.RESULT_QUERY();
                
                if (CODE_CLIENT == "-1")
                {
                    Application.DoEvents();
                    //this.nv_clt_titre.Text = "Ajout de client";
                    //res = CLIENT_APP_PARAM.GEST.P_CLIENT.INSERT_CLIENT(CODE_CLIENT, NV_REF_CLIENT.Text,
                    //    NV_RS_CLIENT.Text, NV_ADRESSE_CLIENT.Text, NV_CP_CLIENT.Text, NV_VILLE_CLIENT.Text, 
                    //    NV_PAYS_CLIENT.Text, NV_TEL_CLIENT.Text, NV_TEL2_CLIENT.Text, NV_FAX_CLIENT.Text,
                    //    NV_EMAIL_CLIENT.Text + "@" + NV_DOMAINE_EMAIL.Text, NV_EXO_CLIENT.Checked,
                    //    NV_ATTEST_EXO_CLIENT.Text, NV_CODE_DOUANE_CLIENT.Text, NV_CODE_TVA_CLIENT.Text, 
                    //    NV_ETAT_CLIENT.Checked, false, Convert.ToDecimal( NV_MAX_CREDIT.Text));
                    res = CLIENT_APP_PARAM.gcws.INSERT_CLIENT(CODE_CLIENT, NV_REF_CLIENT.Text,
                        NV_RS_CLIENT.Text, NV_ADRESSE_CLIENT.Text, NV_CP_CLIENT.Text, NV_VILLE_CLIENT.Text,
                        NV_PAYS_CLIENT.Text, NV_TEL_CLIENT.Text, NV_TEL2_CLIENT.Text, NV_FAX_CLIENT.Text,
                        NV_EMAIL_CLIENT.Text + "@" + NV_DOMAINE_EMAIL.Text, NV_EXO_CLIENT.Checked,
                        NV_ATTEST_EXO_CLIENT.Text, NV_CODE_DOUANE_CLIENT.Text, NV_CODE_TVA_CLIENT.Text,
                        NV_ETAT_CLIENT.Checked, false, Convert.ToDecimal(NV_MAX_CREDIT.Text),txtResponsableClient.Text);
                    CODE_CLIENT = res.CODE;
                    ((DataRowView)bs.Current)["CODE_CLIENT"] = CODE_CLIENT;
                    

                    if (res.OK)
                    {
                        bs.EndEdit();
                        client_param.AcceptChanges();
                        if (ENREG_EV != null)
                            ENREG_EV((DataRowView)bs.Current, true);
                        if (MessageBox.Show(res.MESSAGE + "\nVoulez vous ajouter un autre client?", "Nouveau client", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                            this.Close();
                        else
                        {
                            this.Close();
                            CHM_NOUVEAU_CLIENT f = new CHM_NOUVEAU_CLIENT("-1");
                            f.ShowDialog();
                        }
                    }
                    else
                    {
                        MessageBox.Show(res.MESSAGE, CLIENT_APP_PARAM.Fenetre_principale.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        client_param.RejectChanges();
                        return;
                        MessageBox.Show(res.MESSAGE, "New client", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    Application.DoEvents();

                    //res = CLIENT_APP_PARAM.GEST.P_CLIENT.UPDATE_CLIENT(CODE_CLIENT, NV_REF_CLIENT.Text, NV_RS_CLIENT.Text, NV_ADRESSE_CLIENT.Text,
                    //    NV_CP_CLIENT.Text, NV_VILLE_CLIENT.Text, NV_PAYS_CLIENT.Text, NV_TEL_CLIENT.Text, NV_TEL2_CLIENT.Text, NV_FAX_CLIENT.Text, 
                    //    NV_EMAIL_CLIENT.Text + "@" + NV_DOMAINE_EMAIL.Text, NV_EXO_CLIENT.Checked, NV_ATTEST_EXO_CLIENT.Text, NV_CODE_DOUANE_CLIENT.Text,
                    //    NV_CODE_TVA_CLIENT.Text, NV_ETAT_CLIENT.Checked, Convert.ToDecimal(NV_MAX_CREDIT.Text));
                    res = CLIENT_APP_PARAM.gcws.UPDATE_CLIENT(CODE_CLIENT, NV_REF_CLIENT.Text, NV_RS_CLIENT.Text, NV_ADRESSE_CLIENT.Text,
                        NV_CP_CLIENT.Text, NV_VILLE_CLIENT.Text, NV_PAYS_CLIENT.Text, NV_TEL_CLIENT.Text, NV_TEL2_CLIENT.Text, NV_FAX_CLIENT.Text,
                        NV_EMAIL_CLIENT.Text + "@" + NV_DOMAINE_EMAIL.Text, NV_EXO_CLIENT.Checked, NV_ATTEST_EXO_CLIENT.Text, NV_CODE_DOUANE_CLIENT.Text,
                        NV_CODE_TVA_CLIENT.Text, NV_ETAT_CLIENT.Checked, Convert.ToDecimal(NV_MAX_CREDIT.Text), txtResponsableClient.Text);
                    

                    if (res.OK)
                    {
                        bs.EndEdit();
                        client_param.AcceptChanges();
                        if (ENREG_EV != null)
                            ENREG_EV((DataRowView)bs.Current, false);
                        MessageBox.Show(res.MESSAGE, CLIENT_APP_PARAM.Fenetre_principale.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        client_param.RejectChanges();
                        MessageBox.Show(res.MESSAGE, CLIENT_APP_PARAM.Fenetre_principale.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        
                    }

                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NV_EXO_CLIENT_CheckedChanged(object sender, EventArgs e)
        {
            NV_ATTEST_EXO_CLIENT.Enabled = NV_EXO_CLIENT.Checked;
        }

        private void CHM_NOUVEAU_CLIENT_Shown(object sender, EventArgs e)
        {
            try
            {
                if (CODE_CLIENT != "-1")
                {
                    nv_clt_titre.Text = "Modifier Client";

                }


                Application.DoEvents();

                //client_param = CLIENT_APP_PARAM.GEST.P_CLIENT.LOAD_CLIENT(CODE_CLIENT);
                client_param = CLIENT_APP_PARAM.gcws.LOAD_CLIENT(CODE_CLIENT);
                bs.DataSource = client_param;
                NV_REF_CLIENT.DataBindings.Add("Text", bs, "REF_CLIENT");
                NV_ETAT_CLIENT.DataBindings.Add("Checked", bs, "ETAT_CLIENT", true );
                NV_RS_CLIENT.DataBindings.Add("Text", bs, "RS_CLIENT", true);
                txtResponsableClient.DataBindings.Add("Text", bs, "RESP_CLIENT", true);
                NV_ADRESSE_CLIENT.DataBindings.Add("Text", bs, "ADRESSE_CLIENT", true);
                NV_CP_CLIENT.DataBindings.Add("Text", bs, "CP_CLIENT", true);
                NV_TEL_CLIENT.DataBindings.Add("Text", bs, "TEL_CLIENT", true);
                NV_FAX_CLIENT.DataBindings.Add("Text", bs, "FAX_CLIENT", true);
                NV_EMAIL_CLIENT.DataBindings.Add("Text", bs, "EMAIL_CLIENT", true);
                NV_EXO_CLIENT.DataBindings.Add("Checked", bs, "EXO_CLIENT", true);
                NV_ATTEST_EXO_CLIENT.DataBindings.Add("Text", bs, "ATTEST_EXO_CLIENT", true);
                NV_CODE_TVA_CLIENT.DataBindings.Add("Text", bs, "CODE_TVA_CLIENT", true);
                NV_CODE_DOUANE_CLIENT.DataBindings.Add("Text", bs, "CODE_DOUANE_CLIENT", true);
                NV_VILLE_CLIENT.DataBindings.Add("Text", bs, "VILLE_CLIENT", true);
                NV_PAYS_CLIENT.DataBindings.Add("Text", bs, "PAYS_CLIENT", true);
                NV_TEL2_CLIENT.DataBindings.Add("Text", bs, "TEL2_CLIENT", true);
                NV_MAX_CREDIT.DataBindings.Add("Text", bs, "MAX_CREDIT", true);
                if (CODE_CLIENT == "-1")
                {
                    bs.AddNew();
                    DataRowView clt_drv =  (DataRowView)bs.Current;
                    clt_drv["CODE_CLIENT"] = -1;
                    clt_drv["ETAT_CLIENT"] = false;
                    clt_drv["EXO_CLIENT"] = false;
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Server connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CHM_NOUVEAU_CLIENT_KeyDown(object sender, KeyEventArgs e)
        {
            if (CODE_CLIENT == "-1" && NV_REF_CLIENT.Focused && e.KeyCode == Keys.Enter)
            {
                try
                {
                    Application.DoEvents();
                    //NV_REF_CLIENT.Text = CLIENT_APP_PARAM.GEST.P_CLIENT.NEW_CODE(5);
                    NV_REF_CLIENT.Text = CLIENT_APP_PARAM.gcws.NEW_CODE(5);
                    NV_ETAT_CLIENT.Focus();
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message, "Server connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return;
            }
            // Parcours vers le bas
            if (NV_REF_CLIENT.Focused && NV_REF_CLIENT.Text != "" && e.KeyCode == Keys.Enter)
            {
                NV_ETAT_CLIENT.Focus();
                return;
            }
            if (NV_REF_CLIENT.Focused && e.KeyCode == Keys.Down )
            {
                NV_ETAT_CLIENT.Focus();
                return;
            }
            if (NV_ETAT_CLIENT.Focused && (e.KeyCode == Keys.Down || e.KeyCode == Keys.Enter || e.KeyCode == Keys.Right))
            {
                NV_RS_CLIENT.Focus();
                if (NV_RS_CLIENT.Text != "")
                    NV_RS_CLIENT.SelectAll();
                return;
            }
            if (NV_RS_CLIENT.Focused && (e.KeyCode == Keys.Down || e.KeyCode == Keys.Enter || e.KeyCode == Keys.Right))
            {
                NV_ADRESSE_CLIENT.Focus();
                if (NV_ADRESSE_CLIENT.Text != "")
                    NV_ADRESSE_CLIENT.SelectAll();
                return;
            }
            if (NV_ADRESSE_CLIENT.Focused && (e.KeyCode == Keys.Down || e.KeyCode == Keys.Enter || e.KeyCode == Keys.Right))
            {
                NV_CP_CLIENT.Focus();
                if (NV_CP_CLIENT.Text != "")
                    NV_CP_CLIENT.SelectAll();
                return;
            }
            if (NV_CP_CLIENT.Focused && (e.KeyCode == Keys.Down || e.KeyCode == Keys.Enter || e.KeyCode == Keys.Right))
            {
                NV_VILLE_CLIENT.Focus();
                if (NV_VILLE_CLIENT.Text != "")
                    NV_VILLE_CLIENT.SelectAll();
                return;
            }
            if (NV_VILLE_CLIENT.Focused && (e.KeyCode == Keys.Down || e.KeyCode == Keys.Enter || e.KeyCode == Keys.Right))
            {
                NV_PAYS_CLIENT.Focus();
                if (NV_PAYS_CLIENT.Text != "")
                    NV_PAYS_CLIENT.SelectAll();
                return;
            }
            if (NV_PAYS_CLIENT.Focused && (e.KeyCode == Keys.Down || e.KeyCode == Keys.Enter || e.KeyCode == Keys.Right))
            {
                NV_TEL_CLIENT.Focus();
                if (NV_TEL_CLIENT.Text != "")
                    NV_TEL_CLIENT.SelectAll();
                return;
            }
            if (NV_TEL_CLIENT.Focused && (e.KeyCode == Keys.Down || e.KeyCode == Keys.Enter || e.KeyCode == Keys.Right))
            {
                //NV_TEL2_CLIENT.Focus();
                //if (NV_TEL2_CLIENT.Text != "")
                //    NV_TEL2_CLIENT.SelectAll();
                //return;
                NV_FAX_CLIENT.Focus();
                if (NV_FAX_CLIENT.Text != "")
                    NV_FAX_CLIENT.SelectAll();
                return;
            }
            //if (NV_TEL2_CLIENT.Focused && (e.KeyCode == Keys.Down || e.KeyCode == Keys.Enter || e.KeyCode == Keys.Right))
            //{
            //    NV_FAX_CLIENT.Focus();
            //    if (NV_FAX_CLIENT.Text != "")
            //        NV_FAX_CLIENT.SelectAll();
            //    return;
            //}
            if (NV_FAX_CLIENT.Focused && (e.KeyCode == Keys.Down || e.KeyCode == Keys.Enter || e.KeyCode == Keys.Right))
            {
                NV_EMAIL_CLIENT.Focus();
                if (NV_EMAIL_CLIENT.Text != "")
                    NV_EMAIL_CLIENT.SelectAll();
                return;
            }
            if (NV_EMAIL_CLIENT.Focused && (e.KeyCode == Keys.Down || e.KeyCode == Keys.Enter || e.KeyCode == Keys.Right))
            {
                NV_EXO_CLIENT.Focus();
                return;
            }
            if (NV_EXO_CLIENT.Focused && (e.KeyCode == Keys.Down || e.KeyCode == Keys.Enter || e.KeyCode == Keys.Right))
            {
                NV_ATTEST_EXO_CLIENT.Focus();
                if (NV_ATTEST_EXO_CLIENT.Text != "")
                    NV_RS_CLIENT.SelectAll();
                return;
            }
            if (NV_EXO_CLIENT.Focused && (e.KeyCode == Keys.Down || e.KeyCode == Keys.Enter || e.KeyCode == Keys.Right))
            {
                NV_CODE_TVA_CLIENT.Focus();
                if (NV_CODE_TVA_CLIENT.Text != "")
                    NV_CODE_TVA_CLIENT.SelectAll();
                return;
            }
            if (NV_ATTEST_EXO_CLIENT.Focused && (e.KeyCode == Keys.Down || e.KeyCode == Keys.Enter || e.KeyCode == Keys.Right))
            {
                NV_CODE_TVA_CLIENT.Focus();
                if (NV_CODE_TVA_CLIENT.Text != "")
                    NV_CODE_TVA_CLIENT.SelectAll();
                return;
            }
            if (NV_CODE_TVA_CLIENT.Focused && (e.KeyCode == Keys.Down || e.KeyCode == Keys.Enter || e.KeyCode == Keys.Right))
            {
                NV_CODE_DOUANE_CLIENT.Focus();
                if (NV_CODE_DOUANE_CLIENT.Text != "")
                    NV_CODE_DOUANE_CLIENT.SelectAll();
                return;
            }
            if (NV_CODE_DOUANE_CLIENT.Focused && (e.KeyCode == Keys.Down || e.KeyCode == Keys.Enter || e.KeyCode == Keys.Right))
            {
                NV_MAX_CREDIT.Focus();
                if (NV_MAX_CREDIT.Text != "")
                    NV_MAX_CREDIT.SelectAll();
                return;
            }
            if (NV_MAX_CREDIT.Focused && (e.KeyCode == Keys.Down || e.KeyCode == Keys.Enter || e.KeyCode == Keys.Right))
            {
                BTN_ENREG_NV_CLT.Focus();
                return;
            }
            if (BTN_ENREG_NV_CLT.Focused && (e.KeyCode == Keys.Down || e.KeyCode == Keys.Right))
            {
                BTN_ANNULER_NV_CLT.Focus();
                return;
            }
            if (BTN_ENREG_NV_CLT.Focused && (e.KeyCode == Keys.Enter))
            {
                BTN_ENREG_NV_CLT.PerformClick() ;
                return;
            }
            if (BTN_ANNULER_NV_CLT.Focused && (e.KeyCode == Keys.Down || e.KeyCode == Keys.Right))
            {
                NV_REF_CLIENT.Focus();
                return;
            }
            if (BTN_ANNULER_NV_CLT.Focused && (e.KeyCode == Keys.Enter))
            {
                BTN_ENREG_NV_CLT.PerformClick();
                return;
            }

            // Parcours vers le haut

            if (NV_REF_CLIENT.Focused && e.KeyCode == Keys.Up)
            {
                BTN_ANNULER_NV_CLT.Focus();
                return;
            }
            if (NV_ETAT_CLIENT.Focused && e.KeyCode == Keys.Up)
            {
                NV_REF_CLIENT.Focus();
                if (NV_REF_CLIENT.Text != "")
                    NV_REF_CLIENT.SelectAll();
                return;
            }
            if (NV_RS_CLIENT.Focused && e.KeyCode == Keys.Up)
            {
                NV_ETAT_CLIENT.Focus();
                return;
            }
            if (NV_ADRESSE_CLIENT.Focused && e.KeyCode == Keys.Up)
            {
                NV_RS_CLIENT.Focus();
                if (NV_RS_CLIENT.Text != "")
                    NV_RS_CLIENT.SelectAll();
                return;
            }
            if (NV_CP_CLIENT.Focused && e.KeyCode == Keys.Up)
            {
                NV_ADRESSE_CLIENT.Focus();
                if (NV_ADRESSE_CLIENT.Text != "")
                    NV_ADRESSE_CLIENT.SelectAll();
                return;
            }
            if (NV_TEL_CLIENT.Focused && e.KeyCode == Keys.Up)
            {
                NV_CP_CLIENT.Focus();
                if (NV_CP_CLIENT.Text != "")
                    NV_CP_CLIENT.SelectAll();
                return;
            }
            if (NV_FAX_CLIENT.Focused && e.KeyCode == Keys.Up)
            {
                NV_TEL_CLIENT.Focus();
                if (NV_TEL_CLIENT.Text != "")
                    NV_TEL_CLIENT.SelectAll();
                return;
            }
            if (NV_EMAIL_CLIENT.Focused && e.KeyCode == Keys.Up)
            {
                NV_FAX_CLIENT.Focus();
                if (NV_FAX_CLIENT.Text != "")
                    NV_FAX_CLIENT.SelectAll();
                return;
            }
            if (NV_EXO_CLIENT.Focused && e.KeyCode == Keys.Up)
            {
                NV_EMAIL_CLIENT.Focus();
                if (NV_EMAIL_CLIENT.Text != "")
                    NV_EMAIL_CLIENT.SelectAll();
                return;
            }
            if (NV_ATTEST_EXO_CLIENT.Focused && e.KeyCode == Keys.Up )
            {
                NV_EXO_CLIENT.Focus();
                return;
            }
            if (NV_CODE_TVA_CLIENT.Focused && NV_EXO_CLIENT.CheckState == CheckState.Checked && e.KeyCode == Keys.Up)
            {
                NV_ATTEST_EXO_CLIENT.Focus();
                if (NV_ATTEST_EXO_CLIENT.Text != "")
                    NV_RS_CLIENT.SelectAll();
                return;
            }
            if (NV_CODE_TVA_CLIENT.Focused && NV_EXO_CLIENT.CheckState == CheckState.Unchecked && e.KeyCode == Keys.Up )
            {
                NV_EXO_CLIENT.Focus();
                return;
            }
            if (NV_CODE_DOUANE_CLIENT.Focused && e.KeyCode == Keys.Up)
            {
                NV_CODE_TVA_CLIENT.Focus();
                if (NV_CODE_TVA_CLIENT.Text != "")
                    NV_CODE_TVA_CLIENT.SelectAll();
                return;
            }
            if (BTN_ENREG_NV_CLT.Focused && e.KeyCode == Keys.Up )
            {
                NV_CODE_DOUANE_CLIENT.Focus();
                return;
            }
            if (BTN_ANNULER_NV_CLT.Focused && e.KeyCode == Keys.Up)
            {
                BTN_ENREG_NV_CLT.Focus();
                return;
            }

            // Fermer fiche
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void BTN_ANNULER_Click(object sender, EventArgs e)
        {
            DOMAINE_PANEL.Visible = false;
        }

        private void BTN_OK_Click(object sender, EventArgs e)
        {
            string s = "";
            s += DOMAINE.Text + "." + DOMAINE2.Text;
            NV_DOMAINE_EMAIL.Items.Add(s);
            DOMAINE_PANEL.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DOMAINE_PANEL.Visible = true;
        }

        private void NV_REF_CLIENT_Enter(object sender, EventArgs e)
        {
            //if ((sender as TextBox).Text!="")
            //(sender as TextBox).SelectAll();
        }

        private void CHM_NOUVEAU_CLIENT_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }


    }
}
