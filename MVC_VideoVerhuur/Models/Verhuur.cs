//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVC_VideoVerhuur.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Verhuur
    {
        public int VerhuurNr { get; set; }
        public int KlantNr { get; set; }
        public int BandNr { get; set; }
        public System.DateTime VerhuurDatum { get; set; }
    
        public virtual Film Film { get; set; }
        public virtual Klant Klant { get; set; }
    }
}
