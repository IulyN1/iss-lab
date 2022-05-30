using FluentNHibernate.Mapping;
using Library.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.mapping
{
    public class BookMap : ClassMap<Book>
    {
        public BookMap()
        {
            Id(x => x.bookCode).GeneratedBy.Increment();
            Map(x => x.title);
            Map(x => x.author);
            Map(x => x.year);
            Map(x => x.noOfCopies);
            Table("books");
        }
    }
}
