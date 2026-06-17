using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingWiki_Model.Models
{
    public class Publisher
    {
        public int PublisherId { get; set; }

        public string? Name { get; set; }

        public string? Location { get; set; }

        public ICollection<Book> Books { get; set; } = new List<Book>();
    }
}
