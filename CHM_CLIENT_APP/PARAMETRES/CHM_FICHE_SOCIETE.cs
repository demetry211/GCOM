using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CHM_CLIENT_APP
{
    public partial class CHM_FICHE_SOCIETE : Form
    {
        DataTable dt;
        BindingSource bs = new BindingSource();
        public CHM_FICHE_SOCIETE()
        {
            InitializeComponent();
        }

        private void CHM_FICHE_SOCIETE_Shown(object sender, EventArgs e)
        {
            
        }

        private void buttonFERMER_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonENREGISTRER_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                Application.DoEvents();
                CHMGC.RESULT_QUERY res = CLIENT_APP_PARAM.gcws.ENREGISTRER("1", dt);
                if (res.OK)
                    MessageBox.Show(res.MESSAGE, "Enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show(res.MESSAGE, "Enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Connexion serveur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void buttonPARCOURIR_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                
                LOGO_SOCIETE.Image = Image.FromFile(openFileDialog1.FileName);
                bs.EndEdit();
                (bs.DataSource as DataTable).AcceptChanges();
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void CHM_FICHE_SOCIETE_Load(object sender, EventArgs e)
        {
            try
            {

                Application.DoEvents();
                dt = CLIENT_APP_PARAM.gcws.LOAD_CONFIG_SOCIETE();
                bs.DataSource = dt;
                RS_SOCIETE.DataBindings.Add("Text", bs, "RS_SOCIETE", true);
                DESCRIPTION_SOCIETE.DataBindings.Add("Text", bs, "DESCRIPTION_SOCIETE", true);
                ADRESSE_SOCIETE.DataBindings.Add("Text", bs, "ADRESSE_SOCIETE", true);
                CP_SOCIETE.DataBindings.Add("Text", bs, "CP_SOCIETE", true);
                TEL_SOCIETE.DataBindings.Add("Text", bs, "TEL_SOCIETE", true);
                FAX_SOCIETE.DataBindings.Add("Text", bs, "FAX_SOCIETE", true);
                EMAIL_SOCIETE.DataBindings.Add("Text", bs, "EMAIL_SOCIETE", true);
                SITE_WEB_SOCIETE.DataBindings.Add("Text", bs, "SITE_WEB_SOCETE", true);
                LOGO_SOCIETE.DataBindings.Add("Image", bs, "LOGO_SOCIETE", true);
                CODE_TVA_SOCIETE.DataBindings.Add("Text", bs, "CODE_TVA_SOCIETE", true);
                RIB_SOCIETE.DataBindings.Add("Text", bs, "RIB_SOCIETE", true);

                NUM_DEVC.DataBindings.Add("Value", bs, "NUM_DEVC", true);
                PREFIX1_DEVC.DataBindings.Add("Text", bs, "PREFIX1_DEVC", true);
                PREFIX2_DEVC.DataBindings.Add("Text", bs, "PREFIX2_DEVC", true);

                NUM_COMMANDE.DataBindings.Add("Value", bs, "NUM_COMMANDE", true);
                PREFIX1_COMMANDE.DataBindings.Add("Text", bs, "PREFIX1_COMMANDE", true);
                PREFIX2_COMMANDE.DataBindings.Add("Text", bs, "PREFIX2_COMMANDE", true);

                NUM_FACTURE.DataBindings.Add("Value", bs, "NUM_FACTURE", true);
                PREFIX1_FACTURE.DataBindings.Add("Text", bs, "PREFIX1_FACTURE", true);
                PREFIXE2_FACTURE.DataBindings.Add("Text", bs, "PREFIXE2_FACTURE", true);

                NUM_B_LIV.DataBindings.Add("Value", bs, "NUM_B_LIV", true);
                PREFIXE1_B_LIV.DataBindings.Add("Text", bs, "PREFIX1_B_LIV", true);
                PREFIX2_B_LIV.DataBindings.Add("Text", bs, "PREFIX2_B_LIV", true);

                NUM_CF.DataBindings.Add("Value", bs, "NUM_CF", true);
                PREFIX1_CF.DataBindings.Add("Text", bs, "PREFIX1_CF", true);
                PREFIX2_CF.DataBindings.Add("Text", bs, "PREFIX2_CF", true);

                NUM_FI.DataBindings.Add("Value", bs, "NUM_FI", true);
                PREFIX1_FI.DataBindings.Add("Text", bs, "PREFIX1_FI", true);
                PREFIX2_FI.DataBindings.Add("Text", bs, "PREFIX2_FI", true);

                NUM_TC.DataBindings.Add("Value", bs, "NUM_TC", true);
                PREFIX1_TC.DataBindings.Add("Text", bs, "PREFIX1_TC", true);
                PREFIX2_TC.DataBindings.Add("Text", bs, "PREFIX2_TC", true);

                NUM_BON_RECEPTION.DataBindings.Add("Value", bs, "NUM_BON_RECEPTION", true);
                PREFIX1_BRECEP.DataBindings.Add("Text", bs, "PREFIX1_BRECEP", true);
                PREFIX2_BRECEP.DataBindings.Add("Text", bs, "PREFIX2_BRECEP", true);

                NUM_BONRETOUR_FR.DataBindings.Add("Value", bs, "NUM_BRETOUR_FR", true);
                PREFIX1_BRET_FR.DataBindings.Add("Text", bs, "PREFIX1_BRET_FR", true);
                PREFIX2_BRET_FR.DataBindings.Add("Text", bs, "PREFIX2_BRET_FR", true);

                NUM_BRET_CLT.DataBindings.Add("Value", bs, "NUM_BRETOUR_CLIENT", true);
                PREFIX1_BRET_CLT.DataBindings.Add("Text", bs, "PREFIX1_BRET_CLT", true);
                PREFIX2_BRET_CLT.DataBindings.Add("Text", bs, "PREFIX2_BRET_CLT", true);

                txt_TIMBRE.DataBindings.Add("EditValue", bs, "TIMBRE", true);

                if (NUM_COMMANDE.Value != 0)
                {
                    PREFIX1_COMMANDE.Enabled = NUM_COMMANDE.Enabled = PREFIX2_COMMANDE.Enabled = false;
                }

                if (NUM_FACTURE.Value != 0)
                {
                    PREFIX1_FACTURE.Enabled = NUM_FACTURE.Enabled = PREFIXE2_FACTURE.Enabled = false;
                }

                if (NUM_CF.Value != 0)
                {
                    PREFIX1_CF.Enabled = NUM_CF.Enabled = PREFIX2_CF.Enabled = false;
                }

                if (NUM_B_LIV.Value != 0)
                {
                    PREFIXE1_B_LIV.Enabled = NUM_B_LIV.Enabled = PREFIX2_B_LIV.Enabled = false;
                }

                if (NUM_DEVC.Value != 0)
                {
                    PREFIX1_DEVC.Enabled = NUM_DEVC.Enabled = PREFIX2_DEVC.Enabled = false;
                }

                if (NUM_TC.Value != 0)
                {
                    PREFIX1_TC.Enabled = NUM_TC.Enabled = PREFIX2_TC.Enabled = false;
                }

                if (NUM_FI.Value != 0)
                {
                    PREFIX1_FI.Enabled = NUM_FI.Enabled = PREFIX2_FI.Enabled = false;
                }

                if (NUM_BRET_CLT.Value != 0)
                {
                    PREFIX1_BRET_CLT.Enabled = NUM_BRET_CLT.Enabled = PREFIX2_BRET_CLT.Enabled = false;
                }

                if (NUM_BONRETOUR_FR.Value != 0)
                {
                    PREFIX1_BRET_FR.Enabled = NUM_BONRETOUR_FR.Enabled = PREFIX2_BRET_FR.Enabled = false;
                }

                if (NUM_BON_RECEPTION.Value != 0)
                {
                    PREFIX1_BRECEP.Enabled = NUM_BON_RECEPTION.Enabled = PREFIX2_BRECEP.Enabled = false;
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Connexion serveur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
