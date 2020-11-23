using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WatchStore.Models
{
    public class Categoria_producto
    {
        public int categoriaID { get; set; }
        public int productoID { get; set; }

        public Categoria Categoria { get; set; }
        public Producto Producto { get; set; }
    }
}
