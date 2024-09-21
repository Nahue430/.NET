using aplicacion.Modelos;
using Dominios.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aplicacion.Interfaces
{
    public interface IPeliculaServicio
    {
        void CrearPelicula(PeliculaSolicitud pelicula);
        List<Pelicula> ListaPeliculas();
    }
}
