using Bookstore_Application.Models;
using Bookstore_Application.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Bookstore_Application.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepositery _bookRepositery;
        public BookController() {
            _bookRepositery = new BookRepositery();
        }

        public ViewResult GetAllBooks() {

            var data = _bookRepositery.GetAllBooks();

            return View(data);

           /*
           return "All Boooks";
           https://localhost:7174/book/GetAllBooks
           */
        }

        public BookModel? GetBook(int id) {
            return _bookRepositery.GetBookById(id);

           
            // return $"dotnet with id = {id}";
            //https://localhost:7174/book/getbook/4
           

        }

        public List<BookModel> SearchBooks(string bookName, string authorName)
        {
            return _bookRepositery.SesrchBook(bookName, authorName);


            
            //return $"Book Name = {bookName} and Author is {authorName}";
            // https://localhost:7174/book/SearchBooks?bookName=MVCbook&authorName=Ankit%20Zala
            
        }
    }
}
