using Microsoft.AspNetCore.Mvc;
using MyWebApp.Models;
namespace MyWebApp.Controllers;

public class BooksController : Controller
{
    public IActionResult Search(Book? book)
    {
        return View(book);
    }

    public IActionResult Get()
    {
        var book = new Book()
        {
            Id = 1,
            Title = "Sample Book",
            Price = 19.99m
        };
        return View(book);
    }

}