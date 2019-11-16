using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace faculty.Models
{
    public class Department
    {
        public int Id { get; set; }
        [Required]
        public string  name { get; set; }
        public virtual List<instructor> instructors { get; set; }
        public virtual List<student> students { get; set;}
        public virtual List<Departmentcourse> departmentstudent { get; set; }


    }
}