using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspnetRun.Core.Entities
{
    public partial class Bank
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool? Current { get; set; }
        public string Bankcode { get; set; }
    }
}
