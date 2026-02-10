using System;
using System.Collections.Generic;
using System.Linq;
using Restaurante1.Models;

namespace Restaurante1.Services
{
    public static class DataService
    {
        public static List<Categoria> Categorias { get; private set; }
        public static List<Plato> Platos { get; private set; }
        public static List<Ingrediente> Ingredientes { get; private set; }

        static DataService()
        {
            InitializeData();
        }

        private static void InitializeData()
        {
            Categorias = new List<Categoria>
            {
                new Categoria { IdCategoria = 1, NombreCat = "Postres", DescripcionCat = "Dulces, tartas y helados", EncargadoCat = "Maria Gonzalez" },
                new Categoria { IdCategoria = 2, NombreCat = "Platos Fuertes", DescripcionCat = "Carnes, pescados y pastas", EncargadoCat = "Carlos Ruiz" },
                new Categoria { IdCategoria = 3, NombreCat = "Bebidas", DescripcionCat = "Refrescos, jugos y cócteles", EncargadoCat = "Laura Mendez" }
            };

            Ingredientes = new List<Ingrediente>
            {
                new Ingrediente { IdIngredientes = 157, NombreIngre = "Harina de Trigo", DescipcionIngre = "Harina para reposteria", EncargadoIngre = "Alma", Stock = 42.5m, Unidad = "kg" },
                new Ingrediente { IdIngredientes = 158, NombreIngre = "Azúcar", DescipcionIngre = "Azúcar blanca refinada", EncargadoIngre = "Alma", Stock = 15.0m, Unidad = "kg" },
                new Ingrediente { IdIngredientes = 159, NombreIngre = "Huevos", DescipcionIngre = "Cartón de huevos", EncargadoIngre = "Juan", Stock = 120, Unidad = "u" }
            };

            string projectPath = @"c:\Users\ersil\Documents\Visual Studio 2022\Ejercicios\Restaurante1\Restaurante1";
            
            Platos = new List<Plato>
            {
                new Plato { 
                    IdPlato = 28, 
                    IdCategoria = 1, 
                    IdIngredientes = 157, 
                    NombrePlato = "Tiramisú Clásico", 
                    DescripcionPlato = "Postre italiano con café", 
                    NivelDicultad = "3", 
                    Precio = 8.99m,
                    Foto = System.IO.Path.Combine(projectPath, "Imag", "postre.jpg")
                },
                new Plato { 
                    IdPlato = 29, 
                    IdCategoria = 2, 
                    IdIngredientes = 159, 
                    NombrePlato = "Carbonara", 
                    DescripcionPlato = "Pasta con salsa base de huevo", 
                    NivelDicultad = "2", 
                    Precio = 12.50m,
                    Foto = System.IO.Path.Combine(projectPath, "Imag", "platos fuertes.jpg")
                }
            };
        }

        public static void AddCategoria(Categoria cat)
        {
            cat.IdCategoria = Categorias.Count > 0 ? Categorias.Max(c => c.IdCategoria) + 1 : 1;
            Categorias.Add(cat);
        }

        public static void AddPlato(Plato plato)
        {
            plato.IdPlato = Platos.Count > 0 ? Platos.Max(p => p.IdPlato) + 1 : 1;
            Platos.Add(plato);
        }


        public static void UpdateStock(int idIngrediente, decimal newStock)
        {
            var item = Ingredientes.FirstOrDefault(i => i.IdIngredientes == idIngrediente);
            if (item != null)
            {
                item.Stock = newStock;
            }
        }
    }
}
