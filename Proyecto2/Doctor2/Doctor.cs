using System;
using System.Collections.Generic;
using System.Text;

namespace Doctor2
{
    public class Doctor
    {
        public int edad { get; set; }

        public string especialidad { get; set; }

        public Doctor(int pedad, string pespecialidad)
        {
            edad = pedad;
            especialidad = pespecialidad;
        }

        public void MostrarDoctor()
        {
            Console.WriteLine($"El doctor tiene {edad} años" +
                $" y su especialidad es {especialidad}");
        }
    }
}
