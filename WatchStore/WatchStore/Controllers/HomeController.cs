using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WatchStore.Data;
using WatchStore.Models;
using Microsoft.EntityFrameworkCore;
using WatchStore.Models.CustomModels;

namespace WatchStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly DbWatchContext _context;

        public HomeController(DbWatchContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var model = new HomeModel();
            model.Marca = await _context.Marcas.ToListAsync();
            model.Producto = await _context.Productos
                .Include(p => p.Imagenesproducto)
                .AsNoTracking()
                .ToListAsync();
            return View(model);
            //return View();
        }



        public async Task<IActionResult> Marca(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var marca = await _context.Marcas
                .Include(s => s.Productos)
                .ThenInclude(e => e.Imagenesproducto)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.marcaID == id);
            if (marca == null)
            {
                return NotFound();
            }

            return View(marca);
        }

        public async Task<IActionResult> Carrito(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuarios
                .Include(s => s.Itemscarrito)
                .ThenInclude(s => s.Producto)
                .ThenInclude(e => e.Imagenesproducto)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.usuarioID == id);
            if (usuario == null)
            {
                return NotFound();
            }

            return View(usuario);
        }

        public async Task<IActionResult> Producto(int? id)
        {
            var model = new ProductouserModel();

            if (id == null)
            {
                return NotFound();
            }

            model.Producto = await _context.Productos
                .Include(s => s.Imagenesproducto)
                .Include(m => m.Marca)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.productoID == id);
            if (model.Producto == null)
            {
                return NotFound();
            }

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Agregar([Bind("usuarioID,productoID,cantidadproducto")] Itemcarrito itemcarrito)
        {
            Console.WriteLine("HHHHHHHHHHHHHHHHHHHHHSDFSDFSDFSDFDSDF" + itemcarrito.productoID );
                _context.Add(itemcarrito);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));

        }



        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
