using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using CHM_CLIENT_APP.CHMGC;
using DevExpress.XtraEditors.Controls;

namespace CHM_CLIENT_APP.CHM_ARTICLES.TARIFICATION_VENTE
{
    public partial class CHM_FRM_TRV : Form
    {
        public CHM_FRM_TRV()
        {
            
            
            InitializeComponent();
            InitData();
            entete_Formulaire_21.btn_refresh.Click += Btn_refresh_Click;
            this.KeyDown += CHM_FRM_TRV_KeyDown;
        }

        private void CHM_FRM_TRV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
                InitData();
        }

        private void InitData()
        {
            dbFill();

            dS_TRV.TRV.Merge(CLIENT_APP_PARAM.gcws.getTRV());
        }

        private void Btn_refresh_Click(object sender, EventArgs e)
        {
            InitData();
        }

        private void dbFill()
        {
            dS_TRV.ARTICLE.Merge(CLIENT_APP_PARAM.gcws.SELECT_ALL_ARTICLE());
            dS_TRV.UNITE.Merge(CLIENT_APP_PARAM.gcws.GetUNITE_ARTICLE());
            dS_TRV.CLIENT.Merge(CLIENT_APP_PARAM.gcws.SELECT_ALL_CLIENTS());
        }

        private void CHM_FRM_TRV_Load(object sender, EventArgs e)
        {
            

        }

