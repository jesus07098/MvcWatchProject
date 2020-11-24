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
