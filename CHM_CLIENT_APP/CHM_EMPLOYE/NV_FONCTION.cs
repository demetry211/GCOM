using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CHM_CLIENT_APP
{
    public partial class NV_FONCTION : Form
    {
        public delegate void fct_enreg(DataRowView fct, bool type_ev);
        public event fct_enreg fct_enregistrer;
        DataTable dt;
        BindingSource srcb = new BindingSource();
        string CODE_FCT = "-1";
        public NV_FONCTION(string code_fct)
        {
            InitializeComponent();
            this.CODE_FCT = code_fct;
        }

        private void btn_ENREG_FCT_Click(object sender, EventArgs e)
        {
            try
            {
                if (CODE_FCT == "-1")
                {
                    Application.DoEvents();
                    //string res = CLIENT_APP_PARAM.GEST.P_FONCTION.INSERT_FONCTION(CODE_FCT, NV_FCT.Text);
                    string res = CLIENT_APP_PARAM.gcws.INSERT_FONCTION(CODE_FCT, NV_FCT.Text);
                    if (res == "OK")
                    {
                        MessageBox.Show("La nouvelle fonction à été inséré avec succes.", "Ajout de fonction", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(res, "Ajout de fonction", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    Application.DoEvents();

                    //string modif_msg_reçu = CLIENT_APP_PARAM.GEST.P_FONCTION.UPDATE_FONCTION(CODE_FCT, NV_FCT.Text);
                    string modif_msg_reçu = CLIENT_APP_PARAM.gcws.UPDATE_FONCTION(CODE_FCT, NV_FCT.Text);

                    if (modif_msg_reçu == "OK")
                    {
                        MessageBox.Show("Les informations de la fonction ont été modifiées avec succes.", "Modification de client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(modif_msg_reçu, "Modification de la fonction", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }


            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_FERMER_FCT_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
