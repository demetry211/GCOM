using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace CHM_CLIENT_APP.CHM_APPLICATION_TACTILE
{
    public partial class Template_Vente : UserControl
    {
        int _current_index = 0;
        int _index_suivante = 0;

        public Template_Vente()
        {
            InitializeComponent();
            #region Entete listetete Liste
            entete.btn_des_art.Text = "«·»Ì«‰";
            entete.btn_des_art.FlatAppearance.BorderSize = 0;
            entete.btn_des_art.FlatAppearance.MouseDownBackColor = Color.Transparent;
            entete.btn_des_art.FlatAppearance.MouseOverBackColor = Color.Transparent;
            entete.btn_des_art.BackColor = Color.Transparent;

            entete.btn_ref_art.Text = "«·—„“";
            entete.btn_ref_art.FlatAppearance.BorderSize = 0;
            entete.btn_ref_art.FlatAppearance.MouseDownBackColor = Color.Transparent;
            entete.btn_ref_art.FlatAppearance.MouseOverBackColor = Color.Transparent;
            entete.btn_ref_art.BackColor = Color.Transparent;

            entete.btn_nbr_art.Text = "«·ﬂ„Ì…";
            entete.btn_nbr_art.FlatAppearance.BorderSize = 0;
            entete.btn_nbr_art.FlatAppearance.MouseDownBackColor = Color.Transparent;
            entete.btn_nbr_art.FlatAppearance.MouseOverBackColor = Color.Transparent;
            entete.btn_nbr_art.BackColor = Color.Transparent;

            entete.btn_prix_art.Text = "«·”⁄—";
            entete.btn_prix_art.FlatAppearance.BorderSize = 0;
            entete.btn_prix_art.FlatAppearance.MouseDownBackColor = Color.Transparent;
            entete.btn_prix_art.FlatAppearance.MouseOverBackColor = Color.Transparent;
            entete.btn_prix_art.BackColor = Color.Transparent;

            entete.btn_prix_total.Text = "«·≈Ã„«·Ì";
            entete.btn_prix_total.FlatAppearance.BorderSize = 0;
            entete.btn_prix_total.FlatAppearance.MouseDownBackColor = Color.Transparent;
            entete.btn_prix_total.FlatAppearance.MouseOverBackColor = Color.Transparent;
            entete.btn_prix_total.BackColor = Color.Transparent;
            #endregion
            charger_liste();
        }

        private void charger_liste()
        {
            Point location = new Point(entete.Location.X, 0);
            for (int i = 0; i < 100; i++)
            {
                Template_Ligne_Facture t = new Template_Ligne_Facture(i);
                t.Location = location;
                location = new Point(location.X, location.Y + t.Height);
                t.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                t.Name = i.ToString();
                panel1.Controls.Add(t);
            }
        }

        public void inserer_article(string codart, int index)
        {
            (panel1.Controls[index.ToString()] as Template_Ligne_Facture).charger_article(codart);
        }
    }
}
