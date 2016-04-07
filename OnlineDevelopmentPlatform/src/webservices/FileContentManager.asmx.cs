using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;

namespace OnlineDevelopmentPlatform
{
	namespace SourceControlManager
	{
		public class FileContentManager : System.Web.Services.WebService
		{
			private System.Data.SqlClient.SqlConnection m_sqlConnection;
			private System.Data.SqlClient.SqlCommand m_File;
			private System.Data.SqlClient.SqlCommand m_updateFile;
			#region generated code
			
			//Required by the Web Services Designer 
			private IContainer components = null;
					
			private void InitializeComponent()
			{
				this.m_sqlConnection = new System.Data.SqlClient.SqlConnection();
				this.m_File = new System.Data.SqlClient.SqlCommand();
				this.m_updateFile = new System.Data.SqlClient.SqlCommand();
				// 
				// m_sqlConnection
				// 
				this.m_sqlConnection.ConnectionString = "user id=sa;data source=S2;initial catalog=devplatform;password=sql";
				// 
				// m_File
				// 
				this.m_File.CommandText = "SELECT CONTENT FROM [FILE]";
				this.m_File.Connection = this.m_sqlConnection;
				// 
				// m_updateFile
				// 
				this.m_updateFile.CommandText = "[update_FILE]";
				this.m_updateFile.CommandType = System.Data.CommandType.StoredProcedure;
				this.m_updateFile.Connection = this.m_sqlConnection;
				this.m_updateFile.Parameters.Add(new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((System.Byte)(0)), ((System.Byte)(0)), "", System.Data.DataRowVersion.Current, null));
				this.m_updateFile.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.UniqueIdentifier, 16));
				this.m_updateFile.Parameters.Add(new System.Data.SqlClient.SqlParameter("@PROJECTID", System.Data.SqlDbType.UniqueIdentifier, 16));
				this.m_updateFile.Parameters.Add(new System.Data.SqlClient.SqlParameter("@CONTENT", System.Data.SqlDbType.VarChar, 8000));

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

			public FileContentManager()
			{
				InitializeComponent();
			}


			// this function is connecting to sql-server
			private bool connectToServer()
			{
				// trying to open the sql-connection
				try
				{
					this.m_sqlConnection.Open();
					return true;
				}
				catch
				{
					return false;
				}
			}

			private void closeConnection()
			{
				this.m_sqlConnection.Close();
			}


			[WebMethod]
			public string debugFileContentManager(string messageToPrint)
			{
				if( 0 == messageToPrint.Length )
					messageToPrint = "This is a debug method for - 'SourceControlManager::FileContentManager'.";

				return messageToPrint;
			}


			[WebMethod]
			public string editFile( string fileID, string projectID )
			{
				if( false == connectToServer() )
					return "";

				this.m_File.CommandText += " where ID = '" + fileID + "' and projectid = '" + projectID + "'";	

				// trying to read data from "File" table
				SqlDataReader fileReader;
				fileReader = this.m_File.ExecuteReader();

				string fileContent = "";
				while( fileReader.Read() ) 
				{
                    fileContent = fileReader.GetString(0);				
				}
				fileReader.Close();

				closeConnection();

				return fileContent;
			}


			[WebMethod]
			public bool submitFile( string fileID, string projectID, string fileContent )
			{
				if( false == connectToServer() )
					return false;

				this.m_updateFile.Parameters["@ID"].Value = new Guid(fileID);
				this.m_updateFile.Parameters["@PROJECTID"].Value = new Guid(projectID);
				this.m_updateFile.Parameters["@CONTENT"].Value = fileContent;

				try
				{
					this.m_updateFile.ExecuteNonQuery();
					closeConnection();
                    return true;
				}
				catch
				{
					closeConnection();
					return false;
				}
			}


			[WebMethod]
			public bool lockFile(string depotFile)
            {
				return true;
			}


			[WebMethod]
			public bool unlockFile(string depotFile)
			{
				return true;
			}
		}
	}
}
