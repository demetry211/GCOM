#region Using directives

using System;
using System.Collections;
using System.Text;
using ADODB;
using System.Xml;

#endregion

namespace Connection
{
	public class ConnexionSQL
	{
		//protected static ConnexionSQL instance=new ConnexionSQL();
		public static ConnectionClass Cn = new ConnectionClass();
		public static string Serveur ;
		public static string Db ;
		public static string Usr ;
		public static string Pwd ;
		public static string login;
		public static int fermer=0;
		public static string Code_Role="1";
		public static string Utilisateur="";
		public ConnexionSQL()
		{
			Charger_Configuration();
			string StrConnection ="Data Source=" + Serveur + ";Initial Catalog=" + Db + ";Provider=SQLOLEDB.1"; 
			
			Cn.Open(StrConnection,Usr,Pwd,0);
			Cn.CursorLocation=ADODB.CursorLocationEnum.adUseClient;
		}
		public void BeginTrans()
		{
			Cn.BeginTrans();
		}
		public void CommitTrans()
		{
			Cn.CommitTrans ();
		}
		public void RollBackTrans()
		{
			Cn.RollbackTrans ();
		}
		public static int GetIDConnexion()
		{
			//RecordsetClass Rs = new RecordsetClass();
			//Rs.Open("Select @@SPID as ID",ConnexionSQL.Cn,CursorTypeEnum.adOpenStatic,LockTypeEnum.adLockReadOnly,0);
			string reqSQL="Select @@SPID as ID";
			//Connexion.
			return Int32.Parse(Connexion.ExecuteReq_top(reqSQL)) ;
		}
		public static DateTime GetDate()
		{
			RecordsetClass Rs = new RecordsetClass();
			Rs.Open("Select GetDate() as Date",ConnexionSQL.Cn,CursorTypeEnum.adOpenStatic,LockTypeEnum.adLockReadOnly,0);
			System.IFormatProvider format =	new System.Globalization.CultureInfo("fr-FR", true);
			DateTime D = new DateTime ();
			D= DateTime.Parse(Rs.Fields["Date"].Value.ToString(),format,System.Globalization.DateTimeStyles.None) ;
			D= DateTime.Parse(D.ToString("d"));
			return D;
		}
		public static DateTime GetLongDate()
		{
			RecordsetClass Rs = new RecordsetClass();
			Rs.Open("Select GetDate() as Date",ConnexionSQL.Cn,CursorTypeEnum.adOpenStatic,LockTypeEnum.adLockReadOnly,0);
			System.IFormatProvider format =	new System.Globalization.CultureInfo("fr-FR", true);
			DateTime D = new DateTime ();
			D= DateTime.Parse(Rs.Fields["Date"].Value.ToString(),format,System.Globalization.DateTimeStyles.None) ;
			return D;
		}
		public static DateTime GetTime()
		{
			RecordsetClass Rs = new RecordsetClass();
			Rs.Open("Select GetDate() as Date",ConnexionSQL.Cn,CursorTypeEnum.adOpenStatic,LockTypeEnum.adLockReadOnly,0);
			System.IFormatProvider format =	new System.Globalization.CultureInfo("fr-FR", true);
			DateTime D = new DateTime ();
			D= DateTime.Parse(Rs.Fields["Date"].Value.ToString(),format,System.Globalization.DateTimeStyles.None) ;
			D= DateTime.Parse("30/12/1899 " + D.ToString("T"));
			return D;
		}
		/*public static ConnexionSQL getInstance()
		{
			return instance;
		}*/
		private void Charger_Configuration()
		{
			XmlDocument doc = new XmlDocument();
			doc.Load("Config.xml");
			XmlNode child = doc.SelectSingleNode("/Configurations");
			foreach(System.Xml.XmlNode n in	child)
                if (n.Attributes["id"].Value == "x")
                {
                    for (int i = 0; i < n.ChildNodes.Count; i++)
                        switch (i)
                        {
                            case 0:
                                Serveur = n.ChildNodes[i].InnerText;
                                break;
                            case 1:
                                Db = n.ChildNodes[i].InnerText;
                                break;
                            case 2:
                                Usr = n.ChildNodes[i].InnerText;
                                break;
                            case 3:
                                Pwd = n.ChildNodes[i].InnerText;
                                break;
                            case 4:
                                login = n.ChildNodes[i].InnerText;
                                break;

                        }
                }
		}
	}
}