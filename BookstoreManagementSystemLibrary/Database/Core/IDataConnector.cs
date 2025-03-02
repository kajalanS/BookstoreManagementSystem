using BookstoreManagementSystemLibrary.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BookstoreManagementSystemLibrary.Database.Core
{

    public interface IDataConnector : IUserRepo, IBookRepo
    {

    }

    public interface IUserRepo
    {
        User? CreateUser(User user);
    }
    public interface IBookRepo
    {
        Book? CreateBook(Book book);
    }
}
