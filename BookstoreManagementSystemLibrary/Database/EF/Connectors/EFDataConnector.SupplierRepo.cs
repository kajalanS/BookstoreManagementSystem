using BookstoreManagementSystemLibrary.Database.Core;
using BookstoreManagementSystemLibrary.Helpers;
using BookstoreManagementSystemLibrary.Models;
using BookstoreManagementSystemLibrary.Services;
using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagementSystemLibrary.Database.EF.Connectors
{
	public partial class EFDataConnector : ISupplierRepo
	{
		//public Result<User> CreateUser(User supplier)
		//{
		//	using var transaction = context.Database.BeginTransaction();

		//	try
		//	{
		//		context.Users.Add(supplier);
		//		context.SaveChanges();

		//		transaction.Commit();
		//		return new Result<User>(Data: supplier);
		//	}
		//	catch (Exception)
		//	{
		//		transaction.Rollback();
		//		return new Result<User>(Message: "User not create");
		//	}
		//}

		//public Result<bool> DeleteUser(User supplier)
		//{
		//	using var transaction = context.Database.BeginTransaction();

		//	try
		//	{
		//		supplier.IsDeleted = true;

		//		context.Users.Update(supplier);
		//		context.SaveChanges();

		//		transaction.Commit();
		//		return new Result<bool>(Data: true, Message: "User delete successful.");
		//	}
		//	catch (Exception)
		//	{
		//		transaction.Rollback();
		//		return new Result<bool>(Message: "Fail to Update the supplier");
		//	}
		//}

		//public Result<User> FindUserByUsername(string username)
		//{
		//	try
		//	{
		//		var findSupplier = context.Users
		//			.AsNoTracking()
		//			.Where(u => u.Username == username)
		//			.Where(x => x.IsDeleted == false);

		//		if (!findSupplier.Any())
		//		{
		//			return new Result<User>(Message: "loginUser not found");
		//		}

		//		return new Result<User>(Data: findSupplier.FirstOrDefault());
		//	}
		//	catch (Exception)
		//	{
		//		return new Result<User>(Message: "Fail to find the loginUser");
		//	}
		//}

		//public Result<List<User>> GetAllUsaers()
		//{
		//	try
		//	{
		//		var findSupplier = context.Users
		//			.AsNoTracking()
		//			.Where(x => x.IsDeleted == false);

		//		if (!findSupplier.Any())
		//		{
		//			return new Result<List<User>>(Message: "User not found");
		//		}

		//		return new Result<List<User>>(Data: [.. findSupplier]);
		//	}
		//	catch (Exception e)
		//	{
		//		return new Result<List<User>>(Message: "Fail to find the User");
		//	}
		//}

		//public Task<Result<User>> ResetPasswordAsync(string email, string salt)
		//{
		//	try
		//	{
		//		var findSupplier = context.Users
		//			.AsNoTracking()
		//			.Where(u => u.Email == email)
		//			.Where(x => x.IsDeleted == false);
		//		var supplier = findSupplier.FirstOrDefault();

		//		if (supplier == null || supplier.Email == null)
		//		{
		//			return Task.FromResult(new Result<User>(Message: "loginUser not found"));
		//		}


		//		//var newPassword = PasswordGenerator.GenerateRandomPassword(10);
		//		var newPassword = 10.GenerateRandomPassword();

		//		Dictionary<EmailTemplatePlaceHolder, string> dataMapper = new()
		//		{
		//			{EmailTemplatePlaceHolder.Username,supplier.Username! },
		//			{EmailTemplatePlaceHolder.Password,newPassword },
		//		};

		//		//await Task.Run(async () =>
		//		//{
		//		//    await loginUser.Email.SendHtmlEmailAsync("Password Reset", EmailTemplateType.PasswordReset, dataMapper);
		//		//});

		//		Thread thread = new(() =>
		//		{
		//			Task task = supplier.Email.SendHtmlEmailAsync("Password Reset", EmailTemplateType.PasswordReset, dataMapper);
		//		});

		//		thread.Start();


		//		supplier.PasswordHash = newPassword.GetHash(salt);
		//		context.Users.Update(supplier);
		//		context.SaveChanges();


		//		return Task.FromResult(new Result<User>(Data: supplier));
		//	}
		//	catch (Exception)
		//	{
		//		return Task.FromResult(new Result<User>(Message: "Fail to find the loginUser"));
		//	}
		//}

		//public Task<Result<User>> ResetPasswordAsync(User userData, string salt)
		//{
		//	try
		//	{
		//		var findSupplier = context.Users
		//			.AsNoTracking()
		//			.Where(u => u.UserId == userData.UserId)
		//			.Where(x => x.IsDeleted == false);
		//		var supplier = findSupplier.FirstOrDefault();

		//		if (supplier == null || supplier.Email == null)
		//		{
		//			return Task.FromResult(new Result<User>(Message: "loginUser not found"));
		//		}

		//		return SendResetPasswordMail(salt, supplier);
		//	}
		//	catch (Exception)
		//	{
		//		return Task.FromResult(new Result<User>(Message: "Fail to find the loginUser"));
		//	}
		//}

		//private Task<Result<User>> SendResetPasswordMail(string salt, User supplier)
		//{

		//	//var newPassword = PasswordGenerator.GenerateRandomPassword(10);
		//	var newPassword = 10.GenerateRandomPassword();

		//	Dictionary<EmailTemplatePlaceHolder, string> dataMapper = new()
		//		{
		//			{EmailTemplatePlaceHolder.Username,supplier.Username! },
		//			{EmailTemplatePlaceHolder.Password,newPassword },
		//		};

		//	//await Task.Run(async () =>
		//	//{
		//	//    await loginUser.Email.SendHtmlEmailAsync("Password Reset", EmailTemplateType.PasswordReset, dataMapper);
		//	//});

		//	Task task = supplier.Email.SendHtmlEmailAsync("Password Reset", EmailTemplateType.PasswordReset, dataMapper);

		//	supplier.PasswordHash = newPassword.GetHash(salt);
		//	context.Users.Update(supplier);
		//	context.SaveChanges();


		//	return Task.FromResult(new Result<User>(Data: supplier));
		//}

		//public Result<User> TriggerLogin(string username)
		//{
		//	using var transaction = context.Database.BeginTransaction();
		//	try
		//	{
		//		var loginUser = context.Users
		//			.AsNoTracking()
		//			.Where(x => x.Username == username)
		//			.Where(x => x.IsDeleted == false)
		//			.FirstOrDefault();


		//		if (loginUser == null)
		//		{
		//			return new Result<User>(Message: "Category not found");
		//		}

		//		loginUser.LastLogin = DateTime.Now;
		//		context.Users.Update(loginUser);
		//		context.SaveChanges();

		//		transaction.Commit();
		//		return new Result<User>(Data: loginUser);
		//	}
		//	catch (Exception e)
		//	{
		//		transaction.Rollback();
		//		return new Result<User>(Message: "Fail to login the loginUser");
		//	}
		//}

		//public Result<User> UpdateUserProfile(User supplier)
		//{
		//	using var transaction = context.Database.BeginTransaction();

		//	try
		//	{
		//		context.Users.Update(supplier);
		//		context.SaveChanges();

		//		transaction.Commit();
		//		return new Result<User>(Data: supplier, Message: "User update successful.");
		//	}
		//	catch (Exception)
		//	{
		//		transaction.Rollback();
		//		return new Result<User>(Message: "Fail to Update the User");
		//	}
		//}


		public Result<Supplier> CreateSupplier(Supplier supplier)
		{
			using var transaction = context.Database.BeginTransaction();

			try
			{
				context.Suppliers.Add(supplier);
				context.SaveChanges();

				transaction.Commit();
				return new Result<Supplier>(Data: supplier);
			}
			catch (Exception)
			{
				transaction.Rollback();
				return new Result<Supplier>(Message: "User not supplier");
			}
		}

		public Result<bool> DeleteSupplier(Supplier supplier)
		{
			using var transaction = context.Database.BeginTransaction();

			try
			{
				supplier.IsDeleted = true;

				context.Suppliers.Update(supplier);
				context.SaveChanges();

				transaction.Commit();
				return new Result<bool>(Data: true, Message: "Supplier delete successful.");
			}
			catch (Exception)
			{
				transaction.Rollback();
				return new Result<bool>(Message: "Fail to Update the supplier");
			}
		}

		public Result<Supplier> EditSupplier(Supplier supplier)
		{
			using var transaction = context.Database.BeginTransaction();

			try
			{
				context.Suppliers.Update(supplier);
				context.SaveChanges();

				transaction.Commit();
				return new Result<Supplier>(Data: supplier, Message: "Supplier update successful.");
			}
			catch (Exception)
			{
				transaction.Rollback();
				return new Result<Supplier>(Message: "Fail to Update the Supplier");
			}
		}

		public Result<Supplier> FindSupplier(string name)
		{
			try
			{
				var findSupplier = context.Suppliers
					//.AsNoTracking()
					.Where(u => u.Name == name)
					.Where(x => x.IsDeleted == false);

				if (!findSupplier.Any())
				{
					return new Result<Supplier>(Message: "Supplier not found");
				}

				return new Result<Supplier>(Data: findSupplier.FirstOrDefault());
			}
			catch (Exception)
			{
				return new Result<Supplier>(Message: "Fail to find the Supplier");
			}
		}

		public Result<List<Supplier>> GetAllSupplier()
		{
			try
			{
				var findSupplier = context.Suppliers
					//.AsNoTracking()
					.Where(x => x.IsDeleted == false);

				if (!findSupplier.Any())
				{
					return new Result<List<Supplier>>(Message: "Supplier not found");
				}

				return new Result<List<Supplier>>(Data: [.. findSupplier]);
			}
			catch (Exception e)
			{
				return new Result<List<Supplier>>(Message: "Fail to find the Supplier");
			}
		}
	}
}
