using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Net;
using System.Runtime.Remoting;

namespace CHM_SERVER
{
    public partial class server : Form
    {
        TcpChannel canal;
        public server()
        {
            InitializeComponent();
            btn_demarrer.Visible = true;
            button3.Visible = false;
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

        private void server_Load(object sender, EventArgs e)
        {
            CONNECTION_PARAM.charger_param();
            btn_demarrer_Click(null,null);
            this.Hide();
        }

        private void btn_demarrer_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                Application.DoEvents();
                canal = new TcpChannel(4001);

                ChannelServices.RegisterChannel(canal, false);

                RemotingConfiguration.RegisterWellKnownServiceType(typeof(CHM_GESTION_COM), "CHM_GESTION_COM", WellKnownObjectMode.SingleCall);

                CONNECTION_PARAM.charger_param();
                if (CONNECTION_PARAM.cnx.State == ConnectionState.Closed)
                    CONNECTION_PARAM.cnx.Open();
                
                btn_demarrer.Enabled = false;
                btn_demarrer.Visible = false;
                button3.Visible = true;
                

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
    }
}