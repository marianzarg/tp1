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
    public class PacienteNego
    {

        Cliente paciente = new Cliente();
        PacienteRepo pacienteRepo = new PacienteRepo();


        public void GuardarPaciente(Cliente paciente)
        {
            pacienteRepo.GuardarPaciente(paciente);
        }

        public DataTable listaPacientes()
        {
            return pacienteRepo.listaPacientes();
        }

        public void ModificarPaciente(Cliente paciente, int index)
        {
            pacienteRepo.ModificarPaciente(paciente, index);
        }

        public void borrarPersona(int index)
        {
            pacienteRepo.borrarPersona(index);
        }
    }
}
