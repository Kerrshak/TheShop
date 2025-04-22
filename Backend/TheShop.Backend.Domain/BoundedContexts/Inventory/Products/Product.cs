using TheShop.Shared.ValueObjects;

namespace TheShop.Backend.Domain.BoundedContexts.Inventory.Products;

public class Product
{
    public Guid Id { get; private init; }

    public string Name { get; private set; }
    public string Description { get; private set; }

    public Price Price { get; private set; }

    public ICollection<ProductImage> Images { get; } = [];
}

