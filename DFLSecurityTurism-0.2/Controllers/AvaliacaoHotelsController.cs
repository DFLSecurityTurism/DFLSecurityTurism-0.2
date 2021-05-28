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
    public class AvaliacaoHotelsController : Controller
    {
        private readonly ApplicationDbContext dbContext;
        private readonly IWebHostEnvironment webHostEnvironment;

        public AvaliacaoHotelsController(ApplicationDbContext context, IWebHostEnvironment hostEnvironment)
        {
            dbContext = context;
            webHostEnvironment = hostEnvironment;
        }

        // GET: AvaliacaoHotels
        public async Task<IActionResult> Index()
        {
            var avaliacao = await dbContext.AvaliacaoHotel.ToListAsync();
            return View(avaliacao);
        }

        [Authorize]
        public IActionResult New()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> New(AvaliacaoHotelViewModel model)
        {
            if (ModelState.IsValid)
            {

                AvaliacaoHotel avaliacaoHotel = new AvaliacaoHotel
                {
                    Hotel = model.Hotel,
                    Classifique = model.Classifique,
                    Equipamentos = model.Equipamentos,
                    Período = model.Período,
                    Procedimentos = model.Procedimentos,
                    Recomendação = model.Recomendação,
                    Comentário = model.Comentário,
                    
                };
                dbContext.Add(avaliacaoHotel);
                await dbContext.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
    }
}
