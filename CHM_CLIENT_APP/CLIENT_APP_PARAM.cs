using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Data;
using System.Threading;

namespace CHM_CLIENT_APP
{
    public static class CLIENT_APP_PARAM
    {
        public static CHM_COMMERCIAL_MANAGEMENT_PROGRAM Fenetre_principale = new CHM_COMMERCIAL_MANAGEMENT_PROGRAM();
        public static CHM_FRM_COPIE FRM_COPY = new CHM_FRM_COPIE();
        public static CHM_GESTION_COMERCIALE.CHM_GESTION GEST = null;
        public static string CODE_MAG = "";
        public static string serveur = "";
        public static string port = "";
        public static string instance = "";
        public static string pwd_admin = "";
        public static string key = "";
        public static string InvoicePrintOption = "";
        public static string TicketPrinter = "";
        public static string ReportPrinter = "";
        public static bool entete = false;
        public static string Prefix = "GCOM";




        public static DS_GC ds_param;

        #region Services Web
        public static CHMGC.GSWS gcws;
        public static CHMCNX.CHMCNX gccnx;
        public static CHMSTAT.CHMSTAT gcstat;
        public static CHMGA.CHMGACCES gacces;
        public static CHMMARQUE.CHM_MARQUE gmarque;
        public static CHM_FAMILLE_ARTICLE.CHM_FAMILLE_ARTICLE gfamilleArticle;
        public static CHM_LIGNE_ARTICLE.CHM_LIGNE_ARTICLE gligneArticle;

        #endregion

        public static DateTime _date_cnx;
        public static string etat;
        public static string Etat
        {
            get
            {
                return etat;
            }
            set
            {
                etat = value;
                if (onEtatChanged != null)
                    onEtatChanged();
            }
        }
        public delegate void ChangementEtat();
        public static ChangementEtat onEtatChanged;



        public static void connect(object state)
        {
            AutoResetEvent are = (AutoResetEvent)state;
            Exception er = new Exception();
            string erreur = "";
            try
            {
                CLIENT_APP_PARAM.gccnx = new CHM_CLIENT_APP.CHMCNX.CHMCNX();
                gccnx.Url = "http://" + CLIENT_APP_PARAM.serveur + ":" + CLIENT_APP_PARAM.port + "/CHMCNX.asmx";
                etat = "Connexion au serveur";
                erreur = "Erreur lors de la tentative de connexion au serveur.";
                _date_cnx = gccnx.getDate();
                CLIENT_APP_PARAM.gcws = new CHM_CLIENT_APP.CHMGC.GSWS();
                gcws.Url = "http://" + CLIENT_APP_PARAM.serveur + ":" + CLIENT_APP_PARAM.port + "/GSWS.asmx";
                etat = "Chargement des services de gestion.";
                erreur = "Erreur lors du changement des services de gestion.";
                _date_cnx = gcws.getDateS();
                CLIENT_APP_PARAM.gcstat = new CHM_CLIENT_APP.CHMSTAT.CHMSTAT();
                gcstat.Url = "http://" + CLIENT_APP_PARAM.serveur + ":" + CLIENT_APP_PARAM.port + "/CHMSTAT.asmx";
                etat = "Chargement des services de statistiques.";
                erreur = "Erreur lors du chargement des services de statistiques.";
                _date_cnx = gcstat.getDate();
                CLIENT_APP_PARAM.gacces = new CHM_CLIENT_APP.CHMGA.CHMGACCES();
                gacces.Url = "http://" + CLIENT_APP_PARAM.serveur + ":" + CLIENT_APP_PARAM.port + "/CHMGACCES.asmx";
                etat = "Chargement des services de gestion d'accès.";
                erreur = "Erreur lors du chargement des services de gestion d'accès.";
                _date_cnx = gacces.getDate();
                CLIENT_APP_PARAM.gmarque = new CHM_CLIENT_APP.CHMMARQUE.CHM_MARQUE();
                gmarque.Url = "http://" + CLIENT_APP_PARAM.serveur + ":" + CLIENT_APP_PARAM.port + "/CHM_MARQUE.asmx";
                etat = "Chargement des marques.";
                erreur = "Erreur lors du chargement des marques.";
                _date_cnx = gmarque.getDateS();
                CLIENT_APP_PARAM.gfamilleArticle = new CHM_CLIENT_APP.CHM_FAMILLE_ARTICLE.CHM_FAMILLE_ARTICLE();
                gfamilleArticle.Url = "http://" + CLIENT_APP_PARAM.serveur + ":" + CLIENT_APP_PARAM.port + "/CHM_FAMILLE_ARTICLE.asmx";
                etat = "Chargement des familles articles.";
                erreur = "Erreur lors du chargement des familles articles.";
                _date_cnx = gfamilleArticle.getDateS();
                CLIENT_APP_PARAM.gligneArticle = new CHM_CLIENT_APP.CHM_LIGNE_ARTICLE.CHM_LIGNE_ARTICLE();
                gligneArticle.Url = "http://" + CLIENT_APP_PARAM.serveur + ":" + CLIENT_APP_PARAM.port + "/CHM_LIGNE_ARTICLE.asmx";
                etat = "Chargement des lignes articles";
                erreur = "Erreur lors du chargement des lignes articles.";
                _date_cnx = gligneArticle.getDateS();
            }
            catch (Exception swer)
            {
                throw new Exception(erreur);
            }
            are.Set();
        }

