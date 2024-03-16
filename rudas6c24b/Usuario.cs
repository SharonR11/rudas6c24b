using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rudas6c24b
{
    public class Usuario
    {
        public string Nombre { get; set; }
        public string Saldo { get; set; }
        public Usuario(string nombre, string saldo)
        {
            Nombre = nombre;
            Saldo = saldo;
        }
        public virtual void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Saldo: {Saldo}");
        }
    }
    
}
