using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PracticalTest.Models;
//commented all methods that were created by the EF using Scaffolding
//https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app-mac/adding-model?view=aspnetcore-2.1
namespace PracticalTest.Controllers
{
    public class ContactController : Controller
    {
        private readonly MvcContactContext _context;

        public ContactController(MvcContactContext context)
        {
            _context = context;
        }

        // GET: Contact
        public async Task<IActionResult> Index()
        {
            return View(await _context.Contact.ToListAsync());
        }

        // GET: Contact/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contact = await _context.Contact
                .SingleOrDefaultAsync(m => m.ID == id);
            if (contact == null)
            {
                return NotFound();
            }

            return View(contact);
        }

        // GET: Contact/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Contact/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name,Email,Comment")] Contact contact)
        {
            if (ModelState.IsValid)
            {
                _context.Add(contact);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(contact);
        }

        // GET: Contact/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            return NotFound();
           /* if (id == null)
            {
                return NotFound();
            }

            var contact = await _context.Contact.SingleOrDefaultAsync(m => m.ID == id);
            if (contact == null)
            {
                return NotFound();
            }
            return View(contact);*/
        }

        // POST: Contact/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name,Email,Comment")] Contact contact)
        {
            return NotFound();
            /*
            if (id != contact.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(contact);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ContactExists(contact.ID))
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
            return View(contact);*/
        }

        // GET: Contact/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            return NotFound();
           /* if (id == null)
            {
                return NotFound();
            }

            var contact = await _context.Contact
                .SingleOrDefaultAsync(m => m.ID == id);
            if (contact == null)
            {
                return NotFound();
            }

            return View(contact);*/
        }

        // POST: Contact/Delete/5
        /* [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var contact = await _context.Contact.SingleOrDefaultAsync(m => m.ID == id);
            _context.Contact.Remove(contact);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }*/

        private bool ContactExists(int id)
        {
            return _context.Contact.Any(e => e.ID == id);
        }
    }
}
