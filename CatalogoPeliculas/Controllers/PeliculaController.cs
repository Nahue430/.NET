using aplicacion.Interfaces;
using aplicacion.Modelos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CatalogoPeliculas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeliculaController : ControllerBase
    {
        private readonly IPeliculaServicio _servicio;
        public PeliculaController(IPeliculaServicio servicio)
        {
            _servicio = servicio;

        }
        [HttpGet]
        public IActionResult ListarPeliculas()
        {
            return Ok(_servicio.ListaPeliculas());
        }

        [HttpPost("[action]")]
        public IActionResult CrearPelicula(PeliculaSolicitud pelicula)
        {
            _servicio.CrearPelicula(pelicula);
            return Ok($"Se creo correctamente la pelicula : {pelicula.Titulo}");
        }
    }

}
