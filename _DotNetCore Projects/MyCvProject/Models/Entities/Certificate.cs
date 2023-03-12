using System;
using System.Collections.Generic;

#nullable disable

namespace MyCvProject.Models.Entities
{
    public partial class Certificate
    {
        public int Id { get; set; }
        public string SertifikaAdı { get; set; }
        public string VerenKurulus { get; set; }
        public string Aciklama { get; set; }
        public string Tarih { get; set; }
    }
}
