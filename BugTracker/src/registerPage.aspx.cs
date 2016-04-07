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
	public class registerPage : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Label Label1;
		protected System.Web.UI.WebControls.Label Label2;
		protected System.Web.UI.WebControls.Label Label4;
		protected System.Web.UI.WebControls.Label Label5;
		protected System.Web.UI.WebControls.Label Label6;
		protected System.Web.UI.WebControls.Label Label3;

		protected System.Data.SqlClient.SqlConnection m_sqlConnection;
		protected System.Data.SqlClient.SqlCommand m_insert_USERS;

		protected System.Web.UI.WebControls.TextBox m_loginName;
		protected System.Web.UI.WebControls.TextBox m_email;
		protected System.Web.UI.WebControls.TextBox m_secondName;
		protected System.Web.UI.WebControls.TextBox m_firstName;
		protected System.Web.UI.WebControls.TextBox m_password;
		
		protected System.Web.UI.WebControls.Button m_register;

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
			this.m_insert_USERS = new System.Data.SqlClient.SqlCommand();
			this.m_register.Click += new System.EventHandler(this.register_Click);
			// 
			// m_sqlConnection
			// 
			this.m_sqlConnection.ConnectionString = "user id=sa;data source=\"S4\\DBS\";initial catalog=bugtracker;password=sql";
			// 
			// m_insert_USERS
			// 
			this.m_insert_USERS.CommandText = "[insert_USERS]";
			this.m_insert_USERS.CommandType = System.Data.CommandType.StoredProcedure;
			this.m_insert_USERS.Connection = this.m_sqlConnection;
			this.m_insert_USERS.Parameters.Add(new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((System.Byte)(0)), ((System.Byte)(0)), "", System.Data.DataRowVersion.Current, null));
			this.m_insert_USERS.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.UniqueIdentifier, 16, System.Data.ParameterDirection.Output, false, ((System.Byte)(0)), ((System.Byte)(0)), "", System.Data.DataRowVersion.Current, null));
			this.m_insert_USERS.Parameters.Add(new System.Data.SqlClient.SqlParameter("@LOGIN", System.Data.SqlDbType.VarChar, 50));
			this.m_insert_USERS.Parameters.Add(new System.Data.SqlClient.SqlParameter("@PASSWORD", System.Data.SqlDbType.VarChar, 50));
			this.m_insert_USERS.Parameters.Add(new System.Data.SqlClient.SqlParameter("@FIRSTNAME", System.Data.SqlDbType.VarChar, 50));
			this.m_insert_USERS.Parameters.Add(new System.Data.SqlClient.SqlParameter("@SECONDNAME", System.Data.SqlDbType.VarChar, 50));
			this.m_insert_USERS.Parameters.Add(new System.Data.SqlClient.SqlParameter("@EMAIL", System.Data.SqlDbType.VarChar, 50));
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void register_Click(object sender, System.EventArgs e)
		{
			// checking for empty fields
			if(	(0 == this.m_loginName.Text.Length) ||
				(0 == this.m_password.Text.Length) ||
				(0 == this.m_firstName.Text.Length) ||
				(0 == this.m_secondName.Text.Length) ||
				(0 == this.m_email.Text.Length)	)
			{
				Response.Write("<b><font color=\"red\">Please fill all fields.</font></b>");
				return;
			}


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

			this.m_insert_USERS.Parameters["@LOGIN"].Value = m_loginName.Text; 
			this.m_insert_USERS.Parameters["@PASSWORD"].Value = m_password.Text; 
			this.m_insert_USERS.Parameters["@FIRSTNAME"].Value = m_firstName.Text; 
			this.m_insert_USERS.Parameters["@SECONDNAME"].Value = m_secondName.Text;
			this.m_insert_USERS.Parameters["@EMAIL"].Value = m_email.Text;

			try
			{
				// trying to execute the stored procedure on server
				this.m_insert_USERS.ExecuteNonQuery();
			}
			catch
			{
				// in case we have errors, showing that
				this.m_sqlConnection.Close();
				Response.Redirect("errorPage.aspx");
			}
			
			// we have successfuly registered, going to the login page
			this.m_sqlConnection.Close();
			Response.Redirect("default.aspx");
		}

		private void Page_Load(object sender, System.EventArgs e)
		{
			// changing the connection string to a corect one
			this.m_sqlConnection.ConnectionString = bugtracker.Settings.getConnectionString(this);
		}
	}
}
