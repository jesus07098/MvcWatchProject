using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WatchStore.Models;

namespace WatchStore.Data
{
    public class DbInitializer
    {
        public static void Initialize(DbWatchContext context)
        {
            context.Database.EnsureCreated();

            if (context.Marcas.Any())
            {
                return;   // DB has been seeded
            }

            var marcas = new Marca[]
            {
            new Models.Marca{nombremarca="Breitling", urlimagen="/images/brei.jpg"},
            new Models.Marca{nombremarca="Casio", urlimagen="/images/casio.jpg"},
            new Models.Marca{nombremarca="Hugo", urlimagen="/images/hugo.jpg"},
            new Models.Marca{nombremarca="Iron", urlimagen="/images/iron.jpg"},
            new Models.Marca{nombremarca="omega", urlimagen="/images/omega.jpg"},
            new Models.Marca{nombremarca="Bulova", urlimagen="/images/bulova.jpg"},
            new Models.Marca{nombremarca="Citizen", urlimagen="/images/citizen.jpg"},
            new Models.Marca{nombremarca="Rolex", urlimagen="/images/rolex.jpg"}
            };
            foreach (Marca m in marcas)
            {
                context.Marcas.Add(m);
            }
            context.SaveChanges();



            // Look for any user.
            if (context.Usuarios.Any())
            {
                return;   // DB has been seeded
            }

            var usuarios = new Usuario[]
            {
            new Models.Usuario{nombre="Carson",emailusuario="Alexander",fechacreacion=DateTime.Parse("2005-09-01")},
            new Models.Usuario{nombre="Meredith",emailusuario="Alonso",fechacreacion=DateTime.Parse("2002-09-01")},
            new Models.Usuario{nombre="Arturo",emailusuario="Anand",fechacreacion=DateTime.Parse("2003-09-01")},
            new Models.Usuario{nombre="Gytis",emailusuario="Barzdukas",fechacreacion=DateTime.Parse("2002-09-01")},
            new Models.Usuario{nombre="Yan",emailusuario="Li",fechacreacion=DateTime.Parse("2002-09-01")},
            new Models.Usuario{nombre="Peggy",emailusuario="Justice",fechacreacion=DateTime.Parse("2001-09-01")},
            new Models.Usuario{nombre="Laura",emailusuario="Norman",fechacreacion=DateTime.Parse("2003-09-01")},
            new Models.Usuario{nombre="Nino",emailusuario="Olivetto",fechacreacion=DateTime.Parse("2005-09-01")}
            };
            foreach (Usuario u in usuarios)
            {
                context.Usuarios.Add(u);
            }
            context.SaveChanges();

            var provincias = new Provincia[]
            {
            new Models.Provincia{provinciaID=1050,desprovincia="Chemistry"},
            new Models.Provincia{provinciaID=4022,desprovincia="Microeconomics"},
            new Models.Provincia{provinciaID=4041,desprovincia="Macroeconomics"},
            new Models.Provincia{provinciaID=1045,desprovincia="Calculus"},
            new Models.Provincia{provinciaID=3141,desprovincia="Trigonometry"},
            new Models.Provincia{provinciaID=2021,desprovincia="Composition"},
            new Models.Provincia{provinciaID=2042,desprovincia="Literature"}
            };

            foreach (Provincia p in provincias)
            {
                context.Provincias.Add(p);
            }
            context.SaveChanges();

            var direcciones = new Direccion[]
            {
            new Models.Direccion{usuarioID=1,provinciaID=1050},
            new Models.Direccion{usuarioID=1,provinciaID=4022},
            new Models.Direccion{usuarioID=1,provinciaID=4041},
            new Models.Direccion{usuarioID=2,provinciaID=1045},
            new Models.Direccion{usuarioID=2,provinciaID=3141},
            new Models.Direccion{usuarioID=2,provinciaID=2021},
            new Models.Direccion{usuarioID=3,provinciaID=1050},
            new Models.Direccion{usuarioID=4,provinciaID=1050},
            new Models.Direccion{usuarioID=4,provinciaID=4022},
            new Models.Direccion{usuarioID=5,provinciaID=4041},
            new Models.Direccion{usuarioID=6,provinciaID=1045},
            new Models.Direccion{usuarioID=7,provinciaID=3141}
            };
            foreach (Direccion d in direcciones)
            {
                context.Direcciones.Add(d);
            }
            context.SaveChanges();
        }

    }
}
