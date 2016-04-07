<%@ Page language="c#" Codebehind="recoverPage.aspx.cs" AutoEventWireup="false" Inherits="bugtracker.recoverPage" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>WebForm1</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:TextBox id="MailAgressEd" style="Z-INDEX: 101; LEFT: 200px; POSITION: absolute; TOP: 120px"
				runat="server" Width="208px" Height="26"></asp:TextBox>
			<asp:Label id="FNameLb" style="Z-INDEX: 102; LEFT: 96px; POSITION: absolute; TOP: 124px" runat="server"
				Width="80px" Height="19">Mail Adress</asp:Label>
			<asp:Label id="LoginLb" style="Z-INDEX: 103; LEFT: 96px; POSITION: absolute; TOP: 96px" runat="server"
				Width="80px" Height="19">Login</asp:Label>
			<asp:TextBox id="LoginEd" style="Z-INDEX: 104; LEFT: 200px; POSITION: absolute; TOP: 88px" runat="server"
				Width="208px" Height="26"></asp:TextBox>
			<asp:Button id="RecoverBtn" style="Z-INDEX: 105; LEFT: 288px; POSITION: absolute; TOP: 160px"
				runat="server" Width="120px" Text="Recover" BorderStyle="Solid"></asp:Button>
		</form>
	</body>
</HTML>
