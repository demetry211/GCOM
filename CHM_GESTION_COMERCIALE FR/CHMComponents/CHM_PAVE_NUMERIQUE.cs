using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CHMComponents
{
    public partial class CHM_PAVE_NUMERIQUE : UserControl
    {

        public delegate void ButtonUse(string button);
        public event ButtonUse OnButtonPress;
        public event ButtonUse OnEfface;
        

        public CHM_PAVE_NUMERIQUE()
        {
            InitializeComponent();
        }

        private void CHM_PAVE_NUMERIQUE_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                
            }
        }

        private void CHM_PAVE_NUMERIQUE_Load(object sender, EventArgs e)
        {

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            try
            {
                if (OnButtonPress != null)
                    OnButtonPress((sender as Control).Tag.ToString());
                //SendKeys.Send(string.Format("{0}", (sender as Control).Text));
            }
            catch (Exception er)
            {
                
               
            }
            
        }

        private void btnBackSpace_Click(object sender, EventArgs e)
        {
            if (OnEfface != null)
                OnEfface(string.Empty);
        }
    }
}
