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
    
    public partial class Film
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Film()
        {
            this.Verhuringen = new HashSet<Verhuur>();
        }
    
        public int BandNr { get; set; }
        public string Titel { get; set; }
        public int GenreNr { get; set; }
        public int InVoorraad { get; set; }
        public int UitVoorraad { get; set; }
        public decimal Prijs { get; set; }
        public int TotaalVerhuurd { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Verhuur> Verhuringen { get; set; }
        public virtual Genre Genre { get; set; }
    }
}
