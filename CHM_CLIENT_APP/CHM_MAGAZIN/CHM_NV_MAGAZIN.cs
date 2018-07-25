using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CHM_CLIENT_APP
{
    public partial class CHM_NV_MAGAZIN : Form
    {
        string CODE_MAG = "-1";
        public delegate void enreg_deleg(DataRowView mag, bool etat);
        public event enreg_deleg enreg_event;
        public CHM_NV_MAGAZIN(string CODE_MAG)
        {
            InitializeComponent();
            this.CODE_MAG = CODE_MAG;
        }
        DataTable dt;
        BindingSource bs = new BindingSource();
        DataTable dt_societe;
        BindingSource bs_societe = new BindingSource();
        private void CHM_NV_MAGAZIN_Shown(object sender, EventArgs e)
        {
            try
            {
                dt_societe = CLIENT_APP_PARAM.gcws.SELECT_ALL_SOCIETE();                
                SOCIETE_NV_MAG.DataSource = dt_societe;
                SOCIETE_NV_MAG.DisplayMember = "RS_SOCIETE";
                SOCIETE_NV_MAG.ValueMember = "CODE_SOCIETE";
                
                Application.DoEvents();
                dt = CLIENT_APP_PARAM.gcws.LOAD_MAGAZIN(CODE_MAG);
                bs.DataSource = dt;
                NOM_NV_MAG.DataBindings.Add("Text", bs, "NOM_MAG", true);
                ADR_NV_MAG.DataBindings.Add("Text", bs, "ADRESSE_MAG", true);
                TEL_NV_MAG.DataBindings.Add("Text", bs, "TEL_MAG", true);
                if (CODE_MAG != "-1")
                {
                    this.Text=NOM_FENETRE.Text = "Modifier Magasin";
                    SOCIETE_NV_MAG.SelectedValue=(decimal)dt.Rows[0]["CODE_SOCIETE"];
                }
                if (CODE_MAG == "-1")
                {
                    this.Text = NOM_FENETRE.Text = "Ajouter Magasin";

                    bs.AddNew();
                    DataRowView drv = (DataRowView)bs.Current;

                    drv["CODE_MAG"] = -1;
                    drv["CODE_SOCIETE"] = 1;
                }
            }
            catch (Exception er)
            {
                BTN_ENREG_MAG.Enabled = false;
                MessageBox.Show(er.Message, CLIENT_APP_PARAM.Fenetre_principale.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void BTN_ENREG_MAG_Click(object sender, EventArgs e)
        {
            try
            {
                bs.EndEdit();
                dt.AcceptChanges();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, CLIENT_APP_PARAM.Fenetre_principale.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dt.RejectChanges();
                return;
            }

            try
            {
                CHMGC.RESULT_QUERY res;
                if (CODE_MAG == "-1")
                {
                    Application.DoEvents();
                    res = CLIENT_APP_PARAM.gcws.INSERT_MAGAZIN(CODE_MAG, NOM_NV_MAG.Text, ADR_NV_MAG.Text, TEL_NV_MAG.Text, SOCIETE_NV_MAG.SelectedValue.ToString(), SOCIETE_NV_MAG.Text.ToString());
                    CODE_MAG = res.CODE;
                    ((DataRowView)this.bs.Current)["CODE_MAG"] = CODE_MAG;
                    if (enreg_event != null)
                        enreg_event((DataRowView)bs.Current, true);
                }
                else
                {
                    Application.DoEvents();
                    res = CLIENT_APP_PARAM.gcws.UPDATE_MAGAZIN(CODE_MAG, NOM_NV_MAG.Text, ADR_NV_MAG.Text, TEL_NV_MAG.Text, SOCIETE_NV_MAG.SelectedValue.ToString(), SOCIETE_NV_MAG.Text.ToString());

                    if (enreg_event != null)
                        enreg_event((DataRowView)bs.Current, false);
                }

                if (res.OK)
                {
                    MessageBox.Show(res.MESSAGE, CLIENT_APP_PARAM.Fenetre_principale.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show(res.MESSAGE, CLIENT_APP_PARAM.Fenetre_principale.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, CLIENT_APP_PARAM.Fenetre_principale.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void BTN_FERMER_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
