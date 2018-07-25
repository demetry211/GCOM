using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CHM_CLIENT_APP.CHM_Fenetre_principale
{
    public partial class CHM_FRM_GAIN : Form
    {
        DataTable dt_vente;
        DataTable dt_retour;
        DataTable dt_recu;

        decimal vente = 0;
        decimal retour = 0;
        decimal recu = 0;

        public CHM_FRM_GAIN()
        {
            InitializeComponent();
        }

        private void labelNumerique2_Click(object sender, EventArgs e)
        {

        }

        private void CHM_FRM_GAIN_Load(object sender, EventArgs e)
        {
            calcul();
        }

        private void dtp_du_ValueChanged(object sender, EventArgs e)
        {
            if (dtp_du.Value > dtp_au.Value)
            {
                dtp_du.Value = dtp_au.Value;
            }
            calcul();
        }

        private void dtp_au_ValueChanged(object sender, EventArgs e)
        {
            if (dtp_du.Value > dtp_au.Value)
            {
                dtp_du.Value = dtp_au.Value;
            }
            calcul();
        }

        private void calcul()
        {
            vente = 0;
            recu = 0;
            retour = 0;
            //dt_vente = CLIENT_APP_PARAM.GEST.P_FACTURE.GET_LISTE_VENTE_PAR_DATE(dtp_du.Value, dtp_au.Value);
            dt_vente = CLIENT_APP_PARAM.gcws.GET_LISTE_VENTE_PAR_DATE(dtp_du.Value, dtp_au.Value);
            foreach(DataRow dr in dt_vente.Rows)
            {
                vente+=(decimal)dr["total"];
            }
            lb_vente.Value = vente;
            //dt_retour = CLIENT_APP_PARAM.GEST.P_BRETOUR_CL.IMPRIMER_BR_CL_PAR_DATE(dtp_du.Value, dtp_au.Value);
            dt_retour = CLIENT_APP_PARAM.gcws.IMPRIMER_BR_CL_PAR_DATE(dtp_du.Value, dtp_au.Value);
            foreach (DataRow drr in dt_retour.Rows)
            {
                retour += (decimal)drr["Total"];
            }
            lb_retour.Value = retour;
            //recu = CLIENT_APP_PARAM.GEST.P_BR_FR.GET_SOMME_RECEP(dtp_du.Value, dtp_au.Value);
            recu = CLIENT_APP_PARAM.gcws.GET_SOMME_RECEP(dtp_du.Value, dtp_au.Value);
            lb_recu.Value = recu;
            lb_gain.Value = lb_vente.Value - lb_retour.Value - lb_recu.Value;
        }
    }
}