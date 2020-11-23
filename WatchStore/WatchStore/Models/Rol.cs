using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WatchStore.Models
{
    public class Rol
    {
        public int rolID { get; set; }
        public string titulorol { get; set; }

        public ICollection<Rol_usuario> Roles_usuario { get; set; }
    }
}
