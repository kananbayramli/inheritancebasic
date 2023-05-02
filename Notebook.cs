using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceOdev
{
    public sealed class Notebook:Product
    {
        public string islemci { get; set; }
        public string ram { get; set; }
        public string ekranKarti { get; set; }
    }
}
