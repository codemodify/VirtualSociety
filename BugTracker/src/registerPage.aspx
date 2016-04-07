<%@ Page language="c#" Codebehind="registerPage.aspx.cs" AutoEventWireup="false" Inherits="bugtracker.registerPage" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>BugTracker - Register new account</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:textbox id="m_loginName" style="Z-INDEX: 100; LEFT: 224px; POSITION: absolute; TOP: 128px"
				runat="server" Width="216px"></asp:textbox>
			<asp:textbox id="m_password" style="Z-INDEX: 113; LEFT: 224px; POSITION: absolute; TOP: 160px"
				runat="server" Width="216px" TextMode="Password"></asp:textbox><asp:textbox id="m_email" style="Z-INDEX: 110; LEFT: 224px; POSITION: absolute; TOP: 312px" runat="server"
				Width="216px"></asp:textbox><asp:textbox id="m_secondName" style="Z-INDEX: 109; LEFT: 224px; POSITION: absolute; TOP: 280px"
				runat="server" Width="216px"></asp:textbox><asp:textbox id="m_firstName" style="Z-INDEX: 108; LEFT: 224px; POSITION: absolute; TOP: 248px"
				runat="server" Width="216px"></asp:textbox><asp:label id="Label3" style="Z-INDEX: 104; LEFT: 120px; POSITION: absolute; TOP: 280px" runat="server"
				Width="88px" Height="8px">Second Name</asp:label><asp:label id="Label1" style="Z-INDEX: 102; LEFT: 128px; POSITION: absolute; TOP: 128px" runat="server"
				Width="80px" Height="8px">Login Name</asp:label><asp:label id="Label2" style="Z-INDEX: 103; LEFT: 136px; POSITION: absolute; TOP: 248px" runat="server"
				Width="72px" Height="8px">First Name</asp:label><asp:label id="Label4" style="Z-INDEX: 105; LEFT: 144px; POSITION: absolute; TOP: 160px" runat="server"
				Width="64px" Height="8px">Password</asp:label>
			<HR dir="ltr" style="Z-INDEX: 106; LEFT: 112px; POSITION: absolute; TOP: 200px; HEIGHT: 5px"
				width="400" color="#669966" SIZE="5">
			<asp:label id="Label5" style="Z-INDEX: 107; LEFT: 176px; POSITION: absolute; TOP: 312px" runat="server"
				Width="32px" Height="8px">Email</asp:label><asp:label id="Label6" style="Z-INDEX: 111; LEFT: 448px; POSITION: absolute; TOP: 312px" runat="server"
				Width="40px" Height="8px">@server</asp:label><asp:button id="m_register" style="Z-INDEX: 112; LEFT: 320px; POSITION: absolute; TOP: 352px"
				runat="server" Width="120px" Text="Register" BorderStyle="Solid"></asp:button></form>
	</body>
</HTML>
