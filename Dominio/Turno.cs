using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Turno
    {
        DateTime fechaTurno;
        DateTime horaTurno;
        string motivo;
        string tareas;

        public DateTime FechaTurno
        {
            get
            {
                return fechaTurno;
            }

            set
            {
                fechaTurno = value;
            }
        }

        public DateTime HoraTurno
        {
            get
            {
                return horaTurno;
            }

            set
            {
                horaTurno = value;
            }
        }

        public string Motivo
        {
            get
            {
                return motivo;
            }

            set
            {
                motivo = value;
            }
        }

        public string Tareas
        {
            get
            {
                return tareas;
            }

            set
            {
                tareas = value;
            }
        }
    }
}
