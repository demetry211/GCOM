using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CHM_CLIENT_APP.CHMGC;
using CHM_CLIENT_APP.CHM_UNITE;

namespace CHM_CLIENT_APP.EQUIPEMENTS.TYPE_MAINTENANCE
{
    public partial class CHM_FRM_MAJ_TYPE_MAINT : Form
    {
        DTYPE_MAINTENANCE typeMaint = new DTYPE_MAINTENANCE();
        BindingSource bs = new BindingSource();
        bool valid = false;

        public delegate void MajTypeMaint(DTYPE_MAINTENANCE typeMaint, bool valid);
        public event MajTypeMaint OnMAJ;

        public CHM_FRM_MAJ_TYPE_MAINT(BindingSource bs)
        {
            InitializeComponent();
            entete_Formulaire_21.btn_refresh.Visible = false;
            try
            {
                this.bs = bs;


                cbx_UNITE.DataSource = CLIENT_APP_PARAM.ds_param.UNITE;
                cbx_UNITE.DisplayMember = "LIB_UNITE";
                cbx_UNITE.ValueMember = "CODE_UNITE";

                //Components data Binding
                txt_CODE_TYPE_MAINT.DataBindings.Add("Text", this.bs, "CODE_TYPE_MNT", true);
                txt_LIB_TYPE_MAINT.DataBindings.Add("Text", this.bs, "LIB_MNT", true);
                cbx_UNITE.DataBindings.Add("SelectedValue", this.bs, "CODE_UNITE", true);
                txt_VAL_MAINT.DataBindings.Add("EditValue", this.bs, "VAL_MNT", true);
                txt_NB_JOUR.DataBindings.Add("EditValue", this.bs, "NB_JOUR", true);

                if (((DataRowView)this.bs.Current)["CODE_TYPE_MNT"].ToString() == "-1")
                {
                    this.Text = entete_Formulaire_21.windows_name.Text = "Nv Type de Maintenance";
                }
                else
                {
                    this.Text = entete_Formulaire_21.windows_name.Text = "Modif. Type de Maintenance";
                }
            }
            catch (Exception er)
            {
                Close();
            }
            this.chM_CMP_VALIDATION1.button1.Click += new EventHandler(AjoutTypeMnt);
            this.chM_CMP_VALIDATION1.button2.Click += new EventHandler(FermerFenetre);
        }

        void FermerFenetre(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes vous sûres d'annuler l'opération?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                Close();
        }

        void AjoutTypeMnt(object sender, EventArgs e)
        {
            try
            {
                DataRowView drv = (DataRowView)bs.Current;
                typeMaint = new DTYPE_MAINTENANCE();
                typeMaint.CODE_TYPE_MNT = (int)drv["CODE_TYPE_MNT"];
                typeMaint.LIB_MNT = (string)drv["LIB_MNT"];
                typeMaint.CODE_UNITE = (decimal)drv["CODE_UNITE"];
                typeMaint.VAL_MNT = (decimal)drv["VAL_MNT"];
                typeMaint.NB_JOUR = (int)drv["NB_JOUR"];

                RESULT_QUERY res = new RESULT_QUERY();
                res = CLIENT_APP_PARAM.gcws.ajouteTYPE_MAINTENANCE(typeMaint);

                if (res.OK)
                {
                    valid = true;
                    ((DataRowView)bs.Current)["CODE_TYPE_MNT"] = res.CODE;
                    MessageBox.Show(res.MESSAGE, this.Text);
                    Close();
                }
                else
                {
                    valid = false;
                    MessageBox.Show(res.MESSAGE, this.Text);
                    return;
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, this.Text);
            }
        }

        private void CHM_FRM_MAJ_TYPE_MAINT_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (OnMAJ != null)
                OnMAJ(typeMaint, valid);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CHM_FRM_MAJ_UNITE f = new CHM_FRM_MAJ_UNITE();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.OnSave += new CHM_FRM_MAJ_UNITE.EnregistrementUnite(f_OnSave);
            f.ShowDialog();
        }

        void f_OnSave(DUNITE_ARTICLE unite)
        {
            try
            {
                CLIENT_APP_PARAM.ds_param.bsUnite.AddNew();
                DataRowView drv = (DataRowView)CLIENT_APP_PARAM.ds_param.bsUnite.Current;
                drv["CODE_UNITE"] = unite.CODE_UNITE;
                drv["LIB_UNITE"] = unite.LIB_UNITE;
                CLIENT_APP_PARAM.ds_param.bsUnite.EndEdit();
                (CLIENT_APP_PARAM.ds_param.bsUnite.DataSource as DataTable).AcceptChanges();
                cbx_UNITE.SelectedValue = unite.CODE_UNITE;
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, this.Text);
            }
        }

    }
}
