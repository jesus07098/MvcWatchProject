using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WatchStore.Models.CustomModels
{
    public class HomeModel
    {

        public IEnumerable<Marca> Marca { get; set; }
        public IEnumerable<Producto> Producto { get; set; }
    }
}
