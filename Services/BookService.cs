using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections.Generic;
using APILibros.Models;

namespace APILibros.Services
{
    public class BookService
    {
        public async Task<List<Book>> SearchBooksAsync(string query)
        {
            using (HttpClient client = new HttpClient())
            {
                var url = $"https://openlibrary.org/search.json?q={query}";
                var response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var result = JsonConvert.DeserializeObject<BookSearchResponse>(json);

                    var books = new List<Book>();
                    foreach (var doc in result.Docs)
                    {
                        books.Add(new Book
                        {
                            Title = doc.Title,
                            AuthorName = doc.Author_name != null ? string.Join(", ", doc.Author_name) : "Autor desconocido",
                            FirstPublishYear = doc.First_publish_year ?? 0
                        });
                    }

                    return books;
                }

                return new List<Book>();
            }
        }
    }
}
