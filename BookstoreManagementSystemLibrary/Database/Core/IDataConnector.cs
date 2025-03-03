using BookstoreManagementSystemLibrary.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BookstoreManagementSystemLibrary.Database.Core
{
    public record Result<T>(T? data = default, string? message = null);


    public interface IDataConnector : IUserRepo, IBookRepo, ICategoryRepo
    {

    }

    public interface IUserRepo
    {
        Result<User> CreateUser(User user);
        Result<User> FindUserByUsername(string username);
    }
    public interface IBookRepo
    {
        Result<Book> CreateBook(Book book);
        Result<Book> FindBook(string name);
        Result<List<Book>> GetAllBooks();
    }

    public interface ICategoryRepo
    {
        Result<Category> CreateCategory(Category category);
        Result<Category> FindCategory(string name);
        Result<List<Category>> GetAllCategories();
    }

}
