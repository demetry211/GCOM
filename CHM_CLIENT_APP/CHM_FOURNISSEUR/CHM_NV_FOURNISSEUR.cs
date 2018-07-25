using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CHM_CLIENT_APP
{
    public partial class CHM_NV_FOURNISSEUR : Form
    {
        string code = "-1";
        public delegate void ENREG_FOURNISSEUR_DELEG(DataRowView fournisseur, bool type);
        public event ENREG_FOURNISSEUR_DELEG enreg_fourn_ev;
        DataTable dt ;
        BindingSource bs = new BindingSource();
        public CHM_NV_FOURNISSEUR(string code)
        {
            InitializeComponent();
            this.code = code;
        }

        private void BTN_ENREG_FOURNISSEUR_Click(object sender, EventArgs e)
        {
            try
            {
                bs.EndEdit();
                dt.AcceptChanges();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dt.RejectChanges();
                return;
            }
            if (code == "-1")
            {
                Application.DoEvents();
                //string res = CLIENT_APP_PARAM.GEST.P_FOURNISSEUR.INSERT_FOURNISSEUR(code, REF_FOURNISSEUR.Text, RS_FOURNISSEUR.Text, ADRESSE_FOURNISSEUR.Text, TEL_FOURNISSEUR.Text, FAX_FOURNISSEUR.Text, EMAIL_FOURNISSEUR.Text, SITE_WEB_FOURNISSEUR.Text, RIB_FOURNISSEUR.Text, CODE_TVA_FOURNISSEUR.Text);
                string res = CLIENT_APP_PARAM.gcws.INSERT_FOURNISSEUR(code, REF_FOURNISSEUR.Text, RS_FOURNISSEUR.Text, ADRESSE_FOURNISSEUR.Text, TEL_FOURNISSEUR.Text, FAX_FOURNISSEUR.Text, EMAIL_FOURNISSEUR.Text, SITE_WEB_FOURNISSEUR.Text, RIB_FOURNISSEUR.Text, CODE_TVA_FOURNISSEUR.Text, Convert.ToDecimal(txt_RETENUE_SOURCE.EditValue));
                if (enreg_fourn_ev != null)
                    enreg_fourn_ev((DataRowView)bs.Current, true);
                if (res == "OK")
                {
                    MessageBox.Show("Fournisseur enregistré.", "Ajout fournisseur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show(res, "Ajout fournisseur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                Application.DoEvents();
                //string res = CLIENT_APP_PARAM.GEST.P_FOURNISSEUR.UPDATE_FOURNISSEUR(code, REF_FOURNISSEUR.Text, RS_FOURNISSEUR.Text, ADRESSE_FOURNISSEUR.Text, TEL_FOURNISSEUR.Text, FAX_FOURNISSEUR.Text, EMAIL_FOURNISSEUR.Text, SITE_WEB_FOURNISSEUR.Text, RIB_FOURNISSEUR.Text, CODE_TVA_FOURNISSEUR.Text);
                string res = CLIENT_APP_PARAM.gcws.UPDATE_FOURNISSEUR(code, REF_FOURNISSEUR.Text, RS_FOURNISSEUR.Text, ADRESSE_FOURNISSEUR.Text, TEL_FOURNISSEUR.Text, FAX_FOURNISSEUR.Text, EMAIL_FOURNISSEUR.Text, SITE_WEB_FOURNISSEUR.Text, RIB_FOURNISSEUR.Text, CODE_TVA_FOURNISSEUR.Text, Convert.ToDecimal(txt_RETENUE_SOURCE.EditValue));
                if (enreg_fourn_ev != null)
                    enreg_fourn_ev((DataRowView)bs.Current, false);
                if (res == "OK")
                {
                    MessageBox.Show("Fournisseur enregistré.", "Ajout fournisseur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show(res, "Ajout fournisseur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void CHM_NV_FOURNISSEUR_Shown(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (code != "-1")
                {
                    this.Text = Nom_fenetre.Text = "Modification du fournisseur";
                }
                //dt = CLIENT_APP_PARAM.GEST.P_FOURNISSEUR.LOAD_FOURNISSEUR(code);
                dt = CLIENT_APP_PARAM.gcws.LOAD_FOURNISSEUR(code);
                bs.DataSource = dt;

                REF_FOURNISSEUR.DataBindings.Add("Text", bs, "REF_FOURNISSEUR");
                RS_FOURNISSEUR.DataBindings.Add("Text", bs, "RS_FOURNISSEUR", true);
                ADRESSE_FOURNISSEUR.DataBindings.Add("Text", bs, "ADRESSE_FOURNISSEUR", true);
                TEL_FOURNISSEUR.DataBindings.Add("Text", bs, "TEL_FOURNISSEUR", true);
                FAX_FOURNISSEUR.DataBindings.Add("Text", bs, "FAX_FOURNISSEUR", true);
                EMAIL_FOURNISSEUR.DataBindings.Add("Text", bs, "EMAIL_FOURNISSEUR", true);
                SITE_WEB_FOURNISSEUR.DataBindings.Add("Text", bs, "SITE_WEB_FOURNISSEUR", true);
                RIB_FOURNISSEUR.DataBindings.Add("Text", bs, "RIB_FOURNISSEUR", true);
                CODE_TVA_FOURNISSEUR.DataBindings.Add("Text", bs, "CODE_TVA_FOURNISSEUR", true);
                txt_RETENUE_SOURCE.DataBindings.Add("EditValue", bs, "RETENUE_SOURCE", true);
                if (code == "-1")
                {
                    this.Text = "Ajout de fournisseur";
                    bs.AddNew();
                    DataRowView drv = (DataRowView)bs.Current;
                    drv["CODE_FOURNISSEUR"] = -1;
                }
            }
            catch (Exception er)
            {
                BTN_ENREG_FOURNISSEUR.Enabled = false;
                MessageBox.Show(er.Message, "Connexion serveur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void BTN_ANNULER_FOURNISSEUR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void CHM_NV_FOURNISSEUR_Load(object sender, EventArgs e)
        {

        }

    }
}
