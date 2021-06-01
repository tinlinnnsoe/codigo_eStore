using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace cms.eStore
{
    public partial class Payment
    {
        public string Id { get; set; }
        public ulong Active { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public string PaymentType { get; set; }
        public int PaymentTypeDiscount { get; set; }
        public ulong Allowed { get; set; }
        public string ProductId { get; set; }

        public virtual Product Product { get; set; }
    }
}
