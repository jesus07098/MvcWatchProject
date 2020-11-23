using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WatchStore.Models
{
    public class Rol_usuario
    {
        public int rolID { get; set; }

        public int usuarioID { get; set; }

        public DateTime fecharegistro { get; set; }

        public Rol Rol { get; set; }
        public Usuario Usuario { get; set; }

    }
}
