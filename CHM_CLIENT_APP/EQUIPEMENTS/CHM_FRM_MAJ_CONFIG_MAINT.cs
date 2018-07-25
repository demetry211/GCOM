using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CHM_CLIENT_APP.EQUIPEMENTS.TYPE_MAINTENANCE;
using CHM_CLIENT_APP.CHMGC;

namespace CHM_CLIENT_APP.EQUIPEMENTS
{
    public partial class CHM_FRM_MAJ_CONFIG_MAINT : Form
    {
        public CHM_FRM_MAJ_CONFIG_MAINT()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            CHM_FRM_LISTE_TYPE_MAINT f = new CHM_FRM_LISTE_TYPE_MAINT("s");
            f.StartPosition = FormStartPosition.CenterScreen;
            f.OnSelect += new CHM_FRM_LISTE_TYPE_MAINT.selection(SelectTypeMnt);
            f.ShowDialog();
        }


        void SelectTypeMnt(DTYPE_MAINTENANCE maint)
        {

        }

        
    }
}
