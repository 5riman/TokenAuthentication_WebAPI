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
    
    public partial class GetSubscriptionPlans_Result
    {
        public int ConnectorId { get; set; }
        public int SubscriptionId { get; set; }
        public string ConnectorName { get; set; }
        public string SubscriptionName { get; set; }
        public string Description { get; set; }
        public Nullable<decimal> SubscriptionCost { get; set; }
        public Nullable<bool> Item_Import { get; set; }
        public Nullable<bool> Item_Export { get; set; }
        public Nullable<bool> Inventory_Import { get; set; }
        public Nullable<bool> Inventory_Export { get; set; }
        public Nullable<bool> Price_Import { get; set; }
        public Nullable<bool> Price_Export { get; set; }
        public Nullable<bool> Image_Import { get; set; }
        public Nullable<bool> Image_Export { get; set; }
        public Nullable<bool> Orders_Import { get; set; }
        public Nullable<bool> Orders_Export { get; set; }
        public Nullable<bool> Shipments_Import { get; set; }
        public Nullable<bool> Shipments_Export { get; set; }
        public Nullable<bool> Refunds_Import { get; set; }
        public Nullable<bool> Refunds_Export { get; set; }
    }
}
