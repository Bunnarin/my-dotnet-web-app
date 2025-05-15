using Microsoft.AspNetCore.Mvc;
using MyWebApp.Models;
namespace MyWebApp.Controllers;

public class ItemsController : Controller
{
    public IActionResult Overview()
    {
        var item = new Item()
        {
            Id = 1,
            Name = "Sample Item",
            Price = 19.99m
        };
        return View(item);
    }

}