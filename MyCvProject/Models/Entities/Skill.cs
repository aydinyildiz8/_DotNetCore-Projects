using System;
using System.Collections.Generic;

#nullable disable

namespace MyCvProject.Models.Entities
{
    public partial class Skill
    {
        public int Id { get; set; }
        public string Yetenek { get; set; }
        public byte? Oran { get; set; }
    }
}
