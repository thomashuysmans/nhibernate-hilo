using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateHilo.App
{
    public class PersonMapping : ClassMap<Person>
    {
        public PersonMapping()
        {
            Id(x => x.Id).Column("Id").GeneratedBy.HiLo("PersonHilo", "NextHi", "999");
            Map(x => x.Name);
            Map(x => x.Surname);
            Map(x => x.Age);
        }

    }
}
