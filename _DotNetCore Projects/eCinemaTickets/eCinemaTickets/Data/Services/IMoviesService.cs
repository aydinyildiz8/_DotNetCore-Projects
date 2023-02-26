using eCinemaTickets.Data.Base;
using eCinemaTickets.Data.ViewModels;
using eCinemaTickets.Models;
using System.Threading.Tasks;

namespace eCinemaTickets.Data.Services
{
    public interface IMoviesService: IEntityBaseRepository<Movie>
    {
        Task<Movie> GetMovieByIdAsync(int id);
        Task<NewMovieDropdownVM> GetNewMovieDropdownValues();
        Task AddNewMovieAsync(NewMovieVM data);
        Task UpdateMovieAsync(NewMovieVM data);
    }
}
