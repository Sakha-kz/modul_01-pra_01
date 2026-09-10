using BooksApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace BooksApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BooksController : ControllerBase
{
    private static readonly List<Book> Books =
    [
        new Book
        {
            Id = 1,
            Title = "Clean Code",
            Author = "Robert C. Martin",
            Year = 2008,
            Genre = "Software Engineering",
            Price = 39.99m
        },
        new Book
        {
            Id = 2,
            Title = "Designing Data-Intensive Applications",
            Author = "Martin Kleppmann",
            Year = 2017,
            Genre = "Distributed Systems",
            Price = 49.99m
        }
    ];

    [HttpGet]
    public ActionResult<List<Book>> GetBooks()
    {
        return Ok(Books);
    }

    [HttpGet("{id:int}")]
    public ActionResult<Book> GetBookById(int id)
    {
        var book = Books.FirstOrDefault(item => item.Id == id);

        if (book is null)
        {
            return NotFound();
        }

        return Ok(book);
    }

    [HttpPost]
    public ActionResult<Book> AddBook(Book book)
    {
        book.Id = Books.Count == 0 ? 1 : Books.Max(item => item.Id) + 1;
        Books.Add(book);

        return CreatedAtAction(nameof(GetBookById), new { id = book.Id }, book);
    }
}
