using BlackBooks_API.Services;
using Microsoft.AspNetCore.Mvc;

namespace BlackBooks.API.Controllers;

[ApiController]
[Route("[controller]")]
public class BooksController : ControllerBase
{
    private readonly BookService _bookService;
    private readonly ILogger<BooksController> _logger;

    public BooksController(ILogger<BooksController> logger, BookService bookService)
    {
        _bookService = bookService;
        _logger = logger;
    }

    [HttpGet("All")]
    public ActionResult<List<string>> GetAll()
    {
        try
        {
            var allBooks = _bookService.GetAll();
            return allBooks;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An unexpected error occured.");
            return StatusCode(500, "An unexpected error occured. Please try again later");
        }
    }

    [HttpGet("Search/{searchTerm}")]
    public ActionResult<List<string>> Search(string searchTerm)
    {
        try
        {
            var searchedBooks = _bookService.Search(searchTerm);
            return searchedBooks;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An unexpected error occured.");
            return StatusCode(500, "An unexpected error occured. Please try again later");
        }
    }
}