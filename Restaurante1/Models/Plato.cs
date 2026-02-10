using System;

namespace Restaurante1.Models
{
    public class Plato
    {
        public int IdPlato { get; set; }
        public int IdCategoria { get; set; }
        public int IdIngredientes { get; set; }
        public string NombrePlato { get; set; }
        public string DescripcionPlato { get; set; }
        public string Foto { get; set; }
        public string NivelDicultad { get; set; }
        public decimal Precio { get; set; }
    }
}
