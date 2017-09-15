using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using System;

namespace NHTeste
{
    public class City
    {
        public virtual int Id { get;  set; }
        public virtual long Population { get; set; }
        public virtual string Name { get; set; }
    }
   

}
