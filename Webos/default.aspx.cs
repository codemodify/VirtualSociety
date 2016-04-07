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

namespace WebOS
{
	/// <summary>
	/// Summary description for WebForm1.
	/// </summary>
	public class LoginPage : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.TextBox TextBox1;
		protected System.Web.UI.WebControls.CheckBox remember;
		protected System.Web.UI.WebControls.Image Image1;
		protected System.Web.UI.WebControls.Label Label1;
		protected System.Web.UI.WebControls.Label Label2;
		protected System.Web.UI.WebControls.Image Image2;
		protected System.Web.UI.WebControls.Image Image3;
		protected System.Web.UI.WebControls.Image Image5;
		protected System.Web.UI.WebControls.ImageButton WebOSConcept;
		protected System.Web.UI.WebControls.Button LogIn;
		protected System.Web.UI.HtmlControls.HtmlForm Form1;
		protected System.Web.UI.WebControls.TextBox TextBox2;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			// Put user code to initialize the page here
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
			this.LogIn.Click += new System.EventHandler(this.LogIn_Click);
			this.WebOSConcept.Click += new System.Web.UI.ImageClickEventHandler(this.WebOSConcept_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void WebOSConcept_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			Response.Redirect("WebOSConcept.aspx");
		}

		private void LogIn_Click(object sender, System.EventArgs e)
		{
			//	System.Web.HttpServerUtility.Execute();
			//System.IO.StringWriter writer = new System.IO.StringWriter();
			//Server.Execute("ResourceNotFound.aspx", writer);
			//Response.ClearContent();
			//Response.Write( writer.ToString() );
            Response.Redirect("ResourceNotFound.aspx");
		}

	}
}
