using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CHM_CLIENT_APP.CHMGC;
using CHM_CLIENT_APP.CHM_MARQUE_ARTICLE;

namespace CHM_CLIENT_APP.CHM_CLIENT
{
    public partial class CHM_FRM_MAJ_VEHICULE : Form
    {
        public delegate void MAJ(decimal codeVehicule, bool ValidateChanges);
        public event MAJ OnMaj;
        BindingSource bs;
        decimal CodeVehicule = 0;

        public CHM_FRM_MAJ_VEHICULE(BindingSource bs)
        {
            InitializeComponent();
            this.bs=bs;
            entete_Formulaire_21.btn_refresh.Visible = false;
            CodeVehicule = (decimal)((DataRowView)bs.Current)["CODE_VEHICULE"];


            cbx_CLIENT.DataSource = CLIENT_APP_PARAM.ds_param.CLIENT;
            cbx_CLIENT.DisplayMember = "RS_CLIENT";
            cbx_CLIENT.ValueMember = "CODE_CLIENT";

            cbx_MARQUE.DataSource = CLIENT_APP_PARAM.ds_param.MARQUE;
            cbx_MARQUE.DisplayMember = "DESIGNATION_MARQUE";
            cbx_MARQUE.ValueMember = "CODE_MARQUE";


            lb_CODE_VEHICULE.DataBindings.Add("Text", bs, "CODE_VEHICULE", true);
            txt_GAMME.DataBindings.Add("Text", bs, "GAMME", true);
            txt_MATRICULE.DataBindings.Add("Text", bs, "MATRICULE", true);
            cbx_CLIENT.DataBindings.Add("SelectedValue", bs, "CODE_CLIENT", true);
            cbx_MARQUE.DataBindings.Add("SelectedValue", bs, "CODE_MARQUE", true);
            cbx_TYPE.DataBindings.Add("Text", bs, "TYPE", true);
            nud_CYLINDRE.DataBindings.Add("Value", bs, "PUISSANCE", true); 
            nud_PUISSANCE.DataBindings.Add("Value", bs, "CYLINDRE", true);

            DataRowView drv = (bs.Current as DataRowView);
            if (drv["CODE_VEHICULE"].ToString() == "-1")
                this.Text = entete_Formulaire_21.windows_name.Text = "Nouveau véhicule";
            else
                this.Text = entete_Formulaire_21.windows_name.Text = "Modification véhicule";

            chM_CMP_VALIDATION1.button1.Click += new EventHandler(button1_Click);
            chM_CMP_VALIDATION1.button2.Click += new EventHandler(button2_Click);
        }

        void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes vous sûres d'annuler l'opération", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (OnMaj != null)
                    OnMaj((decimal)((bs.Current as DataRowView)["CODE_VEHICULE"]), false);
                Close();
            }
        }

        void button1_Click(object sender, EventArgs e)
        {
            try
            {
                RESULT_QUERY res = new RESULT_QUERY();
                DVEHICULE vehicule = new DVEHICULE();
                vehicule.CODE_CLIENT = (decimal)cbx_CLIENT.SelectedValue;
                vehicule.CODE_MARQUE = (decimal)cbx_MARQUE.SelectedValue;
                vehicule.CODE_VEHICULE = CodeVehicule;
                vehicule.CYLINDRE = Convert.ToInt32(nud_CYLINDRE.Value);
                vehicule.PUISSANCE = Convert.ToInt32(nud_PUISSANCE.Value);
                vehicule.MATRICULE = txt_MATRICULE.Text;
                vehicule.TYPE = cbx_TYPE.Text;
                vehicule.GAMME = txt_GAMME.Text;
                if (vehicule.CODE_VEHICULE == -1)
                {
                    res = CLIENT_APP_PARAM.gcws.ajouteVEHICULE(vehicule);
                    ((DataRowView)bs.Current)["CODE_VEHICULE"]=vehicule.CODE_VEHICULE= Convert.ToDecimal(res.CODE);
                    if (res.OK)
                    {
                        if(OnMaj!=null)
                            OnMaj(vehicule.CODE_VEHICULE, res.OK);
                        Close();
                    }
                    else
                    {
                        throw new Exception(res.MESSAGE);
                    }
                }
                else
                {
                    res = CLIENT_APP_PARAM.gcws.modifieVEHICULE(vehicule);
                    //((DataRowView)bs.Current)["CODE_VEHICULE"] = vehicule.CODE_VEHICULE = Convert.ToDecimal(res.CODE);
                    if (res.OK)
                    {
                        if (OnMaj != null)
                            OnMaj(vehicule.CODE_VEHICULE, res.OK);
                        Close();
                    }
                    else
                    {
                        throw new Exception(res.MESSAGE);
                    }
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, this.Text);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            liste_client f = new liste_client("s");
            f.OnSelect += new liste_client.Selection(f_OnSelect);
            f.StartPosition = FormStartPosition.CenterScreen;
            f.ShowDialog();
        }

        void f_OnSelect(decimal codeClient)
        {
            cbx_CLIENT.SelectedValue = codeClient;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            CHM_FRM_LISTE_MARQUES f = new CHM_FRM_LISTE_MARQUES("s");
            f.OnSelect += new CHM_FRM_LISTE_MARQUES.SELECTION(OnSelectMarque);
            f.StartPosition = FormStartPosition.CenterScreen;
            f.ShowDialog();
        }

        void OnSelectMarque(decimal code)
        {
            cbx_MARQUE.SelectedValue = code;
        }

        
    }
}
