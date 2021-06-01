using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace cms.eStore
{
    public partial class Product
    {
        public Product()
        {
            Payment = new HashSet<Payment>();
        }

        public string Id { get; set; }
        public ulong Active { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime ExpiryDate { get; set; }
        public byte[] Image { get; set; }
        public decimal Amount { get; set; }
        public int Quantity { get; set; }
        public ulong IsAvailable { get; set; }
        public byte[] Qrcode { get; set; }
        public int OnlyMeUsageMaxEvoucher { get; set; }
        public int GiftToOtherMaxEvoucher { get; set; }
        public int GiftToOtherMaxEvoucherPerUser { get; set; }
        public string DescriptionTinLinnSoe { get; set; }

        public virtual ICollection<Payment> Payment { get; set; }
    }
}
