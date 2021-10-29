using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VĐKO1721050102.Models
{
    public class Lecture : Person
    {
        [StringLength(50)]
        [Display(Name = "Khoa")]
        public string Faculty { get; set; }
        [StringLength(50)]
        [Display(Name = "Phòng Ban")]
        public string Department { get; set; }
    }
}