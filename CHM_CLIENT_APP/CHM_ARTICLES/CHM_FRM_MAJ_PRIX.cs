using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;

namespace CHM_CLIENT_APP.CHM_ARTICLES
{
    public partial class CHM_FRM_MAJ_PRIX : Form
    {
        private decimal _code_maj;
        public decimal code_maj
        {
            get
            {
                return _code_maj;
            }
            set
            {
                _code_maj = value;
                if (code_maj != 0)
                {
                    label1.Visible = txt_nomFichier.Visible = btn_import.Visible = btn_select_fichier.Visible = false;

                    lb_user_validation.Visible = lb_user_importation.Visible = lb_user_annulation.Visible = lb_date_validation.Visible = lb_date_importation.Visible = lb_date_annulation.Visible = chbx_annulee.Visible = chbx_validee.Visible = true;
                    label2.Visible = label3.Visible = txt_description.Visible = true;
                    try
                    {

                        DataTable dt = CLIENT_APP_PARAM.gcws.loadMAJPrix(code_maj);

                        lb_date_importation.Text = Convert.ToDateTime(dt.Rows[0]["DATE_IMPORTATION"]).ToShortDateString();
                        lb_user_importation.Text = dt.Rows[0]["NOM_USER_IMPORTATION"].ToString();
                        chbx_validee.Checked = (bool)dt.Rows[0]["VALIDEE"];
                        lb_date_validation.Text = dt.Rows[0]["DATE_VALIDATION"] == DBNull.Value ? "" : Convert.ToDateTime(dt.Rows[0]["DATE_VALIDATION"]).ToShortDateString();
                        lb_user_validation.Text = dt.Rows[0]["NOM_USER_VALIDATION"] == DBNull.Value ? "" : dt.Rows[0]["NOM_USER_VALIDATION"].ToString();
                        chbx_annulee.Checked = (bool)dt.Rows[0]["ANNULEE"];
                        lb_date_annulation.Text = dt.Rows[0]["DATE_ANNULATION"] == DBNull.Value ? "" : Convert.ToDateTime(dt.Rows[0]["DATE_ANNULATION"]).ToShortDateString();
                        lb_user_annulation.Text = dt.Rows[0]["NOM_USER_ANNULATION"] == DBNull.Value ? "" : dt.Rows[0]["NOM_USER_ANNULATION"].ToString();
                        txt_description.Text = dt.Rows[0]["DESCRIPTION_MAJ"] == DBNull.Value ? "" : dt.Rows[0]["DESCRIPTION_MAJ"].ToString();
                        //DT_MAJ_PRIX.Clear();
                        //DT_MAJ_PRIX.Merge(CLIENT_APP_PARAM.gcws.loadDetailMAJPrix(code_maj));
                        chbx_annulee_CheckedChanged(null,null);
                        chbx_validee_CheckedChanged(null, null);
                    }
                    catch (Exception er)
                    {
                        MessageBox.Show(er.Message);
                    }
                }
                else
                {
                    label1.Visible = txt_nomFichier.Visible = btn_import.Visible = btn_select_fichier.Visible = true;
                    label2.Visible= txt_description.Visible = true;
                }
            }
        }

        

        public CHM_FRM_MAJ_PRIX()
        {
            InitializeComponent();
            _code_maj = 0;
        }

        public CHM_FRM_MAJ_PRIX(decimal code_maj)
        {
            InitializeComponent();
            this.code_maj = code_maj;
            
            //lb_date_annulation.Visible=lb_date_importation.Visible=lb
        }

        private void btn_select_fichier_Click(object sender, EventArgs e)
        {
            if (ficheir_selection.ShowDialog() == DialogResult.OK)
                txt_nomFichier.Text = ficheir_selection.FileName;
        }

        private void btn_import_Click(object sender, EventArgs e)
        {
            
            errorProvider1.SetError(txt_nomFichier, "");
            if (txt_nomFichier.Text.Trim() == "")
            {
                errorProvider1.SetError(txt_nomFichier, "Veuillez sélectionner un fichier valid.");
                txt_description.Focus();
                return;
            }
            errorProvider1.Clear();

            errorProvider1.SetError(txt_description, "");
            if (txt_description.Text.Trim() == "")
            {
                errorProvider1.SetError(txt_description, "Veuillez saisir une description de l'importation.");
                txt_description.Focus();
                return;
            }
            errorProvider1.Clear();


            if (File.Exists(txt_nomFichier.Text))
            {
                try
                {
                    
                    String name = "Items";
                    String constr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +
                        /*"C:\\Sample.xlsx"*/ txt_nomFichier.Text +
                                    ";Extended Properties='Excel 12.0 XML;HDR=NO;';";

                    OleDbConnection con = new OleDbConnection(constr);
                    OleDbCommand oconn = new OleDbCommand("Select * From [Feuil1$]", con);
                    con.Open();

                    OleDbDataAdapter sda = new OleDbDataAdapter(oconn);
                    DataTable dt = new DataTable();
                    sda.FillSchema(dt, SchemaType.Mapped);
                    sda.Fill(dt);
                    //sda.Fill(DT_IMPORT);
                    //if (DT_IMPORT.Rows.Count > 0)
                    //{
                    //    DT_MAJ_PRIX.Rows.Clear();
                    //    DT_MAJ_PRIX.Merge(CLIENT_APP_PARAM.gcws.importMAJPrix(DT_IMPORT, txt_description.Text, Convert.ToDecimal(CLIENT_APP_PARAM.Fenetre_principale.code_user)));
                    //    code_maj = (decimal)DT_MAJ_PRIX.Rows[0][0];
                    //}
                    //else
                    //    MessageBox.Show("Fichier vide ou données invalides.");
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message);
                }
            }
        }

