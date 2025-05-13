using System.Threading.Tasks;
using System.Web.Mvc;
using APILibros.Services;

namespace APILibros.Controllers
{
    public class BookController : Controller
    {
        private readonly BookService _service = new BookService();

        public async Task<ActionResult> Index(string query = "harry potter")
        {
            var books = await _service.SearchBooksAsync(query);
            ViewBag.Query = query;
            return View(books);
        }
    }
}