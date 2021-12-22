using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CVprojectGroup38.Models
{
    public class ProjectClass
    {
        [Key]
        public int Id { get; set; }
        public string Projectname { get; set; }
        public List<UserClass> Participants { get; set; }
        public UserClass ProjectManager { get; set; }
    }
}