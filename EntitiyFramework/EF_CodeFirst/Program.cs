using System.Runtime.InteropServices.ComTypes;
using System.Threading.Channels;
using Microsoft.EntityFrameworkCore;

namespace EF_CodeFirst;

class Program
{
    static async Task Main(string[] args)
    {
        using (MyDatabase db = new())
        {
            Console.WriteLine("Database: {0}", db.Database);
            Console.WriteLine("Can Connect: {0}", db.Database.CanConnect());
            Console.WriteLine();
        }

        using (MyDatabase db = new())
        {
            Console.Write("Before: ");
            await ShowCategoryName(db);
            Console.WriteLine();
            
            // Add new category
            try
            {
                var category = new Category()
                {
                    CategoryId = 3,
                    CategoryName = "Vegetable"
                };
                
                await db.Categories.AddAsync(category);
                await db.SaveChangesAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine("Can't add new category. Error: {0}", e.Message);
            }
            
            // Remove existing categories
            try
            {
                var categoryDeleted = db.Categories.FirstOrDefault(category => category.CategoryId == 3);
                db.Categories.Remove(categoryDeleted!);
                await db.SaveChangesAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine("Can't remove categories. Error: {0}", e.Message);
            }
            
            Console.Write("After: ");
            await ShowCategoryName(db);
            Console.WriteLine();
        }
    }

    static async Task ShowCategoryName(MyDatabase db)
    {
        await db.Categories.ForEachAsync(category =>
        {
            Console.WriteLine(category.CategoryName + category.CategoryId);
        });
    }
}