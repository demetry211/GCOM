using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Net;

namespace CHM_SERVER
{
    public partial class Form1 : Form
    {
        TcpServerChannel canal;
        public static CHM_GESTION_COMERCIALE.CHM_GESTION gest;
        
        public Form1()
        {

            InitializeComponent();
            label1.Text = "Déconnecté";
            btn_demarrer.Visible = true;
            button3.Visible = false;
            pictureBox2.Visible = false;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                Application.DoEvents();
                canal = new TcpServerChannel(4001);

                ChannelServices.RegisterChannel(canal, false);

                RemotingConfiguration.RegisterWellKnownServiceType(typeof(CHM_GESTION_COM), "CHM_GESTION_COM", WellKnownObjectMode.SingleCall);

                CONNECTION_PARAM.charger_param();
                if (CONNECTION_PARAM.cnx.State == ConnectionState.Closed)
                    CONNECTION_PARAM.cnx.Open();
                NOM_MACHINE_SERVER.Text = CONNECTION_PARAM.cnx.WorkstationId.ToString();
                btn_demarrer.Enabled = false;
                btn_demarrer.Visible = false;
                button3.Visible = true;
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
                label1.Text = "Connecté";
                string[] IpAdress = GetIPaddresses(CONNECTION_PARAM.cnx.WorkstationId.ToString());
                int i = 0;
                while (IpAdress[i] != null)
                {

                    SERVER_IP_ADDRESS.Text = IpAdress[i];
                    i++;
                    break;
                }

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }

            finally
            {
                this.Cursor = Cursors.Default;
            }
            //gest = (CHM_GESTION_COMERCIALE.CHM_GESTION)Activator.GetObject(typeof(CHM_GESTION_COMERCIALE.CHM_GESTION), "tcp://LOCALHOST:4001/CHM_GESTION_COM");
            timer1.Enabled = false;
            License.License license = new License.License();

            
            
            if(license.license_type!="O")
            {
                dt = new CHM_GESTION_COM().P_FACTURE.SELECT_ALL_FACTURES(); //gest.P_FACTURE.SELECT_ALL_FACTURES();
                int n = license.nb - dt.Rows.Count;
                if (n <= 50 && n > 0)
                {

                    timer1.Enabled = false;
                    MessageBox.Show(" áÞÏ ÞÇÑÈÊ ÑÎÕÉ ÇÓÊÚãÇá ÇáãäÙæãÉ Úáì ÇáÅäÊåÇÁ.\n ÊÈÞì áßã ÅãßÇäíÉ ÅÏÎÇá " + n.ToString() + "ÝÇÊæÑÉ", "CHM Commercial Management Program");
                    timer1.Enabled = false;
                }

                if (dt.Rows.Count >= license.nb)
                {
                    this.Cursor = Cursors.WaitCursor;
                    Application.DoEvents();
                    canal.StopListening(4001);
                    ChannelServices.UnregisterChannel(canal);

                    if (CONNECTION_PARAM.cnx.State == ConnectionState.Open)
                        CONNECTION_PARAM.cnx.Close();
                    btn_demarrer.Enabled = true;
                    btn_demarrer.Visible = true;
                    button3.Visible = false;
                    pictureBox1.Visible = true;
                    pictureBox2.Visible = false;
                    label1.Text = "Déconnecté";
                    SERVER_IP_ADDRESS.Text = "";
                    MessageBox.Show(" áÞÏ ÇäÊåÊ ÑÎÕÉ ÇÓÊÚãÇá ÇáãäÙæãÉ.", "CHM Commercial Management Program");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                Application.DoEvents();
                canal.StopListening(4001);
                ChannelServices.UnregisterChannel(canal);

                if (CONNECTION_PARAM.cnx.State == ConnectionState.Open)
                    CONNECTION_PARAM.cnx.Close();
                btn_demarrer.Enabled = true;
                btn_demarrer.Visible = true;
                button3.Visible = false;
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
                label1.Text = "Déconnecté";
                SERVER_IP_ADDRESS.Text = "";
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }

            finally
            {
                this.Cursor = Cursors.Default;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            btn_demarrer.Visible = false;
            button3.Visible = false;
        }

        private void BTN_OK_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            btn_demarrer.Visible = true;
            button3.Visible = true;
        }

        string[] GetIPaddresses(string computername)
        {
            string[] saddr = null;

            IPAddress[] addr = Dns.Resolve(computername).AddressList;



            if (addr.Length > 0)
            {
                saddr = new String[addr.Length];
                for (int i = 0; i < addr.Length; i++)

                    saddr[i] = addr[i].ToString();

            }

            return saddr;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CONNECTION_PARAM.charger_param();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            CHM_FRM_PASSWORD frm = new CHM_FRM_PASSWORD();
            frm.ShowDialog();
            if (frm.authentified)
            {
                CHM_DB_CONFIG f = new CHM_DB_CONFIG();
                f.ShowDialog();
            }
        }
        DataTable dt;
        private void timer1_Tick(object sender, EventArgs e)
        {
            License.License license=new License.License();

            dt = gest.P_FACTURE.SELECT_ALL_FACTURES();
            int n = license.nb - dt.Rows.Count;
            if (n <= 50)
            {
                
                timer1.Enabled = false;
                MessageBox.Show(" áÞÏ ÞÇÑÈÊ ÑÎÕÉ ÇÓÊÚãÇá ÇáãäÙæãÉ Úáì ÇáÅäÊåÇÁ.\n ÊÈÞì áßã ÅãßÇäíÉ ÅÏÎÇá " +n.ToString() + "ÝÇÊæÑÉ" , "CHM Commercial Management Program");
                timer1.Enabled = true;
            }

            if (dt.Rows.Count >= license.nb)
                button3_Click(null, null);
        }









    }
}