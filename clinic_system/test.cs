//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace clinic_system
{
    using System;
    using System.Collections.Generic;
    
    public partial class test
    {
        public int testID { get; set; }
        public int patient_ID { get; set; }
        public string type { get; set; }
        public string comment { get; set; }
    
        public virtual patient patient { get; set; }
    }
}