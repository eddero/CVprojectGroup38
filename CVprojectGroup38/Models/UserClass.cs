using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CVprojectGroup38.Models
{
    public class UserClass
    {
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public int WorkOnProject { get; set; }
        public List<ProjectClass> workOnProjects { get; set; }

    }
}