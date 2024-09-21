using aplicacion.Interfaces;
using aplicacion.Modelos;
using Dominios.Entidades;
using Dominios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace aplicacion.Services
{
    public class PeliculaServicio : IPeliculaServicio
    {
        private readonly IPeliculaRepositorio _repositorio;

        public PeliculaServicio(IPeliculaRepositorio repositorio)
        {
            _repositorio = repositorio;
        }
        public void CrearPelicula(PeliculaSolicitud solicitud)
        {
            var nuevaPelicula = new Pelicula();
            nuevaPelicula.Id = solicitud.Id;
            nuevaPelicula.Titulo = solicitud.Titulo;
            nuevaPelicula.Descripcion = solicitud.Descripcion;

            _repositorio.CrearPelicula(nuevaPelicula);
        }

        public List<Pelicula> ListaPeliculas()
        {
            return _repositorio.ListarPeliculas();
        }
    }
}
