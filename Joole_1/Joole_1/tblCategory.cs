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
    
    public partial class tblCategory
    {
        public tblCategory()
        {
            this.tblSubCategories = new HashSet<tblSubCategory>();
        }
    
        public int Category_Id { get; set; }
        public string Category_Name { get; set; }
    
        public virtual ICollection<tblSubCategory> tblSubCategories { get; set; }
    }
}
