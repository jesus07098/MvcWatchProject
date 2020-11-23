using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WatchStore.Models
{
    public class Usuario
    {
        public int usuarioID { get; set; }
        public string nombre { get; set; }
        public string emailusuario { get; set; }
        public string passwordusuario { get; set; }

        public DateTime fechacreacion { get; set; }

        public virtual ICollection<Direccion> Direcciones { get; set; }

    }
}
