using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rudas6c24b
{
    public class Grifo
    {
        public List<Usuario> Usuarios { get; set; }

        public Grifo()
        {
            Usuarios = new List<Usuario>();
        }

        public void AgregarUsuario(Usuario usuario)
        {
            Usuarios.Add(usuario);
        }

        public void MostrarUsuarios()
        {
            foreach (var usuario in Usuarios)
            {
                usuario.MostrarInformacion();
                Console.WriteLine();
            }
        }
    }
}
