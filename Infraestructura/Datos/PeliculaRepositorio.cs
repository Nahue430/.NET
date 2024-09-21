using Dominios.Entidades;
using Dominios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura.Datos
{
    public class PeliculaRepositorio : IPeliculaRepositorio
    {
        public static List<Pelicula> ListaPeliculas = new List<Pelicula>();
        public void CrearPelicula(Pelicula pelicula)
        {
            ListaPeliculas.Add(pelicula);
        }

        public List<Pelicula> ListarPeliculas()
        {
            return ListaPeliculas;
        }
    }
}
