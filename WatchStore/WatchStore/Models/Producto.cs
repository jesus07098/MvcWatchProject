using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WatchStore.Models
{
    public class Producto
    {
        public int productoID { get; set; }
        public int marcaID { get; set; }
        public string pronombre { get; set; }
        public double proprecio { get; set; }
        public string prodescripcion { get; set; }
        public int prostock { get; set; }

        public Marca Marca { get; set; }


        public ICollection<Categoria_producto> Categorias_producto { get; set; }
        public ICollection<Imagenproducto> Imagenesproducto { get; set; }
        public ICollection<Itemcarrito> Itemscarrito { get; set; }
        public ICollection<Detallepedido> Detallespedido { get; set; }


    }
}
