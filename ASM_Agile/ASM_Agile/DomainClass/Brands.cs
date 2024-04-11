using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ASM_Agile.DomainClass
{
    public partial class Brands
    {
        public Brands()
        {
            Phones = new HashSet<Phones>();
        }

        [Key]
        [Column("BrandID")]
        public int BrandId { get; set; }
        [Required]
        [StringLength(50)]
        public string BrandName { get; set; }

        [InverseProperty("Brand")]
        public virtual ICollection<Phones> Phones { get; set; }
    }
}
