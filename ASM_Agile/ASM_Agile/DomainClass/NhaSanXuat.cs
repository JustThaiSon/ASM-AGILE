using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ASM_Agile.DomainClass
{
    public partial class NhaSanXuat
    {
        public NhaSanXuat()
        {
            Phones = new HashSet<Phones>();
        }

        [Key]
        [Column("NhaSanXuatID")]
        public int NhaSanXuatId { get; set; }
        [Required]
        [StringLength(50)]
        public string TenNhaSanXuat { get; set; }

        [InverseProperty("NhaSanXuat")]
        public virtual ICollection<Phones> Phones { get; set; }
    }
}
