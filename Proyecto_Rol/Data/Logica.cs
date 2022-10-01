using Proyecto_Rol.Models;
namespace Proyecto_Rol.Data
{
    public class Logica
    {
        public List<Usuario> ListaUsuarios()
        {
            return new List<Usuario>
            {
                new Usuario{Nombre = "Ronny",Correo = "adm@gmail.com",Clave = "123",Roles = new string[]{"Administrador"} },
                new Usuario{Nombre = "Pedro",Correo = "sup@gmail.com",Clave = "123",Roles = new string[]{"Supervidor"} },
                new Usuario{Nombre = "Juan",Correo = "Emp@gmail.com",Clave = "123",Roles = new string[]{"Empleado"} },
                new Usuario{Nombre = "Naomi",Correo = "superEmp@gmail.com",Clave = "123",Roles = new string[]{"Supervidor","Empleado"} }
            };
        }
    }
}
