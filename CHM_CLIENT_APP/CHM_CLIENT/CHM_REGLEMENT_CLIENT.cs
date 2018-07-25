using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CHM_CLIENT_APP.CHMGC;

namespace CHM_CLIENT_APP
{
    public partial class CHM_REGLEMENT_CLIENT : Form
    {
        string CODE_FACT= "-1";
        string CODE_CLIENT = "";
        string CODE_COMPTE = "";
        DataTable dt_facture;
        BindingSource bs_facture = new BindingSource();
        DataTable dt_clt;
        BindingSource bs_clt = new BindingSource();
        DataTable dt_compte;
        BindingSource bs_compte = new BindingSource();
        public CHM_REGLEMENT_CLIENT(string CODE_FACTURE)
        {
            InitializeComponent();
            this.RightToLeft = RightToLeft.No;
            this.CODE_FACT = CODE_FACTURE;
            NUM_PIECE.Enabled = false;
            BANQUE_CLIENT.Enabled = false;            
            RS_CLIENT.Focus();
            entete_Formulaire_21.btn_refresh.Visible = false;
        }

        private void CHM_REGLEMENT_CLIENT_Shown(object sender, EventArgs e)
        {
            if (CODE_FACT != "-1")
            {
                try
                {

                    //dt_facture = CLIENT_APP_PARAM.GEST.P_FACTURE.LOAD_FACTURE_PAR_CODE(CODE_FACT);
                    dt_facture = CLIENT_APP_PARAM.gcws.LOAD_FACTURE_PAR_CODE(CODE_FACT);
                    bs_facture.DataSource = dt_facture;


                    DataRowView drv_facture = (DataRowView)bs_facture.Current;
                    CODE_CLIENT = drv_facture["CODE_CLIENT"].ToString();
                    NP.Value = (decimal)drv_facture["CREDIT"];
                    CODE_FACTURE.Text = drv_facture["CODE_FACTURE"].ToString();
                    //dt_clt = CLIENT_APP_PARAM.GEST.P_FACTURE.LOAD_CLIENT_FACTURE(CODE_CLIENT);
                    dt_clt = CLIENT_APP_PARAM.gcws.LOAD_CLIENT_FACTURE(CODE_CLIENT);
                    bs_clt.DataSource = dt_clt;


                    DataRowView drv_clt = (DataRowView)bs_clt.Current;
                    RS_CLIENT.Text = drv_clt["RS_CLIENT"].ToString();
                    if (bs_clt.Current != null)
                    {
                        if ((bool)drv_clt["COMPTE"] != true)
                        {
                            try
                            {
                                //CHM_GESTION_COMERCIALE.RESULT_QUERY res = new CHM_GESTION_COMERCIALE.RESULT_QUERY();
                                CHMGC.RESULT_QUERY res = new CHM_CLIENT_APP.CHMGC.RESULT_QUERY();
                                //res = CLIENT_APP_PARAM.GEST.P_COMPTE_CLIENT.CREER_COMPTE_CLIENT(drv_clt["CODE_CLIENT"].ToString());
                                res = CLIENT_APP_PARAM.gcws.CREER_COMPTE_CLIENT(drv_clt["CODE_CLIENT"].ToString());
                                if (res.OK)
                                {
                                    MessageBox.Show(res.MESSAGE, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    //CLIENT_APP_PARAM.GEST.P_CLIENT.UPDATE_ETAT_COMPTE(drv_clt["CODE_CLIENT"].ToString());
                                    CLIENT_APP_PARAM.gcws.UPDATE_ETAT_COMPTE(drv_clt["CODE_CLIENT"].ToString());
                                    CHM_COMPTE_CREDIT_CLIENT fenetre = new CHM_COMPTE_CREDIT_CLIENT(drv_clt["CODE_CLIENT"].ToString());
                                    fenetre.Show();
                                }
                                else
                                    MessageBox.Show(res.MESSAGE, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (Exception er)
                            {
                                MessageBox.Show(er.Message, "Connection error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                    }
                    //dt_compte = CLIENT_APP_PARAM.GEST.P_COMPTE_CLIENT.LOAD_COMPTE_CLIENT(drv_clt["CODE_CLIENT"].ToString());
                    dt_compte = CLIENT_APP_PARAM.gcws.LOAD_COMPTE_CLIENT(drv_clt["CODE_CLIENT"].ToString());
                    bs_compte.DataSource = dt_compte;
                    DataRowView drv_compte = (DataRowView)bs_compte.Current;
                    NUM_COMPTE_CLIENT.Text = drv_compte["NUM_COMPTE_CLIENT"].ToString();
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        DataTable dt_fact;
        BindingSource bs_fact = new BindingSource();
        private void CODE_FACTURE_Leave(object sender, EventArgs e)
        {
            //dt_fact = CLIENT_APP_PARAM.GEST.P_REGLEMENT.recherche_facture(CODE_FACTURE.Text);
            dt_fact = CLIENT_APP_PARAM.gcws.recherche_facture(CODE_FACTURE.Text);
            bs_fact.DataSource = dt_fact;
        }

        private void MODE_REG_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (MODE_REG.SelectedItem.ToString() == "ChËque")
            {
                BANQUE_CLIENT.Enabled = true;
                NUM_PIECE.Enabled = true;
                
            }
            if (MODE_REG.SelectedItem.ToString() == "Carte bancaire")
            {
                BANQUE_CLIENT.Enabled = true;
                NUM_PIECE.Enabled = true;
                
            }
            if (MODE_REG.Text == "Avoir")
            {
                BANQUE_CLIENT.Enabled = true;
                NUM_PIECE.Enabled = true;
               
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            #region Test
            errorProvider1.SetError(MODE_REG, "");
            if (MODE_REG.Text=="")
            {
                MODE_REG.Focus();
                errorProvider1.SetError(MODE_REG, "Vous devez choisir mode de rËglement !");
                
                return;
            }
            errorProvider1.Clear();

            errorProvider1.SetError(NUM_PIECE, "");
            if ((MODE_REG.SelectedText == "ChËque ’ﬂ" || MODE_REG.SelectedText == "Carte bancaire ﬂ—  »‰ﬂÌ…") && NUM_PIECE.Text == "")
            {
                NUM_PIECE.Focus();
                errorProvider1.SetError(MODE_REG, "You should enter the paper or the card code number!");

                return;
            }
            errorProvider1.Clear();

            errorProvider1.SetError(BANQUE_CLIENT, "");
            if ((MODE_REG.SelectedText == "ChËque ’ﬂ" || MODE_REG.SelectedText == "Carte bancaire ﬂ—  »‰ﬂÌ…") && NUM_PIECE.Text == "")
            {
                BANQUE_CLIENT.Focus();
                errorProvider1.SetError(BANQUE_CLIENT, "Vous devez entrer la banque du client !");

                return;
            }
            errorProvider1.Clear();

            errorProvider1.SetError(MONTANT_PAYE, "");
            if (Convert.ToDecimal( MONTANT_PAYE.EditValue)==0)
            {
                MONTANT_PAYE.Focus();
                errorProvider1.SetError(MONTANT_PAYE, "Vous devez entrer le montant payÈ !");

                return;
            }
            errorProvider1.Clear();

            errorProvider1.SetError(CODE_FACTURE, "");
            if (CODE_FACTURE.Text=="")
            {
                CODE_FACTURE.Focus();
                errorProvider1.SetError(CODE_FACTURE, "Vous devez entrer le montant payÈ !");

                return;
            }
            errorProvider1.Clear();

            errorProvider1.SetError(RS_CLIENT, "");
            if (RS_CLIENT.Text=="")
            {
                RS_CLIENT.Focus();
                errorProvider1.SetError(RS_CLIENT, "You should select the client !\n ÌÃ» «Œ Ì«— «·“»Ê‰");

                return;
            }
            errorProvider1.Clear();
            #endregion 
            this.Cursor = Cursors.WaitCursor;
            try
            {
                //CHM_GESTION_COMERCIALE.RESULT_QUERY res1 = new CHM_GESTION_COMERCIALE.RESULT_QUERY();
                //CHMGC.RESULT_QUERY res1 = new CHM_CLIENT_APP.CHMGC.RESULT_QUERY();
                ////res1 = CLIENT_APP_PARAM.GEST.P_FACTURE.UPDATE_ETAT_FACTURE(CODE_FACTURE.Text, MONTANT_PAYE.Value.ToString());
                //res1 = CLIENT_APP_PARAM.gcws.UPDATE_ETAT_FACTURE(CODE_FACTURE.Text,Convert.ToDecimal( MONTANT_PAYE.EditValue));
                //if (res1.OK)
                //{
                //    MessageBox.Show(res1.MESSAGE, "Modification de facture.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
                //else
                //{
                //    MessageBox.Show(res1.MESSAGE, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //}
                //OBSERVATION.Text = res1.MESSAGE;
                //CHM_GESTION_COMERCIALE.RESULT_QUERY res = new CHM_GESTION_COMERCIALE.RESULT_QUERY();
                CHMGC.RESULT_QUERY res = new CHM_CLIENT_APP.CHMGC.RESULT_QUERY();
                //res = CLIENT_APP_PARAM.GEST.P_REGLEMENT.INSERT_REGLEMENT(CODE_FACTURE.Text, DATE.Value, MODE_REG.SelectedItem.ToString(), MONTANT_PAYE.Value.ToString(), NUM_PIECE.Text, BANQUE_CLIENT.Text, OBSERVATION.Text, CODE_CLIENT);
                res = CLIENT_APP_PARAM.gcws.INSERT_REGLEMENT(CODE_FACTURE.Text, DATE.Value, MODE_REG.SelectedItem.ToString(), Convert.ToDecimal(MONTANT_PAYE.EditValue), NUM_PIECE.Text, BANQUE_CLIENT.Text, OBSERVATION.Text, CODE_CLIENT, CODE_COMPTE);
                if (res.OK)
                {
                    MessageBox.Show(res.MESSAGE, "Reglement", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(res.MESSAGE, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
                //CLIENT_APP_PARAM.GEST.P_COMPTE_CLIENT.UPDATE_COMPTE_CLIENT(CODE_COMPTE, MONTANT_PAYE.Value);
                //CLIENT_APP_PARAM.gcws.UPDATE_COMPTE_CLIENT(CODE_COMPTE, MONTANT_PAYE.Value);
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Connection error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }


        }

        private void NUM_COMPTE_CLIENT_Click(object sender, EventArgs e)
        {
            CHM_COMPTE_CREDIT_CLIENT c = new CHM_COMPTE_CREDIT_CLIENT(CODE_CLIENT);
            c.ShowDialog();
        }

        private void RS_CLIENT_Click(object sender, EventArgs e)
        {
            try
            {
                if (RS_CLIENT.Text != "")
                {
                    CLIENT_APP_PARAM.ds_param.bsClient.Position = CLIENT_APP_PARAM.ds_param.bsClient.Find("CODE_CLIENT", CODE_CLIENT);
                    CHM_FICHE_CLIENT f = new CHM_FICHE_CLIENT(CLIENT_APP_PARAM.ds_param.bsClient);
                    f.ShowDialog();
                }
                else
                {
                    CHM_COMMANDE_CLIENT c = new CHM_COMMANDE_CLIENT();
                    c.client_selection_event += new CHM_COMMANDE_CLIENT.client_selection(c_client_selection_event);
                    c.ShowDialog();
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }
        
        void c_client_selection_event(DCLIENT client)
        {
            try
            {
                RS_CLIENT.Text = client.RS_CLIENT.ToString();
                CODE_CLIENT = client.CODE_CLIENT.ToString();
                if (client.COMPTE==1)
                {
                    NUM_COMPTE_CLIENT.Enabled = true;
                    CODE_FACTURE.Enabled = true;
                    //dt_compte = CLIENT_APP_PARAM.GEST.P_CLIENT.LOAD_COMPTE(CODE_CLIENT);
                    dt_compte = CLIENT_APP_PARAM.gcws.LOAD_COMPTE(CODE_CLIENT);
                    bs_compte.DataSource = dt_compte;
                    DataRowView drv = (DataRowView)bs_compte.Current;
                    CODE_COMPTE = drv["CODE_COMPTE_CLIENT"].ToString();
                    NUM_COMPTE_CLIENT.Text = drv["NUM_COMPTE_CLIENT"].ToString();
                    if ((decimal)drv["TOTAL_CREDIT_CLT"] == 0)
                    {
                        MessageBox.Show("Ce client n'a pas de crÈdit, toutes ses factures sont payÈes.", "Rq!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Ce client n'a pas de compte.", "Rq!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    NUM_COMPTE_CLIENT.Enabled = false;
                    CODE_FACTURE.Enabled = false;
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void CODE_FACTURE_Click(object sender, EventArgs e)
        {
            try
            {
                if (CODE_FACT != "-1")
                {
                    CHM_FICHE_FACTURE_CLIENT f = new CHM_FICHE_FACTURE_CLIENT(CODE_FACT);
                    f.ShowDialog();
                }
                else
                {
                    if (RS_CLIENT.Text != "")
                    {
                        CHM_LISTE_FACTURE_CLIENT n = new CHM_LISTE_FACTURE_CLIENT(CODE_CLIENT);
                        n.selection_event += new CHM_LISTE_FACTURE_CLIENT.selection_deleg(n_selection_event);
                        n.ShowDialog();
                    }
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Connection error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void n_selection_event(DataRowView facture)
        {
            CODE_FACTURE.Text = facture["CODE_FACTURE"].ToString();
            NP.Value = (decimal)facture["CREDIT"];
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}