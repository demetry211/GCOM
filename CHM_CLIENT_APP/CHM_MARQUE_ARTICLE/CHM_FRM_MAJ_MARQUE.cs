using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CHM_CLIENT_APP.CHMMARQUE;

namespace CHM_CLIENT_APP.CHM_MARQUE_ARTICLE
{
    public partial class CHM_FRM_MAJ_MARQUE : Form
    {
        decimal code;
        BindingSource bs;
        public CHM_FRM_MAJ_MARQUE(BindingSource bs)
        {
            InitializeComponent();
            this.bs = bs;

            chM_CMP_VALIDATION1.button1.Click += new EventHandler(button1_Click);
            chM_CMP_VALIDATION1.button2.Click += new EventHandler(button2_Click);

            DataRowView drv = (DataRowView)this.bs.Current;
            code = (decimal)drv["CODE_MARQUE"];
            if (code == -1)
            {
                this.Text = entete_Formulaire_21.windows_name.Text = "Nouvelle marque";
            }
            else
                this.Text = entete_Formulaire_21.windows_name.Text = "Modification marque";

            txt_DESCRIPTION_MARQUE.DataBindings.Add("Text", this.bs, "DESCRIPTION_MARQUE", true);
            txt_DESIGNATION_MARQUE.DataBindings.Add("Text", this.bs, "DESIGNATION_MARQUE", true);
            txt_REF_MARQUE.DataBindings.Add("Text", this.bs, "REF_MARQUE", true);
        }

        void button2_Click(object sender, EventArgs e)
        {
            bs.CancelEdit();
            Close();
        }

        void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (code == -1)
                {
                    RESULT_QUERY res = new RESULT_QUERY();
                    res = CLIENT_APP_PARAM.gmarque.insertMarque(txt_REF_MARQUE.Text, txt_DESIGNATION_MARQUE.Text, txt_DESCRIPTION_MARQUE.Text);
                    if (res.OK)
                    {
                        MessageBox.Show(res.MESSAGE);
                        ((DataRowView)bs.Current)["CODE_MARQUE"] = res.CODE;
                        bs.EndEdit();
                        (bs.DataSource as DataTable).AcceptChanges();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show(res.MESSAGE);
                        return;
                    }
                }
                else
                {
                    RESULT_QUERY res = new RESULT_QUERY();
                    res = CLIENT_APP_PARAM.gmarque.updateMarque(code, txt_DESIGNATION_MARQUE.Text, txt_DESCRIPTION_MARQUE.Text);
                    if (res.OK)
                    {
                        MessageBox.Show(res.MESSAGE);
                        bs.EndEdit();
                        (bs.DataSource as DataTable).AcceptChanges();
                    }
                    else
                    {
                        MessageBox.Show(res.MESSAGE);
                        return;
                    }
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void CHM_FRM_MAJ_MARQUE_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{tab}");
            if (e.KeyCode == Keys.Escape)
                this.Close();
            if (e.KeyCode == Keys.Down)
                SendKeys.Send("{tab}");
            if (e.KeyCode == Keys.Up)
                SendKeys.Send("+{tab}");
        }


    }
}