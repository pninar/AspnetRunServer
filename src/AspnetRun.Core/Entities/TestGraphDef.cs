using System;
using System.Collections.Generic;

namespace AspnetRun.Core.Entities
{
    public partial class TestGraphDef
    {
        public int Id { get; set; }
        public int TestId { get; set; }
        public int Row { get; set; }
        public string Heading { get; set; }
        public string ImageR { get; set; }
        public string ImageL { get; set; }
        public string LabelR { get; set; }
        public string LabelL { get; set; }
        public string LabelColorR { get; set; }
        public string LabelColorL { get; set; }
    }
}
