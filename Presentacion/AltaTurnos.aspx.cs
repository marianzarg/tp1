using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;
using System.Data;

namespace Presentacion
{
    public partial class AltaTurnos : System.Web.UI.Page
    {

        PacienteNego pacienteNego = new PacienteNego();
        TurnosNego turnoNego = new TurnosNego();
        Turno turno = new Turno();

        Cliente paciente = new Cliente();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;
            CargarGrilla();
            CargarDropdown();
        }

        private void CargarGrilla()
        {
            gdvTurnos.DataSource = turnoNego.listaTurnos(); //ESTO CARGA LA GRILLA
            gdvTurnos.DataBind(); //ESTO CARGA LA GRILLA
        }

        private void CargarDropdown()
        {

            //ddId.DataSource = pacienteNego.listaPacientes();
            ddId.DataSource = turnoNego.cargarDropdown();
            ddId.DataTextField = "datos";
            ddId.DataValueField = "idPacientes";
            ddId.DataBind();
            ddId.Items.Insert(0, "Seleccione el paciente para asignarle turno");
        }

        protected void ddId_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = Int16.Parse(ddId.SelectedValue);
            txtNombre.Text = turnoNego.LlenarCampos(index).Rows[0]["nombre"].ToString();
            txtApellido.Text = turnoNego.LlenarCampos(index).Rows[0]["apellido"].ToString();
            txtDireccion.Text = turnoNego.LlenarCampos(index).Rows[0]["direccion"].ToString();
            txtTelefono.Text = turnoNego.LlenarCampos(index).Rows[0]["telefono"].ToString();
        }

        protected void btnAsignarTurno_Click(object sender, EventArgs e)
        {
            AsignarTurno();
        }

        private void AsignarTurno()
        {
            int index = Int16.Parse(ddId.SelectedValue);
            turno.FechaTurno = DateTime.Parse((txtFechaTurno.Text) + " " + (txtHora.Text));
            turno.HoraTurno = DateTime.Parse(txtHora.Text);
            turno.Motivo = txtMotivoTurno.Text;
            turno.Tareas = txtTareas.Text;

            turnoNego.AsignarTurno(turno, index);
            CargarGrilla();
            CargarDropdown();
        }

    }
}