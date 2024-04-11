using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ASM_Agile.DomainClass
{
    public partial class Phones
    {
        public Phones()
        {
            OrderDetails = new HashSet<OrderDetails>();
            PhoneCategories = new HashSet<PhoneCategories>();
            PhoneCustomers = new HashSet<PhoneCustomers>();
            PhoneEmployees = new HashSet<PhoneEmployees>();
        }

        [Key]
        [Column("PhoneID")]
        public int PhoneId { get; set; }
        [Required]
        [StringLength(100)]
        public string Model { get; set; }
        [Column("BrandID")]
        public int? BrandId { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal? Price { get; set; }
        public int? StockQuantity { get; set; }
        [Column("NhaSanXuatID")]
        public int? NhaSanXuatId { get; set; }

        [ForeignKey(nameof(BrandId))]
        [InverseProperty(nameof(Brands.Phones))]
        public virtual Brands Brand { get; set; }
        [ForeignKey(nameof(NhaSanXuatId))]
        [InverseProperty("Phones")]
        public virtual NhaSanXuat NhaSanXuat { get; set; }
        [InverseProperty("Phone")]
        public virtual ICollection<OrderDetails> OrderDetails { get; set; }
        [InverseProperty("Phone")]
        public virtual ICollection<PhoneCategories> PhoneCategories { get; set; }
        [InverseProperty("Phone")]
        public virtual ICollection<PhoneCustomers> PhoneCustomers { get; set; }
        [InverseProperty("Phone")]
        public virtual ICollection<PhoneEmployees> PhoneEmployees { get; set; }
    }
}
