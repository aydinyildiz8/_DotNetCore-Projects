namespace eCinemaTickets.Models
{
    public class Actor_Movie
    {
        //13. Adding model relationship
        public int MovieId { get; set; }
        public Movie Movie { get; set; }

        public int ActorId { get; set; }
        public Actor Actor { get; set; }
        //13. Adding model relationship



    }
}
