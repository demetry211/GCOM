using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace CHM_CLIENT_APP.CHM_ARTICLES
{
    public partial class CHM_CMP_BARCODE : UserControl
    {

        private string _barcode;
        public string barcode
        {
            get
            {
                return _barcode;
            }
            set
            {
                _barcode = value;
                CODE_BARRE_ARTICLE.BarCode = barcode;
                if (verifierExistance != null) verifierExistance(barcode);
            }
        }

        public delegate void Delele();
        public event Delele onDelete;

        public delegate void Verif(string barCode);
        public event Verif verifierExistance;

        public CHM_CMP_BARCODE()
        {
            InitializeComponent();
        }

        private void CODE_BARRE_NV_ARTICLE_TextChanged(object sender, EventArgs e)
        {
            barcode = (sender as TextBox).Text;            
        }

        private void btn_ajouter_codebarre_Click(object sender, EventArgs e)
        {
            //if (onDelete != null)
            //    onDelete();
        }


    }
}
