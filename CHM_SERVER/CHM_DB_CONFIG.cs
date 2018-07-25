using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace CHM_SERVER
{
    public partial class CHM_DB_CONFIG : Form
    {
        public CHM_DB_CONFIG()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_valider_Click(object sender, EventArgs e)
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
                            case "Server":
                                n.ChildNodes[i].InnerText=txt_Server.Text;
                                break;
                            case "DB":
                                n.ChildNodes[i].InnerText=txt_DB.Text;
                                break;
                            case "User":
                                n.ChildNodes[i].InnerText = txt_User.Text;
                                break;
                            case "Pwd":
                                n.ChildNodes[i].InnerText=txt_Password.Text;
                                //Password = Decrypt(Password);
                                break;
                        }

                }
            doc.Save(AppDomain.CurrentDomain.BaseDirectory+@"\Config.xml");
            Close();
        }

        private void CHM_DB_CONFIG_Load(object sender, EventArgs e)
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
                            case "Server":
                                txt_Server.Text = n.ChildNodes[i].InnerText;
                                break;
                            case "DB":
                                txt_DB.Text = n.ChildNodes[i].InnerText;
                                break;
                            case "User":
                                txt_User.Text = n.ChildNodes[i].InnerText;
                                break;
                            case "Pwd":
                                txt_Password.Text = n.ChildNodes[i].InnerText;
                                //Password = Decrypt(Password);
                                break;
                        }

                }
        }
    }
}