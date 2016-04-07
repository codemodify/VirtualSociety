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
	/// Summary description for ListofProjects.
	/// </summary>
	public class ListofProjects : System.Web.UI.Page
	{
		protected System.Data.SqlClient.SqlDataAdapter m_ViewProjects;
		protected bugtracker.dataSet m_dataSet1;
		protected System.Data.SqlClient.SqlConnection m_sqlConnection;
		protected System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		protected System.Web.UI.WebControls.Button NewProjBtn1;
	
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

			// filling the dataset with data, and showing the data
			this.m_ViewProjects.Fill( this.m_dataSet1 );
            DataTable table = this.m_dataSet1.Tables["Projects"];
				
			string page_header = "<HTML><BODY><br><br><br><br><br>";
			string page_content = "";
			string page_foter = "</HTML></BODY>";
			int  j=0, k=0;
			//int [] lst;
			ArrayList lst;
			lst=new ArrayList();
            foreach(DataRow row in table.Rows)
			{
                foreach (DataColumn column in table.Columns)
				{
					// de obtinut stringul
                    //Console.WriteLine(myRow[myColumn]);
					
					if (j==0) {k++;lst.Add(row[column]); };
					if (j==1){
						page_content+="<table width=\"400\" border=\"2\" cellspacing=\"0\" cellpadding=\"20 \" bgcolor=\"#999999\">";
  						page_content +="<tr> <td> <A HREF =sessionPage.aspx?Session="+Request.Params.Get("Session")+"&projid="+lst[k-1]+">"+row[column]+"</a></td></tr>";};
          
//<A HREF =sessionPage.aspx?projid="+lst[k-1]+">"+"sessionPage.aspx?projid="+lst[k-1]  +"</a>";};
						
					j++;



						if (j==2){j=0;// page_content += "<br>";
						};
                      
				}
            }

			Response.Write(page_header+page_content+page_foter);

			//this.m_DataGrid1.DataBind();
		//	this.DataList1.DataBind();
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
			this.m_ViewProjects = new System.Data.SqlClient.SqlDataAdapter();
			this.m_dataSet1 = new bugtracker.dataSet();
			this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
			((System.ComponentModel.ISupportInitialize)(this.m_dataSet1)).BeginInit();
			this.NewProjBtn1.Click += new System.EventHandler(this.NewProjBtn1_Click);
			// 
			// m_sqlConnection
			// 
			this.m_sqlConnection.ConnectionString = "workstation id=S4;packet size=4096;user id=sa;data source=\"SERVER\\MSQLSERVER\";per" +
				"sist security info=False;initial catalog=bugtracker";
			// 
			// m_ViewProjects
			// 
			this.m_ViewProjects.SelectCommand = this.sqlSelectCommand1;
			this.m_ViewProjects.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																									 new System.Data.Common.DataTableMapping("Table", "Projects", new System.Data.Common.DataColumnMapping[] {
																																																				 new System.Data.Common.DataColumnMapping("IDProject", "IDProject"),
																																																				 new System.Data.Common.DataColumnMapping("Name", "Name")})});
			// 
			// m_dataSet1
			// 
			this.m_dataSet1.DataSetName = "dataSet";
			this.m_dataSet1.Locale = new System.Globalization.CultureInfo("en-US");
			// 
			// sqlSelectCommand1
			// 
			this.sqlSelectCommand1.CommandText = "SELECT IDProject, Name FROM Projects";
			this.sqlSelectCommand1.Connection = this.m_sqlConnection;
			this.Load += new System.EventHandler(this.Page_Load);
			((System.ComponentModel.ISupportInitialize)(this.m_dataSet1)).EndInit();

		}
		#endregion

		private void sqlConnection2_InfoMessage(object sender, System.Data.SqlClient.SqlInfoMessageEventArgs e)
		{
		
		}

		private void m_DataGrid1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
		
		}

		private void LinkButton1_Click(object sender, System.EventArgs e)
		{
		
		}

		private void NewProjBtn1_Click(object sender, System.EventArgs e)
		{
			this.m_sqlConnection.Close();
			Response.Redirect("AddProject.aspx");
		}

		private void DataList1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
		
		}
	}
}
