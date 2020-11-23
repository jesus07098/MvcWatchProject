using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WatchStore.Models
{
    public class Direccion
    {
        public int direccionID { get; set; }
        public int usuarioID { get; set; }
        public int provinciaID { get; set; }
        public string direcdetalles1 { get; set; }
        public string direcdetalles2 { get; set; }
        public int codigopostal { get; set; }

        public Provincia Provincia { get; set; }
        public Usuario Usuario { get; set; }
    }
}
