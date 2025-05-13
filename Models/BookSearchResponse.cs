using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APILibros.Models
{
    public class BookSearchResponse
    {
        public List<BookDoc> Docs { get; set; }
    }

    public class BookDoc
    {
        public string Title { get; set; }
        public List<string> Author_name { get; set; }
        public int? First_publish_year { get; set; }
    }
}