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
    
    public partial class Device
    {
        public Device()
        {
            this.DeviceBills = new HashSet<DeviceBill>();
        }
    
        public int DeviceID { get; set; }
        public string DeviceName { get; set; }
        public string DevicePrice { get; set; }
        public string DeviceCharact { get; set; }
        public int DeviceCategory { get; set; }
    
        public virtual Category Category { get; set; }
        public virtual ICollection<DeviceBill> DeviceBills { get; set; }
    }
}
