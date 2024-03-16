// See https://aka.ms/new-console-template for more information
namespace rudas6c24b
{
    class Program
    {
        static void Main(string[] args)
        {
            Grifo grifo = new Grifo();

            int opcion = 0;
            while (opcion != 4)
            {
                Console.WriteLine("Menu de opciones:");
                Console.WriteLine("1. Mostrar información del usuario");
                Console.WriteLine("2. Agregar cliente");
                Console.WriteLine("3. Agregar empleado");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");

                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("Información de los usuarios:");
                            grifo.MostrarUsuarios();
                            break;
                        case 2:
                            Console.Write("Nombre del cliente: ");
                            string nombreCliente = Console.ReadLine();
                            Console.Write("Saldo del cliente: ");
                            string saldoCliente = Console.ReadLine();
                            Console.Write("Litros Cargados del cliente: ");
                            double litrosDuCliente = double.Parse(Console.ReadLine());
                            Cliente cliente = new Cliente(nombreCliente, saldoCliente, litrosDuCliente);
                            grifo.AgregarUsuario(cliente);
                            Console.WriteLine("Cliente agregado correctamente.");
                            break;
                        case 3:
                            Console.Write("Nombre del empleado: ");
                            string nombreEmpleado = Console.ReadLine();
                            Console.Write("Saldo del empleado: ");
                            string saldoEmpleado = Console.ReadLine();
                            Console.Write("Sueldo del empleado: ");
                            double sueldoEmpleado;
                            if (double.TryParse(Console.ReadLine(), out sueldoEmpleado))
                            {
                                Empleado empleado = new Empleado(nombreEmpleado, saldoEmpleado, sueldoEmpleado);
                                grifo.AgregarUsuario(empleado);
                                Console.WriteLine("Empleado agregado correctamente.");
                            }
                            else
                            {
                                Console.WriteLine("Por favor, ingrese un valor numérico para el sueldo.");
                            }
                            break;
                        case 4:
                            Console.WriteLine("Saliendo del programa...");
                            break;
                        default:
                            Console.WriteLine("Opción no válida.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Por favor, ingrese un número válido.");
                }

                Console.WriteLine();
            }
        }
    }
}
