using RamosGuillenTrujilloProyectoPorgreso1.Models;

namespace RamosGuillenTrujilloProyectoPorgreso1.Data
{
    public class DA_Logica
    {

        public List<Usuario> ListaUsuario()
        {
            return new List<Usuario>
            {
                new Usuario { Nombre = "David",Correo ="david@gmail.com",Clave ="123", Roles = new string[] {"Conductor"} },
                new Usuario { Nombre = "Xavier",Correo ="xavier@gmail.com",Clave ="1234", Roles = new string[] {"Usuario"} },
                new Usuario { Nombre = "Johan",Correo ="johan@gmail.com",Clave ="12345", Roles = new string[] {"Conductor"} },
                new Usuario { Nombre = "Martin",Correo ="martin@gmail.com",Clave ="123456", Roles = new string[] {"Usuario"} }
            };
            
        }

        public Usuario ValidarUsuario(string _correo, string _clave)
        {
            return ListaUsuario().Where(item => item.Correo == _correo && item.Clave == _clave).FirstOrDefault();
        }

    }
}
