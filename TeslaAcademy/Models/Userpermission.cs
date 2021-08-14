using System;
using System.Collections.Generic;

namespace TeslaAcademy.Models
{
    public partial class Userpermission
    {
        public Userpermission()
        {
            User = new HashSet<User>();
        }

        public int Permissionid { get; set; }
        public int? Userid { get; set; }
        public int? Courseid { get; set; }
        public string Userpermission1 { get; set; }

        public Coursemain Course { get; set; }
        public User UserNavigation { get; set; }
        public ICollection<User> User { get; set; }
    }
}
