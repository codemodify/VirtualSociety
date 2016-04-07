<%@ Page language="c#" Codebehind="default.aspx.cs" AutoEventWireup="false" Inherits="bugtracker.loginPage" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>Login to "Bug Tracker"</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie3-2nav3-0" name="vs_targetSchema">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<TABLE height="662" cellSpacing="0" cellPadding="0" width="322" border="0" ms_2d_layout="TRUE">
			<TR vAlign="top">
				<TD width="322" height="662">
					<form id="Form1" method="post" runat="server">
						<TABLE height="305" cellSpacing="0" cellPadding="0" width="650" border="0" ms_2d_layout="TRUE">
							<TR vAlign="top">
								<TD width="128" height="120"></TD>
								<TD width="8"></TD>
								<TD width="24"></TD>
								<TD width="80"></TD>
								<TD width="184"></TD>
								<TD width="120"></TD>
								<TD width="106"></TD>
							</TR>
							<TR vAlign="top">
								<TD height="80"></TD>
								<TD colSpan="6"><asp:label id="Label3" runat="server" Font-Overline="True" Font-Underline="True" Font-Size="XX-Large"
										Font-Names="Verdana" Font-Bold="True" ForeColor="MidnightBlue" Height="40px" Width="504px">The "Bug Tracker"</asp:label></TD>
							</TR>
							<TR vAlign="top">
								<TD colSpan="6" height="8"></TD>
								<TD rowSpan="5"><asp:image id="Image1" runat="server" Height="104px" Width="104px" ImageUrl="resources\img\login.jpg"></asp:image></TD>
							</TR>
							<TR vAlign="top">
								<TD colSpan="2" height="32"></TD>
								<TD colSpan="2"><asp:label id="Label1" runat="server" Font-Names="Bookman Old Style" Height="19" Width="97px">Login Name</asp:label></TD>
								<TD colSpan="2"><asp:textbox id="m_loginName" runat="server" Width="288px"></asp:textbox></TD>
							</TR>
							<TR vAlign="top">
								<TD colSpan="3" height="32"></TD>
								<TD><asp:label id="Label2" runat="server" Font-Names="Bookman Old Style" Height="19px" Width="41px">Password</asp:label></TD>
								<TD colSpan="2"><asp:textbox id="m_password" runat="server" Height="24px" Width="288px" TextMode="Password"></asp:textbox></TD>
							</TR>
							<TR vAlign="top">
								<TD colSpan="4" height="16"></TD>
								<TD><asp:linkbutton id="m_register" runat="server" Font-Size="Smaller" Font-Names="Georgia" Font-Bold="True"
										ForeColor="RoyalBlue" Height="16px" Width="120px" BackColor="White" BorderColor="White" BorderStyle="None"
										ToolTip="Allows to create a new account">register account</asp:linkbutton></TD>
								<TD rowSpan="2"><asp:button id="m_login" runat="server" Height="32px" Width="104px" BorderStyle="Solid" Text="Login"></asp:button></TD>
							</TR>
							<TR vAlign="top">
								<TD colSpan="4" height="17"></TD>
								<TD><asp:linkbutton id="m_recover" runat="server" Font-Size="Smaller" Font-Names="Georgia" Font-Bold="True"
										ForeColor="RoyalBlue" Height="16px" Width="128px" BackColor="White" BorderColor="White" BorderStyle="None"
										ToolTip="Allows to create a new account">recover password</asp:linkbutton></TD>
							</TR>
						</TABLE>
					</form>
				</TD>
			</TR>
		</TABLE>
	</body>
</HTML>
