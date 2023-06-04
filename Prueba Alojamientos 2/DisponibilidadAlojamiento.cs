using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_Alojamientos_2
{
    public class DisponibilidadAlojamiento
    {
        public string CodHabitacion { get; set; }
        public DateTime Fecha { get; set; }
        public int CantidadDisponible { get; set; }

        public static List<DisponibilidadAlojamiento> Disponibilidades { get; set; } = new List<DisponibilidadAlojamiento>();

        public static void ActualizarCantidadHabitacion(string codHabitacion, DateTime fecha, int nuevaCantidad)
        {
            DisponibilidadAlojamiento disponibilidad = Disponibilidades.Find(d => d.CodHabitacion == codHabitacion && d.Fecha.Date == fecha.Date);
            if (disponibilidad != null)
            {
                disponibilidad.CantidadDisponible = nuevaCantidad;
            }
        }
    }
}
