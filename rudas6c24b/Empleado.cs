﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rudas6c24b
{
    public class Empleado:Usuario
    {
        public double Sueldo { get; set; }

        public Empleado(string nombre, string saldo, double sueldo) : base(nombre, saldo)
        {
            Sueldo = sueldo;
        }
        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Sueldo: {Sueldo}");
        }
    }
}
