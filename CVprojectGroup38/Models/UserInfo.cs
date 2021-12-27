using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CVprojectGroup38.Models
{
    public class UserInfo
    {
        [ForeignKey("UserAccount")]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserImg { get; set; }
        public string UserEducation { get; set; }
        public string UserSkill { get; set; }
        public string UserAdress { get; set; }
        public virtual UserAccount UserAccount { get; set; }

    }
}