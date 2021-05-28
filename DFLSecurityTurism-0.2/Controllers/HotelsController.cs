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
    public class HotelsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HotelsController(ApplicationDbContext context)
        {
            _context = context;
        }

      
        List<Hotel> _lista = new List<Hotel>()
        {
           
            new Hotel(){Nome="Vila Gale Coimbra", Imagem="Imagem2.jpg", Descrição1="Descrição:Tem de se criar um", Descrição2="texto para descrever", Descrição3="as informações", Descrição4="sobre o covid-19"},
            new Hotel(){Nome="Hotel Ibis Coimbra", Imagem="Imagem4.jpg", Descrição1="Covid"},
            new Hotel(){Nome="Hotel Quinta das Lagrimas", Imagem="Imagem3.jpg", Descrição1="Covid"},
            new Hotel(){Nome="Hotel D. Luis", Imagem="Imagem1.jpg", Descrição1="Covid"}
           
        };

        // GET: Hotels
        public IActionResult Index()
        {
            return View(_lista);
        }

        
    }
}
