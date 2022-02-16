using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mission7.Models.ViewModels
{
    public class BooksViewModel //view model for books
    {
        public IQueryable<Book> Books { get; set; }

        public PageInfo PageInfo { get; set; }
    }
}
