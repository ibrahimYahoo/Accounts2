using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.POJO
{
    class Items
    {

        public int IId { get; set; }
        public string IName { get; set; }
        public Nullable<int> CatId { get; set; }
        public decimal IPrice { get; set; }
        public double IQty { get; set; }
        public double IReorder { get; set; }
        public string Imagepath { get; set; }
        public string ImageContent { get; set; }

    }
}
