<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ModificarTurno.aspx.cs" Inherits="Presentacion.ModificarTurno" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div class="container">

        <div class="panel panel-primary">
            <div class="panel-heading">Modificar turno paciente</div>
            <div class="panel-body">

                <%--<div class="form-group">
                    <asp:DropDownList ID="ddId" runat="server" CssClass="form-control" AutoPostBack="True" OnSelectedIndexChanged="ddId_SelectedIndexChanged">
                        <asp:ListItem Selected="True"></asp:ListItem>
                        <asp:ListItem />

                    </asp:DropDownList>
                </div>--%>

                <div class="form-group">
                    <asp:Label ID="lblNombre" runat="server" Text="Nombre" CssClass="col-md-4 control-label"></asp:Label>
                    <div class="col-md-4">
                        <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control input-md" Enabled="false"></asp:TextBox>
                    </div>
                </div>

                <div class="form-group">
                    <asp:Label ID="lblApellido" runat="server" Text="Apellido" CssClass="col-md-4 control-label"></asp:Label>
                    <div class="col-md-4">
                        <asp:TextBox ID="txtApellido" runat="server" CssClass="form-control input-md" Enabled="false"></asp:TextBox>
                    </div>
                </div>

                <div class="form-group">
                    <asp:Label ID="lblDireccion" runat="server" Text="Direccion" CssClass="col-md-4 control-label"></asp:Label>
                    <div class="col-md-4">
                        <asp:TextBox ID="txtDireccion" runat="server" CssClass="form-control input-md" Enabled="false"></asp:TextBox>
                    </div>
                </div>

                <div class="form-group">
                    <asp:Label ID="lblTelefono" runat="server" Text="Telefono" CssClass="col-md-4 control-label"></asp:Label>
                    <div class="col-md-4">
                        <asp:TextBox ID="txtTelefono" runat="server" CssClass="form-control input-md" Enabled="false"></asp:TextBox>
                    </div>
                </div>

                <div class="form-group">
                    <asp:Label ID="lblFechaTurno" runat="server" Text="Fecha Turno" CssClass="col-md-4 control-label"></asp:Label>
                    <div class="col-md-4">
                        <asp:TextBox ID="txtFechaTurno"  runat="server" type="date" CssClass="form-control input-md"></asp:TextBox>
                    </div>
                </div>

                <div class="form-group">
                    <asp:Label ID="lblHora" runat="server" Text="Hora Turno" CssClass="col-md-4 control-label"></asp:Label>
                    <div class="col-md-4">
                        <asp:TextBox ID="txtHora" runat="server" type="time" CssClass="form-control input-md"></asp:TextBox>
                    </div>
                </div>

                <div class="form-group">
                    <asp:Label ID="lblMotivoTurno" runat="server" Text="Motivo" CssClass="col-md-4 control-label"></asp:Label>
                    <div class="col-md-4">
                        <asp:TextBox ID="txtMotivoTurno" runat="server" CssClass="form-control input-md"></asp:TextBox>
                    </div>
                </div>

                <div class="form-group">
                    <asp:Label ID="lblTareas" runat="server" Text="Tareas" CssClass="col-md-4 control-label"></asp:Label>
                    <div class="col-md-4">
                        <asp:TextBox ID="txtTareas" runat="server" CssClass="form-control input-md"></asp:TextBox>
                    </div>
                </div>

                <div class="form-group">
                    <div class="col-md-4">
                    </div>
                    <div class="col-md-4">
                        <asp:Button ID="btnModificarTurno" runat="server" Text="Modificar Turno" OnClick="btnModificarTurno_Click" class="btn btn-primary"  />
                    </div>
                    <div class="col-md-4">
                    </div>
                </div>

            </div>
        </div>
        <%--<div class="form-group">
            <asp:GridView ID="gdvTurnos" runat="server" CssClass="table table-striped" AutoGenerateColumns="false">

                <Columns>

                    <asp:BoundField HeaderText="idTurnos" DataField="idTurnos" />
                    <asp:BoundField HeaderText="Nombre Paciente" DataField="nombre" />
                    <asp:BoundField HeaderText="Apellido Paciente" DataField="apellido" />
                    <asp:BoundField HeaderText="Fecha Turno" DataField="fechaTurno" />
                    <asp:BoundField HeaderText="Fecha Asignación Turno" DataField="fechaRegistro" />
                    <asp:BoundField HeaderText="Motivo" DataField="motivoTurno" />
                    <asp:BoundField HeaderText="Descripción" DataField="descripcion" />
                    <asp:TemplateField HeaderText="Opciones">
                        <ItemTemplate>
                            <asp:ImageButton runat="server" ImageUrl="~/img/edit.png" CommandName="editar" CommandArgument='<%#Eval("idPacientes")%>' />
                            <asp:LinkButton runat="server" CommandName="eliminar" CommandArgument='<%#Eval("idPacientes")%>'><i class="fa fa-trash-o fa-2x" aria-hidden="true"></i></asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>

                </Columns>

            </asp:GridView>
        </div>--%>
    </div>
</asp:Content>
