//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TK_Cons_F_v0.DAO
{
    using System;
    using System.Collections.Generic;
    
    public partial class tableMyData
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tableMyData()
        {
            this.tableErrorLogs = new HashSet<tableErrorLog>();
        }
    
        public int ID { get; set; }
        public Nullable<double> val { get; set; }
        public string sometext { get; set; }
        public Nullable<System.DateTime> recieve_date { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tableErrorLog> tableErrorLogs { get; set; }
    }
}
