<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UpdatePerson.aspx.cs" Inherits="SchoolWEB.UpdatePerson" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="label" runat="server" Text="Person ID"></asp:Label>
    <asp:TextBox ID="txtPersonID" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="label2" runat="server" Text="Last Name"></asp:Label>
    <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="label3" runat="server" Text="First Name"></asp:Label>
    <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="label4" runat="server" Text="Hire Date"></asp:Label>
    <asp:TextBox ID="txtHireDate" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="label5" runat="server" Text="Enrollment Date"></asp:Label>
    <asp:TextBox ID="txtEnrollmentDate" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />
    <br />
    <asp:LinkButton ID="lnkRegresar" runat="server" OnClick="lnkRegresar_Click">Regresar</asp:LinkButton>
</asp:Content>
