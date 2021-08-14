using System;
using System.Collections.Generic;

namespace TeslaAcademy.Models
{
    public partial class Degreelist
    {
        public Degreelist()
        {
            Candidatedetails = new HashSet<Candidatedetails>();
            Streamlist = new HashSet<Streamlist>();
        }

        public int Degreeid { get; set; }
        public int? Courseid { get; set; }
        public string Degreename { get; set; }

        public Coursemain Course { get; set; }
        public ICollection<Candidatedetails> Candidatedetails { get; set; }
        public ICollection<Streamlist> Streamlist { get; set; }
    }
}
