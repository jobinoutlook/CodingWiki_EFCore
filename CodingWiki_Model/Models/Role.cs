using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingWiki_Model.Models
{
    public class Role
    {
        public int RoleId { get; set; }

        public string? Name { get; set; }

        public ICollection<User> Users { get; set; }
    }
}
