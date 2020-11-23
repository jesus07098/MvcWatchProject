using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WatchStore.Models
{
    public class Categoria
    {
        public int categoriaID { get; set; }
        public string nombrecategoria { get; set; }


        public ICollection<Categoria_producto> Categorias_producto { get; set; }

    }
}
