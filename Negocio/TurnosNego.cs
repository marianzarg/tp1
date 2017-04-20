using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Repositorio;
using System.Data;

namespace Negocio
{
    public class TurnosNego
    {
        Turno turnos = new Turno();
        TurnosRepo turnosRepo = new TurnosRepo();

        public DataTable LlenarCampos(int index)
        {
            return turnosRepo.LlenarCampos(index);
        }

        public DataTable listaTurnos()
        {
            return turnosRepo.listaTurnos();
        }

        public void AsignarTurno(Turno turno, int index)
        {
            turnosRepo.AsignarTurnos(turno, index);
        }

        public DataTable cargarDropdown()
        {
            return turnosRepo.CargarDropdown();
        }
    }
}
