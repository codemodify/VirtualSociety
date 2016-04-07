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
		public class FileStateManager : System.Web.Services.WebService
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

			public FileStateManager()
			{
				InitializeComponent();	
			}


			[WebMethod]
			public string debugFileStateManager(string messageToPrint)
			{
				if( 0 == messageToPrint.Length )
					messageToPrint = "This is a debug method for - 'SourceControlManager::FileStateManager'.";

				return messageToPrint;
			}


			[WebMethod]
			public FileState getFileState( string depotFile )
			{
				return FileState.normal;
			}
		}
	}
}
