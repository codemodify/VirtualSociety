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
using System.Xml;
using System.Xml.Schema;

namespace bugtracker
{
	public class Settings
    {
		public static string getConnectionString(System.Web.UI.Page webPage)
		{
			// create the XmlDocument.
			XmlDocument doc = new XmlDocument();

            string path = "http://" + 
						webPage.Request.Url.Authority + 
						webPage.Request.Url.Segments[0] + 
						webPage.Request.Url.Segments[1] +
						"resources/xml/settings.xml";

			// loading the document
            doc.Load(path);

			// returning the connection string
			return doc.DocumentElement.InnerText;
		}
	}
}
namespace bugtracker
{
	public class loginPage : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Label Label1;
		protected System.Web.UI.WebControls.Label Label3;
		protected System.Web.UI.WebControls.Label Label2;

		protected System.Web.UI.WebControls.TextBox m_loginName;
		protected System.Web.UI.WebControls.TextBox m_password;

		protected System.Web.UI.WebControls.LinkButton m_register;
		protected System.Web.UI.WebControls.LinkButton m_recover;

		protected System.Web.UI.WebControls.Button m_login;
		protected System.Data.SqlClient.SqlCommand m_checkUser;
		protected System.Web.UI.WebControls.Image Image1;
		protected System.Data.SqlClient.SqlConnection m_sqlConnection;

	

		#region Web Form Designer generated code
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: This call is required by the ASP.NET Web Form Designer.
			//
			InitializeComponent();
			base.OnInit(e);
		}
		
		private void InitializeComponent()
		{    
			this.m_sqlConnection = new System.Data.SqlClient.SqlConnection();
			this.m_checkUser = new System.Data.SqlClient.SqlCommand();
			this.m_register.Click += new System.EventHandler(this.register_Click);
			this.m_login.Click += new System.EventHandler(this.login_Click);
			this.m_recover.Click += new System.EventHandler(this.recover_Click);
			// 
			// m_sqlConnection
			// 
			this.m_sqlConnection.ConnectionString = "workstation id=S4;packet size=4096;user id=sa;data source=\"SERVER\\MSQLSERVER\";per" +
				"sist security info=False;initial catalog=bugtracker";
			// 
			// m_checkUser
			// 
			this.m_checkUser.CommandText = "[checkUser]";
			this.m_checkUser.CommandType = System.Data.CommandType.StoredProcedure;
			this.m_checkUser.Connection = this.m_sqlConnection;
			this.m_checkUser.Parameters.Add(new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((System.Byte)(0)), ((System.Byte)(0)), "", System.Data.DataRowVersion.Current, null));
			this.m_checkUser.Parameters.Add(new System.Data.SqlClient.SqlParameter("@LOGIN", System.Data.SqlDbType.VarChar, 50));
			this.m_checkUser.Parameters.Add(new System.Data.SqlClient.SqlParameter("@PASSWORD", System.Data.SqlDbType.VarChar, 50));
			this.m_checkUser.Parameters.Add(new System.Data.SqlClient.SqlParameter("@SESSIONID", System.Data.SqlDbType.UniqueIdentifier, 16, System.Data.ParameterDirection.Output, false, ((System.Byte)(0)), ((System.Byte)(0)), "", System.Data.DataRowVersion.Current, null));
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void register_Click(object sender, System.EventArgs e)
		{
			Response.Redirect("registerPage.aspx");
		}

		private void login_Click(object sender, System.EventArgs e)
		{
			// checking for empty fields
			if(	(0 == this.m_loginName.Text.Length) ||
				(0 == this.m_password.Text.Length) )
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
			
			//  try to execute the stored procedure
			this.m_checkUser.Parameters["@LOGIN"].Value = m_loginName.Text;
            this.m_checkUser.Parameters["@PASSWORD"].Value = m_password.Text;

			try
			{
				this.m_checkUser.ExecuteNonQuery();
			}
			catch
			{
				// in case we have errors, showing that
				this.m_sqlConnection.Close();
				Response.Redirect("errorPage.aspx");
			}
			
			// closing sql-connection
			this.m_sqlConnection.Close();

			// checking the result from user check operation
			if( System.Convert.ToString(this.m_checkUser.Parameters["@SESSIONID"].Value) !="" )
			{    // in cazde succes se deschide pagina session 
				//Response.Redirect("sessionPage.aspx");

				;
				Response.Redirect("ListofProjects.aspx?Session="+this.m_checkUser.Parameters["@SESSIONID"].Value);
			}
			else
			{
				Response.Write("<b><font color=\"red\">No such user</font></b>");
			}
		}

		private void recover_Click(object sender, System.EventArgs e)
		{
			Response.Redirect("recoverPage.aspx");
		}

		private void Page_Load(object sender, System.EventArgs e)
		{
			this.m_sqlConnection.ConnectionString = bugtracker.Settings.getConnectionString(this);
		}
	}
}
