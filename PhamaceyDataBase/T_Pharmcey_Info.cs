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
    
    public partial class T_Pharmcey_Info
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_Pharmcey_Info()
        {
            this.T_Medician = new HashSet<T_Medician>();
        }
    
        public int ph_id { get; set; }
        public string code { get; set; }
        public string ph_name { get; set; }
        public string ph_pers_name { get; set; }
        public string ph_phone { get; set; }
        public string ph_mobile { get; set; }
        public string ph_adress { get; set; }
        public string ph_fax { get; set; }
        public string ph_email { get; set; }
        public string ph_logo { get; set; }
        public Nullable<bool> ph_state { get; set; }
        public string ph_note { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_Medician> T_Medician { get; set; }
    }
}
