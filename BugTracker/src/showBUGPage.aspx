<%@ Page language="c#" Codebehind="showBUGPage.aspx.cs" AutoEventWireup="false" Inherits="bugtracker.showBUGPage" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>showBUGPage</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:textbox id="m_bugNumber" style="Z-INDEX: 101; LEFT: 168px; POSITION: absolute; TOP: 176px"
				runat="server" BorderStyle="Outset" Enabled="False" ReadOnly="True" Height="24px" Width="216px"></asp:textbox><asp:label id="Label5" style="Z-INDEX: 106; LEFT: 48px; POSITION: absolute; TOP: 304px" runat="server"
				Height="24px" Width="56px" Font-Bold="True">Assigned</asp:label><asp:label id="Label2" style="Z-INDEX: 105; LEFT: 48px; POSITION: absolute; TOP: 272px" runat="server"
				Height="24px" Width="56px" Font-Bold="True">Status</asp:label><asp:label id="Label4" style="Z-INDEX: 104; LEFT: 48px; POSITION: absolute; TOP: 240px" runat="server"
				Height="24px" Width="56px" Font-Bold="True">Severity</asp:label><asp:label id="Label3" style="Z-INDEX: 103; LEFT: 48px; POSITION: absolute; TOP: 216px" runat="server"
				Height="24px" Width="56px" Font-Bold="True">Priority</asp:label><asp:label id="Label1" style="Z-INDEX: 102; LEFT: 48px; POSITION: absolute; TOP: 184px" runat="server"
				Height="24px" Width="104px" Font-Bold="True">BUG Number:</asp:label><asp:label id="Label6" style="Z-INDEX: 107; LEFT: 160px; POSITION: absolute; TOP: 360px" runat="server"
				Height="16px" Width="56px" Font-Bold="True">Description</asp:label><asp:textbox id=m_description style="Z-INDEX: 108; LEFT: 152px; POSITION: absolute; TOP: 400px" runat="server" Height="96px" Width="528px" Text='<%# DataBinder.Eval(m_dataSet, "Tables[VIEW_BUGS].DefaultView.[0].Description", "{0}") %>' TextMode="MultiLine">
			</asp:textbox><asp:label id=m_Priority_Lb style="Z-INDEX: 109; LEFT: 168px; POSITION: absolute; TOP: 208px" runat="server" BorderStyle="Groove" Height="16px" Width="216px" Text='<%# DataBinder.Eval(m_dataSet, "Tables[VIEW_BUGS].DefaultView.[0].Priority") %>'>
			</asp:label><asp:label id=m_Severity_Lb style="Z-INDEX: 110; LEFT: 168px; POSITION: absolute; TOP: 240px" runat="server" BorderStyle="Groove" Height="16px" Width="216px" Text='<%# DataBinder.Eval(m_dataSet, "Tables[VIEW_BUGS].DefaultView.[0].Severity") %>'>
			</asp:label><asp:label id=m_Status_Lb style="Z-INDEX: 111; LEFT: 168px; POSITION: absolute; TOP: 272px" runat="server" BorderStyle="Groove" Height="24px" Width="216px" Text='<%# DataBinder.Eval(m_dataSet, "Tables[VIEW_BUGS].DefaultView.[0].Status") %>'>
			</asp:label><asp:label id=m_Assigned_Lb style="Z-INDEX: 112; LEFT: 168px; POSITION: absolute; TOP: 304px" runat="server" BorderStyle="Groove" Height="16px" Width="216px" Text='<%# DataBinder.Eval(m_dataSet, "Tables[VIEW_BUGS].DefaultView.[0].Assigned") %>'>
			</asp:label><asp:label id="Title" style="Z-INDEX: 113; LEFT: 144px; POSITION: absolute; TOP: 112px" runat="server"
				Height="32px" Width="192px" Font-Size="Large" ForeColor="Red">Title of The Bug </asp:label><asp:label id=m_Title_Lb style="Z-INDEX: 114; LEFT: 352px; POSITION: absolute; TOP: 112px" runat="server" Height="16px" Width="208px" Text='<%# DataBinder.Eval(m_dataSet, "Tables[VIEW_BUGS].DefaultView.[0].Title") %>' Font-Size="Large" ForeColor="Red">
			</asp:label><asp:label id="Project" style="Z-INDEX: 115; LEFT: 176px; POSITION: absolute; TOP: 48px" runat="server"
				Height="40px" Width="88px" Font-Size="Large" ForeColor="#0000C0">Project</asp:label><asp:label id=m_Project_Lb style="Z-INDEX: 116; LEFT: 280px; POSITION: absolute; TOP: 48px" runat="server" Height="40px" Width="312px" Text='<%# DataBinder.Eval(m_dataSet, "Tables[VIEW_BUGS].DefaultView.[0].Name") %>' Font-Size="Large" ForeColor="#0000C0">
			</asp:label><asp:textbox id="m_NewMessage_T" style="Z-INDEX: 117; LEFT: 152px; POSITION: absolute; TOP: 560px"
				runat="server" Height="110px" Width="528px" TextMode="MultiLine"></asp:textbox><asp:label id="NewBug" style="Z-INDEX: 118; LEFT: 160px; POSITION: absolute; TOP: 512px" runat="server"
				Height="24px" Width="168px" Font-Size="Large">New Message </asp:label><asp:button id="m_SaveChanges_B" style="Z-INDEX: 119; LEFT: 448px; POSITION: absolute; TOP: 680px"
				runat="server" Height="32px" Width="234px" Text="Save Changes &amp; Post New Message"></asp:button><asp:label id="Label7" style="Z-INDEX: 120; LEFT: 232px; POSITION: absolute; TOP: 744px" runat="server"
				Height="24px" Width="184px" Font-Size="Large">Other Messages</asp:label><asp:datagrid id=DataGrid1 style="Z-INDEX: 121; LEFT: 24px; POSITION: absolute; TOP: 800px" runat="server" BorderStyle="None" Height="138px" Width="696px" ForeColor="Black" GridLines="Vertical" BackColor="White" BorderWidth="1px" BorderColor="#DEDFDE" CellPadding="4" DataKeyField="POSTEDTIME" DataMember="VIEW_MESSAGES" DataSource="<%# m_dataSet %>" ShowFooter="True" AllowSorting="True">
				<SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#CE5D5A"></SelectedItemStyle>
				<AlternatingItemStyle BackColor="White"></AlternatingItemStyle>
				<ItemStyle BackColor="#F7F7DE"></ItemStyle>
				<HeaderStyle Font-Bold="True" ForeColor="White" BackColor="#6B696B"></HeaderStyle>
				<FooterStyle ForeColor="White" BackColor="#CCCC99"></FooterStyle>
				<PagerStyle HorizontalAlign="Right" ForeColor="Black" BackColor="#F7F7DE" Mode="NumericPages"></PagerStyle>
			</asp:datagrid></form>
	</body>
</HTML>
