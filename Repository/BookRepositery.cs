using Bookstore_Application.Models;
using System.Linq;


namespace Bookstore_Application.Repository
{
    public class BookRepositery
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }

        public BookModel? GetBookById(int id)
        {
            return DataSource().FirstOrDefault(x => x.Id == id);
        }

        public List<BookModel> SesrchBook(string title,string authorName)
        {
            return DataSource().Where(x=> x.Title.Contains(title) || x.Author.Contains(authorName)).ToList();
        }

        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel(){Id =1,Title="MVC Book",Author="Ankit",ImageUrl = "~/images/Dotnet.png"},
                new BookModel(){Id =2,Title="Python",Author="Vipul",ImageUrl = "~/images/B2.png"},
                new BookModel(){Id =3,Title="C++",Author="Mahir",ImageUrl = "~/images/B3.png"},
                new BookModel(){Id =4,Title="Dot net",Author="Bapu",ImageUrl = "~/images/Dotnet.png"},
                new BookModel(){Id =5,Title="Ai/ML",Author="Viral",ImageUrl = "~/images/AIML.png"},
                new BookModel(){Id =6,Title="PHP",Author="Devansh",ImageUrl = "~/images/PHP.png"},


            };
        }
    }
}
