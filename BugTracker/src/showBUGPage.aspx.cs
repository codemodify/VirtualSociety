using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace bugtracker
{
	/// <summary>
	/// Summary description for showBUGPage.
	/// </summary>
	/// 
	
	public class showBUGPage : System.Web.UI.Page
	{string session;
		protected System.Data.SqlClient.SqlConnection m_sqlConnection;
		protected System.Web.UI.WebControls.TextBox m_bugNumber;
		protected System.Data.SqlClient.SqlDataAdapter m_VIEW_BUGS;
		protected System.Web.UI.WebControls.Label Label3;
		protected System.Web.UI.WebControls.Label Label4;
		protected System.Web.UI.WebControls.Label Label2;
		protected System.Web.UI.WebControls.Label Label5;
		protected System.Web.UI.WebControls.Label Label6;
		protected System.Web.UI.WebControls.TextBox m_description;
		protected bugtracker.m_dataSet m_dataSet;
		protected System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		protected System.Web.UI.WebControls.Label m_Priority_Lb;
		protected System.Web.UI.WebControls.Label m_Severity_Lb;
		protected System.Web.UI.WebControls.Label m_Status_Lb;
		protected System.Web.UI.WebControls.Label m_Assigned_Lb;
		protected System.Web.UI.WebControls.Label Title;
		protected System.Web.UI.WebControls.Label m_Title_Lb;
		protected System.Web.UI.WebControls.Label Project;
		protected System.Web.UI.WebControls.Label m_Project_Lb;
		protected System.Web.UI.WebControls.Label NewBug;
		protected System.Web.UI.WebControls.Label Label7;
		protected System.Data.SqlClient.SqlDataAdapter m_Messages_sqDA;
		protected System.Web.UI.WebControls.DataGrid DataGrid1;
		protected System.Data.SqlClient.SqlCommand sqlSelectCommand2;
		protected System.Web.UI.WebControls.Button m_SaveChanges_B;
		protected System.Web.UI.WebControls.TextBox m_NewMessage_T;
		protected System.Data.SqlClient.SqlCommand m_InsertMessage;
		protected System.Web.UI.WebControls.Label Label1;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			 session=Request.Params.Get("Session");
			//m_NewMessage_T.Text=session;

			// changing the connection string to a corect one
			this.m_sqlConnection.ConnectionString = bugtracker.Settings.getConnectionString(this);

			// in case of invlaid bug id, redirecting to search page
			if( Request.Params.Get("bugid").Length == 0 )
			{
				Response.Write( "<b><font color=\"red\">BUG id is empty.\nRedirecting to the search page...</font></b>" );
				Response.Redirect("sessionPage.aspx");
			}
			else // setting the internal variable to store the data header
			{
				this.m_bugNumber.Text = Request.Params.Get("bugid");

				try
				{
					// trying to open the sql-connection
					this.m_sqlConnection.Open();
				}
				catch
				{
					// in case we have errors, showing that
					Response.Redirect("errorPage.aspx");
				}

                // filling the dataset
			    this.m_VIEW_BUGS.SelectCommand.CommandText += " WHERE ID = " + Request.Params.Get("bugid");
			    this.m_Messages_sqDA.SelectCommand.CommandText += " WHERE BUGID = " + Request.Params.Get("bugid");
				this.m_VIEW_BUGS.Fill( this.m_dataSet, "VIEW_BUGS" );
				this.m_Messages_sqDA.Fill( this.m_dataSet, "VIEW_MESSAGES" );

//				 binding to reflect values
//				this.m_Assigned_DDL.DataBind();
//				this.m_Status_DDL.DataBind();
//				this.m_Priority_DDL.DataBind();
//				this.m_Severity_DDL.DataBind();
				

				this.m_Assigned_Lb.DataBind();
				this.m_Status_Lb.DataBind();
				this.m_Priority_Lb.DataBind();
				this.m_Severity_Lb.DataBind();
				this.m_Title_Lb.DataBind();
				this.m_Project_Lb.DataBind();
				this.m_description.DataBind();
				//this.m_User_DDL.DataBind();
				this.DataGrid1.DataBind();				
				
				
			}
		}

		#region Web Form Designer generated code
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: This call is required by the ASP.NET Web Form Designer.
			//
			InitializeComponent();
			base.OnInit(e);
		}
		
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{    
			this.m_sqlConnection = new System.Data.SqlClient.SqlConnection();
			this.m_VIEW_BUGS = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
			this.m_dataSet = new bugtracker.m_dataSet();
			this.m_Messages_sqDA = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
			this.m_InsertMessage = new System.Data.SqlClient.SqlCommand();
			((System.ComponentModel.ISupportInitialize)(this.m_dataSet)).BeginInit();
			this.m_SaveChanges_B.Click += new System.EventHandler(this.m_SaveChanges_B_Click);
			// 
			// m_sqlConnection
			// 
			this.m_sqlConnection.ConnectionString = "workstation id=S4;packet size=4096;user id=sa;data source=\"SERVER\\MSQLSERVER\";per" +
				"sist security info=False;initial catalog=bugtracker";
			// 
			// m_VIEW_BUGS
			// 
			this.m_VIEW_BUGS.SelectCommand = this.sqlSelectCommand1;
			this.m_VIEW_BUGS.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																								  new System.Data.Common.DataTableMapping("Table", "VIEW_BUGS", new System.Data.Common.DataColumnMapping[] {
																																																			   new System.Data.Common.DataColumnMapping("ProjectID", "ProjectID"),
																																																			   new System.Data.Common.DataColumnMapping("Title", "Title"),
																																																			   new System.Data.Common.DataColumnMapping("ID", "ID"),
																																																			   new System.Data.Common.DataColumnMapping("Priority", "Priority"),
																																																			   new System.Data.Common.DataColumnMapping("Severity", "Severity"),
																																																			   new System.Data.Common.DataColumnMapping("Status", "Status"),
																																																			   new System.Data.Common.DataColumnMapping("Assigned", "Assigned"),
																																																			   new System.Data.Common.DataColumnMapping("DESCRIPTION", "DESCRIPTION"),
																																																			   new System.Data.Common.DataColumnMapping("Color", "Color"),
																																																			   new System.Data.Common.DataColumnMapping("Name", "Name")})});
			// 
			// sqlSelectCommand1
			// 
			this.sqlSelectCommand1.CommandText = "SELECT ProjectID, Title, ID, Priority, Severity, Status, Assigned, DESCRIPTION, C" +
				"olor, Name FROM VIEW_BUGS";
			this.sqlSelectCommand1.Connection = this.m_sqlConnection;
			// 
			// m_dataSet
			// 
			this.m_dataSet.DataSetName = "m_dataSet";
			this.m_dataSet.Locale = new System.Globalization.CultureInfo("en-US");
			// 
			// m_Messages_sqDA
			// 
			this.m_Messages_sqDA.SelectCommand = this.sqlSelectCommand2;
			this.m_Messages_sqDA.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																									  new System.Data.Common.DataTableMapping("Table", "VIEW_MESSAGES", new System.Data.Common.DataColumnMapping[] {
																																																					   new System.Data.Common.DataColumnMapping("CONTENT", "CONTENT"),
																																																					   new System.Data.Common.DataColumnMapping("POSTEDTIME", "POSTEDTIME"),
																																																					   new System.Data.Common.DataColumnMapping("BUGID", "BUGID")})});
			// 
			// sqlSelectCommand2
			// 
			this.sqlSelectCommand2.CommandText = "SELECT CONTENT, POSTEDTIME, BUGID FROM VIEW_MESSAGES";
			this.sqlSelectCommand2.Connection = this.m_sqlConnection;
			// 
			// m_InsertMessage
			// 
			this.m_InsertMessage.CommandText = "[insert_MESSAGES]";
			this.m_InsertMessage.CommandType = System.Data.CommandType.StoredProcedure;
			this.m_InsertMessage.Connection = this.m_sqlConnection;
			this.m_InsertMessage.Parameters.Add(new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((System.Byte)(0)), ((System.Byte)(0)), "", System.Data.DataRowVersion.Current, null));
			this.m_InsertMessage.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.UniqueIdentifier, 16, System.Data.ParameterDirection.Output, false, ((System.Byte)(0)), ((System.Byte)(0)), "", System.Data.DataRowVersion.Current, null));
			this.m_InsertMessage.Parameters.Add(new System.Data.SqlClient.SqlParameter("@BUGID", System.Data.SqlDbType.Int, 4));
			this.m_InsertMessage.Parameters.Add(new System.Data.SqlClient.SqlParameter("@MESSAGECONTENT", System.Data.SqlDbType.VarChar, 8000));
			this.m_InsertMessage.Parameters.Add(new System.Data.SqlClient.SqlParameter("@SessionID", System.Data.SqlDbType.UniqueIdentifier, 16));
			this.Load += new System.EventHandler(this.Page_Load);
			((System.ComponentModel.ISupportInitialize)(this.m_dataSet)).EndInit();

		}
		#endregion

		private void m_SaveChanges_B_Click(object sender, System.EventArgs e)
		{
			this.m_InsertMessage.Parameters["@MESSAGECONTENT"].Value = m_NewMessage_T.Text ; 
			this.m_InsertMessage.Parameters["@BUGID"].Value =System.Convert.ToInt32(this.m_bugNumber.Text); 
			this.m_InsertMessage.Parameters["@SESSIONID"].Value =new Guid(session); 

			try
			{
				// trying to execute the stored procedure on server
				m_InsertMessage.ExecuteNonQuery();
			}
			catch
			{
				// in case we have errors, showing that
				this.m_sqlConnection.Close();
				Response.Redirect("errorPage.aspx");
			}
			
			// we have successfuly registered, going to the login page
			this.m_sqlConnection.Close();
			Response.Redirect("showBUGPage.aspx?Session="+session+"&bugid="+this.m_bugNumber.Text);
			
		}
	}
}
