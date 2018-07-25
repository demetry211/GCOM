using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace CHM_CLIENT_APP.CHM_Fenetre_principale
{
    public partial class CHM_FRM_LICENSE : Form
    {
        bool ok = false;
        public CHM_FRM_LICENSE()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
                doc.Load(AppDomain.CurrentDomain.BaseDirectory + @"\Config.xml");
                XmlNode child = doc.SelectSingleNode("/Configurations");
                foreach (System.Xml.XmlNode n in child)
                    if (n.Attributes["id"].Value == "GC")
                    {
                        for (int i = 0; i < n.ChildNodes.Count; i++)

                            switch (n.ChildNodes[i].Name)
                            {
                                case "key":
                                    n.ChildNodes[i].InnerText= textBox1.Text;
                                    break;
                                
                            }

                    }
                doc.Save(AppDomain.CurrentDomain.BaseDirectory + @"\Config.xml");
                CLIENT_APP_PARAM.key = textBox1.Text;
                License.License l = new License.License();
                if (l.verifier_license(CLIENT_APP_PARAM.key, Environment.MachineName.ToUpper()))
                {
                    ok = true;
                    CLIENT_APP_PARAM.Fenetre_principale.licensefied = true;
                    MessageBox.Show("Clé valid!, licence enregstrée");
                    Close();
                }
                else
                {
                    MessageBox.Show("Clé invalide!, licence inacceptée");
                    ok = false;
                }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CHM_FRM_LICENSE_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!ok)
                Application.Exit();
        }
    }
}