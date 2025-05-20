using ElectronicProductsAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ElectronicProductsAPI.Data
{
    public static class SeedData
    {
        public static void Initialize(ApplicationDbContext context)
        {
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product { Name = "بطارية", Description = "بطارية 9V تستخدم للمشاريع الإلكترونية." },
                    new Product { Name = "ترانزستور", Description = "مكون إلكتروني لتكبير الإشارة." }
                );
                context.SaveChanges();
            }
        }
    }
}