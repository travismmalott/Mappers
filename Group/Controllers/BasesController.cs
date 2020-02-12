using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Group.Data;
using Group.Models;
using Mappers.Model;

namespace Mappers.Controllers
{
    public class BasesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BasesController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult LewisMcChord() 
        {
            return View();
        }
        public IActionResult Everett()
        {
            return View();
        }
        public IActionResult FortSamHouston()
        {
            return View();
        }

        public IActionResult LacklandAFB()
        {
            return View();
        }

        public IActionResult WalterReedMedical()
        {
            return View();
        }

        public IActionResult FortMeade() 
        {
            return View();
        }
        public IActionResult EverttNAS()
        {
            return View();
        }
        // GET: Bases
        public async Task<IActionResult> Index()
        {
            return View(await _context.Bases.ToListAsync());
        }

        // GET: Bases/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @base = await _context.Bases
                .FirstOrDefaultAsync(m => m.BaseID == id);
            if (@base == null)
            {
                return NotFound();
            }

            return View(@base);
        }

        // GET: Bases/Create
        public IActionResult Create()
        {
            //Get branches for viewbag
            var branches = _context.
               Branches
               .Select(x =>
               new SelectListItem(x.Branches, x.BranchID.ToString()))
           .ToList();
            //Get states for Viewbag 
            var states = _context.
              States
               .Select(x =>
               new SelectListItem(x.Name, x.StateID.ToString()))
           .ToList();
            

            //Creates ViewBags for dropdowns to access
            ViewBag.States = states;            
            ViewBag.Branches = branches;
            return View();

        }

        // POST: Bases/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BaseID,City,BaseName")] Base @base, int branchID, int stateID)
        {
            var branch = _context
             .Branches
             .SingleOrDefault(x => x.BranchID == branchID);
            //this attaches existing Branch to the new Base
            @base.Branch = branch;

            var state = _context
             .States
             .SingleOrDefault(x => x.StateID == stateID);
            //this attaches existing State to the new Base
            @base.State = state;
            //adds StateName to Base in database
            @base.StateName = state.Name;
           //@base.


        

            if (ModelState.IsValid)
            {
                
                _context.Add(@base);
                branch.Bases.Add(@base);
                state.Bases.Add(@base);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(@base);
        }

        // GET: Bases/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @base = await _context.Bases.FindAsync(id);
            if (@base == null)
            {
                return NotFound();
            }
            return View(@base);
        }

        // POST: Bases/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("BaseID,City,State,BaseName")] Base @base)
        {
            if (id != @base.BaseID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(@base);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BaseExists(@base.BaseID))
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
            return View(@base);
        }

        // GET: Bases/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @base = await _context.Bases
                .FirstOrDefaultAsync(m => m.BaseID == id);
            if (@base == null)
            {
                return NotFound();
            }

            return View(@base);
        }

        // POST: Bases/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var @base = await _context.Bases.FindAsync(id);
            _context.Bases.Remove(@base);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BaseExists(int id)
        {
            return _context.Bases.Any(e => e.BaseID == id);
        }
    }
}
