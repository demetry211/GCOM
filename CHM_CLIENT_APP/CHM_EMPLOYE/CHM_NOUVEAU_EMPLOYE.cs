using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CHM_CLIENT_APP
{
    public partial class CHM_NOUVEAU_EMPLOYE : Form
    {
        string CODE_EMPLOYE = "-1";
        public delegate void ENREG_EMP_DELEG(DataRowView employer, bool type_ev);
        public event ENREG_EMP_DELEG ENREG_EMP_EV;
        public CHM_NOUVEAU_EMPLOYE(string CODE_EMPLOYE)
        {
            InitializeComponent();
            this.CODE_EMPLOYE = CODE_EMPLOYE;
        }
        DataTable dt;
        BindingSource srcb = new BindingSource();
        DataTable dt_societe;
        BindingSource bs_societe = new BindingSource();
        string code_societe = "";
        private void CHM_NOUVEAU_EMPLOYE_Shown(object sender, EventArgs e)
        {
            if (CODE_EMPLOYE != "-1")
            {
                this.Text = nom_fenetre.Text = "Modification du magazinier";
            }
            Application.DoEvents();
            //dt = CLIENT_APP_PARAM.GEST.P_EMPLOYE.LOAD_EMPLOYE(CODE_EMPLOYE);
            dt = CLIENT_APP_PARAM.gcws.LOAD_EMPLOYE(CODE_EMPLOYE);
            srcb.DataSource = dt;
            srcb.MoveFirst();
            DataRowView drv_emp = (DataRowView)srcb.Current;
            NV_NOM_EMPLOYE.DataBindings.Add("Text", srcb, "NOM_EMPLOYE", true);
            NV_PRENOM_EMPLOYE.DataBindings.Add("Text", srcb, "PRENOM_EMPLOYE", true);
            NV_DATE_NAISS_EMPLOYE.DataBindings.Add("Value", srcb, "DATE_NAIS_EMPLOYE.", true);
            NV_ADRESSE_EMPLOYE.DataBindings.Add("Text", srcb, "ADRESSE_EMPLOYE", true);
            NV_TEL_EMPLOYE.DataBindings.Add("Text", srcb, "TEL_EMPLOYE", true);
            NV_EMAIL_EMPLOYE.DataBindings.Add("Text", srcb, "EMAIL_EMPLOYE", true);
            NV_DATE_EMBAUCHE_EMPLOYE.DataBindings.Add("Value", srcb, "DATE_EMBAUCHE_EMPLOYE", true);
            NV_ETAT_EMPLOYE.DataBindings.Add("Checked", srcb, "ETAT_EMPLOYE", true);
            //dt_societe = CLIENT_APP_PARAM.GEST.P_SOCIETE.SELECT_ALL_SOCIETE();
            dt_societe = CLIENT_APP_PARAM.gcws.SELECT_ALL_SOCIETE();
            bs_societe.DataSource = dt_societe;
            foreach (DataRowView dr in bs_societe)
            {
                NV_SOCIETE.Items.Add(dr["RS_SOCIETE"]);
            }

            if (CODE_EMPLOYE == "-1")
            {
                this.Text = "Ajout de magasinier";
                srcb.AddNew();
                DataRowView drv = (DataRowView)srcb.Current;
                drv["CODE_EMPLOYE"] = -1;
                drv["ETAT_EMPLOYE"] = false;
                drv["CODE_SOCIETE"] = 1;
            }
        }

        private void BTN_FERMER_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_ENREGISTRER_Click(object sender, EventArgs e)
        {
            #region TEST
            errorProvider1.SetError(NV_NOM_EMPLOYE, "");
            if (NV_NOM_EMPLOYE.Text == "")
            {
                NV_NOM_EMPLOYE.Focus();
                errorProvider1.SetError(NV_NOM_EMPLOYE, "Vous devez saisir le nom de l'employer !");

                return;
            }
            errorProvider1.Clear();

            errorProvider1.SetError(NV_PRENOM_EMPLOYE, "");
            if (NV_PRENOM_EMPLOYE.Text == "")
            {
                NV_PRENOM_EMPLOYE.Focus();
                errorProvider1.SetError(NV_PRENOM_EMPLOYE, "Vous devez saisir le prénom de l'employer !");

                return;
            }
            errorProvider1.Clear();

            errorProvider1.SetError(NV_ADRESSE_EMPLOYE, "");
            if (NV_NOM_EMPLOYE.Text == "")
            {
                NV_ADRESSE_EMPLOYE.Focus();
                errorProvider1.SetError(NV_ADRESSE_EMPLOYE, "Vous devez saisir l'adresse de l'employer !");

                return;
            }
            errorProvider1.Clear();

            #endregion

            try
            {
                //CHM_GESTION_COMERCIALE.RESULT_QUERY res = new CHM_GESTION_COMERCIALE.RESULT_QUERY();
                CHMGC.RESULT_QUERY res = new CHM_CLIENT_APP.CHMGC.RESULT_QUERY();
                try
                {
                    srcb.EndEdit();
                    dt.AcceptChanges();
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dt.RejectChanges();
                    return;
                }
                if (CODE_EMPLOYE == "-1")
                {

                    Application.DoEvents();
                    //res = CLIENT_APP_PARAM.GEST.P_EMPLOYE.INSERT_EMPLOYE(CODE_EMPLOYE, NV_NOM_EMPLOYE.Text, NV_PRENOM_EMPLOYE.Text, NV_DATE_NAISS_EMPLOYE.Value, NV_ADRESSE_EMPLOYE.Text, NV_TEL_EMPLOYE.Text, NV_EMAIL_EMPLOYE.Text, NV_DATE_EMBAUCHE_EMPLOYE.Value, NV_ETAT_EMPLOYE.Checked, ((int)NV_SOCIETE.SelectedItem + 1).ToString());
                    res = CLIENT_APP_PARAM.gcws.INSERT_EMPLOYE(CODE_EMPLOYE, NV_NOM_EMPLOYE.Text, NV_PRENOM_EMPLOYE.Text, NV_DATE_NAISS_EMPLOYE.Value, NV_ADRESSE_EMPLOYE.Text, NV_TEL_EMPLOYE.Text, NV_EMAIL_EMPLOYE.Text, NV_DATE_EMBAUCHE_EMPLOYE.Value, NV_ETAT_EMPLOYE.Checked, ((int)NV_SOCIETE.SelectedItem + 1).ToString());
                    CODE_EMPLOYE = res.CODE;
                    ((DataRowView)srcb.Current)["CODE_EMPLOYE"] = CODE_EMPLOYE;
                    if (ENREG_EMP_EV != null)
                        ENREG_EMP_EV((DataRowView)srcb.Current, true);

                    if (res.OK)
                    {

                        MessageBox.Show(res.MESSAGE, "Ajout de magasinier", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(res.MESSAGE, "Ajout de magasinier", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    Application.DoEvents();
                    //res = CLIENT_APP_PARAM.GEST.P_EMPLOYE.UPDATE_EMPLOYE(CODE_EMPLOYE, NV_NOM_EMPLOYE.Text, NV_PRENOM_EMPLOYE.Text, NV_DATE_NAISS_EMPLOYE.Value, NV_ADRESSE_EMPLOYE.Text, NV_TEL_EMPLOYE.Text, NV_EMAIL_EMPLOYE.Text, NV_DATE_EMBAUCHE_EMPLOYE.Value, NV_ETAT_EMPLOYE.Checked, ((int)NV_SOCIETE.SelectedItem + 1).ToString());
                    res = CLIENT_APP_PARAM.gcws.UPDATE_EMPLOYE(CODE_EMPLOYE, NV_NOM_EMPLOYE.Text, NV_PRENOM_EMPLOYE.Text, NV_DATE_NAISS_EMPLOYE.Value, NV_ADRESSE_EMPLOYE.Text, NV_TEL_EMPLOYE.Text, NV_EMAIL_EMPLOYE.Text, NV_DATE_EMBAUCHE_EMPLOYE.Value, NV_ETAT_EMPLOYE.Checked, ((int)NV_SOCIETE.SelectedItem + 1).ToString());
                    if (ENREG_EMP_EV != null)
                        ENREG_EMP_EV((DataRowView)srcb.Current, false);

                    if (res.OK)
                    {
                        MessageBox.Show(res.MESSAGE, "Modification du magazinier", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(res.MESSAGE, "Modification du magazinier", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
