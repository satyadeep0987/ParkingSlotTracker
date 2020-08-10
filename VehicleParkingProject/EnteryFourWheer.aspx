<%@ Page Title="" Language="C#" MasterPageFile="~/FourWheelerMaster.Master" AutoEventWireup="true" CodeBehind="EnteryFourWheer.aspx.cs" Inherits="VehicleParkingProject.EnteryFourWheer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            width: 100%;
            border: 1px solid #808080;
        }
        .p1{
            text-align:center;
            position:relative;
        }
    </style>
    <script type="text/javascript">
        function CallCodeBehind() {
            //alert("Data Inserted");
            if (window.confirm('Data Inserted')) {
                window.location.href = 'http://localhost:59459/EnteryFourWheer.aspx';
            };
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Button ID="Button2" runat="server" PostBackUrl="~/home.aspx" Text="Home" />
    <br />
    <table class="auto-style2">
        <tr>
            <td colspan="2"><p class="p1" style="font-weight: bold">Enter The Vehicle</p></td>
        </tr>
        <tr>
            <td><p class="p1">Enter Name:</p></td>
            <td>
                <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td><p class="p1">Ente Entry Time:</p></td>
            <td>
                <asp:TextBox ID="txtTime" runat="server" TextMode="Time"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td><p class="p1">Enter Slot:</p></td>
            <td>
                <asp:DropDownList ID="ddlEntrySLot" runat="server" Width="151px" DataSourceID="SqlDataSource1" DataTextField="slot" DataValueField="slot">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ParkingProjectConnectionString %>" SelectCommand="SELECT [slot] FROM [avalslotheavy]"></asp:SqlDataSource>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
                <asp:Label ID="Label1" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
