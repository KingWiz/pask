//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DMS.DAL.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    
    public partial class lvl01employee_levels
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public lvl01employee_levels()
        {
            this.emp01employee = new HashSet<emp01employee>();
        }
    
        public int lvl01uin { get; set; }
        public string lvl01title { get; set; }
        public string lvl01description { get; set; }
        public string lvl01code { get; set; }
        public bool lvl01status { get; set; }
        public bool lvl01deleted { get; set; }
        public string lvl01created_by { get; set; }
        public string lvl01created_date_nep { get; set; }
        public System.DateTime lvl01created_date_eng { get; set; }
        public string lvl01updated_by { get; set; }
        public string lvl01updated_date_nep { get; set; }
        public System.DateTime lvl01updated_date_eng { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<emp01employee> emp01employee { get; set; }
    }
}
