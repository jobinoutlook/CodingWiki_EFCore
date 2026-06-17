using CodingWiki_Model.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingWiki_DataAccess.FluentConfig
{
    public class FluentBookDetailConfig : IEntityTypeConfiguration<BookDetail>
    {
        public void Configure(EntityTypeBuilder<BookDetail> modelBuilder)
        {
            

            //modelBuilder.HasData(

            //    new BookDetail() { BookDetailId = 1, BookId = 1, NumberOfChapters = 10, NumberOfPages = 100, Weight = "100" },
            //    new BookDetail() { BookDetailId = 2, BookId = 2, NumberOfChapters = 20, NumberOfPages = 200, Weight = "200" },
            //    new BookDetail() { BookDetailId = 3, BookId = 3, NumberOfChapters = 30, NumberOfPages = 300, Weight = "300" },
            //    new BookDetail() { BookDetailId = 4, BookId = 4, NumberOfChapters = 40, NumberOfPages = 400, Weight = "400" }
            //    );
        }
    }
}
