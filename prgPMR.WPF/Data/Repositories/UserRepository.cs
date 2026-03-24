using Microsoft.EntityFrameworkCore;
using prgPMR.WPF.Core.Models;

namespace prgPMR.WPF.Data.Repositories;

public interface IUserRepository
{
    Task<User?> ValidateLoginAsync(string username, string password);
    Task<User?> GetByIdAsync(int userId);
    Task        UpdateAsync(User user);
}

public class UserRepository : IUserRepository
{
    private readonly AppDbContext _db;

    public UserRepository(AppDbContext db) => _db = db;

    public async Task<User?> ValidateLoginAsync(string username, string password)
        => await _db.Users
            .FirstOrDefaultAsync(u =>
                u.Username == username &&
                u.Password == password);

    public async Task<User?> GetByIdAsync(int userId)
        => await _db.Users.FindAsync(userId);

    public async Task UpdateAsync(User user)
    {
        _db.Users.Update(user);
        await _db.SaveChangesAsync();
    }
}
