<%@ Page language="c#" Codebehind="Addtask.aspx.cs" AutoEventWireup="false" Inherits="bugtracker.Addtask" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>Addtask</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:dropdownlist id=DropDownList1 style="Z-INDEX: 101; LEFT: 200px; POSITION: absolute; TOP: 120px" runat="server" DataValueField="ID" DataTextField="NAME" DataMember="PRIORITY" DataSource="<%# dataSet31 %>" Height="24px" Width="272px">
			</asp:dropdownlist><asp:textbox id="TextBox1" style="Z-INDEX: 102; LEFT: 200px; POSITION: absolute; TOP: 88px" runat="server"
				Width="272px"></asp:textbox><asp:label id="Label1" style="Z-INDEX: 103; LEFT: 88px; POSITION: absolute; TOP: 88px" runat="server"
				Height="24px" Width="96px" Font-Size="Larger">Title of  Bug</asp:label><asp:label id="Label2" style="Z-INDEX: 104; LEFT: 96px; POSITION: absolute; TOP: 120px" runat="server"
				Height="24px" Width="88px" Font-Size="Larger">Priotity</asp:label><asp:label id="Label3" style="Z-INDEX: 105; LEFT: 96px; POSITION: absolute; TOP: 152px" runat="server"
				Height="24px" Width="96px" Font-Size="Larger">Severity</asp:label><asp:dropdownlist id=DropDownList2 style="Z-INDEX: 106; LEFT: 200px; POSITION: absolute; TOP: 152px" runat="server" DataValueField="ID" DataTextField="NAME" DataMember="SEVERITY" DataSource="<%# dataSet41 %>" Height="16px" Width="272px">
			</asp:dropdownlist><asp:label id="Label4" style="Z-INDEX: 107; LEFT: 96px; POSITION: absolute; TOP: 184px" runat="server"
				Height="8px" Width="80px" Font-Size="Larger">Status</asp:label><asp:label id="Label5" style="Z-INDEX: 108; LEFT: 96px; POSITION: absolute; TOP: 216px" runat="server"
				Height="32px" Width="80px" Font-Size="Larger">Assigned</asp:label><asp:dropdownlist id=DropDownList3 style="Z-INDEX: 109; LEFT: 200px; POSITION: absolute; TOP: 184px" runat="server" DataValueField="ID" DataTextField="NAME" DataMember="STATE" DataSource="<%# dataSet51 %>" Height="24px" Width="273px">
			</asp:dropdownlist><asp:textbox id="TextBox2" style="Z-INDEX: 110; LEFT: 88px; POSITION: absolute; TOP: 312px" runat="server"
				Height="240px" Width="472px" TextMode="MultiLine"></asp:textbox><asp:label id="Label6" style="Z-INDEX: 111; LEFT: 120px; POSITION: absolute; TOP: 272px" runat="server"
				Height="24px" Width="264px" Font-Size="Larger">Description of the BUG</asp:label><asp:button id="Button1" style="Z-INDEX: 112; LEFT: 432px; POSITION: absolute; TOP: 568px" runat="server"
				Height="32px" Width="120px" Font-Size="Smaller" Text="OK"></asp:button><asp:label id="Label7" style="Z-INDEX: 113; LEFT: 464px; POSITION: absolute; TOP: 24px" runat="server"
				Height="32px" Width="48px">Label</asp:label><asp:label id="Label8" style="Z-INDEX: 114; LEFT: 400px; POSITION: absolute; TOP: 24px" runat="server"
				Height="40px" Width="48px" Font-Size="Larger">Project </asp:label><asp:label id="Label9" style="Z-INDEX: 115; LEFT: 344px; POSITION: absolute; TOP: 272px" runat="server"
				Height="24px" Width="321px">Label</asp:label><asp:textbox id="TextBox3" style="Z-INDEX: 116; LEFT: 608px; POSITION: absolute; TOP: 176px"
				runat="server" Width="56px"></asp:textbox>
			<asp:DropDownList id=DropDownList4 style="Z-INDEX: 117; LEFT: 200px; POSITION: absolute; TOP: 216px" runat="server" DataValueField="ID" DataTextField="FIRSTNAME" DataMember="USERS" DataSource="<%# dataSet61 %>" Height="24px" Width="272px">
			</asp:DropDownList></form>
	</body>
</HTML>
