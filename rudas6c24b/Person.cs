using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rudas6c24b
{
    //antes internal
    public class Person
    {
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public int Edad { get; set; }
        public string GetNombresCompletos()
        {
            return Nombres + " " + Apellidos;
        }
        public bool EsMayorEdad()
        {
            return Edad >18;
        }

    }
}
