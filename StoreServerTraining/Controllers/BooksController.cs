using Microsoft.AspNetCore.Mvc;
using StoreServerTraining.Dtos;
using StoreServerTraining.Services;
using StoreServerTraining.Models;

namespace StoreServerTraining.Controllers;
[Route("api/[controller]/[action]")]
[ApiController]
public class BooksController : ControllerBase
{

    [HttpPost]
    public IActionResult GetAllBooks(RequestBookDto request)
    {
        var bookData = BookService.books;
        var response = new ResponseBookDto<List<Book>>();

        response.Data = bookData
            .Skip((request.PageNumber-1) * request.PageSize)
            .Take(request.PageSize)
            .ToList();
        response.PageNumber = request.PageNumber;
        response.PageSize = request.PageSize;
        response.TotalPageCount = (int)Math.Ceiling((double)bookData.Count / request.PageSize);
        response.IsFirstPage = request.PageNumber == 1;
        response.IsLastPage = request.PageNumber == response.TotalPageCount;

        return Ok(response);
    }
}
