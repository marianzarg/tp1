using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace Presentacion
{
    public partial class ModificarTurno : System.Web.UI.Page
    {

        PacienteNego pacienteNego = new PacienteNego();
        TurnosNego turnoNego = new TurnosNego();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;
            CargarCampos();
        }
        protected void btnModificarTurno_Click(object sender, EventArgs e)
        {

        }

        protected void CargarCampos()
        {
            int index = Int16.Parse(Request["idTurnos"]);
            txtNombre.Text = turnoNego.LlenarCamposTurno(index).Rows[0]["nombre"].ToString();
            txtApellido.Text = turnoNego.LlenarCamposTurno(index).Rows[0]["apellido"].ToString();
            txtDireccion.Text = turnoNego.LlenarCamposTurno(index).Rows[0]["direccion"].ToString();
            txtTelefono.Text = turnoNego.LlenarCamposTurno(index).Rows[0]["telefono"].ToString();
            string fecha = turnoNego.LlenarCamposTurno(index).Rows[0]["fechaTurno"].ToString();
            txtFechaTurno.Text = DateTime.Parse(fecha).ToString("yyyy-MM-dd");
            string hora = turnoNego.LlenarCamposTurno(index).Rows[0]["fechaTurno"].ToString();
            txtHora.Text = DateTime.Parse(fecha).ToString("HH:mm");
            txtMotivoTurno.Text = turnoNego.LlenarCamposTurno(index).Rows[0]["motivoTurno"].ToString();
            txtTareas.Text = turnoNego.LlenarCamposTurno(index).Rows[0]["Descripcion"].ToString();
        }
    }
}