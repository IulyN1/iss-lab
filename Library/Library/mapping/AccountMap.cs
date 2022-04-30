using FluentNHibernate.Mapping;
using Library.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.mapping
{
    public class AccountMap : ClassMap<Account>
    {
        public AccountMap()
        {
            Id(x => x.id).GeneratedBy.Increment();
            Map(x => x.username);
            Map(x => x.password);
            Map(x => x.admin);
            Table("accounts");
        }
    }
}
