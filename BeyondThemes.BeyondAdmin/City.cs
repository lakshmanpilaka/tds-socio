//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TDS.Socio
{
    using System;
    using System.Collections.Generic;
    
    public partial class City
    {
        public City()
        {
            this.Stores = new HashSet<Store>();
        }
    
        public int CityId { get; set; }
        public string City1 { get; set; }
        public Nullable<int> PersResponsible { get; set; }
        public string CityCode { get; set; }
    
        public virtual Employee Employee { get; set; }
        public virtual ICollection<Store> Stores { get; set; }
    }
}
