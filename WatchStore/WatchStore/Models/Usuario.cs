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

        public ICollection<Direccion> Direcciones { get; set; }
        public ICollection<Rol_usuario> Roles_usuario { get; set; }
        public ICollection<Itemcarrito> Itemscarrito { get; set; }
        public ICollection<Pedido> Pedidos { get; set; }

    }
}
