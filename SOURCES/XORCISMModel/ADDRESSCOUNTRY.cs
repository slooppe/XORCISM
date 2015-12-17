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
    
    public partial class ADDRESSCOUNTRY
    {
        public int AddressCountryID { get; set; }
        public Nullable<int> AddressID { get; set; }
        public string AddressGUID { get; set; }
        public Nullable<int> CountryID { get; set; }
        public string CountryGUID { get; set; }
        public Nullable<System.DateTimeOffset> CreatedDate { get; set; }
        public Nullable<int> CreationObjectID { get; set; }
        public Nullable<System.DateTimeOffset> timestamp { get; set; }
        public Nullable<int> VocabularyID { get; set; }
        public Nullable<System.DateTimeOffset> ValidFromDate { get; set; }
        public Nullable<System.DateTimeOffset> ValidUntilDate { get; set; }
        public Nullable<int> ConfidenceLevelID { get; set; }
        public Nullable<bool> isEncrypted { get; set; }
    
        public virtual ADDRESS ADDRESS { get; set; }
        public virtual CONFIDENCELEVEL CONFIDENCELEVEL { get; set; }
        public virtual COUNTRY COUNTRY { get; set; }
        public virtual CREATIONOBJECT CREATIONOBJECT { get; set; }
        public virtual VOCABULARY VOCABULARY { get; set; }
    }
}