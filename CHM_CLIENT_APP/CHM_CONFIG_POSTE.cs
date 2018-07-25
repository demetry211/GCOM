using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Drawing.Printing;

namespace CHM_CLIENT_APP
{
    public partial class CHM_CONFIG_POSTE : Form
    {
        public CHM_CONFIG_POSTE()
        {
            InitializeComponent();

            CLIENT_APP_PARAM.configurer_poste();
            //DataTable dt= CLIENT_APP_PARAM.GEST.P_MAGAZIN.SELECT_ALL_MAGAZIN();
            DataTable dt = CLIENT_APP_PARAM.gcws.SELECT_ALL_MAGAZIN();
            cbx_magazin.DataSource = dt;
            cbx_magazin.DisplayMember = "NOM_MAG";
            cbx_magazin.ValueMember = "CODE_MAG";
            cbx_InvoiceOption.Text = CLIENT_APP_PARAM.InvoicePrintOption;
            cbx_magazin.SelectedValue = Convert.ToDecimal(CLIENT_APP_PARAM.CODE_MAG);
            chbx_entete.Checked = CLIENT_APP_PARAM.entete;

            foreach (String strPrinter in PrinterSettings.InstalledPrinters)
            {

                txt_Ticket_Printer.Items.Add(strPrinter);

                if (strPrinter == CLIENT_APP_PARAM.TicketPrinter)
                {
                    txt_Ticket_Printer.SelectedIndex = txt_Ticket_Printer.Items.IndexOf(strPrinter);
                }

            }

            foreach (String strPrinter in PrinterSettings.InstalledPrinters)
            {

                txt_Report_Printer.Items.Add(strPrinter);

                if (strPrinter == CLIENT_APP_PARAM.ReportPrinter)
                {
                    txt_Report_Printer.SelectedIndex = txt_Report_Printer.Items.IndexOf(strPrinter);
                }

            }
        }

        private void CHM_CONFIG_POSTE_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(@"C:\Program Files\CHM PROJECTS\GCOM\Config_Poste.xml");
                XmlNode child = doc.SelectSingleNode("/Configurations");
                foreach (System.Xml.XmlNode n in child)
                    if (n.Attributes["id"].Value == CLIENT_APP_PARAM.Prefix)
                    {
                        for (int i = 0; i < n.ChildNodes.Count; i++)

                            switch (n.ChildNodes[i].Name)
                            {
                                case "Store":
                                    n.ChildNodes[i].InnerText= cbx_magazin.SelectedValue.ToString();
                                    break;
                                case "InvoicePrintOption":
                                    n.ChildNodes[i].InnerText = cbx_InvoiceOption.Text;
                                    break;
                                case "TicketPrinter":
                                    n.ChildNodes[i].InnerText = txt_Ticket_Printer.Text;
                                    break;
                                case "ReportPrinter":
                                    n.ChildNodes[i].InnerText = txt_Report_Printer.Text;
                                    break;
                                case "entete":
                                    n.ChildNodes[i].InnerText = chbx_entete.Checked ? "true" : "false";
                                    break;
                            }

                    }
                doc.Save(@"C:\Program Files\CHM PROJECTS\GCOM\Config_Poste.xml");
                CLIENT_APP_PARAM.CODE_MAG = cbx_magazin.SelectedValue.ToString();
                CLIENT_APP_PARAM.InvoicePrintOption = cbx_InvoiceOption.Text;
                CLIENT_APP_PARAM.TicketPrinter = txt_Ticket_Printer.Text;
                CLIENT_APP_PARAM.ReportPrinter = txt_Report_Printer.Text;
                CLIENT_APP_PARAM.entete = chbx_entete.Checked;
                Close();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Error");
            }
        
        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbx_InvoiceOption_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
        }
    }
}