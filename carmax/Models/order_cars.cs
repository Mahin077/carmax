//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace carmax.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class order_cars
    {
        public int id { get; set; }
        public int user_id { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public int car_id { get; set; }
        public string car_name { get; set; }
        public double car_price { get; set; }
        public string time { get; set; }
        public string details { get; set; }
    
        public virtual login login { get; set; }
        public virtual product product { get; set; }
    }
}
