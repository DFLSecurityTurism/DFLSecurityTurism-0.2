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
    public class InquéritoController : Controller
    {
        private readonly ApplicationDbContext dbContext;
        private readonly IWebHostEnvironment webHostEnvironment;
        public InquéritoController(ApplicationDbContext context, IWebHostEnvironment hostEnvironment)
        {
            dbContext = context;
            webHostEnvironment = hostEnvironment;
        }

        public async Task<IActionResult> Index()
        {
            var inquérito = await dbContext.Inquérito.ToListAsync();
            return View(inquérito);
        }

        [Authorize]
        public IActionResult New()
        {
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        
        public async Task<IActionResult> New(InquéritoViewModel model)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = UploadedFile(model);

                Inquérito inquérito = new Inquérito
                {
                    TipoDeEstabelecimento = model.TipoDeEstabelecimento,
                    Nome = model.Nome,
                    QuantosCertificadosDeSegurançaTem = model.QuantosCertificadosDeSegurançaTem,
                    QuaisSão = model.QuaisSão,
                    QueMecanismosDeSegurançaOEstabelecimentoUtiliza = model.QueMecanismosDeSegurançaOEstabelecimentoUtiliza,
                    QuantosEquipamentosDeSegurançaOEstabelecimentoUtiliza = model.QuantosEquipamentosDeSegurançaOEstabelecimentoUtiliza,
                    QuaisSãoOsEquipamentosDeSegurançaQueTem = model.QuaisSãoOsEquipamentosDeSegurançaQueTem,
                    Imagem = uniqueFileName,
                };
                dbContext.Add(inquérito);
                await dbContext.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        private string UploadedFile(InquéritoViewModel model)
        {
            string uniqueFileName = null;

            if (model.Imagem != null)
            {
                string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "images");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.Imagem.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.Imagem.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
        }
    }
}
