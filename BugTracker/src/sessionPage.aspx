<%@ Page language="c#" Codebehind="sessionPage.aspx.cs" AutoEventWireup="false" Inherits="bugtracker.sessionPage" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>sessionPage</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			&nbsp;<asp:button id="Button1" style="Z-INDEX: 101; LEFT: 16px; POSITION: absolute; TOP: 96px" runat="server"
				Height="32px" Width="136px" Text="Add New Task"></asp:button>
			<asp:DataGrid id=m_dataGrid style="Z-INDEX: 102; LEFT: 24px; POSITION: absolute; TOP: 144px" runat="server" Width="648px" Height="344px" BorderStyle="None" BorderColor="#3366CC" BackColor="White" CellPadding="4" BorderWidth="1px" DataSource="<%# m_dataSet %>" DataMember="VIEW_BUGS" DataKeyField="ID" ForeColor="White">
				<SelectedItemStyle Font-Bold="True" ForeColor="#CCFF99" BackColor="#009999"></SelectedItemStyle>
				<AlternatingItemStyle HorizontalAlign="Left" ForeColor="White" VerticalAlign="Top" BackColor="#0099FF"></AlternatingItemStyle>
				<ItemStyle Font-Size="Smaller" HorizontalAlign="Left" ForeColor="Blue" VerticalAlign="Top"
					BackColor="White"></ItemStyle>
				<HeaderStyle Font-Bold="True" ForeColor="#CCCCFF" BackColor="#003399"></HeaderStyle>
				<FooterStyle ForeColor="#003399" BackColor="#99CCCC"></FooterStyle>
				<Columns>
					<asp:ButtonColumn Text="Add  New Message" HeaderText="Add new Message" CommandName="Select"></asp:ButtonColumn>
				</Columns>
				<PagerStyle HorizontalAlign="Left" ForeColor="#003399" BackColor="#99CCCC" Mode="NumericPages"></PagerStyle>
			</asp:DataGrid>
			<asp:Button id="m_Message_Btn2" style="Z-INDEX: 103; LEFT: 160px; POSITION: absolute; TOP: 96px"
				runat="server" Width="136px" Height="32px" Text="New Message"></asp:Button>
			<asp:Button id="m_Edit_btn3" style="Z-INDEX: 104; LEFT: 312px; POSITION: absolute; TOP: 96px"
				runat="server" Width="136px" Height="32px" Text="Edit Bug"></asp:Button>
			<asp:Label id="m_Project_Lb" style="Z-INDEX: 105; LEFT: 48px; POSITION: absolute; TOP: 32px"
				runat="server" Width="88px" Height="40px" Font-Size="Large">Project</asp:Label>
			<asp:Label id=Label1 style="Z-INDEX: 106; LEFT: 160px; POSITION: absolute; TOP: 32px" runat="server" Width="408px" Height="32px" Text='<%# DataBinder.Eval(m_dataSet, "Tables[VIEW_BUGS].DefaultView.[0].Name") %>' Font-Size="Large">
			</asp:Label></form>
	</body>
</HTML>
