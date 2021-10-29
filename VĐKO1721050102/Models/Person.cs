using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VĐKO1721050102.Models
{
    public class Person
    {
        [Key]
        [StringLength(20)]
        [Display(Name = "ID Sinh Viên")]
        public string PersonID { get; set; }

        [StringLength(50)]
        [Display(Name = "Tên Sinh Viên")]
        public string PersonName { get; set; }
    }
}