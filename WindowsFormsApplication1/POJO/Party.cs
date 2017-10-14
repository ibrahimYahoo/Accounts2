using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.POJO
{
    class Party
    {
        public int PId { get; set; }
        public string PName { get; set; }
        public string PAddress { get; set; }
        public Nullable<decimal> Pcontact { get; set; }
        public string PEmail { get; set; }
        public decimal PBalance { get; set; }
        public decimal POwnerBal { get; set; }

        //public virtual ICollection<ledger> ledgers { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<Purchase> Purchases { get; set; }
    }
}
