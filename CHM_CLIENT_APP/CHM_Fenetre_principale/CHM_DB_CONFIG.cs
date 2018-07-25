using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace CHM_CLIENT_APP
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
            try
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
                                    n.ChildNodes[i].InnerText= txt_server.Text;
                                    break;
                                case "Port":
                                    n.ChildNodes[i].InnerText=txt_Port.Text;
                                    break;
                                case "Instance":
                                    n.ChildNodes[i].InnerText=txt_instance.Text;
                                    break;
                            }

                    }
                doc.Save(AppDomain.CurrentDomain.BaseDirectory + @"\Config.xml");
                
                if (txt_instance.Text != CLIENT_APP_PARAM.instance || txt_Port.Text != CLIENT_APP_PARAM.port || txt_server.Text != CLIENT_APP_PARAM.serveur)
                {
                    MessageBox.Show("Configuration enregistrée avec succès.\nL'application va etre redémarrer afin d'activer la nouvelle configuration.");
                    Application.Restart();
                }
                Close();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Erreur");
            }
        }

        private void CHM_DB_CONFIG_Load(object sender, EventArgs e)
        {
            try
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
                                    txt_server.Text = n.ChildNodes[i].InnerText;
                                    break;
                                case "Port":
                                    txt_Port.Text = n.ChildNodes[i].InnerText;
                                    break;
                                case "Instance":
                                    txt_instance.Text = n.ChildNodes[i].InnerText;
                                    break;
                            }

                    }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Erreur");
            }
        }
    }
}