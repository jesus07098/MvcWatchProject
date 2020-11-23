using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WatchStore.Models
{
    public class Detallepedido
    {
        public int pedidoID { get; set; }
        public int productoID { get; set; }
        public int cantidadproducto { get; set; }
        public double preciopro  { get; set; }

        public Pedido Pedido { get; set; }
        public Producto Producto { get; set; }
        
    }
}
