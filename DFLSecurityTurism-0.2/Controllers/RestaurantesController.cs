using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DFLSecurityTurism_0._2.Data;
using DFLSecurityTurism_0._2.Models;

namespace DFLSecurityTurism_0._2.Controllers
{
    public class RestaurantesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RestaurantesController(ApplicationDbContext context)
        {
            _context = context;
        }

        List<Restaurante> _lista = new List<Restaurante>()
        {

            new Restaurante(){Nome="Solar do bacalhau", Imagem="Imagem1.jpg", Descrição1="Descrição:Tem de se criar um", Descrição2="texto para descrever", Descrição3="as informações", Descrição4="sobre o covid-19"},
            new Restaurante(){Nome="Restaurante italia", Imagem="Imagem2.jpg", Descrição1="Covid"}

        };

        // GET: Hotels
        public IActionResult Index()
        {
            return View(_lista);
        }
    }
}
