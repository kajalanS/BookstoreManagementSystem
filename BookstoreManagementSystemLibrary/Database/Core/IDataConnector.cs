using BookstoreManagementSystemLibrary.Models;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BookstoreManagementSystemLibrary.Database.Core
{
    public record Result<T>(T? Data = default, string? Message = null);

    public interface IDataConnector : IDashboard,IUserRepo, IBookRepo, ICategoryRepo
    {
    }

    public interface IDashboard
    {
        Result<DashboardDataResult> GetDashboardData();
    }

    public interface IUserRepo
    {
        Result<User> CreateUser(User user);
        Result<User> FindUserByUsername(string username);
        Result<User> TriggerLogin(string username);
        Task<Result<User>> ResetPasswordAsync(string email, string salt);
    }
    public interface IBookRepo
    {
        Result<Book> CreateBook(Book book);
        Result<List<Book>> FindBook(string name);
        Result<List<Book>> GetAllBooks();
    }

    public interface ICategoryRepo
    {
        Result<Category> CreateCategory(Category category);
        Result<Category> FindCategory(string name);
        Result<List<Category>> GetAllCategories();
    }

}
