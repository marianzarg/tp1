<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AltaPersona.aspx.cs" Inherits="Presentacion.AltaPersona1" %>

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
                        <asp:Button ID="btnGuardarPaciente" runat="server" Text="Guardar" class="btn btn-primary" OnClick="btnGuardarPaciente_Click" />
                    </div>
                    <div class="col-md-4">
                    </div>
                </div>

            </div>
        </div>
        <div class="form-group">
            <asp:GridView ID="gdvPacientes" runat="server" CssClass="table table-striped" AutoGenerateColumns="false" OnRowCommand="gdvPacientes_RowCommand">

                <Columns>
                    <asp:BoundField HeaderText="idPaciente" DataField="idPacientes" />
                    <asp:BoundField HeaderText="Nombre" DataField="nombre" />
                    <asp:BoundField HeaderText="Apellido" DataField="apellido" />
                    <asp:BoundField HeaderText="Direccion" DataField="direccion" />
                    <asp:BoundField HeaderText="Telefono" DataField="telefono" />
                    <asp:TemplateField HeaderText="Opciones">
                        <ItemTemplate>
                            <asp:ImageButton runat="server" ImageUrl="~/img/edit.png" CommandName="editar" CommandArgument='<%#Eval("idPacientes")%>' />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>

            </asp:GridView>
        </div>
    </div>
</asp:Content>
