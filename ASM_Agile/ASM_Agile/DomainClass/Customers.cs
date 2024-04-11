using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ASM_Agile.DomainClass
{
    public partial class Customers
    {
        public Customers()
        {
            Orders = new HashSet<Orders>();
            PhoneCustomers = new HashSet<PhoneCustomers>();
        }

        [Key]
        [Column("CustomerID")]
        public int CustomerId { get; set; }
        [StringLength(100)]
        public string Account { get; set; }
        [StringLength(20)]
        public string Pass { get; set; }
        [Column(TypeName = "date")]
        public DateTime? Birtdate { get; set; }
        [StringLength(10)]
        public string Gender { get; set; }
        [StringLength(100)]
        public string Address { get; set; }
        [StringLength(200)]
        public string Name { get; set; }
        [Required]
        [StringLength(100)]
        public string Email { get; set; }
        [StringLength(15)]
        public string PhoneNumber { get; set; }

        [InverseProperty("Customer")]
        public virtual ICollection<Orders> Orders { get; set; }
        [InverseProperty("Customer")]
        public virtual ICollection<PhoneCustomers> PhoneCustomers { get; set; }
    }
}
