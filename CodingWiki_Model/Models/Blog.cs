using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingWiki_Model.Models
{
    public class Blog
    {
        public int BlogId { get; set; }
        public string? Title { get; set; }

        // Navigation property (one Blog has many Posts)
        public ICollection<Post> Posts { get; set; }
    }
}
