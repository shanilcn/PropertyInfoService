//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PropertyInfoService
{
    using System;
    using System.Collections.Generic;
    
    public partial class PropertyInfo
    {
        public int PropertyId { get; set; }
        public string Type { get; set; }
        public Nullable<int> Rooms { get; set; }
        public Nullable<decimal> Budget { get; set; }
        public Nullable<int> FloorArea { get; set; }
        public Nullable<int> LocationId { get; set; }
        public byte[] Image { get; set; }
    }
}
