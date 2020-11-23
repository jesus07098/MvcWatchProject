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

namespace WatchStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly DbWatchContext _context;
        private readonly ILogger<HomeController> _logger;

        public HomeController(DbWatchContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Marcas.ToListAsync());
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
