using Dominios.Enum;

namespace Dominios.Entidades
{
    public class Actor
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public Nacionalidad PaisNacimiento { get; set; }

    }
}