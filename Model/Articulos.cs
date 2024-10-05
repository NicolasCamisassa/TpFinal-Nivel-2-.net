using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Model
{
    public class Articulos
    {
        public int Id { get; set; }
        public string Codigo {  get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string ImagenUrl {  get; set; }
        public decimal Precio {  get; set; }
        public Categorias Categoria { get; set; }
        public Marcas Marcas { get; set; }


                
    }
}
