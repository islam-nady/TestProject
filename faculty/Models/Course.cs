using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace faculty.Models
{
    public class Course
    {
        public int id { get; set; }
        public string name { get; set; }
        public int duration { get; set; }
        public virtual List<studentCourse> studentcourse { get; set; }
        public virtual List<Departmentcourse> departmentcourse { get; set; }
    }
}