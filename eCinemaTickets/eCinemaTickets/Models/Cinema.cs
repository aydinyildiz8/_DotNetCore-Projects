using eCinemaTickets.Data.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eCinemaTickets.Models
{
    public class Cinema : IEntityBase
    {
        public int Id { get; set; }


        [Display(Name = "Cinema Logo")]
        [Required(ErrorMessage ="Cinema Logo is Required")]
        public string Logo { get; set; }


        [Display(Name = "Cinema Name")]
        [Required(ErrorMessage = "Cinema Name is Required")]
        public string Name { get; set; }


        [Display(Name = "Description")]
        [Required(ErrorMessage = "Cinema Description is Required")]
        public string Description { get; set; }

       
        // Relationships
        public List<Movie> Movies { get; set; }
        

    }
}
