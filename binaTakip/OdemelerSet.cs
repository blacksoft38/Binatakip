//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace binaTakip
{
    using System;
    using System.Collections.Generic;
    
    public partial class OdemelerSet
    {
        public int OdemeID { get; set; }
        public int daireId { get; set; }
        public double tutar { get; set; }
        public System.DateTime tarih { get; set; }
        public string Ogid { get; set; }
        public int daireler_daireId { get; set; }
        public int Og_OgId { get; set; }
    
        public virtual dairelerSet dairelerSet { get; set; }
        public virtual OgSet OgSet { get; set; }
    }
}