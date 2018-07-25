using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CHM_CLIENT_APP
{
    public partial class FONCTIONNALITE_UTILISATEUR : Form
    {
        DataTable dt;
        BindingSource srcb = new BindingSource();
        public FONCTIONNALITE_UTILISATEUR()
        {
            InitializeComponent();
        }

        private void FONCTIONNALITE_UTILISATEUR_Shown(object sender, EventArgs e)
        {
            dgv_fct_utilisateur.AutoGenerateColumns = false;
            try
            {
                Application.DoEvents();
                //dt = CLIENT_APP_PARAM.GEST.P_FONCTION.SELECT_ALL_FONTIONS();
                dt = CLIENT_APP_PARAM.gcws.SELECT_ALL_FONTIONS();
                srcb.DataSource = dt;
                dgv_fct_utilisateur.DataSource = srcb;
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Connexion serveur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void nouveauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NV_FONCTION f = new NV_FONCTION("-1");
            f.ShowDialog();
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)srcb.Current;
            NV_FONCTION f = new NV_FONCTION((drv["CODE_FONCTION"]).ToString());
            f.ShowDialog();
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (srcb.Current != null)
            {
                if (MessageBox.Show("Voulez-vous supprimer cette fonction?", "Cofirmation de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    try
                    {
                        DataRowView drv = (DataRowView)srcb.Current;
                        string res = CLIENT_APP_PARAM.gcws.DELETE_FONCTION(drv["CODE_FONCTION"].ToString());
                        if (res == "OK")
                        {
                            srcb.RemoveCurrent();
                            dt.AcceptChanges();
                        }
                        else
                            MessageBox.Show(res, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception er)
                    {
                        MessageBox.Show(er.Message, "Connexion serveur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


    }
}
