using BookstoreManagementSystemLibrary.Database.Core;
using BookstoreManagementSystemLibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace BookstoreManagementSystemLibrary.Database.EF.Connectors
{
    public partial class EFDataConnector : IBookRepo
    {
        public Result<Book> CreateBook(Book book)
        {
            using var transaction = context.Database.BeginTransaction();
            try
            {
                context.Books.Add(book);
                context.SaveChanges();

                transaction.Commit();
                return new Result<Book>(Data: book,Message:"Book Created Successfuly.");
            }
            catch (Exception e)
            {
                transaction.Rollback();
                return new Result<Book>(Message: "Fail to create the book");
            }
        }

        public Result<bool> DeleteBook(Book book)
        {
            using var transaction = context.Database.BeginTransaction();
            try
            {
                book.IsDeleted = true;

                context.Books.Update(book);
                context.SaveChanges();

                transaction.Commit();
                return new Result<bool>(Data: true, Message: "Books delete successful.");
            }
            catch (Exception)
            {
                transaction.Rollback();
                return new Result<bool>(Message: "Fail to Update the book");
            }
        }

        public Result<Book> EditBook(Book book)
        {
            using var transaction = context.Database.BeginTransaction();
            try
            {
                context.Books.Update(book);
                context.SaveChanges();

                transaction.Commit();
                return new Result<Book>(Data: book, Message: "Book update successful.");
            }
            catch (Exception)
            {
                transaction.Rollback();
                return new Result<Book>(Message: "Fail to Update the book");
            }
        }

        public Result<List<Book>> FindBook(string name)
        {
            try
            {
                var findBook = context.Books
                  //.AsNoTracking()
                  .Where(u => u.Title.Contains(name))
                  .Where(x => x.IsDeleted == false);

                if (!findBook.Any())
                {
                    return new Result<List<Book>>(Message: "book not found");
                }

                return new Result<List<Book>>(Data: [.. findBook]);
            }
            catch (Exception)
            {
                return new Result<List<Book>>(Message: "Fail to find the book");
            }
        }

        public Result<List<Book>> GetAllBooks()
        {
            try
            {
                var findBook = context.Books
                  //.AsNoTracking()
                  .Include(x => x.Category)
                  .Include(x => x.OrderDetails)
                  .Include(x => x.Suppliers)
                  .Where(x => x.IsDeleted == false);

                if (!findBook.Any())
                {
                    return new Result<List<Book>>(Message: "book not found");
                }

                return new Result<List<Book>>(Data: [.. findBook]);
            }
            catch (Exception e)
            {
                return new Result<List<Book>>(Message: "Fail to find the book");
            }
        }

    }
}
