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
	/// Summary description for WebForm1.
	/// </summary>
	public class recoverPage : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Label FNameLb;
		protected System.Web.UI.WebControls.Label LoginLb;
		protected System.Web.UI.WebControls.Button RecoverBtn;
		protected System.Web.UI.WebControls.TextBox LoginEd;
		protected System.Web.UI.WebControls.DataGrid DataGrid1;
		protected System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
		protected System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		protected System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		protected System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		protected System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		protected System.Data.SqlClient.SqlConnection m_sqlConnection;
		protected System.Web.UI.WebControls.TextBox MailAgressEd;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			// changing the connection string to a corect one
			this.m_sqlConnection.ConnectionString = bugtracker.Settings.getConnectionString(this);
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
			this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
			this.RecoverBtn.Click += new System.EventHandler(this.Button1_Click);
			// 
			// m_sqlConnection
			// 
			this.m_sqlConnection.ConnectionString = "user id=sa;password=sql;data source=\"S1\\DBS\";initial catalog=MPB2005";
			// 
			// sqlDataAdapter1
			// 
			this.sqlDataAdapter1.DeleteCommand = this.sqlDeleteCommand1;
			this.sqlDataAdapter1.InsertCommand = this.sqlInsertCommand1;
			this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand1;
			this.sqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																									  new System.Data.Common.DataTableMapping("Table", "Personal", new System.Data.Common.DataColumnMapping[] {
																																																				  new System.Data.Common.DataColumnMapping("ID", "ID"),
																																																				  new System.Data.Common.DataColumnMapping("Nume", "Nume"),
																																																				  new System.Data.Common.DataColumnMapping("Prenume", "Prenume"),
																																																				  new System.Data.Common.DataColumnMapping("Patrimonic", "Patrimonic"),
																																																				  new System.Data.Common.DataColumnMapping("Mobil", "Mobil"),
																																																				  new System.Data.Common.DataColumnMapping("Telefon", "Telefon"),
																																																				  new System.Data.Common.DataColumnMapping("Photo", "Photo"),
																																																				  new System.Data.Common.DataColumnMapping("Password", "Password"),
																																																				  new System.Data.Common.DataColumnMapping("Adressa", "Adressa"),
																																																				  new System.Data.Common.DataColumnMapping("SeriaBulletin", "SeriaBulletin"),
																																																				  new System.Data.Common.DataColumnMapping("sex", "sex"),
																																																				  new System.Data.Common.DataColumnMapping("virsta", "virsta"),
																																																				  new System.Data.Common.DataColumnMapping("functia", "functia"),
																																																				  new System.Data.Common.DataColumnMapping("Salariu", "Salariu"),
																																																				  new System.Data.Common.DataColumnMapping("concediat", "concediat")})});
			this.sqlDataAdapter1.UpdateCommand = this.sqlUpdateCommand1;
			// 
			// sqlDeleteCommand1
			// 
			this.sqlDeleteCommand1.CommandText = @"DELETE FROM Personal WHERE (ID = @Original_ID) AND (Adressa = @Original_Adressa) AND (Mobil = @Original_Mobil OR @Original_Mobil IS NULL AND Mobil IS NULL) AND (Nume = @Original_Nume) AND (Password = @Original_Password) AND (Patrimonic = @Original_Patrimonic) AND (Prenume = @Original_Prenume) AND (Salariu = @Original_Salariu) AND (SeriaBulletin = @Original_SeriaBulletin OR @Original_SeriaBulletin IS NULL AND SeriaBulletin IS NULL) AND (Telefon = @Original_Telefon OR @Original_Telefon IS NULL AND Telefon IS NULL) AND (concediat = @Original_concediat) AND (functia = @Original_functia) AND (sex = @Original_sex) AND (virsta = @Original_virsta)";
			this.sqlDeleteCommand1.Connection = this.m_sqlConnection;
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.UniqueIdentifier, 16, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Adressa", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Adressa", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Mobil", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "Mobil", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Nume", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nume", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Password", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Password", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Patrimonic", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Patrimonic", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Prenume", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prenume", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Salariu", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Salariu", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_SeriaBulletin", System.Data.SqlDbType.VarChar, 25, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "SeriaBulletin", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Telefon", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "Telefon", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_concediat", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "concediat", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_functia", System.Data.SqlDbType.VarChar, 25, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "functia", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_sex", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "sex", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_virsta", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "virsta", System.Data.DataRowVersion.Original, null));
			// 
			// sqlInsertCommand1
			// 
			this.sqlInsertCommand1.CommandText = @"INSERT INTO Personal(ID, Nume, Prenume, Patrimonic, Mobil, Telefon, Photo, Password, Adressa, SeriaBulletin, sex, virsta, functia, Salariu, concediat) VALUES (@ID, @Nume, @Prenume, @Patrimonic, @Mobil, @Telefon, @Photo, @Password, @Adressa, @SeriaBulletin, @sex, @virsta, @functia, @Salariu, @concediat); SELECT ID, Nume, Prenume, Patrimonic, Mobil, Telefon, Photo, Password, Adressa, SeriaBulletin, sex, virsta, functia, Salariu, concediat FROM Personal WHERE (ID = @ID)";
			this.sqlInsertCommand1.Connection = this.m_sqlConnection;
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.UniqueIdentifier, 16, "ID"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Nume", System.Data.SqlDbType.VarChar, 30, "Nume"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Prenume", System.Data.SqlDbType.VarChar, 30, "Prenume"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Patrimonic", System.Data.SqlDbType.VarChar, 50, "Patrimonic"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Mobil", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "Mobil", System.Data.DataRowVersion.Current, null));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Telefon", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "Telefon", System.Data.DataRowVersion.Current, null));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Photo", System.Data.SqlDbType.VarBinary, 2147483647, "Photo"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Password", System.Data.SqlDbType.VarChar, 15, "Password"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Adressa", System.Data.SqlDbType.VarChar, 50, "Adressa"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@SeriaBulletin", System.Data.SqlDbType.VarChar, 25, "SeriaBulletin"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@sex", System.Data.SqlDbType.VarChar, 2, "sex"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@virsta", System.Data.SqlDbType.SmallInt, 2, "virsta"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@functia", System.Data.SqlDbType.VarChar, 25, "functia"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Salariu", System.Data.SqlDbType.Money, 8, "Salariu"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@concediat", System.Data.SqlDbType.VarChar, 2, "concediat"));
			// 
			// sqlSelectCommand1
			// 
			this.sqlSelectCommand1.CommandText = "SELECT ID, Nume, Prenume, Patrimonic, Mobil, Telefon, Photo, Password, Adressa, S" +
				"eriaBulletin, sex, virsta, functia, Salariu, concediat FROM Personal";
			this.sqlSelectCommand1.Connection = this.m_sqlConnection;
			// 
			// sqlUpdateCommand1
			// 
			this.sqlUpdateCommand1.CommandText = @"UPDATE Personal SET ID = @ID, Nume = @Nume, Prenume = @Prenume, Patrimonic = @Patrimonic, Mobil = @Mobil, Telefon = @Telefon, Photo = @Photo, Password = @Password, Adressa = @Adressa, SeriaBulletin = @SeriaBulletin, sex = @sex, virsta = @virsta, functia = @functia, Salariu = @Salariu, concediat = @concediat WHERE (ID = @Original_ID) AND (Adressa = @Original_Adressa) AND (Mobil = @Original_Mobil OR @Original_Mobil IS NULL AND Mobil IS NULL) AND (Nume = @Original_Nume) AND (Password = @Original_Password) AND (Patrimonic = @Original_Patrimonic) AND (Prenume = @Original_Prenume) AND (Salariu = @Original_Salariu) AND (SeriaBulletin = @Original_SeriaBulletin OR @Original_SeriaBulletin IS NULL AND SeriaBulletin IS NULL) AND (Telefon = @Original_Telefon OR @Original_Telefon IS NULL AND Telefon IS NULL) AND (concediat = @Original_concediat) AND (functia = @Original_functia) AND (sex = @Original_sex) AND (virsta = @Original_virsta); SELECT ID, Nume, Prenume, Patrimonic, Mobil, Telefon, Photo, Password, Adressa, SeriaBulletin, sex, virsta, functia, Salariu, concediat FROM Personal WHERE (ID = @ID)";
			this.sqlUpdateCommand1.Connection = this.m_sqlConnection;
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.UniqueIdentifier, 16, "ID"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Nume", System.Data.SqlDbType.VarChar, 30, "Nume"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Prenume", System.Data.SqlDbType.VarChar, 30, "Prenume"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Patrimonic", System.Data.SqlDbType.VarChar, 50, "Patrimonic"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Mobil", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "Mobil", System.Data.DataRowVersion.Current, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Telefon", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "Telefon", System.Data.DataRowVersion.Current, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Photo", System.Data.SqlDbType.VarBinary, 2147483647, "Photo"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Password", System.Data.SqlDbType.VarChar, 15, "Password"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Adressa", System.Data.SqlDbType.VarChar, 50, "Adressa"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@SeriaBulletin", System.Data.SqlDbType.VarChar, 25, "SeriaBulletin"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@sex", System.Data.SqlDbType.VarChar, 2, "sex"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@virsta", System.Data.SqlDbType.SmallInt, 2, "virsta"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@functia", System.Data.SqlDbType.VarChar, 25, "functia"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Salariu", System.Data.SqlDbType.Money, 8, "Salariu"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@concediat", System.Data.SqlDbType.VarChar, 2, "concediat"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.UniqueIdentifier, 16, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ID", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Adressa", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Adressa", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Mobil", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "Mobil", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Nume", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nume", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Password", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Password", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Patrimonic", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Patrimonic", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Prenume", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prenume", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Salariu", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Salariu", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_SeriaBulletin", System.Data.SqlDbType.VarChar, 25, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "SeriaBulletin", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Telefon", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "Telefon", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_concediat", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "concediat", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_functia", System.Data.SqlDbType.VarChar, 25, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "functia", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_sex", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "sex", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_virsta", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "virsta", System.Data.DataRowVersion.Original, null));
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void Button1_Click(object sender, System.EventArgs e)
		{
			m_sqlConnection.Open();
			DataGrid1.DataBind();
			//LNameEd.Text=FNameEd.Text;
		}

		private void sqlDataAdapter1_RowUpdated(object sender, System.Data.SqlClient.SqlRowUpdatedEventArgs e)
		{
		
		}
	}
}
