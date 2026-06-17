using CodingWiki_Model.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace CodingWiki_DataAccess.FluentConfig
{
    public class FluentBookConfig : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> modelBuilder)
        {
            //modelBuilder.HasData(
            //    new Book() { BookId = 1, ISBN = "I054485754", Price = (decimal)10.26, Title = "Harry Potter", PublisherId = 1 },
            //    new Book() { BookId = 2, ISBN = "I954T56565", Price = (decimal)20.26, Title = "Super Mario", PublisherId = 2 },
            //    new Book() { BookId = 3, ISBN = "I867433467", Price = (decimal)30.26, Title = "He Man", PublisherId = 3 },
            //    new Book() { BookId = 4, ISBN = "I056665754", Price = (decimal)40.26, Title = "Spider Man", PublisherId = 3 }
            //    );
        }
    }
}
