using System;
using System.Collections.Generic;

#nullable disable

namespace MyCvProject.Models.Entities
{
    public partial class About
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Adres { get; set; }
        public string Meslek { get; set; }
        public string Telefon { get; set; }
        public string Aciklama { get; set; }
        public string Mail { get; set; }
        public string ResimUrl { get; set; }
    }
}
