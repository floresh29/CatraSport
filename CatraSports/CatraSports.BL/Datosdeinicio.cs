using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatraSports.BL
{
    public class Datosdeinicio: CreateDatabaseIfNotExists<Contexto>
    {
        protected override void Seed(Contexto contexto)
        {
            var nuevoUsuario = new Usuario();
            nuevoUsuario.Nombre = "Allan";
            nuevoUsuario.Contrasena = Encriptar.CodificarContrasena ("123");
            contexto.Usuarios.Add(nuevoUsuario);

            var nuevoUsuario1 = new Usuario();
            nuevoUsuario1.Nombre = "Claudia";
            nuevoUsuario1.Contrasena = Encriptar.CodificarContrasena("1234");
            contexto.Usuarios.Add(nuevoUsuario1);

            var nuevoUsuario2 = new Usuario();
            nuevoUsuario2.Nombre = "Wilmer";
            nuevoUsuario2.Contrasena = Encriptar.CodificarContrasena("321");
            contexto.Usuarios.Add(nuevoUsuario2);

            base.Seed(contexto);
        }
    }
}
