//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Joole_1
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblProperty
    {
        public tblProperty()
        {
            this.tblPropertyValues = new HashSet<tblPropertyValue>();
        }
    
        public int Property_Id { get; set; }
        public string Property_Name { get; set; }
        public Nullable<bool> Property_isType { get; set; }
        public Nullable<bool> Property_isTechSpec { get; set; }
    
        public virtual ICollection<tblPropertyValue> tblPropertyValues { get; set; }
    }
}
