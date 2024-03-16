using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rudas6c24b
{

    public class Cliente : Usuario
    {
        public double LitrosCargados { get; set; }

        public Cliente(string nombre, string saldo, double litrosCargados) : base(nombre, saldo)
        {
            LitrosCargados = litrosCargados;
        }
        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Litros Cargados: {LitrosCargados}");
        }
    }
}
