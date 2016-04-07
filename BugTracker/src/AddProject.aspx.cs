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
	/// Summary description for AddProject.
	/// </summary>
	public class AddProject : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.TextBox m_NameProject_T;
		protected System.Web.UI.WebControls.TextBox m_DescriptionP_T;
		protected System.Web.UI.WebControls.Label Label1;
		protected System.Web.UI.WebControls.Button m_AddProject_B;
		protected System.Data.SqlClient.SqlConnection m_sqlConnection;
		protected System.Data.SqlClient.SqlCommand m_InsertProject;
		protected System.Web.UI.WebControls.Label Label2;
	
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
			this.m_InsertProject = new System.Data.SqlClient.SqlCommand();
			this.m_AddProject_B.Click += new System.EventHandler(this.m_AddProject_B_Click);
			// 
			// m_sqlConnection
			// 
			this.m_sqlConnection.ConnectionString = "workstation id=S4;packet size=4096;user id=sa;data source=\"SERVER\\MSQLSERVER\";per" +
				"sist security info=False;initial catalog=bugtracker";
			// 
			// m_InsertProject
			// 
			this.m_InsertProject.CommandText = "[insert_Projects]";
			this.m_InsertProject.CommandType = System.Data.CommandType.StoredProcedure;
			this.m_InsertProject.Connection = this.m_sqlConnection;
			this.m_InsertProject.Parameters.Add(new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((System.Byte)(0)), ((System.Byte)(0)), "", System.Data.DataRowVersion.Current, null));
			this.m_InsertProject.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Name", System.Data.SqlDbType.VarChar, 25));
			this.m_InsertProject.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Descriere", System.Data.SqlDbType.VarChar, 500));
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void m_AddProject_B_Click(object sender, System.EventArgs e)
		{
			this.m_InsertProject.Parameters["@Name"].Value = m_NameProject_T.Text; 
			this.m_InsertProject.Parameters["@Descriere"].Value = m_DescriptionP_T.Text; 
			

			try
			{
				// trying to execute the stored procedure on server
				m_InsertProject.ExecuteNonQuery();
			}
			catch
			{
				// in case we have errors, showing that
				this.m_sqlConnection.Close();
				Response.Redirect("errorPage.aspx");
			}

			this.m_sqlConnection.Close();
			Response.Redirect("AddProject.aspx");

		}
	}
}
