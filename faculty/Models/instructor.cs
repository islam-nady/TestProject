using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace faculty.Models
{
    public class instructor
    {
        [Key]

        [ForeignKey("appUser")]
         public string id { get; set; }
        public string name { get; set; }
      
        public DateTime HireDate { get; set; }
       
        [MaxLength(12)]
        [MinLength(1)]
        [RegularExpression("^[0-9]*$", ErrorMessage = "salary must be numeric")]
         public string salary { get; set; }
        public string Photo { get; set; }
        [ForeignKey("department")]
        public int? DeptID { get; set; }
        public virtual Department department  { get; set; }
        public virtual ApplicationUser appUser { get; set; }

    }
}