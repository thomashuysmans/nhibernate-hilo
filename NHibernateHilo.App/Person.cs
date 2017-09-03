using FluentNHibernate.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateHilo.App
{
    public class Person : Entity
    {

        public virtual string Name { get; set; }

        public virtual  string Surname { get; set; }

        public virtual int Age { get; set; }
    }
}
