using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WatchStore.Models
{
    public class Pedido
    {
        public int pedidoID { get; set; }
        public int usuarioID { get; set; }
        public string direccionpedido { get; set; }
        public int provinciaID { get; set; }
        public double costetotal { get; set; }
        public int numproductos { get; set; }
        public DateTime fechapedido { get; set; }

        public Usuario Usuario { get; set; }
        public Provincia Provincia { get; set; }

        public ICollection<Detallepedido> Detallespedido { get; set; }
    }
}
