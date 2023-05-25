using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CoCWebForm.Data;
using CoCWebForm.Models;

namespace CoCWebForm.Controllers
{
    public class ClientModelsController : Controller
    {
        private readonly CoCWebFormContext _context;

        public ClientModelsController(CoCWebFormContext context)
        {
            _context = context;
        }

        // GET: ClientModels
        public async Task<IActionResult> Index()
        {
              return _context.ClientModel != null ? 
                          View(await _context.ClientModel.ToListAsync()) :
                          Problem("Entity set 'CoCWebFormContext.ClientModel'  is null.");
        }

        // GET: ClientModels/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.ClientModel == null)
            {
                return NotFound();
            }

            var clientModel = await _context.ClientModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (clientModel == null)
            {
                return NotFound();
            }

            return View(clientModel);
        }

        // GET: ClientModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ClientModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,SessionId,Email,WorkOrderNum")] ClientModel clientModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(clientModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(clientModel);
        }

        // GET: ClientModels/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.ClientModel == null)
            {
                return NotFound();
            }

            var clientModel = await _context.ClientModel.FindAsync(id);
            if (clientModel == null)
            {
                return NotFound();
            }
            return View(clientModel);
        }

        // POST: ClientModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,SessionId,Email,WorkOrderNum")] ClientModel clientModel)
        {
            if (id != clientModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(clientModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClientModelExists(clientModel.Id))
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
            return View(clientModel);
        }

        // GET: ClientModels/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.ClientModel == null)
            {
                return NotFound();
            }

            var clientModel = await _context.ClientModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (clientModel == null)
            {
                return NotFound();
            }

            return View(clientModel);
        }

        // POST: ClientModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.ClientModel == null)
            {
                return Problem("Entity set 'CoCWebFormContext.ClientModel'  is null.");
            }
            var clientModel = await _context.ClientModel.FindAsync(id);
            if (clientModel != null)
            {
                _context.ClientModel.Remove(clientModel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClientModelExists(string id)
        {
          return (_context.ClientModel?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
