using System;
using System.Collections.Generic;

#nullable disable

namespace MyCvProject.Models.Entities
{
    public partial class SocialMedia
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Link { get; set; }
        public string Ikon { get; set; }
        public bool? Durum { get; set; }
    }
}
