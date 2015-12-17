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
    
    public partial class OBFUSCATIONTECHNIQUE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OBFUSCATIONTECHNIQUE()
        {
            this.OBFUSCATIONTECHNIQUETAG = new HashSet<OBFUSCATIONTECHNIQUETAG>();
        }
    
        public int ObfuscationTechniqueID { get; set; }
        public string ObfuscationTechniqueGUID { get; set; }
        public Nullable<int> TechniqueID { get; set; }
        public string ObfuscationTechniqueName { get; set; }
        public string ObfuscationTechniqueDescription { get; set; }
        public Nullable<int> VocabularyID { get; set; }
        public Nullable<System.DateTimeOffset> CreatedDate { get; set; }
        public Nullable<int> CreationObjectID { get; set; }
        public Nullable<System.DateTimeOffset> timestamp { get; set; }
        public Nullable<System.DateTimeOffset> ValidFromDate { get; set; }
        public Nullable<System.DateTimeOffset> ValidUntilDate { get; set; }
        public Nullable<bool> isEncrypted { get; set; }
    
        public virtual CREATIONOBJECT CREATIONOBJECT { get; set; }
        public virtual TECHNIQUE TECHNIQUE { get; set; }
        public virtual VOCABULARY VOCABULARY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OBFUSCATIONTECHNIQUETAG> OBFUSCATIONTECHNIQUETAG { get; set; }
    }
}