using Prueba_Alojamientos_2;
using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        // Cargar datos desde JSON a las listas de objetos
        CargaDatos cargaDatos = new CargaDatos();
        List<Alojamiento> alojamientos = cargaDatos.CargaAlojamientos("C:\\Users\\npare\\source\\repos\\Prueba Alojamientos 2\\Prueba Alojamientos 2\\Data\\EntAlojamiento.json");
        List<HabitacionAlojamiento> habitaciones = cargaDatos.CargadHabitaciones("C:\\Users\\npare\\source\\repos\\Prueba Alojamientos 2\\Prueba Alojamientos 2\\Data\\HabitacionAlojamientos.json");
        List<DisponibilidadAlojamiento> disponibilidad = cargaDatos.CargaDisponibilidad("C:\\Users\\npare\\source\\repos\\Prueba Alojamientos 2\\Prueba Alojamientos 2\\Data\\DisponibilidadHabitacion.json");

    }
    
}

