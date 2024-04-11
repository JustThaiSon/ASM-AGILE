using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ASM_Agile.DomainClass
{
    public partial class PhoneEmployees
    {
        [Key]
        [Column("PhoneID")]
        public int PhoneId { get; set; }
        [Key]
        [Column("EmployeeID")]
        public int EmployeeId { get; set; }

        [ForeignKey(nameof(EmployeeId))]
        [InverseProperty(nameof(Employees.PhoneEmployees))]
        public virtual Employees Employee { get; set; }
        [ForeignKey(nameof(PhoneId))]
        [InverseProperty(nameof(Phones.PhoneEmployees))]
        public virtual Phones Phone { get; set; }
    }
}
