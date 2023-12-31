//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AuthTask
{
    using System;
    using System.Collections.Generic;
    
    public partial class AuditLog
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AuditLog()
        {
            this.ErrorLogs = new HashSet<ErrorLog>();
            this.ErrorLogs1 = new HashSet<ErrorLog>();
        }
    
        public int PK_AuditID { get; set; }
        public Nullable<int> FK_IntegratorID { get; set; }
        public string ProcessName { get; set; }
        public string ProcessedFrom { get; set; }
        public Nullable<System.DateTime> StartTime { get; set; }
        public Nullable<System.DateTime> EndTime { get; set; }
        public Nullable<int> RecordsProcessed { get; set; }
        public Nullable<int> RecordsFailed { get; set; }
        public Nullable<int> RunBy { get; set; }
        public string ErrorDetails { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ErrorLog> ErrorLogs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ErrorLog> ErrorLogs1 { get; set; }
    }
}
