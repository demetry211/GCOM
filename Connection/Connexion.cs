using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using System.Xml;

namespace Connection
{
	/// <summary>
	/// Description résumée de Connexion.
	/// </summary>
	public class Connexion
	{
		public Connexion()
		{
			//
			// TODO : ajoutez ici la logique du constructeur
			//
		}

	#region *****Mise à jour BD******
	// Méthode d'execution d'une commande SQL (SQLSERVER)
	//Cette méthode est utile pour l'execution des requetes SQL se type (INSERT, UPDATE ,DELETE).

		public static void ExecuteReq(string reqSQL)
		{
	
			SqlCommand myCommand = new SqlCommand(reqSQL,CnxBase.myConn);
			myCommand.Transaction=CnxBase.trans;
			myCommand.ExecuteNonQuery();	
		}
	#endregion


	#region *****Avoir un seul valeur******
		public static string ExecuteReq_top(string reqSQL)
		{
	
			SqlCommand myCommand = new SqlCommand(reqSQL,CnxBase.myConn);
			myCommand.Transaction=CnxBase.trans;
			string d="";
			d=myCommand.ExecuteScalar().ToString();
			return (d);	
		}
	#endregion
		

	#region *****Selection multiple******
		public static SqlDataReader Execute(String reqSQL)
		{
			SqlCommand myCommand = new SqlCommand(reqSQL,CnxBase.myConn);
			myCommand.Transaction=CnxBase.trans;
			return(myCommand.ExecuteReader());
		}
	#endregion

		public static DataTable list(string strSQL)
		{

		
			
//			if(CnxBase.Local=="Oui")
//			{
            try
            {
                SqlDataAdapter myDataAdapter = new SqlDataAdapter(strSQL, CnxBase.myConn);
                DataSet myDataSet = new DataSet();
                myDataAdapter.SelectCommand.Transaction = CnxBase.trans;
                myDataAdapter.Fill(myDataSet, "MySrcTable");

                return myDataSet.Tables["MySrcTable"];
            }
            catch (Exception myException)
            {
                throw (new Exception(myException.Message + " => " + strSQL));
            }
           
//			}
//			else
//			{
//				localhost.Service1 sr=new Test.service.localhost.Service1();
//
//				return sr.List(strSQL).Tables[0];
//			}
		}

		/////////////////////////////////////////////////////////////////////////////////////////
		///
		public static DataTable list1(string strSQL)
		{

		
			
			//			if(CnxBase.Local=="Oui")
			//			{
			try
			{
                CnxBase cnx2 = CnxBase.getInstance();
                SqlDataAdapter myDataAdapter = new SqlDataAdapter (strSQL, cnx2.OpenConnection());
				DataSet myDataSet = new DataSet();
				myDataAdapter.Fill(myDataSet,"MySrcTable");
				
				return myDataSet.Tables["MySrcTable"];
			}
			catch(Exception myException)
			{
				throw(new Exception(myException.Message +" => " + strSQL));
			}
			//			}
			//			else
			//			{
			//				localhost.Service1 sr=new Test.service.localhost.Service1();
			//
			//				return sr.List(strSQL).Tables[0];
			//			}
		}
	}
}
