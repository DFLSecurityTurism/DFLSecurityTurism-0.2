using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DFLSecurityTurism_0._2.Data;
using DFLSecurityTurism_0._2.Models;
using Microsoft.AspNetCore.Authorization;

namespace DFLSecurityTurism_0._2.Controllers
{
    public class InquéritoController : Controller
    {
        private readonly ApplicationDbContext _context;

        public InquéritoController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Inquérito
        public async Task<IActionResult> Index()
        {
            return View(await _context.Inquérito.ToListAsync());
        }

        // GET: Inquérito/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inquérito = await _context.Inquérito
                .FirstOrDefaultAsync(m => m.Id == id);
            if (inquérito == null)
            {
                return NotFound();
            }

            return View(inquérito);
        }

        // GET: Inquérito/Create
        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Inquérito/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Tipodeestabelecimento,Nome,Quantoscertificadosdesegurançatem,Quaissão,QueMecanismosdesegurançaoestabelecimentoutiliza,Quantosequipamentosdesegurançaoestabelecimentoutiliza,Quaissãoo")] Inquérito inquérito)
        {
            if (ModelState.IsValid)
            {
                _context.Add(inquérito);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(inquérito);
        }

        // GET: Inquérito/Edit/5
        [Authorize]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inquérito = await _context.Inquérito.FindAsync(id);
            if (inquérito == null)
            {
                return NotFound();
            }
            return View(inquérito);
        }

        // POST: Inquérito/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
       
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Tipodeestabelecimento,Nome,Quantoscertificadosdesegurançatem,Quaissão,QueMecanismosdesegurançaoestabelecimentoutiliza,Quantosequipamentosdesegurançaoestabelecimentoutiliza,Quaissãoo")] Inquérito inquérito)
        {
            if (id != inquérito.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(inquérito);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InquéritoExists(inquérito.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(inquérito);
        }

        // GET: Inquérito/Delete/5

        [Authorize]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inquérito = await _context.Inquérito
                .FirstOrDefaultAsync(m => m.Id == id);
            if (inquérito == null)
            {
                return NotFound();
            }

            return View(inquérito);
        }

        // POST: Inquérito/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var inquérito = await _context.Inquérito.FindAsync(id);
            _context.Inquérito.Remove(inquérito);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InquéritoExists(int id)
        {
            return _context.Inquérito.Any(e => e.Id == id);
        }
    }
}
