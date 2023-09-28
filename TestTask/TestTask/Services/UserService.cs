using Microsoft.EntityFrameworkCore;
using TestTask.Data;
using TestTask.Enums;
using TestTask.Models;
using TestTask.Services.Interfaces;

namespace TestTask.Services;
public class UserService : IUserService
{
    private readonly ApplicationDbContext _dbContext;

    public UserService(ApplicationDbContext dbContext) => _dbContext = dbContext;

    /// <inheritdoc />
    public async Task<User> GetUser()
    {
        var users = await _dbContext.Users.Include(user => user.Orders).ToListAsync();
        return users.MaxBy(user => user.Orders.Count);
    }

    /// <inheritdoc />
    public async Task<List<User>> GetUsers() => 
        await _dbContext.Users
            .Where(user => user.Status == UserStatus.Inactive)
            .ToListAsync();
}
