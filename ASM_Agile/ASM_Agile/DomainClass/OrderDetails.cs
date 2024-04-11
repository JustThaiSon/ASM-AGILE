using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ASM_Agile.DomainClass
{
    public partial class OrderDetails
    {
        [Key]
        [Column("OrderDetailID")]
        public int OrderDetailId { get; set; }
        [Column("OrderID")]
        public int? OrderId { get; set; }
        [Column("PhoneID")]
        public int? PhoneId { get; set; }
        public int? Quantity { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal? UnitPrice { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal? TotalPrice { get; set; }

        [ForeignKey(nameof(OrderId))]
        [InverseProperty(nameof(Orders.OrderDetails))]
        public virtual Orders Order { get; set; }
        [ForeignKey(nameof(PhoneId))]
        [InverseProperty(nameof(Phones.OrderDetails))]
        public virtual Phones Phone { get; set; }
    }
}
