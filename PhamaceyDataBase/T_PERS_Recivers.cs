//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PhamaceyDataBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class T_Pers_Recivers
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_Pers_Recivers()
        {
            this.T_OPeration_Out = new HashSet<T_OPeration_Out>();
        }
    
        public string name { get; set; }
        public int id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_OPeration_Out> T_OPeration_Out { get; set; }
    }
}
