using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VĐKO1721050102.Models
{
    public class Student : Person
    {
        [StringLength(50)]
        [Display(Name = " Trường")]
        public string University { get; set; }

        [StringLength(50)]
        [Display(Name = " Địa Chỉ")]
        public string Address { get; set; }
    }
}