using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Web;
using System.Web.Services;

namespace OnlineDevelopmentPlatform
{
	namespace ProfileManager
	{
		public class ProfileManager : System.Web.Services.WebService
		{
			public ProfileManager()
			{
				InitializeComponent();
			}
			private System.Data.SqlClient.SqlConnection m_sqlConnection;
			private System.Data.SqlClient.SqlCommand m_CREATE_PROFILE;
			private System.Data.SqlClient.SqlCommand m_LOGIN_PROFILE;
			private System.Data.SqlClient.SqlCommand m_ISVALID_PROFILE;
			private System.Data.SqlClient.SqlCommand m_ISLOGGED_PROFILE;
			private System.Data.SqlClient.SqlCommand m_LOGOUT_PROFILE;


			#region Component Designer generated code
		
			//Required by the Web Services Designer 
			private IContainer components = null;
				
			private void InitializeComponent()
			{
				this.m_CREATE_PROFILE = new System.Data.SqlClient.SqlCommand();
				this.m_sqlConnection = new System.Data.SqlClient.SqlConnection();
				this.m_LOGIN_PROFILE = new System.Data.SqlClient.SqlCommand();
				this.m_ISVALID_PROFILE = new System.Data.SqlClient.SqlCommand();
				this.m_ISLOGGED_PROFILE = new System.Data.SqlClient.SqlCommand();
				this.m_LOGOUT_PROFILE = new System.Data.SqlClient.SqlCommand();
				// 
				// m_CREATE_PROFILE
				// 
				this.m_CREATE_PROFILE.CommandText = "[CREATE_PROFILE]";
				this.m_CREATE_PROFILE.CommandType = System.Data.CommandType.StoredProcedure;
				this.m_CREATE_PROFILE.Connection = this.m_sqlConnection;
				this.m_CREATE_PROFILE.Parameters.Add(new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((System.Byte)(0)), ((System.Byte)(0)), "", System.Data.DataRowVersion.Current, null));
				this.m_CREATE_PROFILE.Parameters.Add(new System.Data.SqlClient.SqlParameter("@LOGIN", System.Data.SqlDbType.VarChar, 100));
				this.m_CREATE_PROFILE.Parameters.Add(new System.Data.SqlClient.SqlParameter("@PASSWORD", System.Data.SqlDbType.VarChar, 100));
				this.m_CREATE_PROFILE.Parameters.Add(new System.Data.SqlClient.SqlParameter("@EMAIL", System.Data.SqlDbType.VarChar, 100));
				// 
				// m_sqlConnection
				// 
				this.m_sqlConnection.ConnectionString = "user id=sa;password=sql;data source=S2;initial catalog=devplatform";
				// 
				// m_LOGIN_PROFILE
				// 
				this.m_LOGIN_PROFILE.CommandText = "[LOGIN_PROFILE]";
				this.m_LOGIN_PROFILE.CommandType = System.Data.CommandType.StoredProcedure;
				this.m_LOGIN_PROFILE.Connection = this.m_sqlConnection;
				this.m_LOGIN_PROFILE.Parameters.Add(new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((System.Byte)(0)), ((System.Byte)(0)), "", System.Data.DataRowVersion.Current, null));
				this.m_LOGIN_PROFILE.Parameters.Add(new System.Data.SqlClient.SqlParameter("@LOGIN", System.Data.SqlDbType.VarChar, 100));
				this.m_LOGIN_PROFILE.Parameters.Add(new System.Data.SqlClient.SqlParameter("@PASSWORD", System.Data.SqlDbType.VarChar, 100));
				this.m_LOGIN_PROFILE.Parameters.Add(new System.Data.SqlClient.SqlParameter("@SESSIONID", System.Data.SqlDbType.UniqueIdentifier, 16, System.Data.ParameterDirection.Output, false, ((System.Byte)(0)), ((System.Byte)(0)), "", System.Data.DataRowVersion.Current, null));
				// 
				// m_ISVALID_PROFILE
				// 
				this.m_ISVALID_PROFILE.CommandText = "[ISVALID_PROFILE]";
				this.m_ISVALID_PROFILE.CommandType = System.Data.CommandType.StoredProcedure;
				this.m_ISVALID_PROFILE.Connection = this.m_sqlConnection;
				this.m_ISVALID_PROFILE.Parameters.Add(new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((System.Byte)(0)), ((System.Byte)(0)), "", System.Data.DataRowVersion.Current, null));
				this.m_ISVALID_PROFILE.Parameters.Add(new System.Data.SqlClient.SqlParameter("@LOGIN", System.Data.SqlDbType.VarChar, 100));
				this.m_ISVALID_PROFILE.Parameters.Add(new System.Data.SqlClient.SqlParameter("@PASSWORD", System.Data.SqlDbType.VarChar, 100));
				this.m_ISVALID_PROFILE.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ISVALID", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Output, false, ((System.Byte)(0)), ((System.Byte)(0)), "", System.Data.DataRowVersion.Current, null));
				// 
				// m_ISLOGGED_PROFILE
				// 
				this.m_ISLOGGED_PROFILE.CommandText = "[ISLOGGED_PROFILE]";
				this.m_ISLOGGED_PROFILE.CommandType = System.Data.CommandType.StoredProcedure;
				this.m_ISLOGGED_PROFILE.Connection = this.m_sqlConnection;
				this.m_ISLOGGED_PROFILE.Parameters.Add(new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((System.Byte)(0)), ((System.Byte)(0)), "", System.Data.DataRowVersion.Current, null));
				this.m_ISLOGGED_PROFILE.Parameters.Add(new System.Data.SqlClient.SqlParameter("@LOGIN", System.Data.SqlDbType.VarChar, 100));
				this.m_ISLOGGED_PROFILE.Parameters.Add(new System.Data.SqlClient.SqlParameter("@PASSWORD", System.Data.SqlDbType.VarChar, 100));
				this.m_ISLOGGED_PROFILE.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ISLOGGED", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Output, false, ((System.Byte)(0)), ((System.Byte)(0)), "", System.Data.DataRowVersion.Current, null));
				// 
				// m_LOGOUT_PROFILE
				// 
				this.m_LOGOUT_PROFILE.CommandText = "[LOGOUT_PROFILE]";
				this.m_LOGOUT_PROFILE.CommandType = System.Data.CommandType.StoredProcedure;
				this.m_LOGOUT_PROFILE.Connection = this.m_sqlConnection;
				this.m_LOGOUT_PROFILE.Parameters.Add(new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((System.Byte)(0)), ((System.Byte)(0)), "", System.Data.DataRowVersion.Current, null));
				this.m_LOGOUT_PROFILE.Parameters.Add(new System.Data.SqlClient.SqlParameter("@SESSIONID", System.Data.SqlDbType.UniqueIdentifier, 16));

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

			[WebMethod]
			public string debugProfileManager(string messageToPrint)
			{
				if( 0 == messageToPrint.Length )
					messageToPrint = "This is a debug method for - 'SourceControlManager::ProfileManager'.";

				return messageToPrint;
			}		


			[WebMethod]
			public bool createProfile(string loginName, string password, string email)
			{
				// trying to open the sql-connection
				try
				{
					this.m_sqlConnection.Open();
				}
				catch
				{
					return false;
				}
			
				//  try to execute the stored procedure
				this.m_CREATE_PROFILE.Parameters["@LOGIN"].Value = loginName;
				this.m_CREATE_PROFILE.Parameters["@PASSWORD"].Value = password;
				this.m_CREATE_PROFILE.Parameters["@EMAIL"].Value = email;
				try
				{
					this.m_CREATE_PROFILE.ExecuteNonQuery();
				}
				catch
				{
					this.m_sqlConnection.Close();
                    return false;
				}
			
				// closing sql-connection
				this.m_sqlConnection.Close();
				return true;
			}
	

			[WebMethod]
			public bool closeProfile(string profileID)
			{
				return true;
			}


			[WebMethod]
			public bool reopenProfile(string profileID)
			{
				return true;
			}


			[WebMethod]
			public string loginProfile(string loginName, string password)
			{
				// if profile is not a valid one, or if it is logged-in already, then deny logon
				if( !isProfileValid(loginName, password) || isProfileLoggedIn(loginName, password) )
                    return string.Empty;

				// trying to open the sql-connection
				try
				{
					this.m_sqlConnection.Open();
				}
				catch
				{
					return string.Empty;
				}
			
				//  try to execute the stored procedure
				this.m_LOGIN_PROFILE.Parameters["@LOGIN"].Value = loginName;
				this.m_LOGIN_PROFILE.Parameters["@PASSWORD"].Value = password;
				try
				{
					this.m_LOGIN_PROFILE.ExecuteNonQuery();
				}
				catch
				{
					this.m_sqlConnection.Close();
					return string.Empty;
				}
			
				// closing sql-connection
				this.m_sqlConnection.Close();

				// getting the session-id, returned by the server
				string sessionid = string.Empty;
				sessionid = Convert.ToString(this.m_LOGIN_PROFILE.Parameters["@SESSIONID"].Value);

				return sessionid;                
			}


			[WebMethod]
			public bool logoutProfile(string sessionID)
			{
				// trying to open the sql-connection
				try
				{
					this.m_sqlConnection.Open();
				}
				catch
				{
					return false;
				}
			
				//  try to execute the stored procedure
				this.m_LOGOUT_PROFILE.Parameters["@SESSIONID"].Value = new Guid(sessionID);
				try
				{
					this.m_LOGOUT_PROFILE.ExecuteNonQuery();
				}
				catch
				{
					this.m_sqlConnection.Close();
					return false;
				}
			
				// closing sql-connection
				this.m_sqlConnection.Close();
                return true;				
			}


			[WebMethod]
			public bool isProfileValid(string loginName, string password)
			{
				// trying to open the sql-connection
				try
				{
					this.m_sqlConnection.Open();
				}
				catch
				{
					return false;
				}
			
				//  try to execute the stored procedure
				this.m_ISVALID_PROFILE.Parameters["@LOGIN"].Value = loginName;
				this.m_ISVALID_PROFILE.Parameters["@PASSWORD"].Value = password;
				try
				{
					this.m_ISVALID_PROFILE.ExecuteNonQuery();
				}
				catch
				{
					this.m_sqlConnection.Close();
					return false;
				}
			
				// closing sql-connection
				this.m_sqlConnection.Close();

				// getting the validity of the profile
				bool isValid = false;
				isValid = Convert.ToBoolean(this.m_ISVALID_PROFILE.Parameters["@ISVALID"].Value);

				return isValid;				
			}


			[WebMethod]
			public bool isProfileLoggedIn(string loginName, string password)
			{
				// trying to open the sql-connection
				try
				{
					this.m_sqlConnection.Open();
				}
				catch
				{
					return false;
				}
			
				//  try to execute the stored procedure
				this.m_ISLOGGED_PROFILE.Parameters["@LOGIN"].Value = loginName;
				this.m_ISLOGGED_PROFILE.Parameters["@PASSWORD"].Value = password;
				try
				{
					this.m_ISLOGGED_PROFILE.ExecuteNonQuery();
				}
				catch
				{
					this.m_sqlConnection.Close();
					return false;
				}
			
				// closing sql-connection
				this.m_sqlConnection.Close();

				// getting the validity of the profile
				bool isLoggedIn = false;
				isLoggedIn = Convert.ToBoolean(this.m_ISLOGGED_PROFILE.Parameters["@ISLOGGED"].Value);

				return isLoggedIn;				
			}
		}
	}
}
