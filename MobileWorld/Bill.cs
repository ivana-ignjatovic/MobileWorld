//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MobileWorld
{
    using System;
    using System.Collections.Generic;
    
    public partial class Bill
    {
        public Bill()
        {
            this.DeviceBills = new HashSet<DeviceBill>();
        }
    
        public int BillID { get; set; }
        public System.DateTime BillDateTime { get; set; }
        public int BillEmployee { get; set; }
        public Nullable<decimal> BillTotal { get; set; }
    
        public virtual Employee Employee { get; set; }
        public virtual ICollection<DeviceBill> DeviceBills { get; set; }
    }
}
