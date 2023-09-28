using TestTask.Models;

namespace TestTask.Services.Interfaces
{
    public interface IUserService
    {
        /// <summary>
        /// Возвращать пользователя с самым большим количеством заказов
        /// </summary>
        /// <returns>Пользователь с самым большим количеством заказов</returns>
        public Task<User> GetUser();

        /// <summary>
        /// Возвращать пользователей с статусом Inaсtive
        /// </summary>
        /// <returns>Пользователи с статусом Inaсtive</returns>
        public Task<List<User>> GetUsers();
    }
}
