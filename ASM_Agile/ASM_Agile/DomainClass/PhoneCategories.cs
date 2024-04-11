using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ASM_Agile.DomainClass
{
    public partial class PhoneCategories
    {
        [Key]
        [Column("PhoneID")]
        public int PhoneId { get; set; }
        [Key]
        [Column("CategoryID")]
        public int CategoryId { get; set; }

        [ForeignKey(nameof(CategoryId))]
        [InverseProperty(nameof(Categories.PhoneCategories))]
        public virtual Categories Category { get; set; }
        [ForeignKey(nameof(PhoneId))]
        [InverseProperty(nameof(Phones.PhoneCategories))]
        public virtual Phones Phone { get; set; }
    }
}
