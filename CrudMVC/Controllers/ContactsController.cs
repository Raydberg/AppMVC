using CrudMVC.Data;
using CrudMVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CrudMVC.Controllers;

public class ContactsController : Controller
{
    private readonly ApplicationDBContext _context;

    public ContactsController(ApplicationDBContext context) { _context = context; }

    [HttpGet]
    public async Task<IActionResult> Index() { return View(await _context.Contacts.ToListAsync()); }

    [HttpGet]
    public IActionResult Create() { return View(); }


    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(Contact contact)
    {
        if (ModelState.IsValid)
        {
            contact.CreateTime = DateTime.Now;
            _context.Contacts.Add(contact);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        return View();
    }

    [HttpGet]
    public IActionResult Edit(int? id)
    {
        if (id == null) return NotFound();

        var contact = _context.Contacts.Find(id);
        if (contact == null) return NotFound();

        return View(contact);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(Contact contact)
    {
        if (ModelState.IsValid)
        {
            _context.Update(contact);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        return View();
    }

    [HttpGet]
    public IActionResult Detail(int? id)
    {
        if (id == null) return NotFound();

        var contact = _context.Contacts.Find(id);
        if (contact == null) return NotFound();

        return View(contact);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete (int id)
    {
        var contact = await _context.Contacts.FindAsync(id);
        if (contact == null)
        {
            return Json(new { success = false });
        }

        _context.Contacts.Remove(contact);
        await _context.SaveChangesAsync();
        return Json(new { success = true });
    }
}
