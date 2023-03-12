using System;
using System.Collections.Generic;

#nullable disable

namespace MyCvProject.Models.Entities
{
    public partial class Education
    {
        public int Id { get; set; }
        public string Okul { get; set; }
        public string Fakülte { get; set; }
        public string Bölüm { get; set; }
        public string Gno { get; set; }
        public string MezuniyetTarihi { get; set; }
    }
}
