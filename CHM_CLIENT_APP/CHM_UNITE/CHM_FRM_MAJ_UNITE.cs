using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CHM_CLIENT_APP.CHMGC;

namespace CHM_CLIENT_APP.CHM_UNITE
{
    public partial class CHM_FRM_MAJ_UNITE : Form
    {
        public delegate void EnregistrementUnite(DUNITE_ARTICLE unite);
        public event EnregistrementUnite OnSave;
        DUNITE_ARTICLE unite;
        public CHM_FRM_MAJ_UNITE()
        {
            InitializeComponent();
            unite = new DUNITE_ARTICLE();
            entete_Formulaire_21.btn_refresh.Visible = false;
            chM_CMP_VALIDATION1.button1.Click += new EventHandler(AjouteUnite);
            chM_CMP_VALIDATION1.button2.Click += new EventHandler(Fermer);
            this.Text = entete_Formulaire_21.windows_name.Text = "Nouvelle unité";
        }

        void Fermer(object sender, EventArgs e)
        {
            Close();
        }

        void AjouteUnite(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Libellé non valid.", this.Text);
                    return;
                }
                RESULT_QUERY res = new RESULT_QUERY();
                unite = new DUNITE_ARTICLE();
                unite.LIB_UNITE = textBox1.Text;
                res = CLIENT_APP_PARAM.gcws.ajouteUNITE_ARTICLE(unite);
                if (res.OK)
                {
                    unite.CODE_UNITE = Convert.ToDecimal(res.CODE);
                    if (OnSave != null)
                        OnSave(unite);
                    Close();
                }
                else
                {
                    MessageBox.Show(res.MESSAGE, this.Text);
                    return;
                }
            }
            catch (Exception er )
            {
                MessageBox.Show(er.Message, this.Text);
            }
        }
    }
}
