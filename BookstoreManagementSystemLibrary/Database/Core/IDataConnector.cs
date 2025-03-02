using BookstoreManagementSystemLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagementSystemLibrary.Database.Core
{
    public interface IDataConnector
    {
        // CREATE USER
        User CreateUser(User user);

    }
}