        private void tdbg_liste_FetchRowStyle(object sender, C1.Win.C1TrueDBGrid.FetchRowStyleEventArgs e)
        {
            string S = "";// this.tdbg_liste.Columns["DESIGNATION"].CellText(e.Row).ToString();
            if (S.Contains("Introuvable"))
            {
                e.CellStyle.BackColor = System.Drawing.Color.Red;
            }
            
        }

        private void CHM_FRM_MAJ_PRIX_Load(object sender, EventArgs e)
        {
            if (_code_maj == 0)
            {

            }
            else
            {
                
                
            }
        }

        private void lb_user_annulation_Click(object sender, EventArgs e)
        {

        }

        private void chbx_annulee_CheckedChanged(object sender, EventArgs e)
        {
            btn_annuler.Enabled = !chbx_annulee.Checked;
            btn_refresh.Enabled = !chbx_annulee.Checked || !chbx_validee.Checked;
            btn_valider.Enabled = !chbx_annulee.Checked;
        }

        private void chbx_validee_CheckedChanged(object sender, EventArgs e)
        {
            btn_refresh.Enabled = !chbx_validee.Checked || !chbx_annulee.Checked;
            btn_annuler.Enabled = chbx_validee.Checked;
            btn_valider.Enabled = !chbx_validee.Checked;
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            try
            {
                CHMGC.RESULT_QUERY res = new CHM_CLIENT_APP.CHMGC.RESULT_QUERY();
                //res = CLIENT_APP_PARAM.gcws.validerMAJPrix(Convert.ToDecimal(tdbg_liste.Columns["CODE_MAJ_P"].Value), Convert.ToDecimal(CLIENT_APP_PARAM.Fenetre_principale.code_user));
                MessageBox.Show(res.MESSAGE);
                Close();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }

        }

        private void tdbg_liste_FetchCellStyle(object sender, C1.Win.C1TrueDBGrid.FetchCellStyleEventArgs e)
        {
            try
            {
                string S = "";
                if (e.Column.Name == "Changement")
                {
                    S = "";// this.tdbg_liste[e.Row, "Changement"].ToString();
                    if (S.Contains("Augmentation"))
                    {
                        e.CellStyle.ForeColor = System.Drawing.Color.Green;
                    }
                    if (S.Contains("Diminution"))
                    {
                        e.CellStyle.ForeColor = System.Drawing.Color.Red;
                    }
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            try
            {
                CHMGC.RESULT_QUERY res = new CHM_CLIENT_APP.CHMGC.RESULT_QUERY();
                //res = CLIENT_APP_PARAM.gcws.annulerMAJPrix(Convert.ToDecimal(tdbg_liste.Columns["CODE_MAJ_P"].Value), Convert.ToDecimal(CLIENT_APP_PARAM.Fenetre_principale.code_user), chbx_validee.Checked);
                MessageBox.Show(res.MESSAGE);
                Close();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            errorProvider1.SetError(txt_description, "");
            if (txt_description.Text.Trim() == "")
            {
                errorProvider1.SetError(txt_description, "Veuillez saisir une description de l'importation.");
                txt_description.Focus();
                return;
            }
            errorProvider1.Clear();
            try
            {
                //DT_IMPORT.Rows.Clear();
                //foreach (DataRow dr in DT_MAJ_PRIX.Rows)
                //{
                //    DataRow drimp = DT_IMPORT.NewRow();
                //    drimp[0] = dr["CODE_BARRE"];
                //    drimp[1] = dr["NOUVEAU_PV"];
                //    DT_IMPORT.Rows.Add(drimp);

                //}
                //DT_MAJ_PRIX.Rows.Clear();
                //tdbg_liste.UpdateData();
                //DT_MAJ_PRIX.Merge(CLIENT_APP_PARAM.gcws.rafrechirMAJPrix(DT_IMPORT, Convert.ToDecimal(CLIENT_APP_PARAM.Fenetre_principale.code_user), code_maj, txt_description.Text));
                //tdbg_liste.UpdateData();
                
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }
    }
}