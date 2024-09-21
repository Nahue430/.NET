using Dominios.Entidades;

namespace Dominios.Interfaces
{
    public interface IPeliculaRepositorio
    {
        void CrearPelicula(Pelicula pelicula);
        List<Pelicula> ListarPeliculas();
    }
}
