using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace CHM_CLIENT_APP
{
    public static class CHM_GESTION_CONTROL
    {
        public static void chargerComboMagazin(ComboBox cbx)
        {
            cbx.DataSource = CLIENT_APP_PARAM.gcws.SELECT_ALL_MAGAZIN();
            cbx.DisplayMember = "NOM_MAG";
            cbx.ValueMember = "CODE_MAG";
        }
    }
}
