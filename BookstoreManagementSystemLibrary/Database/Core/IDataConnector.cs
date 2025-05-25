using BookstoreManagementSystemLibrary.Models;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BookstoreManagementSystemLibrary.Database.Core
{
    public record Result<T>(T? Data = default, string? Message = null);

    public interface IDataConnector : IDashboardRepo, IUserRepo, IBookRepo, ICategoryRepo, IOrderRepo, ISupplierRepo, IAuditLogRepo, ICustomerRepo
    {
        Result<bool> CheckConnection();
    }

    public interface ICustomerRepo
    {
        Result<User> CreateCustomer(User customer);
        Result<List<User>> GetAllCustomer();
    }

    public interface IAuditLogRepo
    {
        //Result<AuditLog> DeleteAuditLog(AuditLog auditLog);
        //Result<AuditLog> EditAuditLog(AuditLog auditLog);
        Result<List<AuditLog>> GetAllAuditLog();
    }

    public interface IDashboardRepo
    {
        Result<DashboardDataResult> GetDashboardData();
    }

    public interface ISupplierRepo
    {
        Result<Supplier> CreateSupplier(Supplier supplier);
        Result<Supplier> FindSupplier(string name);
        Result<List<Supplier>> GetAllSupplier();
        Result<Supplier> EditSupplier(Supplier supplier);
        Result<bool> DeleteSupplier(Supplier supplier);
    }


    public interface IUserRepo
    {
        Result<User> CreateUser(User user);
        Result<User> FindUserByUsername(string username);
        Result<User> TriggerLogin(string username);

        Task<Result<User>> ResetPasswordAsync(string email, string salt);
        Task<Result<User>> ResetPasswordAsync(User user, string salt);
        Result<User> UpdateUserProfile(User user);
        Result<bool> DeleteUser(User user);
        Result<List<User>> GetAllUsers();
    }



    public interface IBookRepo
    {
        Result<Book> CreateBook(Book book);
        Result<List<Book>> FindBook(string name);
        Result<List<Book>> GetAllBooks();
        Result<Book> EditBook(Book book);
        Result<bool> DeleteBook(Book book);
    }


    public interface ICategoryRepo
    {
        Result<Category> CreateCategory(Category category);
        Result<Category> FindCategory(string name);
        Result<List<Category>> GetAllCategories();
    }

    public interface IOrderRepo
    {
        Result<Order> CreateOrder(Order order);
        Result<Order> FindOrder(int orderId);
        Result<List<Order>> GetAllOrders();
        Result<Order> EditOrder(Order order);
        Result<bool> DeleteOrder(Order order);
    }

}
