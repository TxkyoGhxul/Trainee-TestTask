using Microsoft.EntityFrameworkCore;
using TestTask.Data;
using TestTask.Models;
using TestTask.Services.Interfaces;

namespace TestTask.Services;
public class OrderService : IOrderService
{
    private readonly ApplicationDbContext _dbContext;

    public OrderService(ApplicationDbContext dbContext) => _dbContext = dbContext;

    /// <inheritdoc />
    public async Task<Order> GetOrder() => 
        _dbContext.Orders.MaxBy(order => order.Price);

    /// <inheritdoc />
    public async Task<List<Order>> GetOrders() => 
        await _dbContext.Orders.Where(order => order.Quantity > 10).ToListAsync();
}
