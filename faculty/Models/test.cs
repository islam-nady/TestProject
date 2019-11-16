using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace faculty.Models
{
    public class test
    {
        [Key]
        public string id { get; set; }
        public string name { get; set; }
        public string degree { get; set; }
        
    }
}