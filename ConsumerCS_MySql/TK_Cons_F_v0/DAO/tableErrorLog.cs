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
    
    public partial class tableErrorLog
    {
        public int ErrID { get; set; }
        public Nullable<System.DateTime> ErrDateTime { get; set; }
        public string ErrNote { get; set; }
        public Nullable<int> DataID { get; set; }
        public Nullable<int> ClsID { get; set; }
    
        public virtual tableClassify tableClassify { get; set; }
        public virtual tableMyData tableMyData { get; set; }
    }
}