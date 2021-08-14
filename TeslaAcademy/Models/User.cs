using System;
using System.Collections.Generic;

namespace TeslaAcademy.Models
{
    public partial class User
    {
        public User()
        {
            Userpermission = new HashSet<Userpermission>();
        }

        public int Userid { get; set; }
        public int? Orgid { get; set; }
        public string Rolename { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
        public string Userimage { get; set; }
        public int? Permissionid { get; set; }
        public string Setpermission { get; set; }
        public bool? Isactive { get; set; }
        public DateTime? Createddate { get; set; }

        public Organization Org { get; set; }
        public Userpermission Permission { get; set; }
        public ICollection<Userpermission> Userpermission { get; set; }
    }
}
