using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Web;
using System.Web.Services;

namespace OnlineDevelopmentPlatform
{
	namespace ProjectCompileManager
	{
		public class ProjectCompileManager : System.Web.Services.WebService
		{
			public ProjectCompileManager()
			{
				InitializeComponent();
			}


			#region Component Designer generated code
		
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

		}
	}
}
