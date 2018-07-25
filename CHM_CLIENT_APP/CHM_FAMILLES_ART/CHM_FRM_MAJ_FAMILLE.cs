using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CHM_CLIENT_APP.CHM_FAMILLES_ART
{
    public partial class CHM_FRM_MAJ_FAMILLE : Form
    {
        public delegate void MAJ(decimal codeFamArt);
        public event MAJ OnMaj;
        BindingSource bs;

        public CHM_FRM_MAJ_FAMILLE(BindingSource bs)
        {
            InitializeComponent();
            this.bs = bs;

            lb_CODE_FAMART.DataBindings.Add("Text", bs, "CODE_FAMILLE", true);
            txt_REF_FAMART.DataBindings.Add("Text", bs, "REF_FAMILLE", true);
            txt_DES_FAMART.DataBindings.Add("Text", bs, "DESIGNATION_FAMILLE", true);
            txt_DESC_FAMART.DataBindings.Add("Text", bs, "DESCRIPTION_FAMILLE", true);

            chM_CMP_VALIDATION2.button1.Click += new EventHandler(button1_Click);
            chM_CMP_VALIDATION2.button2.Click += new EventHandler(button2_Click);
        }

        void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Etes vous sûres d'annuler l'opération?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    bs.CancelEdit();
                    (bs.DataSource as DataTable).RejectChanges();
                    Close();
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, this.Text);
            }
        }

        void button1_Click(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)bs.Current;
            try
            {
                CHM_CLIENT_APP.CHM_FAMILLE_ARTICLE.RESULT_QUERY res = new CHM_CLIENT_APP.CHM_FAMILLE_ARTICLE.RESULT_QUERY();
                if ((decimal)drv["CODE_FAMILLE"] == -1)
                {
                    res = CLIENT_APP_PARAM.gfamilleArticle.insertFAMILLE(txt_REF_FAMART.Text, txt_DES_FAMART.Text, txt_DESC_FAMART.Text, 0, "");
                    if (res.OK)
                    {
                        (bs.Current as DataRowView)["CODE_FAMILLE"] = res.CODE;
                        bs.EndEdit();
                        (bs.DataSource as DataTable).AcceptChanges();

                        MessageBox.Show(res.MESSAGE, this.Text);
                        if (OnMaj != null)
                        {
                            OnMaj(Convert.ToDecimal(res.CODE));
                            Close();
                        }
                    }
                    else
                    {
                        bs.CancelEdit();
                        (bs.DataSource as DataTable).RejectChanges();
                        MessageBox.Show(res.MESSAGE, this.Text);
                        Close();
                    }
                }
                else
                {
                    res = CLIENT_APP_PARAM.gfamilleArticle.updateFamille((decimal)drv["CODE_FAMILLE"], txt_REF_FAMART.Text, txt_DES_FAMART.Text, txt_DESC_FAMART.Text, 0);
                    if (res.OK)
                    {
                        bs.EndEdit();
                        (bs.DataSource as DataTable).AcceptChanges();

                        MessageBox.Show(res.MESSAGE, this.Text);
                        if (OnMaj != null)
                        {
                            OnMaj(Convert.ToDecimal(res.CODE));
                            Close();
                        }
                    }
                    else
                    {
                        bs.CancelEdit();
                        (bs.DataSource as DataTable).RejectChanges();
                        MessageBox.Show(res.MESSAGE, this.Text);
                        Close();
                    }
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, this.Text);
            }

        }

        private void CHM_FRM_MAJ_FAMILLE_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{tab}");
            if(e.KeyCode==Keys.Escape)
                button2_Click(null, null);
        }
    }
}