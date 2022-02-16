using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mission7.Models.ViewModels
{
    public class PageInfo //class for page info
    {
        public int TotalNumBooks { get; set; }
        public int BooksPerPage { get; set; }
        public int CurrentPage { get; set; }

        //number of pages needed
        public int TotalPages => (int)Math.Ceiling((double) TotalNumBooks / BooksPerPage); //cast and calculate
    }
}
