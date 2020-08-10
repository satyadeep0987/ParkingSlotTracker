<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="FourWheeler.aspx.cs" Inherits="VehicleParkingProject.FourWheeler" %>
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
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <table class="auto-style2">
        <tr>
            <td colspan="2">
                <p class="p1">Every hours charge 50Rs. One hour chrge is mendatory if Vehical parked.</p>
                <p class="p1">If you had across 2.7 hours we will charge according to the base i.e 100Rs.</p>
                <p class="p1">*Plese Don't lost Your Slip, There Would Be Fine Of 200Rs and Requirment Of Proof.</p>
            </td>
        </tr>
        <tr>
              <td><p class="p1">Enter The Vehicle</p></td>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Enter" PostBackUrl="~/EnteryFourWheer.aspx" />
            </td>
        </tr>
        <tr>
            <td><p class="p1">Exit The Vehicle</p></td>
            <td>
                <asp:Button ID="btnEntry" runat="server" Text="Exit" PostBackUrl="~/ExitFourWheeler.aspx" />
            </td>
        </tr>
        <tr>
              <td><p class="p1">Check Availability</p></td>
            <td>
                <asp:Button ID="BtnCheck" runat="server" Text="Check" OnClick="BtnCheck_Click" />
               <asp:Label ID="Label1" runat="server" Text="  ---  ????"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
