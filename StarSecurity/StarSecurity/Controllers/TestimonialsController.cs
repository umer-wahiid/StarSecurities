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
    public class TestimonialsController : Controller
    {
        private readonly StarSecurityDbContext _context;
        IWebHostEnvironment iw;

        public TestimonialsController(StarSecurityDbContext context, IWebHostEnvironment i)
        {
            _context = context;
            iw = i;
        }

        // GET: Testimonials
        public async Task<IActionResult> Index()
        {
              return _context.Testimonials != null ? 
                          View(await _context.Testimonials.ToListAsync()) :
                          Problem("Entity set 'StarSecurityDbContext.Testimonials'  is null.");
        }

        // GET: Testimonials/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Testimonials == null)
            {
                return NotFound();
            }

            var testimonials = await _context.Testimonials
                .FirstOrDefaultAsync(m => m.TestimonialsId == id);
            if (testimonials == null)
            {
                return NotFound();
            }

            return View(testimonials);
        }

        // GET: Testimonials/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Testimonials/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Testimonials testimonials, IFormFile image)
        {
            if (image != null)
            {
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
                    testimonials.TImage = @"Image/" + fname;
                    _context.Add(testimonials);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }
            return View(testimonials);
        }

        // GET: Testimonials/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Testimonials == null)
            {
                return NotFound();
            }

            var testimonials = await _context.Testimonials.FindAsync(id);
            if (testimonials == null)
            {
                return NotFound();
            }
            return View(testimonials);
        }

        // POST: Testimonials/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Testimonials testimonials, IFormFile image)
        {
            if (image != null)
            {
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
                    testimonials.TImage = @"Image/" + fname;
                    _context.Update(testimonials);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }
            return View(testimonials);
        }

        // GET: Testimonials/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Testimonials == null)
            {
                return NotFound();
            }

            var testimonials = await _context.Testimonials
                .FirstOrDefaultAsync(m => m.TestimonialsId == id);
            if (testimonials == null)
            {
                return NotFound();
            }

            return View(testimonials);
        }

        // POST: Testimonials/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Testimonials == null)
            {
                return Problem("Entity set 'StarSecurityDbContext.Testimonials'  is null.");
            }
            var testimonials = await _context.Testimonials.FindAsync(id);
            if (testimonials != null)
            {
                _context.Testimonials.Remove(testimonials);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TestimonialsExists(int id)
        {
          return (_context.Testimonials?.Any(e => e.TestimonialsId == id)).GetValueOrDefault();
        }
    }
}
