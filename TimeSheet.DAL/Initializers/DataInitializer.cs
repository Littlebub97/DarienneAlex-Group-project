using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TimeSheet.DAL.EF;

namespace TimeSheet.DAL.Initializers
{
   public static class DataInitializer
    {
        public static void InitializeData(IServiceProvider serviceProvider)
        {
            var context = serviceProvider.GetService<TimeSheetContext>();
            InitializeData(context);
        }
        public static void InitializeData(TimeSheetContext context)
        {
            context.Database.Migrate();
            ClearData(context);
            SeedData(context);
        }
        public static void ClearData(TimeSheetContext context)
        {
            ExecuteDeleteSQL(context, "Employees");
            ResetIdentity(context);
        }
        public static void ExecuteDeleteSQL(TimeSheetContext context, string tableName)
        {
            var sql = $"Delete from TimeSheet.{tableName}";
            context.Database.ExecuteSqlCommand(sql);
        }
        public static void ResetIdentity(TimeSheetContext context)
        {
            var tables = new[] {"Employees","timeSheet",
                ""};
            foreach (var itm in tables)
            {
                var sql = $"DBCC CHECKIDENT (\"Store.{itm}\", RESEED, -1);";
                context.Database.ExecuteSqlCommand(sql);
            }
        }

        public static void SeedData(TimeSheetContext context)
        {
            try
            {
                if (!context.Employees.Any())
                {
                    context.Employees.AddRange(TimeSheetSampleData.GetEmployees());
                    context.SaveChanges();
                }
            }
            //  if (!context.Products.Any())
            //{
            //    context.Products.AddRange(
            //      TimeSheetSampleData.GetProducts(context.Employees.ToList()));
            // context.SaveChanges();
            //}
            //if (!context.Customers.Any())
            // {
            //    context.Customers.AddRange(
            //       TimeSheetSampleData.GetAllCustomerRecords(context));
            //   context.SaveChanges();
            // }
            // var customer = context.Customers.FirstOrDefault();
            // if (!context.Orders.Any())
            // {
            //    context.Orders.AddRange(TimeSheetSampleData.GetOrders(customer, context));
            //   context.SaveChanges();
            // }
            // if (!context.ShoppingCartRecords.Any())
            // {
            //    context.ShoppingCartRecords.AddRange(
            //      TimeSheetSampleData.Get(customer, context));
            //  context.SaveChanges();
            //    }
            // }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}

