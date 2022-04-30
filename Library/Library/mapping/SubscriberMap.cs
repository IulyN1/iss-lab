using FluentNHibernate.Mapping;
using Library.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.mapping
{
    public class SubscriberMap : ClassMap<Subscriber>
    {
        public SubscriberMap()
        {
            Id(x => x.cnp);
            Map(x => x.firstName);
            Map(x => x.lastName);
            Map(x => x.phone);
            Map(x => x.address);
            Map(x => x.accountId);
            Table("subscribers");
        }
    }
}
