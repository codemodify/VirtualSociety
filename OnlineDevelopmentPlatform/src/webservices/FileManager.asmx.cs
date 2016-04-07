using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Web;
using System.Web.Services;

namespace OnlineDevelopmentPlatform
{
	namespace SourceControlManager
	{
		public class FileManager : System.Web.Services.WebService
		{
			#region generated code
		
			//Required by the Web Services Designer 
			private IContainer components = null;
				
			private void InitializeComponent()
			{
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

			public FileManager()
			{
				InitializeComponent();
			}


			[WebMethod]
			public string debugFileManager(string messageToPrint)
			{
				if( 0 == messageToPrint.Length )
					messageToPrint = "This is a debug method for - 'SourceControlManager::FileManager'.";

				return messageToPrint;
			}


			[WebMethod]
			public bool addFile(string userFile)
			{
				return true;
			}


			[WebMethod]
			public bool deleteFile(string depotFile)
			{
				return true;
			}


			[WebMethod]
			public bool moveFile(string depotFile)
			{
				return true;
			}


			[WebMethod]
			public bool renameFile(string depotFile)
			{
				return true;
			}
		}
	}
}
