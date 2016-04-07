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
	/// Summary description for Addtask.
	/// </summary>
	public class Addtask : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.TextBox TextBox1;
		protected System.Web.UI.WebControls.Label Label1;
		protected System.Web.UI.WebControls.Label Label2;
		protected System.Web.UI.WebControls.Label Label3;
		protected System.Web.UI.WebControls.DropDownList DropDownList2;
		protected System.Web.UI.WebControls.Label Label4;
		protected System.Web.UI.WebControls.Label Label5;
		protected System.Web.UI.WebControls.DropDownList DropDownList3;
		protected System.Web.UI.WebControls.TextBox TextBox2;
		protected System.Web.UI.WebControls.Label Label6;
		protected System.Web.UI.WebControls.Button Button1;
		protected System.Web.UI.WebControls.Label Label7;
		protected System.Web.UI.WebControls.Label Label8;
		protected System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
		protected System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		protected bugtracker.DataSet3 dataSet31;
		protected System.Web.UI.WebControls.Label Label9;
		protected System.Data.SqlClient.SqlDataAdapter sqlDataAdapter2;
		protected System.Data.SqlClient.SqlCommand sqlSelectCommand2;
		protected bugtracker.DataSet4 dataSet41;
		protected System.Data.SqlClient.SqlDataAdapter sqlDataAdapter3;
		protected System.Data.SqlClient.SqlCommand sqlSelectCommand3;
		protected bugtracker.DataSet5 dataSet51;
		protected System.Web.UI.WebControls.TextBox TextBox3;
		protected System.Data.SqlClient.SqlCommand m_InsertBug;
		protected System.Data.SqlClient.SqlConnection m_sqlConnection;
		protected System.Web.UI.WebControls.DropDownList DropDownList4;
		protected System.Data.SqlClient.SqlDataAdapter sqlDataAdapter4;
		protected System.Data.SqlClient.SqlCommand sqlSelectCommand4;
		protected System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		protected bugtracker.DataSet6 dataSet61;
                 string idProject;
		protected System.Web.UI.WebControls.DropDownList DropDownList1;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			// changing the connection string to a corect one
			this.m_sqlConnection.ConnectionString = bugtracker.Settings.getConnectionString(this);

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

			if( Request.Params.Get("projid").Length == 0 )
			{
				Response.Write( "<b><font color=\"red\">BUG id is empty.\nRedirecting to the search page...</font></b>" );
				Response.Redirect("Addtask.aspx");
			}
			else // setting the internal variable to store the data header
			{
				
				idProject = Request.Params.Get("Projid");
			};

			this.sqlDataAdapter1.Fill( this.dataSet31 );
 			this.DropDownList1.DataBind();

			this.sqlDataAdapter2.Fill( this.dataSet41 );
			this.DropDownList2.DataBind();

			this.sqlDataAdapter3.Fill( this.dataSet51 );
			this.DropDownList3.DataBind();

			this.sqlDataAdapter4.Fill( this.dataSet61 );
			this.DropDownList4.DataBind();
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
			this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
			this.dataSet31 = new bugtracker.DataSet3();
			this.sqlDataAdapter2 = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
			this.dataSet41 = new bugtracker.DataSet4();
			this.sqlDataAdapter3 = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlSelectCommand3 = new System.Data.SqlClient.SqlCommand();
			this.dataSet51 = new bugtracker.DataSet5();
			this.m_InsertBug = new System.Data.SqlClient.SqlCommand();
			this.sqlDataAdapter4 = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlSelectCommand4 = new System.Data.SqlClient.SqlCommand();
			this.dataSet61 = new bugtracker.DataSet6();
			((System.ComponentModel.ISupportInitialize)(this.dataSet31)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet41)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet51)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet61)).BeginInit();
			this.DropDownList1.SelectedIndexChanged += new System.EventHandler(this.DropDownList1_SelectedIndexChanged);
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			// 
			// m_sqlConnection
			// 
			this.m_sqlConnection.ConnectionString = "workstation id=S4;packet size=4096;user id=sa;data source=\"SERVER\\MSQLSERVER\";per" +
				"sist security info=False;initial catalog=bugtracker";
			// 
			// sqlDataAdapter1
			// 
			this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand1;
			this.sqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																									  new System.Data.Common.DataTableMapping("Table", "PRIORITY", new System.Data.Common.DataColumnMapping[] {
																																																				  new System.Data.Common.DataColumnMapping("ID", "ID"),
																																																				  new System.Data.Common.DataColumnMapping("NAME", "NAME")})});
			// 
			// sqlSelectCommand1
			// 
			this.sqlSelectCommand1.CommandText = "SELECT ID, NAME FROM PRIORITY";
			this.sqlSelectCommand1.Connection = this.m_sqlConnection;
			// 
			// dataSet31
			// 
			this.dataSet31.DataSetName = "DataSet3";
			this.dataSet31.Locale = new System.Globalization.CultureInfo("en-US");
			// 
			// sqlDataAdapter2
			// 
			this.sqlDataAdapter2.SelectCommand = this.sqlSelectCommand2;
			this.sqlDataAdapter2.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																									  new System.Data.Common.DataTableMapping("Table", "SEVERITY", new System.Data.Common.DataColumnMapping[] {
																																																				  new System.Data.Common.DataColumnMapping("ID", "ID"),
																																																				  new System.Data.Common.DataColumnMapping("NAME", "NAME")})});
			// 
			// sqlSelectCommand2
			// 
			this.sqlSelectCommand2.CommandText = "SELECT ID, NAME FROM SEVERITY";
			this.sqlSelectCommand2.Connection = this.m_sqlConnection;
			// 
			// dataSet41
			// 
			this.dataSet41.DataSetName = "DataSet4";
			this.dataSet41.Locale = new System.Globalization.CultureInfo("en-US");
			// 
			// sqlDataAdapter3
			// 
			this.sqlDataAdapter3.SelectCommand = this.sqlSelectCommand3;
			this.sqlDataAdapter3.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																									  new System.Data.Common.DataTableMapping("Table", "STATE", new System.Data.Common.DataColumnMapping[] {
																																																			   new System.Data.Common.DataColumnMapping("ID", "ID"),
																																																			   new System.Data.Common.DataColumnMapping("NAME", "NAME")})});
			// 
			// sqlSelectCommand3
			// 
			this.sqlSelectCommand3.CommandText = "SELECT ID, NAME FROM STATE";
			this.sqlSelectCommand3.Connection = this.m_sqlConnection;
			// 
			// dataSet51
			// 
			this.dataSet51.DataSetName = "DataSet5";
			this.dataSet51.Locale = new System.Globalization.CultureInfo("en-US");
			// 
			// m_InsertBug
			// 
			this.m_InsertBug.CommandText = "[insert_BUG]";
			this.m_InsertBug.CommandType = System.Data.CommandType.StoredProcedure;
			this.m_InsertBug.Connection = this.m_sqlConnection;
			this.m_InsertBug.Parameters.Add(new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((System.Byte)(0)), ((System.Byte)(0)), "", System.Data.DataRowVersion.Current, null));
			this.m_InsertBug.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Output, false, ((System.Byte)(0)), ((System.Byte)(0)), "", System.Data.DataRowVersion.Current, null));
			this.m_InsertBug.Parameters.Add(new System.Data.SqlClient.SqlParameter("@STATEID", System.Data.SqlDbType.UniqueIdentifier, 16));
			this.m_InsertBug.Parameters.Add(new System.Data.SqlClient.SqlParameter("@PRIORITYID", System.Data.SqlDbType.UniqueIdentifier, 16));
			this.m_InsertBug.Parameters.Add(new System.Data.SqlClient.SqlParameter("@SEVERITYID", System.Data.SqlDbType.UniqueIdentifier, 16));
			this.m_InsertBug.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ASSIGNEDUSERID", System.Data.SqlDbType.UniqueIdentifier, 16));
			this.m_InsertBug.Parameters.Add(new System.Data.SqlClient.SqlParameter("@DESCRIPTION", System.Data.SqlDbType.VarChar, 8000));
			this.m_InsertBug.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ProjectID", System.Data.SqlDbType.Int, 4));
			this.m_InsertBug.Parameters.Add(new System.Data.SqlClient.SqlParameter("@TITLE", System.Data.SqlDbType.NVarChar));
			// 
			// sqlDataAdapter4
			// 
			this.sqlDataAdapter4.DeleteCommand = this.sqlDeleteCommand1;
			this.sqlDataAdapter4.SelectCommand = this.sqlSelectCommand4;
			this.sqlDataAdapter4.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																									  new System.Data.Common.DataTableMapping("Table", "USERS", new System.Data.Common.DataColumnMapping[] {
																																																			   new System.Data.Common.DataColumnMapping("ID", "ID"),
																																																			   new System.Data.Common.DataColumnMapping("FIRSTNAME", "FIRSTNAME")})});
			// 
			// sqlDeleteCommand1
			// 
			this.sqlDeleteCommand1.CommandText = "DELETE FROM USERS WHERE (ID = @Original_ID) AND (FIRSTNAME = @Original_FIRSTNAME)" +
				"";
			this.sqlDeleteCommand1.Connection = this.m_sqlConnection;
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.UniqueIdentifier, 16, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_FIRSTNAME", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "FIRSTNAME", System.Data.DataRowVersion.Original, null));
			// 
			// sqlSelectCommand4
			// 
			this.sqlSelectCommand4.CommandText = "SELECT ID, FIRSTNAME FROM USERS";
			this.sqlSelectCommand4.Connection = this.m_sqlConnection;
			// 
			// dataSet61
			// 
			this.dataSet61.DataSetName = "DataSet6";
			this.dataSet61.Locale = new System.Globalization.CultureInfo("en-US");
			this.Load += new System.EventHandler(this.Page_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataSet31)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet41)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet51)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet61)).EndInit();

		}
		#endregion

		private void Button1_Click(object sender, System.EventArgs e)
		{
			string idPriority;
			string idSeverity;
			string idStatus;
			string idAsigned;
             
				idProject = Request.Params.Get("Projid");
		      idPriority=DropDownList1.SelectedItem.Value;
			  idSeverity=DropDownList2.SelectedItem.Value;
			  idStatus=DropDownList3.SelectedItem.Value;
			  idAsigned=DropDownList4.SelectedItem.Value;

			//-------------------------------
			// checking for empty fields
//			if(	(0 == idSeverity.Length) ||
//				(0 == idPriority.Length) ||
//				(0 == idStatus.Length) ||
//				(0 == idAsigned.Length) 
//					)
//			{
//				Response.Write("<b><font color=\"red\">Please fill all fields.</font></b>");
//				return;
//			}

//
//			try
//			{
//				// trying to open the sql-connection
//				this.m_sqlConnection.Open();
//			}
//			catch
//			{
//				// in case we have errors, showing that
//				Response.Redirect("errorPage.aspx");
//			
//			}
// trebuie de scris un stored procedures pentru introducerea bagului 

        	this.m_InsertBug.Parameters["@STATEID"].Value = new Guid(idStatus) ; 
			this.m_InsertBug.Parameters["@PRIORITYID"].Value =new Guid(idPriority); 
			this.m_InsertBug.Parameters["@SEVERITYID"].Value =new Guid(idSeverity) ; 
			this.m_InsertBug.Parameters["@ASSIGNEDUSERID"].Value =new Guid(idAsigned) ;
			this.m_InsertBug.Parameters["@DESCRIPTION"].Value =TextBox2.Text;
			this.m_InsertBug.Parameters["@ProjectID"].Value =System.Convert.ToInt32(idProject); 
			this.m_InsertBug.Parameters["@TITLE"].Value =TextBox1.Text;

			//Label9.Text=idStatus;
			try
			{
				// trying to execute the stored procedure on server
				m_InsertBug.ExecuteNonQuery();
			}
			catch
			{
				// in case we have errors, showing that
				this.m_sqlConnection.Close();
				Response.Redirect("errorPage.aspx");
			}
			
			// we have successfuly registered, going to the login page
		this.m_sqlConnection.Close();
    	Response.Redirect("sessionPage.aspx?projid="+idProject);
			//-------------------------------

               
		}

		private void DropDownList1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
		
		}
	}
}
