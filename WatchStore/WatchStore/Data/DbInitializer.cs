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
            new Models.Marca{nombremarca="Breitling", urlimagen="/images/marcas/brei.jpg"},
            new Models.Marca{nombremarca="Casio", urlimagen="/images/marcas/casio.jpg"},
            new Models.Marca{nombremarca="Hugo", urlimagen="/images/marcas/hugo.jpg"},
            new Models.Marca{nombremarca="Iron", urlimagen="/images/marcas/iron.jpg"},
            new Models.Marca{nombremarca="omega", urlimagen="/images/marcas/omega.jpg"},
            new Models.Marca{nombremarca="Bulova", urlimagen="/images/marcas/bulova.jpg"},
            new Models.Marca{nombremarca="Citizen", urlimagen="/images/marcas/citizen.jpg"},
            new Models.Marca{nombremarca="Rolex", urlimagen="/images/marcas/rolex.jpg"}
            };
            foreach (Marca m in marcas)
            {
                context.Marcas.Add(m);
            }
            context.SaveChanges();


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
            new Models.Provincia{desprovincia="Chemistry"},
            new Models.Provincia{desprovincia="Microeconomics"},
            new Models.Provincia{desprovincia="Macroeconomics"},
            new Models.Provincia{desprovincia="Calculus"},
            new Models.Provincia{desprovincia="Trigonometry"},
            new Models.Provincia{desprovincia="Composition"},
            new Models.Provincia{desprovincia="Literature"}
            };
            foreach (Provincia p in provincias)
            {
                context.Provincias.Add(p);
            }
            context.SaveChanges();
  

            var productos = new Producto[]
           {
            new Models.Producto{marcaID=1,pronombre="Townsman Automatic Dark wood Leather Watch", proprecio=344.00, prodescripcion="Sistema operativo: Desarrollado con Wear OS de GoogleCompatibilidad: use la aplicación Google WearOS en su teléfono con Android ™ 6.0+ (excluyendo la edición Go), iOS 12.0+Procesador: Qualcomm® Snapdragon ™ Wear 3100Memoria: 1 GB de RAM, 8 GB de almacenamientoPantalla: 1.28 AMOLED / 416 x 416 / 328ppiEntrada: 2 pulsadores adicionales(configurables), botón de inicio giratorio, pantalla táctil, vozSonido / Actuador: Altavoz, Micrófono, Vibración", prostock=2},
            new Models.Producto{marcaID=1,pronombre="Creative Simplicity mujeres reloj de cuero genuino elegante mujeres ", proprecio=200, prodescripcion="", prostock=2},
            new Models.Producto{marcaID=1,pronombre="Breitling Superocean Heritage aviator", proprecio=550, prodescripcion="", prostock=2},
            new Models.Producto{marcaID=2,pronombre="SmartWatch  Black Watch Wear OS by Google", proprecio=252, prodescripcion="", prostock=2}
           };

            foreach (Producto x in productos)
            {
                context.Productos.Add(x);
            }
            context.SaveChanges();


            var imagenesproductos = new Imagenproducto[]
           {
            new Models.Imagenproducto{productoID=4,urlimagen="/images/relojes/townsman 2.jpg"},
            new Models.Imagenproducto{productoID=4,urlimagen="/images/relojes/townsman 3.jpg"},
            new Models.Imagenproducto{productoID=4,urlimagen="/images/relojes/townsman automatic.jpg"},
            new Models.Imagenproducto{productoID=3,urlimagen="/images/relojes/2.jpg"},
            new Models.Imagenproducto{productoID=2,urlimagen="/images/relojes/breitling-blue.jpg"},
            new Models.Imagenproducto{productoID=1,urlimagen="/images/relojes/smartwatch.jpg"}
           };
            foreach (Imagenproducto x in imagenesproductos)
            {
                context.Imagenesproducto.Add(x);
            }
            context.SaveChanges();




        }

    }
}
