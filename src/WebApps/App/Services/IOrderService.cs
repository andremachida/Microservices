using App.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace App.Services
{
    public interface IOrderService
    {
        Task<IEnumerable<OrderResponseModel>> GetOrdersByUserName(string userName);
    }
}