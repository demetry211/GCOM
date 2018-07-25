using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using CHM_CLIENT_APP.CHMGC;

namespace CHM_CLIENT_APP.CHM_FACTURE
{
    public partial class CHM_FRM_REG : DevExpress.XtraEditors.XtraForm
    {

        public delegate void Paiement(decimal NetAPayer, decimal MntReçu, decimal Reste, DataTable dtReglement);
        public event Paiement OnPaiement;
        BindingSource bsPaiement = new BindingSource();
        string FocusedControl = string.Empty;
        string TypePiece = string.Empty;

        string modePaiment = string.Empty;
        DCLIENT client = new DCLIENT();

        string ModePaiment
        {
            get
            {
                return modePaiment;
            }
            set
            {
                modePaiment = value;
                grpPaiement.Text = string.Format("Paiement {0}", modePaiment);
            }
        }

        private decimal montantPaye = 0;

        public decimal MontantPaye
        {
            get { return montantPaye; }

            set
            {

                montantPaye = value;
                lb_Reste.Value = montantPaye - lbn_total_apres_remise.Value;
                lbCurrentReste.Value = montantPaye + Convert.ToDecimal(txt_MntRecu.Text) - lbn_total_apres_remise.Value;
            }
        }


        public CHM_FRM_REG()
        {
            InitializeComponent();
            entete_Formulaire_21.btn_refresh.Visible = false;
            this.KeyPreview = true;
        }

        public CHM_FRM_REG(decimal NetAPayer, string typePiece)
        {
            InitializeComponent();
            entete_Formulaire_21.btn_refresh.Visible = false;
            lbn_total_apres_remise.Value = NetAPayer;
            chM_PAVE_NUMERIQUE1.OnButtonPress += new CHMComponents.CHM_PAVE_NUMERIQUE.ButtonUse(chM_PAVE_NUMERIQUE1_OnButtonPress);
            chM_PAVE_NUMERIQUE1.OnEfface += new CHMComponents.CHM_PAVE_NUMERIQUE.ButtonUse(chM_PAVE_NUMERIQUE1_OnEfface);
            MontantPaye = 0;
            bsPaiement.DataSource = dS_MOUV1.REGLEMENT_CLIENT;
            gridControl1.DataSource = bsPaiement;
            TypePiece = typePiece;

            chM_CMP_VALIDATION1.button1.Text = "Valider [F10]";
            chM_CMP_VALIDATION1.button1.Click += new EventHandler(button1_Click);
            chM_CMP_VALIDATION1.button2.Click += new EventHandler(button2_Click);
        }

        public CHM_FRM_REG(decimal NetAPayer, string typePiece, DCLIENT client)
        {
            InitializeComponent();
            entete_Formulaire_21.btn_refresh.Visible = false;
            lbn_total_apres_remise.Value = NetAPayer;
            chM_PAVE_NUMERIQUE1.OnButtonPress += new CHMComponents.CHM_PAVE_NUMERIQUE.ButtonUse(chM_PAVE_NUMERIQUE1_OnButtonPress);
            chM_PAVE_NUMERIQUE1.OnEfface += new CHMComponents.CHM_PAVE_NUMERIQUE.ButtonUse(chM_PAVE_NUMERIQUE1_OnEfface);
            MontantPaye = 0;
            bsPaiement.DataSource = dS_MOUV1.REGLEMENT_CLIENT;
            gridControl1.DataSource = bsPaiement;
            TypePiece = typePiece;
            this.client = client;
            txt_REF_CLIENT.Text = this.client.REF_CLIENT;
            txt_REF_CLIENT.Tag = this.client.CODE_CLIENT;
            txt_RS_CLIENT.Text = this.client.RS_CLIENT;
            chM_CMP_VALIDATION1.button1.Text = "Valider [F10]";
            chM_CMP_VALIDATION1.button1.Click += new EventHandler(button1_Click);
            chM_CMP_VALIDATION1.button2.Click += new EventHandler(button2_Click);
        }

        void chM_PAVE_NUMERIQUE1_OnEfface(string button)
        {

            grpPaiement.Controls[FocusedControl].Focus();
            grpPaiement.Controls[FocusedControl].Text = "0";
            //txt_MntRecu.Focus();
            //txt_MntRecu.Text = "0";
        }

        void chM_PAVE_NUMERIQUE1_OnButtonPress(string button)
        {
            //if (FocusedControl != string.Empty)
            //{
            grpPaiement.Controls[FocusedControl].Focus();
            //txt_MntRecu.Focus();
            string s = "{" + string.Format("{0}", button) + "}";
            SendKeys.Send(s);
            //}
        }


        

        void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes vous sûres d'annuler l'opération?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                Close();
        }



