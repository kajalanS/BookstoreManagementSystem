using BookstoreManagementSystemLibrary.Database.Core;
using BookstoreManagementSystemLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagementSystemLibrary.Database.EF.Connectors
{
    public partial class EFDataConnector : ICustomerRepo
    {
        public Result<User> CreateCustomer(User customer)
        {
            using var transaction = context.Database.BeginTransaction();

            try
            {
                customer.Role = Core.Enum.UserRole.Customer;

                context.Users.Add(customer);
                context.SaveChanges();

                transaction.Commit();
                return new Result<User>(Data: customer);
            }
            catch (Exception)
            {
                transaction.Rollback();
                return new Result<User>(Message: "Fail to create the Customer");
            }
        }

        public Result<List<User>> GetAllCustomer()
        {
            try
            {
                var findCustomer = context.Users.Where(x=>x.Role == Core.Enum.UserRole.Customer).Where(x => x.IsDeleted == false);

                if (!findCustomer.Any())
                {
                    return new Result<List<User>>(Message: "Customer not found");
                }

                return new Result<List<User>>(Data: [.. findCustomer]);
            }
            catch (Exception e)
            {

                return new Result<List<User>>(Message: "Fail to find the Customer");
            }
        }
    }
}
