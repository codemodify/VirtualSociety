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
	public class sessionPage : System.Web.UI.Page
	{
		protected System.Data.SqlClient.SqlCommand m_checkBUG;
		protected System.Data.SqlClient.SqlConnection m_sqlConnection;
		protected bugtracker.m_dataSet m_dataSet;
		protected System.Data.SqlClient.SqlDataAdapter m_VIEW_BUGS;
		protected System.Web.UI.WebControls.DataGrid m_dataGrid;
		protected System.Web.UI.WebControls.Button m_Message_Btn2;
		protected System.Web.UI.WebControls.Button m_Edit_btn3;
		protected System.Web.UI.WebControls.Label m_Project_Lb;
		protected System.Web.UI.WebControls.Label Label1;
		protected System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		protected System.Web.UI.WebControls.Button Button1;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			// changing the connection string to a corect one
			this.m_sqlConnection.ConnectionString = bugtracker.Settings.getConnectionString(this);

			if( Request.Params.Get("projid").Length == 0 )
			{
				Response.Write( "<b><font color=\"red\">BUG id is empty.\nRedirecting to the search page...</font></b>" );
				Response.Redirect("sessionPage.aspx");
			}
			else // setting the internal variable to store the data header
			{
				m_VIEW_BUGS.SelectCommand.CommandText="SELECT * FROM VIEW_BUGS where ProjectId = "+Request.Params.Get("projid");
				// = Request.Params.Get("bugid");
			};



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

            // filling the dataset with data, and showing the data
			//this.m_ViewProjects.Fill( this.m_dataSet1 );

            this.m_VIEW_BUGS.Fill( this.m_dataSet );
			
			this.m_dataGrid.DataBind();
		//	this.Label1.DataBind();
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
			this.m_checkBUG = new System.Data.SqlClient.SqlCommand();
			this.m_sqlConnection = new System.Data.SqlClient.SqlConnection();
			this.m_VIEW_BUGS = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
			this.m_dataSet = new bugtracker.m_dataSet();
			((System.ComponentModel.ISupportInitialize)(this.m_dataSet)).BeginInit();
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			this.m_dataGrid.SelectedIndexChanged += new System.EventHandler(this.m_dataGrid_SelectedIndexChanged);
			// 
			// m_checkBUG
			// 
			this.m_checkBUG.CommandText = "[checkBUG]";
			this.m_checkBUG.CommandType = System.Data.CommandType.StoredProcedure;
			this.m_checkBUG.Connection = this.m_sqlConnection;
			this.m_checkBUG.Parameters.Add(new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((System.Byte)(0)), ((System.Byte)(0)), "", System.Data.DataRowVersion.Current, null));
			this.m_checkBUG.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.Int, 4));
			this.m_checkBUG.Parameters.Add(new System.Data.SqlClient.SqlParameter("@EXIST", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Output, false, ((System.Byte)(0)), ((System.Byte)(0)), "", System.Data.DataRowVersion.Current, null));
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
			this.Load += new System.EventHandler(this.Page_Load);
			((System.ComponentModel.ISupportInitialize)(this.m_dataSet)).EndInit();

		}
		#endregion


		private void Button1_Click(object sender, System.EventArgs e)
		{
			Response.Redirect("Addtask.aspx?Projid="+Request.Params.Get("projid"));
		}



		private void m_VIEW_BUGS_RowUpdated(object sender, System.Data.SqlClient.SqlRowUpdatedEventArgs e)
		{
		
		}

		

		

		private void m_dataGrid_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			// la apasaerea linkului din datagrid se deschide pagina 
			// showBug cu parametru Data Key 
		Response.Redirect("showBUGPage.aspx?Session="+Request.Params.Get("Session")+"&bugid="+m_dataGrid.DataKeys[m_dataGrid.SelectedIndex]);
		this.m_sqlConnection.Close();
		}

		
	}
}