        void button1_Click(object sender, EventArgs e)
        {

            try
            {
                if (client.CODE_CLIENT == 1)
                {
                    if (lb_Reste.Value >= 0)
                    {
                        DataTable dtReglement = new DataTable("detailsReg");
                        foreach (DataColumn col in dS_MOUV1.REGLEMENT_CLIENT.Columns)
                        {
                            dtReglement.Columns.Add(col.ColumnName, col.DataType);

                        }

                        foreach (DataRow dr in dS_MOUV1.REGLEMENT_CLIENT.Rows)
                        {
                            dtReglement.ImportRow(dr);
                        }

                        if (OnPaiement != null)
                            OnPaiement(lbn_total_apres_remise.Value, Convert.ToDecimal(txt_MntRecu.Text), lb_Reste.Value, dtReglement);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Règlement non valide.\nMontant inférieur au net à payer!", this.Text);
                        return;
                    }
                }
                else
                {
                    DataTable dtReglement = new DataTable("detailsReg");
                    foreach (DataColumn col in dS_MOUV1.REGLEMENT_CLIENT.Columns)
                    {
                        dtReglement.Columns.Add(col.ColumnName, col.DataType);

                    }

                    foreach (DataRow dr in dS_MOUV1.REGLEMENT_CLIENT.Rows)
                    {
                        dtReglement.ImportRow(dr);
                    }

                    if (OnPaiement != null)
                        OnPaiement(lbn_total_apres_remise.Value, Convert.ToDecimal(txt_MntRecu.Text), lb_Reste.Value, dtReglement);
                    Close();
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }

        }

        private void CHM_FRM_REG_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{tab}");
            }
            if (e.KeyCode == Keys.F1)
            {
                btn_Espece.PerformClick();
            }
            if (e.KeyCode == Keys.F2)
            {
                btn_Cheque.PerformClick();
            }
            if (e.KeyCode == Keys.F3)
            {
                btn_Traite.PerformClick();
            }
            if (e.KeyCode == Keys.F9 && grpPaiement.Visible)
            {
                btn_ValiderLgReg.PerformClick();
            }
            if (e.KeyCode == Keys.Escape && grpPaiement.Visible)
            {
                btn_AnnulerLgReg.PerformClick();
            }
            if (e.KeyCode == Keys.F10)
            {
                chM_CMP_VALIDATION1.button1.PerformClick();
            }
        }

        private void CHM_FRM_REG_Load(object sender, EventArgs e)
        {
            MontantPaye = 0;
            txt_MntRecu.Focus();
            txt_MntRecu.SelectAll();
        }

        private void txt_MntRecu_EditValueChanged(object sender, EventArgs e)
        {
            //MontantPaye = Convert.ToDecimal(txt_MntRecu.Text);
            lbCurrentReste.Value = montantPaye + Convert.ToDecimal(txt_MntRecu.Text) - lbn_total_apres_remise.Value;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CHM_FRM_REG_Shown(object sender, EventArgs e)
        {
            txt_MntRecu.Focus();
            txt_MntRecu.SelectAll();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            ModePaiment = (sender as Control).Tag.ToString();
            grpPaiement.Visible = true;
            label1.Visible = txt_banque.Visible = false;
            label3.Visible = txt_numCheque.Visible = false;
        }

        private void txt_MntRecu_Click(object sender, EventArgs e)
        {
            FocusedControl = (sender as Control).Name;
        }

        private void txt_banque_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
        }

        private void grpPaiement_VisibleChanged(object sender, EventArgs e)
        {
            pModePaiement.Visible = !grpPaiement.Visible;
            if (!(sender as Control).Visible)
            {
                FocusedControl = string.Empty;
                ModePaiment = string.Empty;
                txt_MntRecu.Text = "0";
                txt_banque.Text = string.Empty;
                txt_numCheque.Text = string.Empty;
            }
            else
            {
                FocusedControl = txt_MntRecu.Name;

            }
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            grpPaiement.Visible = false;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            ModePaiment = (sender as Control).Tag.ToString();
            grpPaiement.Visible = true;
            label1.Visible = txt_banque.Visible = true;
            label3.Visible = txt_numCheque.Visible = true;
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            ModePaiment = (sender as Control).Tag.ToString();
            grpPaiement.Visible = true;
            label1.Visible = txt_banque.Visible = true;
            label3.Visible = txt_numCheque.Visible = true;
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(txt_MntRecu.Text) > 0)
            {
                bsPaiement.AddNew();
                DataRowView drv = bsPaiement.Current as DataRowView;

                drv["MODE_REGLEMENT_CLT"] = ModePaiment;
                drv["MONTANT_REG_CLIENT"] = lbn_total_apres_remise.Value;
                drv["MONTANT_PIECE"] = Convert.ToDecimal(txt_MntRecu.Text);
                drv["NUM_PIECE_CLIENT"] = txt_numCheque.Text;
                drv["BANQUE_CLIENT"] = txt_banque.Text;
                drv["RESTE"] = lbCurrentReste.Value;
                drv["TYPE_PIECE"] = TypePiece;
                drv["CODE_REGLEMENT_CLIENT"] = bsPaiement.Count+1;

                bsPaiement.EndEdit();
                (bsPaiement.DataSource as DataTable).AcceptChanges();

                grpPaiement.Visible = false;
            }
            else
            {
                MessageBox.Show("Montant non valid!");
            }
        }

        private void lb_Reste_TextChanged(object sender, EventArgs e)
        {
            if (lb_Reste.Value > 0)
                lb_Reste.ForeColor = Color.Lime;
            else
                lb_Reste.ForeColor = Color.OrangeRed;
            if (this.client.CODE_CLIENT == 1)
            {
                chM_CMP_VALIDATION1.Button1.Enabled = lb_Reste.Value >= 0;
            }
            else 
            { 
                chM_CMP_VALIDATION1.button1.Enabled = true; 
            }
        }

        private void gridView1_RowCountChanged(object sender, EventArgs e)
        {
            MontantPaye = Convert.ToDecimal(colMONTANT_PIECE.SummaryText);
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (e.Column.Name == "colSuppr" && bsPaiement.Current != null)
                bsPaiement.RemoveCurrent();
        }

        private void chM_PAVE_NUMERIQUE1_Load(object sender, EventArgs e)
        {

        }
    }
}