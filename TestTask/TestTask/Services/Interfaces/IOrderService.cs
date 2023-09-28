using TestTask.Models;

namespace TestTask.Services.Interfaces
{
    public interface IOrderService
    {
        /// <summary>
        /// Возвращает заказ с самой большой суммой заказа
        /// </summary>
        /// <returns>Заказ с самой большой суммой заказа</returns>
        public Task<Order> GetOrder();

        /// <summary>
        /// Возвращает заказы, в которых количество товара больше 10
        /// </summary>
        /// <returns>Заказы, в которых количество товара больше 10</returns>
        public Task<List<Order>> GetOrders();
    }
}
