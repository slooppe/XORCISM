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
    
    public partial class PROTOCOLCOMMAND
    {
        public int ProtocolCommandID { get; set; }
        public Nullable<int> ProtocolID { get; set; }
        public Nullable<int> CommandID { get; set; }
        public Nullable<bool> KnownVulnerable { get; set; }
        public Nullable<System.DateTimeOffset> CreatedDate { get; set; }
        public Nullable<System.DateTimeOffset> timestamp { get; set; }
        public Nullable<int> VocabularyID { get; set; }
        public Nullable<bool> isEncrypted { get; set; }
    
        public virtual COMMAND COMMAND { get; set; }
        public virtual PROTOCOL PROTOCOL { get; set; }
        public virtual VOCABULARY VOCABULARY { get; set; }
    }
}
