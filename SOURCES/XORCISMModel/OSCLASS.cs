//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace XORCISMModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class OSCLASS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OSCLASS()
        {
            this.CWEOSCLASS = new HashSet<CWEOSCLASS>();
        }
    
        public int OSClassID { get; set; }
        public string OSClassGUID { get; set; }
        public string Operating_System_Class_Description { get; set; }
        public Nullable<System.DateTimeOffset> CreatedDate { get; set; }
        public Nullable<System.DateTimeOffset> timestamp { get; set; }
        public Nullable<int> VocabularyID { get; set; }
        public Nullable<bool> isEncrypted { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CWEOSCLASS> CWEOSCLASS { get; set; }
        public virtual VOCABULARY VOCABULARY { get; set; }
    }
}
