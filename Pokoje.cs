//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hotel_Kus
{
    using System;
    using System.Collections.Generic;
    
    public partial class Pokoje
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pokoje()
        {
            this.Rezerwacje = new HashSet<Rezerwacje>();
        }
    
        public int IDPokoju { get; set; }
        public string NumerPokoju { get; set; }
        public int Pojemnosc { get; set; }
        public int Status { get; set; }
    
        public virtual StatusPokoju StatusPokoju { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rezerwacje> Rezerwacje { get; set; }
    }
}
