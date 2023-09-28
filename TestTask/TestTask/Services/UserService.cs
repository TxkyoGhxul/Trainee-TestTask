using Microsoft.EntityFrameworkCore;
using TestTask.Data;
using TestTask.Models;
using TestTask.Services.Interfaces;

namespace TestTask.Services;
public class UserService : IUserService
{
    private readonly ApplicationDbContext _dbContext;

    public UserService(ApplicationDbContext dbContext) => _dbContext = dbContext;

    /// <inheritdoc />
    public async Task<User> GetUser() => 
        _dbContext.Users
            .Include(user => user.Orders)
            .MaxBy(user => user.Orders.Count);

    /// <inheritdoc />
    public async Task<List<User>> GetUsers() => 
        await _dbContext.Users
            .Where(user => user.Status == Enums.UserStatus.Inactive)
            .ToListAsync();
}
