using System;
using System.Collections.Generic;

namespace TeslaAcademy.Models
{
    public partial class Lookup
    {
        public int Lookupid { get; set; }
        public string Lookupname { get; set; }
        public string Type { get; set; }
        public int? Position { get; set; }
        public int? Parentid { get; set; }
        public bool? Isactive { get; set; }
        public DateTime? Createddate { get; set; }
    }
}
