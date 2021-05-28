using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.IO;
using System.Threading.Tasks;
using DFLSecurityTurism_0._2.Data;
using DFLSecurityTurism_0._2.ViewModels;
using DFLSecurityTurism_0._2.Models;
using Microsoft.AspNetCore.Authorization;

namespace DFLSecurityTurism_0._2.Controllers
{
    public class AvaliacaoRestaurantesController : Controller
    {
        private readonly ApplicationDbContext dbContext;
        private readonly IWebHostEnvironment webHostEnvironment;

        public AvaliacaoRestaurantesController(ApplicationDbContext context, IWebHostEnvironment hostEnvironment)
        {
            dbContext = context;
            webHostEnvironment = hostEnvironment;
        }

        // GET: AvaliacaoRestaurantes
        public async Task<IActionResult> Index()
        {
            var avaliacaoo = await dbContext.AvaliacaoRestaurante.ToListAsync();
            return View(avaliacaoo);
        }

        [Authorize]
        public IActionResult New()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> New(AvaliacaoRestauranteViewModel model)
        {
            if (ModelState.IsValid)
            {

                AvaliacaoRestaurante avaliacaoRestaurante = new AvaliacaoRestaurante
                {
                    Restaurante = model.Restaurante,
                    Classifique = model.Classifique,
                    Equipamentos = model.Equipamentos,
                    Período = model.Período,
                    Procedimentos = model.Procedimentos,
                    Recomendação = model.Recomendação,
                    Comentário = model.Comentário,

                };
                dbContext.Add(avaliacaoRestaurante);
                await dbContext.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
    }
}