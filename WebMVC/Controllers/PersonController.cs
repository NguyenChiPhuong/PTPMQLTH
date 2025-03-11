using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebMvc.Models;
using WebMVC.Data;
namespace WebMVC.Controllers
{
    public class PersonController : Controller
    {
        private readonly ApplicationDbContext _context;
        public PersonController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var model = await _context.Person.ToListAsync();
            return View(model);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Blind( "PersonId, FullName, Address")] Person ps)
    {
        if (ModelState.IsValid)
        {
            _context.Add(ps);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(ps);
    }
  
    public async Task<IActionResult> Edit(string id)
    {
        if (id == null)
        {
            return NotFound();
        }
        var ps = await _context.Person.FindAsync(id);
        if (ps == null)
        {
            return NotFound();
        }
        return View(ps);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(string id, [Blind( "PersonId, FullName, Address")] Person ps)
    {
        if (id != ps.PersonId)
        {
            return NotFound();
        }
        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(ps);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PersonExists(ps.PersonId))
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
        return View(ps);
    }
    public async Task<IActionResult> Delete(string id)
    {
        if (id == null)
        {
            return NotFound();
        }
        var ps = await _context.Person.FirstOrDefaultAsync(m => m.PersonId == id);
        if (ps == null)
        {
            return NotFound();
        }
        return View(ps);
    }

    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        if (_context.Person == null)
        {
            return Problem("Entity set 'ApplicationDbContext.Person'  is null.");
        }
        var ps = await _context.Person.FindAsync(id);
        if (ps != null)
        {
            _context.Person.Remove(ps);
        }
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }
    private bool PersonExists(string id)
    {
        return _context.Person.Any(e => e.PersonId == id);
    }
    }

    internal class BlindAttribute : Attribute
    {
        private string v;

        public BlindAttribute(string v)
        {
            this.v = v;
        }
    }
}