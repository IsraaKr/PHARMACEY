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
    
    public partial class T_OPeration_Damage
    {
        public int dam_OP_id { get; set; }
        public Nullable<int> emp_id { get; set; }
        public Nullable<int> op_type_id { get; set; }
        public Nullable<int> Med_id { get; set; }
        public int In_op_id { get; set; }
    
        public virtual T_Medician T_Medician { get; set; }
        public virtual T_OPeration_IN T_OPeration_IN { get; set; }
        public virtual T_OPeration_Type T_OPeration_Type { get; set; }
        public virtual T_Pers_Emploee T_Pers_Emploee { get; set; }
    }
}