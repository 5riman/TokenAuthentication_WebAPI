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
    
    public partial class ErrorLog
    {
        public int PK_ErrorId { get; set; }
        public Nullable<int> FK_IntegratorId { get; set; }
        public Nullable<int> FK_CustomerId { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string ProcessName { get; set; }
        public string ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
        public Nullable<int> FK_AuditId { get; set; }
        public Nullable<bool> Retry_Running { get; set; }
        public Nullable<bool> Retry_status { get; set; }
    
        public virtual AuditLog AuditLog { get; set; }
        public virtual AuditLog AuditLog1 { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
