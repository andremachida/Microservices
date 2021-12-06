using App.Models;
using System.Threading.Tasks;

namespace App.Services
{
    public interface IBasketService
    {
        Task<BasketModel> GetBasket(string userName);

        Task<BasketModel> UpdateBasket(BasketModel model);

        Task CheckoutBasket(BasketCheckoutModel model);
    }
}