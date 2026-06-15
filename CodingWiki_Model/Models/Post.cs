using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingWiki_Model.Models
{
    public class Post
    {
        public int PostId { get; set; }
        public string? Content { get; set; }

        // Foreign key to Blog
        //[ForeignKey("Blog")]
        public int BlogId { get; set; }

        // Navigation property (one Post belongs to one Blog)
        public Blog Blog { get; set; }
    }
}
