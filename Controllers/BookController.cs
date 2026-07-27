using Microsoft.AspNetCore.Mvc;
namespace BookCrud.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using BookCrud.Models;
    using System.Collections.Generic;
    using System.Linq;

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
        // public string UpdateBook(int id, Book book)
        // {
        //     // Logic to update an existing book
        //     return $"Book with ID {id} updated successfully!";
        // }

        // public string GetABook()
        // {
        //     // Logic to retrieve a single book
        //     return "Get a single book!";
        // }
        // public string GetAllBooks()
        // {
        //     // Logic to retrieve all books
        //     return "Retrieved all books!";
        // }


    }
}