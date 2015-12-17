//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace XATTACKModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class ATTACKTOOL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ATTACKTOOL()
        {
            this.ATTACKTOOLAUTHENTICATIONTYPE = new HashSet<ATTACKTOOLAUTHENTICATIONTYPE>();
            this.ATTACKTOOLFORTHREATACTORTTP = new HashSet<ATTACKTOOLFORTHREATACTORTTP>();
        }
    
        public int AttackToolID { get; set; }
        public string AttackTooldGUID { get; set; }
        public Nullable<int> TooldID { get; set; }
        public Nullable<int> AttackToolTypeID { get; set; }
        public string AttackToolName { get; set; }
        public string AttackToolVersion { get; set; }
        public Nullable<int> VersionID { get; set; }
        public string AttackToolDescription { get; set; }
        public string AttackToolAuthor { get; set; }
        public string AttackToolLink { get; set; }
        public Nullable<System.DateTimeOffset> timestamp { get; set; }
        public Nullable<int> VocabularyID { get; set; }
        public Nullable<System.DateTimeOffset> CreatedDate { get; set; }
        public Nullable<int> CreationObjectID { get; set; }
        public Nullable<System.DateTimeOffset> ValidFromDate { get; set; }
        public Nullable<System.DateTimeOffset> ValidUntilDate { get; set; }
        public Nullable<bool> isEncrypted { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ATTACKTOOLAUTHENTICATIONTYPE> ATTACKTOOLAUTHENTICATIONTYPE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ATTACKTOOLFORTHREATACTORTTP> ATTACKTOOLFORTHREATACTORTTP { get; set; }
    }
}