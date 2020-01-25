using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Group.Data;
using Group.Models;

namespace Group.Controllers
{
    public class MappersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MappersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Mappers
        public async Task<IActionResult> Index()
        {
            return View(await _context.Mappers.ToListAsync());
        }

        // GET: Mappers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mapper = await _context.Mappers
                .FirstOrDefaultAsync(m => m.MapperID == id);
            if (mapper == null)
            {
                return NotFound();
            }

            return View(mapper);
        }

      
        // GET: Mappers/Create
        public IActionResult Register()
        {
            return View();
        }

        // POST: Mappers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("firstName,lastName,password,phoneNumber,email,currentBase,notifications,publicOrPrivate")] Mapper mapper)
        {
            if (ModelState.IsValid)
            {
                _context.Add(mapper);
                await _context.SaveChangesAsync();
                return View("worldoverview"); 
            }
            return View(mapper);
        }

        // GET: Mappers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mapper = await _context.Mappers.FindAsync(id);
            if (mapper == null)
            {
                return NotFound();
            }
            return View(mapper);
        }

        // POST: Mappers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MapperID,firstName,lastName,password,phoneNumber,email,currentBase,notifications,publicOrPrivate")] Mapper mapper)
        {
            if (id != mapper.MapperID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mapper);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MapperExists(mapper.MapperID))
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
            return View(mapper);
        }

        // GET: Mappers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mapper = await _context.Mappers
                .FirstOrDefaultAsync(m => m.MapperID == id);
            if (mapper == null)
            {
                return NotFound();
            }

            return View(mapper);
        }

        // POST: Mappers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var mapper = await _context.Mappers.FindAsync(id);
            _context.Mappers.Remove(mapper);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MapperExists(int id)
        {
            return _context.Mappers.Any(e => e.MapperID == id);
        }
    }
}
