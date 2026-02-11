using System;

namespace Restaurante1.Models
{
    public class Ingrediente
    {
        public int IdIngredientes { get; set; }
        public string? NombreIngre { get; set; }
        public string? DescipcionIngre { get; set; }
        public string? EncargadoIngre { get; set; }
        
        public decimal Stock { get; set; } 
        public string? Unidad { get; set; } = "kg";
    }
}
