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
    
    public partial class GetErrorLogRecords_Result
    {
        public int PK_ErrorId { get; set; }
        public string ProcessName { get; set; }
        public string ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
        public string CreateDate { get; set; }
        public bool Retry_status { get; set; }
    }
}