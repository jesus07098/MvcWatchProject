using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WatchStore.Models
{
    public class Provincia
    {
        public int provinciaID { get; set; }
        public string desprovincia { get; set; }
        public ICollection<Direccion> Direcciones { get; set; }
        public ICollection<Pedido> Pedidos { get; set; }

    }
}
