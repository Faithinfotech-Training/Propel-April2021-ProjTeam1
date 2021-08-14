using System;
using System.Collections.Generic;

namespace TeslaAcademy.Models
{
    public partial class Streamlist
    {
        public int Streamid { get; set; }
        public int? Courseid { get; set; }
        public int? Degreeid { get; set; }
        public string Stream { get; set; }

        public Coursemain Course { get; set; }
        public Degreelist Degree { get; set; }
    }
}
