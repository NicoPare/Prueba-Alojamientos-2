using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Prueba_Alojamientos_2
{
    public class CargaDatos
    {
        public List<Alojamiento> CargaAlojamientos(string filePath)
        {
            string json = File.ReadAllText(filePath);
            List<Alojamiento> alojamientos = JsonConvert.DeserializeObject<List<Alojamiento>>(json);
            return alojamientos;
        }

        public List<HabitacionAlojamiento> CargadHabitaciones(string filePath)
        {
            string json = File.ReadAllText(filePath);
            List<HabitacionAlojamiento> habitaciones = JsonConvert.DeserializeObject<List<HabitacionAlojamiento>>(json);
            return habitaciones;
        }

        public List<DisponibilidadAlojamiento> CargaDisponibilidad(string filePath)
        {
            string json = File.ReadAllText(filePath);
            List<DisponibilidadAlojamiento> disponibilidad = JsonConvert.DeserializeObject<List<DisponibilidadAlojamiento>>(json);
            return disponibilidad;
        }
    }

    
}
