using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WatchStore.Models
{
    public class Itemcarrito
    {
        public int usuarioID { get; set; }
        public int productoID { get; set; }
        public int cantidadproducto { get; set; }
        public Producto Producto { get; set; }

    }
}
