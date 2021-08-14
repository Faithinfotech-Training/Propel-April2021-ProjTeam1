using System;
using System.Collections.Generic;

namespace TeslaAcademy.Models
{
    public partial class Candidatedetails
    {
        public int Candidateid { get; set; }
        public int? Courseid { get; set; }
        public int? Degreeid { get; set; }
        public string Coursename { get; set; }
        public string Candidateimage { get; set; }
        public string Candidatenumber { get; set; }
        public string Email { get; set; }
        public DateTime? Dob { get; set; }
        public string Address { get; set; }
        public string Collegename { get; set; }
        public int? Yop { get; set; }
        public double? Percentage { get; set; }
        public int? Backlogs { get; set; }
        public int? Experience { get; set; }
        public string Status { get; set; }
        public DateTime? Createddate { get; set; }
        public bool? Isactive { get; set; }

        public Coursemain Course { get; set; }
        public Degreelist Degree { get; set; }
    }
}
