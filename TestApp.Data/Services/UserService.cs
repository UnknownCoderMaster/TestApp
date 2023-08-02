using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using System.Text;
using TestApp.Data.DTOs;
using TestApp.Data.Models;

namespace TestApp.Data.Services;

public class UserService
{
    private readonly AppDbContext dbContext;

    public UserService(AppDbContext dbContext)
    {
        this.dbContext = dbContext;
    }


    //Register user
    public UserAuth Register(User user)
    {
        var foundUser = dbContext.Users.FirstOrDefault(s => s.Username == user.Username);

        if (foundUser != null)
        {
            return new UserAuth { Id = user.Id, Username = user.Username, Password = user.Password, IsAuth = false };
        }

        var security = user.Password;

        user.Password = GetSHA256Hash(user.Password);

        dbContext.Add(user);

        dbContext.SaveChanges();

        return new UserAuth { Id = user.Id, Username = user.Username, Password = security, IsAuth = true };
    }

    //Login User
    public async Task<UserAuth> Login(User user)
    {
        var foundUser = await dbContext.Users.FirstOrDefaultAsync(u => u.Username == user.Username); 
        if (foundUser != null && foundUser.Password == GetSHA256Hash(user.Password)) 
        {
            return new UserAuth {Id = foundUser.Id, Username = user.Username, Password = user.Password, IsAuth = true };
        }

        return new UserAuth {Id = user.Id, Username = user.Username, Password = user.Password, IsAuth = false };
    }

    private static string GetSHA256Hash(string input)
    {
        using (SHA256 sha256Hash = SHA256.Create())
        {
            byte[] data = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            StringBuilder sb = new StringBuilder();

            foreach (byte b in data)
            {
                sb.Append(b.ToString("x2"));
            }

            return sb.ToString();
        }
    }

}
