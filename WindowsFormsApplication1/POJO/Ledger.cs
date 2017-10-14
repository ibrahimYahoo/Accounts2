using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.POJO
{
    class Ledger
    {


        public int TransId { get; set; }
        public int PId { get; set; }
        public decimal Debit { get; set; }
        public decimal Credit { get; set; }
        public int IId { get; set; }
        public Nullable<int> ItemQuantity { get; set; }
        public string Description { get; set; }
        public System.DateTime Date { get; set; }
        public int ItemBought { get; set; }
        public decimal Balance { get; set; }

        public  Items Item { get; set; }
        public  Party Party { get; set; }
    }
}
