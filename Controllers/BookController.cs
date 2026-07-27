using Microsoft.AspNetCore.Mvc;
using BookCrud.Models;

namespace BookCrud.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BookController : ControllerBase
{
    [HttpGet]
    public string CreateBook()
    {
        // Logic to create a new book
        return "Book created successfully!";
    }
}