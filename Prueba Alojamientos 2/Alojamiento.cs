using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_Alojamientos_2
{
    public class Alojamiento : Producto
    {
        public string CodHotel { get; set; }
        public string NombreAlojamiento { get; set; }
        public string CodCiudad { get; set; }
        public string Direccion { get; set; }
        public int Calificacion { get; set; }
        public string CodHabitacion { get; set; }

        public static List<Alojamiento> Alojamientos { get; set; } = new List<Alojamiento>();

        public void AgregarAlojamiento(Alojamiento alojamiento)
        {
            Alojamientos.Add(alojamiento);
        }

        public static void ActualizarDatosAlojamiento(string codHotel, string nombre = null, string ciudad = null, string direccion = null, int calificacion = 0)
        {
            Alojamiento alojamiento = Alojamientos.Find(a => a.CodHotel == codHotel);
            if (alojamiento != null)
            {
                if (nombre != null)
                    alojamiento.NombreAlojamiento = nombre;
                if (ciudad != null)
                    alojamiento.CodCiudad = ciudad;
                if (direccion != null)
                    alojamiento.Direccion = direccion;
                if (calificacion != 0)
                    alojamiento.Calificacion = calificacion;                
            }
        }
    }

    
}
