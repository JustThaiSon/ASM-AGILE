using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ASM_Agile.DomainClass
{
    public partial class Categories
    {
        public Categories()
        {
            PhoneCategories = new HashSet<PhoneCategories>();
        }

        [Key]
        [Column("CategoryID")]
        public int CategoryId { get; set; }
        [Required]
        [StringLength(50)]
        public string CategoryName { get; set; }

        [InverseProperty("Category")]
        public virtual ICollection<PhoneCategories> PhoneCategories { get; set; }
    }
}
