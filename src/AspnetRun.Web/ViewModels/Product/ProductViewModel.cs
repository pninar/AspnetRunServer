using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspnetRun.Web.ViewModels.Product
{
    public class ProductViewModel : BaseProductViewModel
    {
        public CategoryViewModel Category { get; set; }
    }
}
