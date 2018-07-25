using CHM_CLIENT_APP.CHMGC;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Data;
using System.Windows.Forms;

namespace CHM_CLIENT_APP.CHM_TVA
{
    public partial class CHM_LIST_TVA : Form
    {
        public CHM_LIST_TVA()
        {
            InitializeComponent();
        }

        private void CHM_LIST_TVA_Load(object sender, EventArgs e)
        {
            ChargerTVA();
            ChargerTAXE();
        }

        private void ChargerTAXE()
        {
            try
            {

                dSTVA.TAXE.Clear();
                dSTVA.TAXE.Merge(CLIENT_APP_PARAM.gcws.GetTAXE());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void ChargerTVA()
        {
            try
            {
                DataTable dt = CLIENT_APP_PARAM.gcws.GetTVA();
                dSTVA.TVA.Clear();
                dSTVA.TVA.Merge(CLIENT_APP_PARAM.gcws.GetTVA());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void gridView1_MasterRowExpanded(object sender, DevExpress.XtraGrid.Views.Grid.CustomMasterRowEventArgs e)
        {
            try
            {
                GridView grid = sender as GridView;
                GridView childGrid = grid.GetDetailView(e.RowHandle, e.RelationIndex) as GridView;
                childGrid.RowUpdated += ChildGrid_RowUpdated;
                childGrid.InitNewRow += ChildGrid_InitNewRow;
                childGrid.RowDeleting += ChildGrid_RowDeleting;
                childGrid.BeginUpdate();
                childGrid.Columns["TAX_ID"].Visible = false;
                childGrid.Columns["CODE_TVA"].Visible = false;
                childGrid.Columns["TAX_LIBELLE"].Visible = false;
                childGrid.Columns["TAX_CREATEUR"].Visible = false;
                childGrid.Columns["TAX_DATE_CREATION"].Visible = false;
                childGrid.Columns["TAX_DATE_MODIF"].Visible = false;
                childGrid.Columns["TAX_MODIFICATEUR"].Visible = false;
                childGrid.EndUpdate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChildGrid_RowDeleting(object sender, DevExpress.Data.RowDeletingEventArgs e)
        {
            RESULT_QUERY res = new RESULT_QUERY();
            DTAXE taxe = new DTAXE();

            taxe.TAX_ID = Convert.ToDecimal((e.Row as DataRowView)["TAX_ID"]);

            try
            {
                res = CLIENT_APP_PARAM.gcws.effaceTAXE(taxe);
                if (res.OK)
                {
                    
                }
                else
                {
                    e.Cancel = true;
                    MessageBox.Show(res.MESSAGE, "Erreur los de la suppression", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur los de la suppression", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChildGrid_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            GridView grid = sender as GridView;
            grid.SetRowCellValue(e.RowHandle, "TAX_ID", -1);
            grid.SetRowCellValue(e.RowHandle, "TAX_LIBELLE", "");
            grid.SetRowCellValue(e.RowHandle, "TAX_TAUX", "");
            grid.SetRowCellValue(e.RowHandle, "TAX_DEB_APPLIC", DateTime.Now);
            grid.SetRowCellValue(e.RowHandle, "TAX_CREATEUR", CLIENT_APP_PARAM.Fenetre_principale.code_user);
            grid.SetRowCellValue(e.RowHandle, "TAX_DATE_CREAT", DateTime.Now);
            grid.SetRowCellValue(e.RowHandle, "TAX_DATE_MODIF", DateTime.Now);
            grid.SetRowCellValue(e.RowHandle, "TAX_MODIFICATEUR", CLIENT_APP_PARAM.Fenetre_principale.code_user);

        }

        private void ChildGrid_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            RESULT_QUERY res = new RESULT_QUERY();
            GridView grid = sender as GridView;

            if (grid.IsNewItemRow(e.RowHandle))
            {
                DTAXE taxe = new DTAXE();
                taxe.CODE_TVA = (decimal)((e.Row as DataRowView)["CODE_TVA"]);
                taxe.TAX_CREATEUR = Convert.ToDecimal( CLIENT_APP_PARAM.Fenetre_principale.code_user);
                taxe.TAX_DATE_CREATION = DateTime.Now;
                taxe.TAX_DATE_MODIF = DateTime.Now;
                taxe.TAX_DEB_APPLIC = Convert.ToDateTime((e.Row as DataRowView)["TAX_DEB_APPLIC"]);
                taxe.TAX_ID = -1;
                taxe.TAX_LIBELLE = (e.Row as DataRowView)["TAX_LIBELLE"].ToString();
                taxe.TAX_MODIFICATEUR = Convert.ToDecimal(CLIENT_APP_PARAM.Fenetre_principale.code_user);
                taxe.TAX_TAUX = (decimal)((e.Row as DataRowView)["TAX_TAUX"]);
                res = CLIENT_APP_PARAM.gcws.ajouteTAXE(taxe);
                if (res.OK)
                {

                }
                else
                {
                    MessageBox.Show(res.MESSAGE, this.Text);
                }
            }
            else
            {
                DTAXE taxe = new DTAXE();
                taxe.CODE_TVA = (decimal)((e.Row as DataRowView)["CODE_TVA"]);
                taxe.TAX_DATE_MODIF = DateTime.Now;
                taxe.TAX_DEB_APPLIC = Convert.ToDateTime((e.Row as DataRowView)["TAX_DEB_APPLIC"]);
                taxe.TAX_ID = (decimal)((e.Row as DataRowView)["TAX_ID"]);
                taxe.TAX_LIBELLE = (e.Row as DataRowView)["TAX_LIBELLE"].ToString();
                taxe.TAX_MODIFICATEUR = Convert.ToDecimal(CLIENT_APP_PARAM.Fenetre_principale.code_user);
                taxe.TAX_TAUX = (decimal)((e.Row as DataRowView)["TAX_TAUX"]);
                res = CLIENT_APP_PARAM.gcws.modifierTAXE(taxe);
                if (res.OK)
                {

                }
                else
                {
                    MessageBox.Show(res.MESSAGE, this.Text);
                }

            }
        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            RESULT_QUERY res = new RESULT_QUERY();
            GridView grid = sender as GridView;
            if (grid.IsNewItemRow(e.RowHandle))
            {
                DTVA tva = new DTVA();
                tva.TVA_LIBELLE = (e.Row as DataRowView)["TVA_LIBELLE"].ToString();
                res = CLIENT_APP_PARAM.gcws.ajouteTVA(tva);
                if(res.OK)
                {
                    (e.Row as DataRowView)["CODE_TVA"] = res.CODE;
                }
                else
                {
                    MessageBox.Show(res.MESSAGE, this.Text);
                }
            }
            else
            {
                DTVA tva = new DTVA();
                tva.TVA_LIBELLE = (e.Row as DataRowView)["TVA_LIBELLE"].ToString();
                tva.CODE_TVA = (decimal)((e.Row as DataRowView)["CODE_TVA"]);
                res = CLIENT_APP_PARAM.gcws.modifieTVA(tva);
                if (res.OK)
                {

                }
                else
                {
                    MessageBox.Show(res.MESSAGE, this.Text);
                }

            }
        }

        private void gridControl1_ProcessGridKey(object sender, KeyEventArgs e)
        {
            var grid= sender as GridControl;
            var view = grid.FocusedView as GridView;
            if(e.KeyData==Keys.Delete && MessageBox.Show("Etes vous sûres de supprimer la ligne suivante?", "Confirmation de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)==DialogResult.Yes)
            {
                    view.DeleteRow(view.FocusedRowHandle);
            }
        }

        private void gridView1_RowDeleting(object sender, DevExpress.Data.RowDeletingEventArgs e)
        {
            RESULT_QUERY res = new RESULT_QUERY();
            DTVA tva = new DTVA();
            tva.CODE_TVA = Convert.ToDecimal((e.Row as DataRowView)["CODE_TVA"]);

            try
            {
                res = CLIENT_APP_PARAM.gcws.effaceTVA(tva);
                if (res.OK)
                {
                    
                }
                else
                {
                    e.Cancel = true;
                    MessageBox.Show(res.MESSAGE, "Erreur los de la suppression", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message , "Erreur los de la suppression", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
