using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace faculty.Models
{
    public class Departmentcourse
    {
        [Key, ForeignKey("department"), Column(Order = 1)]
        public int dept_id { get; set; }

        [Key, ForeignKey("course"), Column(Order = 2)]
        public int course_id { get; set; }

        public virtual Department department { get; set; }
        
        public virtual  Course course{ get; set; }
    }
}