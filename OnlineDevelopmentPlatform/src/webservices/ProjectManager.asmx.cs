using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;
using System.Xml;

namespace OnlineDevelopmentPlatform
{
	namespace ProjectManager
	{
		public class ProjectManager : System.Web.Services.WebService
		{
			public ProjectManager()
			{
				InitializeComponent();
			}

			private System.Data.SqlClient.SqlConnection m_sqlConnection;
			private System.Data.SqlClient.SqlCommand m_Project;
			private System.Data.SqlClient.SqlCommand m_File;
			private System.Data.SqlClient.SqlConnection sqlConnection1;


			#region Component Designer generated code
		
			//Required by the Web Services Designer 
			private IContainer components = null;
				
			private void InitializeComponent()
			{
				this.m_sqlConnection = new System.Data.SqlClient.SqlConnection();
				this.m_Project = new System.Data.SqlClient.SqlCommand();
				this.m_File = new System.Data.SqlClient.SqlCommand();
				this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
				// 
				// m_sqlConnection
				// 
				this.m_sqlConnection.ConnectionString = "user id=sa;password=sql;data source=\"S2\";initial catalog=devplatform";
				// 
				// m_Project
				// 
				this.m_Project.CommandText = "SELECT ID, NAME FROM PROJECT";
				this.m_Project.Connection = this.m_sqlConnection;
				// 
				// m_File
				// 
				this.m_File.CommandText = "SELECT ID, NAME, PROJECTID FROM [FILE]";
				this.m_File.Connection = this.sqlConnection1;
				// 
				// sqlConnection1
				// 
				this.sqlConnection1.ConnectionString = "user id=sa;password=sql;data source=\"S2\";initial catalog=devplatform";

			}


			protected override void Dispose( bool disposing )
			{
				if(disposing && components != null)
				{
					components.Dispose();
				}
				base.Dispose(disposing);		
			}
		

			#endregion

			// this function is connecting to sql-server
			private bool connectToServer()
			{
				// trying to open the sql-connection
				try
				{
					this.m_sqlConnection.Open();
					this.sqlConnection1.Open();
					return true;
				}
				catch
				{
					return false;
				}
			}


			[WebMethod]
			public string debugProjectManager(string messageToPrint)
			{
				if( 0 == messageToPrint.Length )
					messageToPrint = "This is a debug method for - 'SourceControlManager::ProjectManager'.";

				return messageToPrint;
			}		


			[WebMethod]
			public bool createProject(string projectName)
			{
				return true;
			}


			[WebMethod]
			public bool openProject(string projectID)
			{
				return true;
			}


			[WebMethod]
			public bool closeProject(string projectID)
			{
				return true;
			}


			[WebMethod]
			public bool deleteProject(string projectID)
			{
				return true;
			}


			[WebMethod]
			public string getListOfProjects()
			{
				if( false == connectToServer() )
				return string.Empty;

				// trying to read data from "Project" table
				SqlDataReader projectReader;
				projectReader = this.m_Project.ExecuteReader();

				XmlDocument xmlDocument = new XmlDocument();
				xmlDocument.LoadXml("<?xml version='1.0'?><projects></projects>");

				while( projectReader.Read() ) 
				{
					XmlNode root = xmlDocument.DocumentElement;

					//create a new node
					XmlElement element = xmlDocument.CreateElement( "project" );
					element.SetAttribute("label",projectReader.GetString(1));
					//element.SetAttribute("isBranch","false");
					element.SetAttribute("projectid",Convert.ToString( projectReader.GetGuid(0) ));

					{ // getting the list of files for each project
						string sql =  this.m_File.CommandText;
						this.m_File.CommandText += " where PROJECTID = '"+Convert.ToString( projectReader.GetGuid(0) )+"'";

						SqlDataReader fileReader;
						fileReader = this.m_File.ExecuteReader();
						while( fileReader.Read() )
						{
                            XmlElement fileElement = xmlDocument.CreateElement( "file" );
							fileElement.SetAttribute("label", fileReader.GetString(1));
                            fileElement.SetAttribute("fileid",Convert.ToString( fileReader.GetGuid(0) ));
							fileElement.SetAttribute("projectid",Convert.ToString( projectReader.GetGuid(0) ));
							element.AppendChild(fileElement);
						}
						fileReader.Close();
                        
						this.m_File.CommandText = sql;
					}

					// adding the newly created node
					root.AppendChild( element );
				}
				projectReader.Close();
				
				//closing the connection
				this.m_sqlConnection.Close();
				
				// saving the xml-document
				//xmlDocument.Save("c:\\tree.xml");
				string path = "http://" + 
					this.Context.Request.Url.Authority + 
					this.Context.Request.Url.Segments[0] + 
					this.Context.Request.Url.Segments[1] +
					"resources/tree.xml";

                xmlDocument.Save( "C:\\Perforce\\OnlineDevelopmentPlatform\\src\\webservices\\resources\\tree.xml" );

				// returning the URL to the file containing the structure of the projects
				return path;
			}
		}
	}
}
