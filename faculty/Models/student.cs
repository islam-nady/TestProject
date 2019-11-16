using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace faculty.Models
{
    public class student
    {
        [Key]
        [ForeignKey("appUser")]
        public string id { get; set; }
        public string name { get; set; }

     
        public string degree { get; set; }

         
        [ForeignKey("department")]

        public int? DeptID { get; set; }
        public string Photo { get; set; }
        public virtual Department department { get; set; }
        
        public virtual List<studentCourse>studentcourse { get; set; }

        public virtual ApplicationUser appUser { get; set; }
    }
}