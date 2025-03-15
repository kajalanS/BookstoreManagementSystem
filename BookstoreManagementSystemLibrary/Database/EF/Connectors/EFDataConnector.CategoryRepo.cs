using BookstoreManagementSystemLibrary.Database.Core;
using BookstoreManagementSystemLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagementSystemLibrary.Database.EF.Connectors
{
	public partial class EFDataConnector : ICategoryRepo
	{
		public Result<Category> CreateCategory(Category category)
		{
			using var transaction = context.Database.BeginTransaction();

			try
			{
				context.Categories.Add(category);
				context.SaveChanges();

				transaction.Commit();
				return new Result<Category>(Data: category);
			}
			catch (Exception)
			{
				transaction.Rollback();
				return new Result<Category>(Message: "Fail to create the category");
			}
		}

		public Result<Category> FindCategory(string name)
		{
			try
			{
				var findCategory = context.Categories
					.Where(u => u.CategoryName == name)
					.Where(x => x.IsDeleted == false);

				if (!findCategory.Any())
				{
					return new Result<Category>(Message: "Category not found");
				}

				return new Result<Category>(Data: findCategory.FirstOrDefault());
			}
			catch (Exception)
			{
				return new Result<Category>(Message: "Fail to find the Category");
			}
		}

		public Result<List<Category>> GetAllCategories()
		{
			try
			{
				var findCategory = context.Categories.Where(x => x.IsDeleted == false);

				if (!findCategory.Any())
				{
					return new Result<List<Category>>(Message: "Category not found");
				}

				return new Result<List<Category>>(Data: [.. findCategory]);
			}
			catch (Exception e)
			{

				return new Result<List<Category>>(Message: "Fail to find the Category");
			}
		}



	}
}
