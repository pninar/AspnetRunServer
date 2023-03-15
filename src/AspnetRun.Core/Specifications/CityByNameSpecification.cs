using AspnetRun.Core.Entities;
using AspnetRun.Core.Specifications.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspnetRun.Core.Specifications
{
    public class CityByNameSpecification : BaseSpecification<City>
    {
        public CityByNameSpecification() : base(null)
        {
            ApplyOrderBy(o => o.Name);
        }
    }
}