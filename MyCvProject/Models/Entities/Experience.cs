using System;
using System.Collections.Generic;

#nullable disable

namespace MyCvProject.Models.Entities
{
    public partial class Experience
    {
        public int Id { get; set; }
        public string Meslek { get; set; }
        public string Alan { get; set; }
        public string Aciklama { get; set; }
        public string Tarih { get; set; }
    }
}
