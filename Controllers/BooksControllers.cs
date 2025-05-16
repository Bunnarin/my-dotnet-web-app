
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyWebApp.Data;
using MyWebApp.Models;
namespace MyWebApp.Controllers;

[ApiController]
[Route("books")]
public class BooksController : Controller
{
    private readonly MyWebAppContext _context;
    public BooksController(MyWebAppContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> Index()
    {
        var books = await _context.Books.ToListAsync();
        return View(books);
    }

    [HttpGet("create")]
    [Authorize]
    public IActionResult Create()
    {
        return View();
    }
    [HttpPost("create")]
    [Authorize]
    public async Task<IActionResult> Create([FromForm] Book book)
    {
        if (ModelState.IsValid)
        {
            _context.Books.Add(book);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        return View(book);
    }
    [HttpGet("delete/{id}")]
    [Authorize]
    public async Task<IActionResult> Delete(int id)
    {
        var item = await _context.Books.FindAsync(id);
        if (item != null)
        {
            _context.Books.Remove(item);
            await _context.SaveChangesAsync();
        }
        return RedirectToAction("Index");
    }
}

