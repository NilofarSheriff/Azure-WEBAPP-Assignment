//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AzureAssignment
{
    using System;
    using System.Collections.Generic;
    
    public partial class Member_C
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Member_C()
        {
            this.Issue_C = new HashSet<Issue_C>();
        }
    
        public int Member_Id { get; set; }
        public Nullable<System.DateTime> Account_Open_Date { get; set; }
        public Nullable<decimal> Max_Allowed_Books { get; set; }
        public Nullable<decimal> Penalty_Amount { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Issue_C> Issue_C { get; set; }
    }
}
