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

            new Restaurante(){Nome="Solar do bacalhau", Imagem="Imagem1.jpg", Descrição1="Certificações:", Descrição2="Mecanismos de segurança:", Descrição3="Quantidade de equipamentos de segurança:", Descrição4="Quais são os equipamentos de segurança:"},
            new Restaurante(){Nome="Restaurante Italia", Imagem="Imagem2.jpg", Descrição1="Certificações:", Descrição2="Mecanismos de segurança:", Descrição3="Quantidade de equipamentos de segurança:", Descrição4="Quais são os equipamentos de segurança:"},
            new Restaurante(){Nome="Restaurante Notes Bar & Kitchen", Imagem="Imagem3.png", Descrição1="Certificações:", Descrição2="Mecanismos de segurança:", Descrição3="Quantidade de equipamentos de segurança:", Descrição4="Quais são os equipamentos de segurança:"},
            new Restaurante(){Nome="Restaurante Café Atenas", Imagem="Imagem4.jpg", Descrição1="Certificações:", Descrição2="Mecanismos de segurança:", Descrição3="Quantidade de equipamentos de segurança:", Descrição4="Quais são os equipamentos de segurança:"},

        };

        // GET: Hotels
        public IActionResult Index()
        {
            return View(_lista);
        }
    }
}
