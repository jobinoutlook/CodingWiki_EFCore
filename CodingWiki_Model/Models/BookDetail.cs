using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingWiki_Model.Models
{
    public class BookDetail
    {
        public int BookDetailId { get; set; }
        public int NumberOfPages { get; set; }

        public int NumberOfChapters { get; set; }
        
        public string? Weight  { get; set; }

        //[ForeignKey("Book")]
        public int BookId { get; set; }
        public Book Book { get; set; }
    }
}