        public static Image ByteToImage(byte[] image)
        {
            MemoryStream ms = new MemoryStream(image);
            Image img = Bitmap.FromStream(ms);
            return img;
        }


        public static byte[] IMAGE_TO_BYTE(Image image)
        {
            if (image == null)
                return null;

            MemoryStream ms = new MemoryStream();
            image.Save(ms, ImageFormat.Png);
            return ms.ToArray();
        }

        public static byte[] FILE_TO_BYTE(string filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);

            byte[] ImageData = new byte[fs.Length];

            fs.Read(ImageData, 0, System.Convert.ToInt32(fs.Length));

            fs.Close();
            return ImageData;
        }
        public static void BYTE_TO_FILE(byte[] b, string filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Create);

            fs.Write(b, 0, System.Convert.ToInt32(b.Length));

            fs.Close();
        }

        public static void configurer_connection()
        {
            XmlDocument doc = new XmlDocument();
            //doc.Load(AppDomain.CurrentDomain.BaseDirectory + @"\Config.xml");
            doc.Load(@"C:\Program Files\CHM PROJECTS\GCOM\Config.xml");
            XmlNode child = doc.SelectSingleNode("/Configurations");
            foreach (System.Xml.XmlNode n in child)
                if (n.Attributes["id"].Value == Prefix)
                {
                    for (int i = 0; i < n.ChildNodes.Count; i++)
                        switch (n.ChildNodes[i].Name)
                        {
                            case "Server":
                                serveur = n.ChildNodes[i].InnerText;
                                break;
                            case "Port":
                                port = n.ChildNodes[i].InnerText;
                                break;
                            case "Instance":
                                instance = n.ChildNodes[i].InnerText;
                                break;
                            case "pwd_admin":
                                pwd_admin = n.ChildNodes[i].InnerText;
                                break;
                            case "key":
                                key = n.ChildNodes[i].InnerText;
                                break;
                        }
                }
        }

        public static void configurer_poste()
        {
            XmlDocument doc = new XmlDocument();
            //doc.Load(AppDomain.CurrentDomain.BaseDirectory + @"\Config_Poste.xml");
            doc.Load(@"C:\Program Files\CHM PROJECTS\GCOM\Config_Poste.xml");
            XmlNode child = doc.SelectSingleNode("/Configurations");
            foreach (System.Xml.XmlNode n in child)
                if (n.Attributes["id"].Value == "GC2S2E")
                {
                    for (int i = 0; i < n.ChildNodes.Count; i++)

                        switch (n.ChildNodes[i].Name)
                        {
                            case "Store":
                                CODE_MAG = n.ChildNodes[i].InnerText;
                                break;
                            case "InvoicePrintOption":
                                InvoicePrintOption = n.ChildNodes[i].InnerText;
                                break;
                            case "TicketPrinter":
                                TicketPrinter = n.ChildNodes[i].InnerText;
                                break;
                            case "ReportPrinter":
                                ReportPrinter = n.ChildNodes[i].InnerText;
                                break;
                            case "entete":
                                entete = n.ChildNodes[i].InnerText == "true" ? true : false;
                                break;
                        }

                }
        }

        public static void declarer_menu(MenuStrip menu)
        {
            try
            {
                DataTable dt_menu;

                dt_menu = gacces.GetMENU();


                foreach (ToolStripItem item in menu.Items)
                {
                    if (item is ToolStripMenuItem)
                    {
                        bool exist = false;
                        for (int i = 0; i < dt_menu.Rows.Count; i++)
                        {
                            if (item.Tag != null && item.Tag.ToString() == dt_menu.Rows[i]["CODE_MENU"])
                            {
                                exist = true;
                                break;
                            }

                        }
                        if (!exist && item.Tag != null)
                        {
                            DataRow dr = dt_menu.NewRow();
                            dr.BeginEdit();
                            dr[0] = item.Tag.ToString();
                            dr[1] = item.Name;
                            dr[2] = item.Text;
                            dr[3] = menu.Tag.ToString();
                            dr.EndEdit();
                            dt_menu.Rows.Add(dr);
                        }
                        exist = false;
                        foreach (ToolStripItem citem in (item as ToolStripMenuItem).DropDownItems)
                        {
                            if (citem is ToolStripMenuItem)
                            {
                                for (int i = 0; i < dt_menu.Rows.Count; i++)
                                {
                                    if (citem.Tag != null && citem.Tag.ToString() == dt_menu.Rows[i]["CODE_MENU"])
                                    {
                                        exist = true;
                                        break;
                                    }

                                }
                                if (!exist && citem.Tag != null)
                                {
                                    DataRow dr = dt_menu.NewRow();
                                    dr.BeginEdit();
                                    dr[0] = citem.Tag.ToString();
                                    dr[1] = citem.Name;
                                    dr[2] = citem.Text;
                                    dr[3] = item.Tag.ToString();
                                    dr.EndEdit();
                                    dt_menu.Rows.Add(dr);
                                }
                                exist = false;
                                foreach (ToolStripItem ccitem in (citem as ToolStripMenuItem).DropDownItems)
                                {
                                    if (ccitem is ToolStripMenuItem)
                                    {
                                        for (int i = 0; i < dt_menu.Rows.Count; i++)
                                        {
                                            if (ccitem.Tag != null && ccitem.Tag.ToString() == dt_menu.Rows[i]["CODE_MENU"])
                                            {
                                                exist = true;
                                                break;
                                            }

                                        }
                                        if (!exist && ccitem.Tag != null)
                                        {
                                            DataRow dr = dt_menu.NewRow();
                                            dr.BeginEdit();
                                            dr[0] = ccitem.Tag.ToString();
                                            dr[1] = ccitem.Name;
                                            dr[2] = ccitem.Text;
                                            dr[3] = citem.Tag.ToString();
                                            dr.EndEdit();
                                            dt_menu.Rows.Add(dr);
                                        }
                                        exist = false;
                                        foreach (ToolStripItem cccitem in (ccitem as ToolStripMenuItem).DropDownItems)
                                        {
                                            if (cccitem is ToolStripMenuItem)
                                            {
                                                for (int i = 0; i < dt_menu.Rows.Count; i++)
                                                {
                                                    if (cccitem.Tag != null && cccitem.Tag.ToString() == dt_menu.Rows[i]["CODE_MENU"])
                                                    {
                                                        exist = true;
                                                        break;
                                                    }

                                                }
                                                if (!exist && cccitem.Tag != null)
                                                {
                                                    DataRow dr = dt_menu.NewRow();
                                                    dr.BeginEdit();
                                                    dr[0] = cccitem.Tag.ToString();
                                                    dr[1] = cccitem.Name;
                                                    dr[2] = cccitem.Text;
                                                    dr[3] = ccitem.Tag.ToString();
                                                    dr.EndEdit();
                                                    dt_menu.Rows.Add(dr);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

                gacces.ajouteMENU(dt_menu);

            }
            catch (Exception er)
            {
                throw er;
            }
        }

        public static void chargerAccesMenu()
        {
            DataTable dt = new DataTable();
            try
            {


                dt = CLIENT_APP_PARAM.gacces.GetACCES_MENU();
                dt.DefaultView.RowFilter = "CODE_GROUPE = '" + CLIENT_APP_PARAM.Fenetre_principale.code_group.ToString() + "'";
                dt = dt.DefaultView.ToTable();

                if (dt.Rows.Count > 0)
                {


                    foreach (ToolStripItem cts in Fenetre_principale.menuStrip.Items)
                    {
                        if (cts is ToolStripMenuItem)
                            if (cts.Tag != null && cts.Tag.ToString() != "")
                                chargerMenuItem(dt, cts);
                            else
                                cts.Visible = false;


                    }


                    foreach (ToolStripItem ctsFav in Fenetre_principale.boite_outil.Items)
                    {

                        if (ctsFav.Tag != null && ctsFav.Tag.ToString() != "")
                        {
                            dt.DefaultView.RowFilter = "MENU like '" + ctsFav.Tag.ToString() + "'";
                            using (DataTable dt_temp = dt.DefaultView.ToTable())
                            {
                                if (dt_temp.Rows.Count > 0)
                                {
                                    ctsFav.Visible = (bool)dt_temp.Rows[0]["VISIBLITE"];
                                }
                            }
                            dt.DefaultView.RowFilter = "";
                        }
                        else
                            ctsFav.Visible = false;


                    }



                }
                else
                {
                    foreach (ToolStripItem c in Fenetre_principale.menuStrip.Items)
                    {

                        c.Visible = false;
                    }

                    foreach (ToolStripItem ctsFav in Fenetre_principale.boite_outil.Items)
                    {
                        ctsFav.Visible = false;
                    }
                    //fileMenu.Visible = true;
                    //foreach (ToolStripItem stc in fileMenu.DropDownItems)
                    //{
                    //    stc.Visible = false;
                    //}
                    //exitToolStripMenuItem.Visible = true;
                    //redémarrerToolStripMenuItem.Visible = true;
                }
            }
            catch (Exception er)
            {
                throw (er);
            }
        }

        public static void chargerMenuItem(DataTable dt, ToolStripItem item)
        {
            if (item is ToolStripMenuItem)
            {
                if (item.Tag != null && item.Tag.ToString() != "")
                {
                    dt.DefaultView.RowFilter = "MENU like '" + item.Tag.ToString() + "'";
                    using (DataTable dt_temp = dt.DefaultView.ToTable())
                    {
                        if (dt_temp.Rows.Count > 0)
                        {
                            item.Visible = (bool)dt_temp.Rows[0]["VISIBLITE"];
                        }
                    }
                    dt.DefaultView.RowFilter = "";
                    if ((item as ToolStripMenuItem).DropDownItems.Count > 0)
                    {
                        foreach (ToolStripItem ts in (item as ToolStripMenuItem).DropDownItems)
                        {
                            chargerMenuItem(dt, ts);
                        }
                    }
                }
                else
                {
                    item.Visible = false;
                }
            }
            else
                item.Visible = true;
        }
    }
}
