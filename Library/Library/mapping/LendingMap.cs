using FluentNHibernate.Mapping;
using Library.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.mapping
{
    public class LendingMap : ClassMap<Lending>
    {
        public LendingMap()
        {
            Id(x => x.id);
            Map(x => x.accountId);
            Map(x => x.bookCode);    
            Map(x => x.borrowDate);
            Map(x => x.returnDate);
            Map(x => x.status);
            Table("lendings");
        }
    }
}
