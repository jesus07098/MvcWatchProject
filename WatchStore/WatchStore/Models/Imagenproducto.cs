using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WatchStore.Models
{
    public class Imagenproducto
    {
        public int imagenproductoID { get; set; }
        public int productoID { get; set; }
        public string urlimagen { get; set; }

        public Producto Producto { get; set; }

    }
}
