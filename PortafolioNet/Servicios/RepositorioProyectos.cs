using PortafolioNet.Models;

namespace PortafolioNet.Servicios
{
    public interface IRepositorioProyectos
    {
        List<ProyectoDTO> ObtenerProyectos();
    }
    public class RepositorioProyectos: IRepositorioProyectos
    {
        public List<ProyectoDTO> ObtenerProyectos()
        {
            return new List<ProyectoDTO> {
                new ProyectoDTO
            {
                Titulo="Google",
                Descripcion="E-Commerce realizado en asp.net core",
                Link="https://google.com",
                ImagenUrl="/imagenes/google.jpg"
            },
                new ProyectoDTO
            {
                Titulo="Amazon",
                Descripcion="E-Commerce realizado en angular y node",
                Link="https://amazon.com",
                ImagenUrl="/imagenes/amazon.jpg"
            },
                new ProyectoDTO
            {
                Titulo="Facebook",
                Descripcion="E-Commerce realizado en asp.net y react",
                Link="https://facebook.com",
                ImagenUrl="/imagenes/facebook.jpg"
            },
                new ProyectoDTO
            {
                Titulo="New York Times",
                Descripcion="E-Commerce realizado en asp.net Vue y Node",
                Link="https://nytimes.com",
                ImagenUrl="/imagenes/newyorktimes.png"
            }
            };
        }
    }
}