        private void gridView1_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            GridView view = sender as GridView;
            view.SetRowCellValue(e.RowHandle, view.Columns["TRV_ID"], "-1");
            view.SetRowCellValue(e.RowHandle, view.Columns["TRV_LIBELLE"], "");
            //view.SetRowCellValue(e.RowHandle, view.Columns["TRV_CODE_ARTICLE"], "");
            //view.SetRowCellValue(e.RowHandle, view.Columns["TRV_CODE_CLIENT"], "");
            //view.SetRowCellValue(e.RowHandle, view.Columns["TRV_CODE_UNITE"], "");
            view.SetRowCellValue(e.RowHandle, view.Columns["TRV_PRIX_HT"], 0);
            view.SetRowCellValue(e.RowHandle, view.Columns["TRV_TX_REMISE"], 0);
            view.SetRowCellValue(e.RowHandle, view.Columns["TRV_DEBUT_VALID"], Convert.ToDateTime(DateTime.Now.ToShortDateString()));
            view.SetRowCellValue(e.RowHandle, view.Columns["TRV_FIN_VALID"], Convert.ToDateTime(DateTime.Now.AddDays(1).ToShortDateString()));
            view.SetRowCellValue(e.RowHandle, view.Columns["TRV_DATE_CREATION"], DateTime.Now);
            view.SetRowCellValue(e.RowHandle, view.Columns["TRV_CREATEUR"], CLIENT_APP_PARAM.Fenetre_principale.code_user);
            view.SetRowCellValue(e.RowHandle, view.Columns["TRV_DATE_MODIF"], DateTime.Now);
            view.SetRowCellValue(e.RowHandle, view.Columns["TRV_MODIFICATEUR"], CLIENT_APP_PARAM.Fenetre_principale.code_user);
        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            RESULT_QUERY res = new RESULT_QUERY();
            GridView v = sender as GridView;
            if (v.IsNewItemRow(e.RowHandle))
            {
                //Ajout
                DTARIF_VENTE tarif = new DTARIF_VENTE();
                tarif.TRV_ID = (decimal)(e.Row as DataRowView)["TRV_ID"];
                tarif.TRV_LIBELLE = (e.Row as DataRowView)["TRV_LIBELLE"].ToString();
                tarif.TRV_CODE_ARTICLE = (decimal)(e.Row as DataRowView)["TRV_CODE_ARTICLE"];
                tarif.TRV_CODE_CLIENT = (e.Row as DataRowView)["TRV_CODE_CLIENT"]==null?0:(decimal)(e.Row as DataRowView)["TRV_CODE_CLIENT"];
                tarif.TRV_CODE_UNITE = (decimal)(e.Row as DataRowView)["TRV_CODE_UNITE"];
                tarif.TRV_CREATEUR = Convert.ToDecimal( CLIENT_APP_PARAM.Fenetre_principale.code_user);
                tarif.TRV_MODIFICATEUR = Convert.ToDecimal(CLIENT_APP_PARAM.Fenetre_principale.code_user);
                tarif.TRV_DATE_CREATION = Convert.ToDateTime((e.Row as DataRowView)["TRV_DATE_CREATION"]);
                tarif.TRV_DATE_MODIF = Convert.ToDateTime((e.Row as DataRowView)["TRV_DATE_MODIF"]);
                tarif.TRV_DEBUT_VALID =   Convert.ToDateTime(Convert.ToDateTime((e.Row as DataRowView)["TRV_DEBUT_VALID"]).ToShortDateString());
                tarif.TRV_FIN_VALID = Convert.ToDateTime(Convert.ToDateTime((e.Row as DataRowView)["TRV_FIN_VALID"]).ToShortDateString());
                tarif.TRV_PRIX_HT = (decimal)(e.Row as DataRowView)["TRV_PRIX_HT"];
                tarif.TRV_TX_REMISE = (decimal)(e.Row as DataRowView)["TRV_TX_REMISE"];

                res = CLIENT_APP_PARAM.gcws.AjoutTarifVente(tarif);
                if (res.OK)
                {
                    (e.Row as DataRowView)["TRV_ID"] = res.CODE;
                }
                else
                {
                    MessageBox.Show(res.MESSAGE, "Erreur création", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                //Modification
                DTARIF_VENTE tarif = new DTARIF_VENTE();
                tarif.TRV_ID = (decimal)(e.Row as DataRowView)["TRV_ID"];
                tarif.TRV_LIBELLE = (e.Row as DataRowView)["TRV_LIBELLE"].ToString();
                tarif.TRV_CODE_ARTICLE = (decimal)(e.Row as DataRowView)["TRV_CODE_ARTICLE"];
                tarif.TRV_CODE_CLIENT = (decimal)(e.Row as DataRowView)["TRV_CODE_CLIENT"];
                tarif.TRV_CODE_UNITE = (decimal)(e.Row as DataRowView)["TRV_CODE_UNITE"];
                tarif.TRV_MODIFICATEUR = Convert.ToDecimal(CLIENT_APP_PARAM.Fenetre_principale.code_user);
                tarif.TRV_DATE_MODIF = DateTime.Now;
                tarif.TRV_DEBUT_VALID = Convert.ToDateTime(Convert.ToDateTime((e.Row as DataRowView)["TRV_DEBUT_VALID"]).ToShortDateString());
                tarif.TRV_FIN_VALID = Convert.ToDateTime(Convert.ToDateTime((e.Row as DataRowView)["TRV_FIN_VALID"]).ToShortDateString());
                tarif.TRV_PRIX_HT = (decimal)(e.Row as DataRowView)["TRV_PRIX_HT"];
                tarif.TRV_TX_REMISE = (decimal)(e.Row as DataRowView)["TRV_TX_REMISE"];

                res = CLIENT_APP_PARAM.gcws.ModifTarifVente(tarif);
                if (res.OK)
                {
                    MessageBox.Show(res.MESSAGE, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(res.MESSAGE, "Erreur modification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void gridView1_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            GridView v = sender as GridView;
            string s = v.GetRowCellValue(e.RowHandle, "TRV_CODE_CLIENT").ToString();
            if (s   == "")
            {
                e.Valid = false;
                return;
            }

            DTARIF_VENTE trv = new DTARIF_VENTE() {
                TRV_CODE_ARTICLE= (decimal)(e.Row as DataRowView)["TRV_CODE_ARTICLE"],
                TRV_CODE_CLIENT= (decimal)(e.Row as DataRowView)["TRV_CODE_CLIENT"],
                TRV_DEBUT_VALID= Convert.ToDateTime((e.Row as DataRowView)["TRV_DEBUT_VALID"]),
                TRV_FIN_VALID= Convert.ToDateTime((e.Row as DataRowView)["TRV_FIN_VALID"]),
                TRV_CODE_UNITE = (decimal)(e.Row as DataRowView)["TRV_CODE_UNITE"],
                TRV_ID= (decimal)(e.Row as DataRowView)["TRV_ID"]
            };

            if (CLIENT_APP_PARAM.gcws.VerifExistTarifVente(trv).Rows.Count > 0)
            {
                MessageBox.Show("Il exist déja un tarif dans cette periode.", "Erreur validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Valid = false;
                return;
            }
        }

        private void gridView1_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }
    }
}
