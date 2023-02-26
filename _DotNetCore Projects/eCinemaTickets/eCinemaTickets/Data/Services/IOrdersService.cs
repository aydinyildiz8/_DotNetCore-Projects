using eCinemaTickets.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eCinemaTickets.Data.Services
{
    public interface IOrdersService
    {
        Task StoreOrderAsync(List<ShoppingCartItem> items, string userId, string userEmailAddress);
        Task<List<Order>> GetOrdersByUserIdAsync (string userId);
        //Task<List<Order>> GetOrdersByUserIdAsync (string userId, string userEmailAddress);

    }
}
