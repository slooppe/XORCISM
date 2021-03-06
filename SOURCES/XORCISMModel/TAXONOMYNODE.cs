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
    
    public partial class TAXONOMYNODE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TAXONOMYNODE()
        {
            this.CWETAXONOMYNODE = new HashSet<CWETAXONOMYNODE>();
        }
    
        public int TaxonomyNodeID { get; set; }
        public Nullable<int> TaxonomyID { get; set; }
        public string TaxonomyNodeName { get; set; }
        public string TaxonomyMappedNodeID { get; set; }
        public Nullable<System.DateTimeOffset> timestamp { get; set; }
        public Nullable<int> VocabularyID { get; set; }
        public Nullable<System.DateTimeOffset> CreatedDate { get; set; }
        public string TaxonomyNodeDescription { get; set; }
        public Nullable<System.DateTimeOffset> ValidFromDate { get; set; }
        public Nullable<System.DateTimeOffset> ValidUntilDate { get; set; }
        public Nullable<bool> isEncrypted { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CWETAXONOMYNODE> CWETAXONOMYNODE { get; set; }
        public virtual TAXONOMY TAXONOMY { get; set; }
        public virtual VOCABULARY VOCABULARY { get; set; }
    }
}
