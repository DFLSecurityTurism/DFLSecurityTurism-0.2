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
           
            new Hotel(){Nome="Hotel Vila Gale Coimbra", Imagem="Imagem2.jpg", Descrição1="Certificações: Clean & Safe.", Descrição2="Mecanismos de segurança: Divisórias de vidro,", Descrição3="disponibilização de álcool/gel, toalhetes de papel e máscara.", Descrição4="Quantidade de equipamentos de segurança: 1.",  Descrição5="Equipamentos de segurança: Suporte de chão com dispensador de álcool."},
            new Hotel(){Nome="Hotel Ibis Coimbra", Imagem="Imagem4.jpg", Descrição1="Certificações: Clean & Safe.", Descrição2="Mecanismos de segurança: Divisórias de vidro,", Descrição3="disponibilização de álcool/gel, toalhetes de papel e máscara.", Descrição4="Quantidade de equipamentos de segurança: 1.",  Descrição5="Equipamentos de segurança: Suporte de chão com dispensador de álcool."},
            new Hotel(){Nome="Hotel Quinta das Lagrimas", Imagem="Imagem3.jpg",Descrição1="Certificações: Clean & Safe.", Descrição2="Mecanismos de segurança: Divisórias de vidro,", Descrição3="disponibilização de álcool/gel, toalhetes de papel e máscara.", Descrição4="Quantidade de equipamentos de segurança: 1.",  Descrição5="Equipamentos de segurança: Suporte de chão com dispensador de álcool."},
            new Hotel(){Nome="Hotel D. Luis", Imagem="Imagem1.jpg", Descrição1="Certificações: Clean & Safe.", Descrição2="Mecanismos de segurança: Divisórias de vidro,", Descrição3="disponibilização de álcool/gel, toalhetes de papel e máscara.", Descrição4="Quantidade de equipamentos de segurança: 1.",  Descrição5="Equipamentos de segurança: Suporte de chão com dispensador de álcool."}
        };

        // GET: Hotels
        public IActionResult Index()
        {
            return View(_lista);
        }

        
    }
}
