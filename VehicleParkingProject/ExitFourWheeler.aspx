<%@ Page Title="" Language="C#" MasterPageFile="~/FourWheelerMaster.Master" AutoEventWireup="true" CodeBehind="ExitFourWheeler.aspx.cs" Inherits="VehicleParkingProject.ExitFourWheeler" %>
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
            if (window.confirm('Vehical Exitted')) {
                window.location.href = 'http://localhost:59459/ExitFourWheeler.aspx';
            };
        } 
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Button ID="Button2" runat="server" PostBackUrl="~/home.aspx" Text="Home" />
    <br />
    <table class="auto-style2">
        <tr>
            <td colspan="4"><p class="p1" style="font-weight: bold">Select The Vehicle For Exit</p></td>
        </tr>
        <tr>
            <td colspan="2"><p class="p1">Choose Name:</p></td>
            <td colspan="2">
                <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="vname" DataValueField="vid">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ParkingProjectConnectionString %>" SelectCommand="SELECT [vid], [vname] FROM [vehicle_reg] WHERE (([slot] IS NOT NULL) AND ([type] = @type))">
                    <SelectParameters>
                        <asp:Parameter DefaultValue="4-wheeler" Name="type" Type="String" />
                    </SelectParameters>
                </asp:SqlDataSource>
            </td>
        </tr>
        <tr>
            <td colspan="2">&nbsp;</td>
            <td colspan="2">
                <asp:Button ID="btnView" runat="server" Text="View" OnClick="btnView_Click" />
            </td>
        </tr>
        <tr>
            <td>
                <p class="p1">Ente Entry Time:</p></td>
            <td>
                <asp:TextBox ID="txtEntrytime" runat="server" Enabled="False"></asp:TextBox>
            </td>
            <td><p class="p1">Ente Exit Time:</p></td>
            <td>
                <asp:TextBox ID="txtTime" runat="server" TextMode="Time"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2"><p class="p1">Vehicle Slot:</p></td>
            <td colspan="2">
                <asp:TextBox ID="txtExitSlot" runat="server" Enabled="False" Width="105px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">&nbsp;</td>
            <td colspan="2">
                <asp:Button ID="btnCal" runat="server" Text="Calculate" OnClick="btnCal_Click" />
            </td>
        </tr>

        <tr>
            <td colspan="2"><p class="p1">Duration:</p</td>
            <td colspan="2">
                <asp:TextBox ID="txtDur" runat="server" Enabled="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2"><p class="p1">Charge Of Parking :</p></td>
            <td colspan="2">
                <asp:TextBox ID="txtCharge" runat="server" Enabled="False"></asp:TextBox>
                <asp:Button ID="btnExit" runat="server" Text="Exit" OnClick="btnExit_Click" />
                <asp:Label ID="Label1" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
