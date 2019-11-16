using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace faculty.Models
{
    public class studentCourse
    {
        [Key, ForeignKey("course"), Column(Order = 1)]
        public int course_id { get; set; }

        [Key, ForeignKey("student"), Column(Order = 2)]
        public string student_id { get; set; }

        public virtual Course course{ get; set; }

        public virtual student student { get; set; }
    }
}