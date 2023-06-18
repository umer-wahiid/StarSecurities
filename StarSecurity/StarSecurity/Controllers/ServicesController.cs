using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StarSecurity.Models;

namespace StarSecurity.Controllers
{
    public class ServicesController : Controller
    {
        private readonly StarSecurityDbContext _context;
        IWebHostEnvironment iw;

        public ServicesController(StarSecurityDbContext context, IWebHostEnvironment i)
        {
            _context = context;
            iw = i;
        }

        // GET: Services
        public async Task<IActionResult> Index()
        {
              return _context.Services != null ? 
                          View(await _context.Services.ToListAsync()) :
                          Problem("Entity set 'StarSecurityDbContext.Services'  is null.");
        }

        // GET: Services/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Services == null)
            {
                return NotFound();
            }

            var services = await _context.Services
                .FirstOrDefaultAsync(m => m.ServicesId == id);
            if (services == null)
            {
                return NotFound();
            }

            return View(services);
        }

        // GET: Services/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Services/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Services services, IFormFile image)
        {
            if (image != null)
            {
                string ext = Path.GetExtension(image.FileName);
                if(ext == ".jpg" || ext == ".png" || ext == ".jpeg")
                {
                    string d = Path.Combine(iw.WebRootPath, "Image");
                    var fname = Path.GetFileName(image.FileName);
                    string filepath = Path.Combine(d, fname);
                    using (var fs = new FileStream(filepath, FileMode.Create))
                    {
                        await image.CopyToAsync(fs);
                    }
                    services.ServiceLogo = @"Image/" + fname;
                    _context.Add(services);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }
            return View(services);
        }

        // GET: Services/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Services == null)
            {
                return NotFound();
            }

            var services = await _context.Services.FindAsync(id);
            if (services == null)
            {
                return NotFound();
            }
            return View(services);
        }

        // POST: Services/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Services services, IFormFile image)
        {
            if (image != null)
            {

            }
            string ext = Path.GetExtension(image.FileName);
            if (ext == ".jpg" || ext == ".png" || ext == ".jpeg")
            {
                string d = Path.Combine(iw.WebRootPath, "Image");
                var fname = Path.GetFileName(image.FileName);
                string filepath = Path.Combine(d, fname);
                using (var fs = new FileStream(filepath, FileMode.Create))
                {
                    await image.CopyToAsync(fs);
                }
                services.ServiceLogo = @"Image/" + fname;
                _context.Update(services);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(services);
        }

        // GET: Services/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Services == null)
            {
                return NotFound();
            }

            var services = await _context.Services
                .FirstOrDefaultAsync(m => m.ServicesId == id);
            if (services == null)
            {
                return NotFound();
            }

            return View(services);
        }

        // POST: Services/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Services == null)
            {
                return Problem("Entity set 'StarSecurityDbContext.Services'  is null.");
            }
            var services = await _context.Services.FindAsync(id);
            if (services != null)
            {
                _context.Services.Remove(services);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ServicesExists(int id)
        {
          return (_context.Services?.Any(e => e.ServicesId == id)).GetValueOrDefault();
        }
    }
}
