using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APILibros.Models
{
        public class Book
        {
            public string Title { get; set; }
            public string AuthorName { get; set; }
            public int FirstPublishYear { get; set; }
        }
    }
