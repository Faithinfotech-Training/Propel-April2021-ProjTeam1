using System;
using System.Collections.Generic;

namespace TeslaAcademy.Models
{
    public partial class Organization
    {
        public Organization()
        {
            Coursemain = new HashSet<Coursemain>();
            User = new HashSet<User>();
        }

        public int Orgid { get; set; }
        public string Orgname { get; set; }
        public string Orgaddress { get; set; }
        public string Orglocality { get; set; }
        public string Orgstate { get; set; }
        public string Orgdistrict { get; set; }
        public string Orgcountry { get; set; }
        public string Orgpin { get; set; }
        public bool? Isactive { get; set; }
        public DateTime? Createddate { get; set; }

        public ICollection<Coursemain> Coursemain { get; set; }
        public ICollection<User> User { get; set; }
    }
}
