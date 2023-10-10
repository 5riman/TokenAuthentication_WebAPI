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
    
    public partial class Customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer()
        {
            this.UserConnectors = new HashSet<UserConnector>();
            this.CustomerSubscriptions = new HashSet<CustomerSubscription>();
            this.ErrorLogs = new HashSet<ErrorLog>();
            this.RefreshTokens = new HashSet<RefreshToken>();
        }
    
        public int PK_CustomerID { get; set; }
        public Nullable<int> Fk_RoleID { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string NS_Email { get; set; }
        public string NS_Password { get; set; }
        public string NS_RoleKey { get; set; }
        public string NS_Account { get; set; }
        public string NS_AppID { get; set; }
        public string NS_ConsumerKey { get; set; }
        public string NS_ConsumerSecret { get; set; }
        public string NS_TokenID { get; set; }
        public string NS_TokenSecret { get; set; }
        public string TimeZone { get; set; }
        public Nullable<bool> IsVerified { get; set; }
        public Nullable<bool> InActive { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string VerifyToken { get; set; }
        public Nullable<System.DateTime> VT_CreatedDate { get; set; }
        public string RestletURL { get; set; }
        public string company { get; set; }
        public string Ac_URL { get; set; }
        public string AC_Username { get; set; }
        public string AC_Password { get; set; }
        public string AC_Company { get; set; }
        public string AC_Branch { get; set; }
        public string AC_Locate { get; set; }
        public string AC_TimeZone { get; set; }
        public Nullable<bool> isSubsidiaries { get; set; }
        public Nullable<bool> isSandBox { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserConnector> UserConnectors { get; set; }
        public virtual User User { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerSubscription> CustomerSubscriptions { get; set; }
        public virtual Role Role { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ErrorLog> ErrorLogs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefreshToken> RefreshTokens { get; set; }
    }
}