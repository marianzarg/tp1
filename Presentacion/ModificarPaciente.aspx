<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ModificarPaciente.aspx.cs" Inherits="Presentacion.ModificarPaciente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">

        <div class="panel panel-primary">
            <div class="panel-heading">Ingrese datos básicos</div>
            <div class="panel-body">

                <div class="form-group">
                    <asp:Label ID="lblNombre" runat="server" Text="Nombre" CssClass="col-md-2 control-label"></asp:Label>
                    <div class="col-md-4">
                        <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <asp:Label ID="lblApellido" runat="server" Text="Apellido" CssClass="col-md-2 control-label"></asp:Label>
                    <div class="col-md-4">
                        <asp:TextBox ID="txtApellido" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>

                <div class="form-group">
                    <asp:Label ID="lblDireccion" runat="server" Text="Direccion" CssClass="col-md-2 control-label"></asp:Label>
                    <div class="col-md-4">
                        <asp:TextBox ID="txtDireccion" runat="server" CssClass="form-control input-md"></asp:TextBox>
                    </div>
                    <asp:Label ID="lblTelefono" runat="server" Text="Telefono" CssClass="col-md-2 control-label"></asp:Label>
                    <div class="col-md-4">
                        <asp:TextBox ID="txtTelefono" runat="server" CssClass="form-control input-md"></asp:TextBox>
                    </div>
                </div>

                <div class="form-group">
                </div>
                
                <div class="form-group">
                    <div class="col-md-4">
                    </div>
                    <div class="col-md-4">
                        <asp:Button ID="btnModificarPaciente" runat="server" Text="Modificar" class="btn btn-primary" OnClick="btnModificarPaciente_Click" />
                    </div>
                    <div class="col-md-4">
                    </div>
                </div>

            </div>
        </div>
</asp:Content>
