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
    
    public partial class TAXONOMYREFERENCE
    {
        public int TaxonomyReferenceID { get; set; }
        public int TaxonomyID { get; set; }
        public int ReferenceID { get; set; }
        public Nullable<System.DateTimeOffset> CreatedDate { get; set; }
        public string TaxonomyReferenceName { get; set; }
        public string TaxonomyReferenceDescription { get; set; }
        public Nullable<System.DateTimeOffset> timestamp { get; set; }
        public Nullable<System.DateTimeOffset> ValidFromDate { get; set; }
        public Nullable<System.DateTimeOffset> ValidUntilDate { get; set; }
        public Nullable<int> ConfidenceLevelID { get; set; }
        public Nullable<int> VocabularyID { get; set; }
        public Nullable<bool> isEncrypted { get; set; }
    
        public virtual CONFIDENCELEVEL CONFIDENCELEVEL { get; set; }
        public virtual REFERENCE REFERENCE { get; set; }
        public virtual TAXONOMY TAXONOMY { get; set; }
        public virtual VOCABULARY VOCABULARY { get; set; }
    }
}
