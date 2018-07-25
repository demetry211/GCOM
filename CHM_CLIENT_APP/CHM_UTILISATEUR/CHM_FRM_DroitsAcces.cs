using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CHM_CLIENT_APP.Properties;

namespace CHM_CLIENT_APP.CHM_UTILISATEUR
{
    public partial class CHM_FRM_DroitsAcces : Form
    {
        DataTable _dt_menu;
        
        decimal _selected_user ;
        public CHM_FRM_DroitsAcces()
        {
            try
            {
                InitializeComponent();
                charger_groups_utilisateur();

                _dt_menu = CLIENT_APP_PARAM.gacces.GetMENU();


                charger_panel(_dt_menu, p_pages);
                (p_groups.Controls[0] as Button).PerformClick();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void CHM_FRM_DroitsAcces_Load(object sender, EventArgs e)
        {
            (p_groups.Controls[0] as Button).PerformClick();
        }

        private void charger_groups_utilisateur()
        {
            try
            {
                p_groups.Controls.Clear();
                DataTable d;
                    d = CLIENT_APP_PARAM.gacces.GetGROUPE_USERS(CLIENT_APP_PARAM.Fenetre_principale.code_group);
                Point location = new Point(0, 0);
                for (int i = 0; i < d.Rows.Count; i++)
                {
                    Button b = new Button();
                    b.Name = d.Rows[i]["CODE_FONCTION_USER"].ToString();
                    b.Text = d.Rows[i]["LIB_FONCTION_USER"].ToString();
                    b.Size = new Size((int)(p_groups.Width * 0.95), 30);
                    b.Tag = (decimal)d.Rows[i]["CODE_FONCTION_USER"];
                    b.Location = location;
                    b.BackColor = Color.WhiteSmoke;
                    location = new Point(location.X, location.Y + b.Height + 2);
                    b.Click += new EventHandler(b_Click);
                    Button bt_modif = new Button();
                    bt_modif.Size = new Size(26, 26);
                    bt_modif.Location = new Point(b.Width - 27, 1);
                    bt_modif.BackgroundImageLayout = ImageLayout.Stretch;
                    bt_modif.BackgroundImage = Resources.arrow_tourner_vers_la_droite_icone_8357_32;
                    bt_modif.Click += new EventHandler(bt_modif_Click);
                    b.Controls.Add(bt_modif);
                    p_groups.Controls.Add(b);
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void bt_modif_Click(object sender, EventArgs e)
        {
            CHM_FRM_MAJ_GU f = new CHM_FRM_MAJ_GU(Convert.ToDecimal((sender as Control).Parent.Name));
            f.ShowDialog();
            charger_groups_utilisateur();
            (p_groups.Controls[(sender as Control).Parent.Name] as Button).PerformClick();
        }

        void b_Click(object sender, EventArgs e)
        {
            try
            {
                _selected_user = (decimal)(sender as Control).Tag;
                foreach (Button b in p_groups.Controls)
                {
                    b.BackColor = Color.WhiteSmoke;
                }
                (sender as Control).BackColor = Color.LightBlue;
                charger_acces(_selected_user);
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void charger_panel(DataTable dt, Panel p)
        {
            try
            {
                if (_dt_menu.Rows.Count > 0)
                {
                    #region CHM_MODE
                    _dt_menu.DefaultView.RowFilter = "MENU_PARENT like '1'";
                    DataTable dt_pages = _dt_menu.DefaultView.ToTable();
                    _dt_menu.DefaultView.RowFilter = "";
                    p.Controls.Clear();
                    Point location_pages = new Point(5, 5);
                    for (int i = 0; i < dt_pages.Rows.Count; i++)
                    {
                        CheckBox ch = new CheckBox();
                        ch.Name = dt_pages.Rows[i]["CODE_MENU"].ToString();
                        ch.Text = dt_pages.Rows[i]["DESCRIPTION_MENU"].ToString();
                        ch.Size = new Size(200, 20);
                        ch.Location = location_pages;
                        ch.Tag = "1";
                        ch.MouseDown += new MouseEventHandler(ch_l_MouseDown);
                        ch.CheckedChanged += new EventHandler(ch_g_CheckedChanged);
                        ch.Click += new EventHandler(ch_Click);
                        location_pages = new Point(location_pages.X, location_pages.Y + ch.Height + 2);
                        p.Controls.Add(ch);

                        _dt_menu.DefaultView.RowFilter = "MENU_PARENT like '" + ch.Name + "'";
                        DataTable dt_group = _dt_menu.DefaultView.ToTable();
                        _dt_menu.DefaultView.RowFilter = "";
                        Point location_group = new Point(20, location_pages.Y);
                        for (int j = 0; j < dt_group.Rows.Count; j++)
                        {
                            CheckBox ch_g = new CheckBox();
                            ch_g.Name = dt_group.Rows[j]["CODE_MENU"].ToString();
                            ch_g.Text = dt_group.Rows[j]["DESCRIPTION_MENU"].ToString();
                            ch_g.Size = new Size(200, 20);
                            ch_g.Location = location_group;
                            ch_g.Tag = ch.Name;
                            ch_g.MouseDown += new MouseEventHandler(ch_l_MouseDown);
                            ch_g.CheckedChanged += new EventHandler(ch_g_CheckedChanged);
                            ch_g.Click += new EventHandler(ch_Click);
                            location_group = new Point(location_group.X, location_group.Y + ch_g.Height + 2);
                            p.Controls.Add(ch_g);
                            _dt_menu.DefaultView.RowFilter = "MENU_PARENT like '" + ch_g.Name + "'";
                            DataTable dt_link = _dt_menu.DefaultView.ToTable();
                            _dt_menu.DefaultView.RowFilter = "";
                            Point location_link = new Point(40, location_group.Y);
                            for (int k = 0; k < dt_link.Rows.Count; k++)
                            {
                                CheckBox ch_l = new CheckBox();
                                ch_l.Name = dt_link.Rows[k]["CODE_MENU"].ToString();
                                ch_l.Text = dt_link.Rows[k]["DESCRIPTION_MENU"].ToString();
                                ch_l.Size = new Size(200, 20);
                                ch_l.Location = location_link;
                                ch_l.Tag = ch_g.Name;
                                ch_l.CheckedChanged += new EventHandler(ch_g_CheckedChanged);
                                ch_l.MouseDown += new MouseEventHandler(ch_l_MouseDown);
                                ch_l.Click += new EventHandler(ch_Click);
                                location_link = new Point(location_link.X, location_link.Y + ch_l.Height + 2);
                                p.Controls.Add(ch_l);
                                _dt_menu.DefaultView.RowFilter = "MENU_PARENT like '" + ch_l.Name + "'";
                                DataTable dt_submenu4 = _dt_menu.DefaultView.ToTable();
                                _dt_menu.DefaultView.RowFilter = "";
                                Point location_submenu = new Point(60, location_link.Y);
                                for (int s = 0; s < dt_submenu4.Rows.Count; s++)
                                {
                                    CheckBox ch_s4 = new CheckBox();
                                    ch_s4.Name = dt_submenu4.Rows[s]["CODE_MENU"].ToString();
                                    ch_s4.Text = dt_submenu4.Rows[s]["DESCRIPTION_MENU"].ToString();
                                    ch_s4.Size = new Size(200, 20);
                                    ch_s4.Location = location_submenu;
                                    ch_s4.Tag = ch_l.Name;
                                    ch_s4.CheckedChanged += new EventHandler(ch_g_CheckedChanged);
                                    ch_s4.MouseDown += new MouseEventHandler(ch_l_MouseDown);
                                    location_submenu = new Point(location_submenu.X, location_submenu.Y + ch_s4.Height + 2);
                                    p.Controls.Add(ch_s4);
                                }
                                location_link = new Point(location_link.X, location_submenu.Y);
                            }
                            location_group = new Point(location_group.X, location_link.Y);
                        }
                        location_pages = new Point(location_pages.X, location_group.Y);
                    }
                    #endregion                   

                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        void ch_Click(object sender, EventArgs e)
        {
            
        }

        void ch_l_MouseDown(object sender, MouseEventArgs e)
        {
            checked_item = (sender as Control).Name;
        }

        string checked_item = "";
        void ch_g_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if ((sender as CheckBox).Checked)
                {
                    if ((sender as Control).Tag.ToString() != "1")
                        foreach (CheckBox c in p_pages.Controls)
                        {
                            //if (c.Name.ToString() == (sender as Control).Tag.ToString() && !c.Checked)
                            //    c.Checked = true;
                            //if (c.Name.Length >= 4 && c.Name.Substring(0, 4) == (sender as Control).Name && checked_item.Length <= 4)
                            //    c.Checked = true;
                            if (c.Name == (sender as CheckBox).Tag.ToString())
                                c.Checked = true;
                            //if (c.Tag.ToString() == (sender as CheckBox).Name )
                                if (c.Tag.ToString() == checked_item)
                                c.Checked = true;
                        }
                    else
                        foreach (CheckBox c in p_pages.Controls)
                        {
                            if (c.Tag.ToString() == checked_item)
                                c.Checked = true;
                        }
                }
                else
                {
                    if ((sender as Control).Tag.ToString() != "1")
                        foreach (CheckBox c in p_pages.Controls)
                        {
                            ////if (c.Name.Length >= 4 && c.Name.Substring(0, 4) == (sender as Control).Name)
                            ////    c.Checked = false;
                            if (c.Tag.ToString() == (sender as CheckBox).Name)
                                c.Checked = false;
                        }
                    else
                        foreach (CheckBox c in p_pages.Controls)
                        {
                            if (c.Tag.ToString() == (sender as CheckBox).Name)
                                c.Checked = false;
                        }
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void charger_acces(decimal code_groupe)
        {
            DataTable dt =new DataTable();
            try
            {
                
                
                
                        dt = CLIENT_APP_PARAM.gacces.GetACCES_MENU();
                        dt.DefaultView.RowFilter = "CODE_GROUPE = '" + _selected_user.ToString() + "'";
                        dt = dt.DefaultView.ToTable();
                   
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        foreach (CheckBox c in p_pages.Controls)
                        {
                            if (c.Name == dt.Rows[i]["MENU"].ToString())
                            {
                                string s = dt.Rows[i]["VISIBLITE"].ToString();
                                if (dt.Rows[i]["VISIBLITE"].ToString() == "True")
                                    c.Checked = true;
                                else
                                    c.Checked = false;
                                break;
                            }
                        }
                    }
                }
                else
                {
                    foreach (CheckBox c in p_pages.Controls)
                    {

                        c.Checked = false;
                    }
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            DataTable dt=new DataTable();
            try
            {
                
                
                        dt = CLIENT_APP_PARAM.gacces.GetACCES_MENU();
                        dt.DefaultView.RowFilter = "CODE_GROUPE = '" + _selected_user.ToString() + "'";
                    
                dt.Rows.Clear();

                foreach (Control c in p_pages.Controls)
                {
                    DataRow dr = dt.NewRow();
                    dr.BeginEdit();
                    dr[0] = c.Name.ToString();
                    dr[1] = _selected_user;
                    dr[2] = (c as CheckBox).Checked;
                    dr.EndEdit();
                    dt.Rows.Add(dr);
                }

                
                        CLIENT_APP_PARAM.gacces.saveAccesGroupUser(_selected_user.ToString(), dt);
                   

                MessageBox.Show("Droits d'accès enregistrés avec succès.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void p_pages_MouseEnter(object sender, EventArgs e)
        {
            (sender as Panel).Select();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CHM_FRM_MAJ_GU f = new CHM_FRM_MAJ_GU(0);
            f.ShowDialog();
            
            charger_groups_utilisateur();
            (p_groups.Controls[p_groups.Controls.Count-1] as Button).PerformClick();
        }



    }
}
