using BookSoreServer.WebApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookSoreServer.WebApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class BooksController : ControllerBase
{
    private static List<Book> books = new()
    {
        new Book { Id = 1, Title ="Domain-Driven Design Tackling Complexity in the Heart of Software", Author = "Eric Evans", Summary = "DDD", CoverImageUrl = "", CreateAt = DateTime.Now, IsActive = true, ISBN = "978-11579168", Price = 19.99m, Quantity = 10 },
        new Book { Id = 2, Title ="Clean Architecture", Author = "Robert C. Martin", Summary = "CA", CoverImageUrl = "", CreateAt = DateTime.Now, 
           IsActive = true, ISBN = "958-11789168", Price = 14.99m, Quantity = 10 },
    };

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok();
    }
}
