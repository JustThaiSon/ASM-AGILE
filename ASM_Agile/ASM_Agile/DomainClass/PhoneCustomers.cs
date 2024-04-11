using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ASM_Agile.DomainClass
{
    public partial class PhoneCustomers
    {
        [Key]
        [Column("PhoneID")]
        public int PhoneId { get; set; }
        [Key]
        [Column("CustomerID")]
        public int CustomerId { get; set; }

        [ForeignKey(nameof(CustomerId))]
        [InverseProperty(nameof(Customers.PhoneCustomers))]
        public virtual Customers Customer { get; set; }
        [ForeignKey(nameof(PhoneId))]
        [InverseProperty(nameof(Phones.PhoneCustomers))]
        public virtual Phones Phone { get; set; }
    }
}
