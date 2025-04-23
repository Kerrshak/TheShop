using Microsoft.EntityFrameworkCore;
using TheShop.Backend.Domain.BoundedContexts.Inventory.Products;

namespace TheShop.Backend.Data.Context;

internal class DataContext : DbContext
{
    internal DbSet<Product> Products { get; set; }
    internal DbSet<ProductImage> ProductImages { get; set; }
}
