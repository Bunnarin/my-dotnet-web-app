using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyWebApp.Models;
namespace MyWebApp.Controllers
{
    [ApiController]
    [Route("books")]
    public class BooksController : Controller
    {
        [HttpPost(Name = "SearchBooks")]
        [Authorize]
        public IActionResult Search(Book? book)
        {
            return View(book);
        }

    }
}

