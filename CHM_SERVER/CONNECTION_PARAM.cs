using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Xml;

namespace CHM_SERVER
{
    public static class CONNECTION_PARAM
    {
        public static SqlConnection cnx;
        public static SqlTransaction trans;
        public static string pwd_admin = "";
        private static string user = "";
        public static string User
        {
            get
            {
                return user;
            }
            set
            {
                if (user == value)
                    return;
                user = value;
            }
        }
        private static string password = "";
        public static string Password
        {
            get
            {
                return password;
            }
            set
            {
                if (password == value)
                    return;
                password = value;
            }
        }
        private static string server = "";
        public static string Server
        {
            get
            {
                return server;
            }
            set
            {
                if (server == value)
                    return;
                server = value;
            }
        }
        private static string db = "";
        public static string DB
        {
            get
            {
                return db;
            }
            set
            {
                if (db == value)
                    return;
                db = value;
            }
        }

        private static string cnxString = "";        

        public static void charger_param()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(AppDomain.CurrentDomain.BaseDirectory+@"\Config.xml");
            XmlNode child = doc.SelectSingleNode("/Configurations");
            foreach (System.Xml.XmlNode n in child)
                if (n.Attributes["id"].Value == "GC")
                {
                    for (int i = 0; i < n.ChildNodes.Count; i++)

                        switch (n.ChildNodes[i].Name)
                        {                            
                            case "Server":
                                Server = n.ChildNodes[i].InnerText;
                                break;
                            case "DB":
                                DB = n.ChildNodes[i].InnerText;
                                break;
                            case "User":
                                User = n.ChildNodes[i].InnerText;
                                break;
                            case "Pwd":
                                Password = n.ChildNodes[i].InnerText;                                
                                //Password = Decrypt(Password);
                                break;
                            case "pwd_admin":
                                pwd_admin = n.ChildNodes[i].InnerText;
                                break;
                        }

                }
            cnxString = @"user id=" + User + ";Password = " + Password + ";data source=" + Server + ";initial catalog=" + DB;
            cnx = new SqlConnection(cnxString);
        }
    }
}
