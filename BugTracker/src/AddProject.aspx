<%@ Page language="c#" Codebehind="AddProject.aspx.cs" AutoEventWireup="false" Inherits="bugtracker.AddProject" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>AddProject</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:TextBox id="m_NameProject_T" style="Z-INDEX: 101; LEFT: 136px; POSITION: absolute; TOP: 80px"
				runat="server" Width="240px"></asp:TextBox>
			<asp:TextBox id="m_DescriptionP_T" style="Z-INDEX: 102; LEFT: 136px; POSITION: absolute; TOP: 168px"
				runat="server" Width="520px" TextMode="MultiLine" Height="104px"></asp:TextBox>
			<asp:Button id="m_AddProject_B" style="Z-INDEX: 103; LEFT: 496px; POSITION: absolute; TOP: 288px"
				runat="server" Width="160px" Height="32px" Text="Add Project"></asp:Button>
			<asp:Label id="Label1" style="Z-INDEX: 104; LEFT: 136px; POSITION: absolute; TOP: 48px" runat="server"
				Width="128px" Height="24px" Font-Size="Medium">Name Of Project</asp:Label>
			<asp:Label id="Label2" style="Z-INDEX: 105; LEFT: 144px; POSITION: absolute; TOP: 136px" runat="server"
				Width="184px" Height="24px" Font-Size="Medium">Description Of Project</asp:Label>
		</form>
	</body>
</HTML>
