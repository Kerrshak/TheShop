using TheShop.Shared.ValueObjects;

namespace TheShop.Backend.Domain.BoundedContexts.Inventory.Products;

public class Product
{
    private Guid _id;
    public Guid Id { get => _id; private set => _id = value; }

    private string _name;
    public string Name { get => _name; private set => _name = value; }

    private string _description;
    public string Description { get => _description; private set => _description = value; }

    private Price _price;
    public Price Price { get => _price; private set => _price = value; }

    private readonly ICollection<ProductImage> _images = [];
    public IEnumerable<ProductImage> Images => _images;
}

