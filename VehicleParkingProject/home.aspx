<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="VehicleParkingProject.home" Theme="Skin1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <style type="text/css">
        .lblCheckPresent
        {
            text-align:center;
        }
    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">

    <asp:Panel ID="Panel1" runat="server" BorderColor="#666666" HorizontalAlign="Center" style="position: relative; top: 29px; left: 69px; height: 129px; width: 324px">
        <asp:Label ID="Label2" runat="server" Text="Check Avalability" Font-Bold="True"></asp:Label>
        <asp:Button ID="Button2" runat="server" Font-Bold="True" style="position: relative; z-index: 1; left: -133px; top: 61px; height: 32px" Text="Check" OnClick="Button2_Click" />
        
    </asp:Panel>
    <asp:Panel ID="Panel2" runat="server" style="position: relative; top: -102px; left: 875px; height: 136px; width: 332px; text-align: center">
        <asp:Label ID="Label3" runat="server" Text="Check Vehicle Present" Font-Bold="True"></asp:Label>
        <asp:Button ID="Button3" runat="server" Font-Bold="True" style="position: relative; z-index: 1; left: -107px; top: 59px; height: 32px" Text="Check" OnClick="Button3_Click" />
            
        </asp:Panel>
    <asp:Panel ID="Panel3" runat="server" style="position: relative; top: -237px; left: 459px; width: 327px; height: 118px; text-align: center">
        <asp:Label ID="Label1" runat="server" Text="Check Vehicle Left" Font-Bold="True"></asp:Label>
        <asp:Button ID="Button1" runat="server" Font-Bold="True" style="position: relative; z-index: 1; left: -105px; top: 63px; height: 32px" Text="Check" OnClick="Button1_Click" />
        <asp:Panel ID="Panel4" runat="server" style="position: relative; top: 109px; left: -219px; width: 698px; z-index: 1; height: 300px">
            <asp:Label ID="Label5" runat="server" Text="Check Result Below"></asp:Label>
            <br />
            <asp:Panel ID="Panel5" runat="server" Height="101px" ScrollBars="Auto" style="text-align: justify" Visible="False" Width="691px">
                <asp:GridView ID="GridView4" runat="server" AutoGenerateColumns="False" DataKeyNames="vid" DataSourceID="SqlDataSource1" Width="667px">
                    <Columns>
                        <asp:BoundField DataField="vid" HeaderText="vid" InsertVisible="False" ReadOnly="True" SortExpression="vid" />
                        <asp:BoundField DataField="vname" HeaderText="vname" SortExpression="vname" />
                        <asp:BoundField DataField="ent" HeaderText="ent" SortExpression="ent" />
                        <asp:BoundField DataField="ext" HeaderText="ext" SortExpression="ext" />
                        <asp:BoundField DataField="slot" HeaderText="slot" SortExpression="slot" />
                        <asp:BoundField DataField="type" HeaderText="type" SortExpression="type" />
                        <asp:BoundField DataField="duration" HeaderText="duration" SortExpression="duration" />
                        <asp:BoundField DataField="charge" HeaderText="charge" SortExpression="charge" />
                    </Columns>
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ParkingProjectConnectionString %>" SelectCommand="SELECT * FROM [vehicle_reg] WHERE ([slot] IS NULL)"></asp:SqlDataSource>
            </asp:Panel>
            <asp:Panel ID="Panel6" runat="server">
                <asp:Label ID="lblCheck" runat="server"></asp:Label>
                <br />
                <asp:Label ID="lblCheck0" runat="server"></asp:Label>
            </asp:Panel>
            <asp:Panel ID="Panel7" runat="server" Height="102px" ScrollBars="Auto" Visible="False" Width="694px">
                <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" DataKeyNames="vid" DataSourceID="SqlDataSource3" PageSize="5" Width="629px">
                    <Columns>
                        <asp:BoundField DataField="vid" HeaderText="vid" InsertVisible="False" ReadOnly="True" SortExpression="vid" />
                        <asp:BoundField DataField="vname" HeaderText="vname" SortExpression="vname" />
                        <asp:BoundField DataField="ent" HeaderText="ent" SortExpression="ent" />
                        <asp:BoundField DataField="ext" HeaderText="ext" SortExpression="ext" />
                        <asp:BoundField DataField="slot" HeaderText="slot" SortExpression="slot" />
                        <asp:BoundField DataField="type" HeaderText="type" SortExpression="type" />
                        <asp:BoundField DataField="duration" HeaderText="duration" SortExpression="duration" />
                        <asp:BoundField DataField="charge" HeaderText="charge" SortExpression="charge" />
                    </Columns>
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:ParkingProjectConnectionString %>" SelectCommand="SELECT * FROM [vehicle_reg] WHERE ([slot] IS NOT NULL)"></asp:SqlDataSource>
                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ParkingProjectConnectionString %>" SelectCommand="SELECT * FROM [vehicle_reg] WHERE ([slot] IS NOT NULL)"></asp:SqlDataSource>
            </asp:Panel>
            <br />
        </asp:Panel>
            </asp:Panel>

</asp:Content>