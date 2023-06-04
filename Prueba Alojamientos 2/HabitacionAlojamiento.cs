using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_Alojamientos_2
{
    public class HabitacionAlojamiento
    {
        public string CodHotel { get; set; }
        public string CodHabitacion { get; set; }
        public string NombreHabitacion { get; set; }
        public decimal Tarifa { get; set; }
        public int CapacidadAdultos { get; set; }
        public int CapacidadMenores { get; set; }
        public int CapacidadInfantes { get; set; }
        public int CantidadHabitaciones { get; set; }

        public static List<HabitacionAlojamiento> Habitaciones { get; set; } = new List<HabitacionAlojamiento>();

        public static void ActualizarTarifaAlojamiento(string codHabitacion, decimal nuevaTarifa)
        {
            HabitacionAlojamiento habitacion = Habitaciones.Find(h => h.CodHabitacion == codHabitacion);
            if (habitacion != null)
            {
                habitacion.Tarifa = nuevaTarifa;
            }
        }
    }
}
