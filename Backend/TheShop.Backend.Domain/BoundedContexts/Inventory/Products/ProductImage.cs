namespace TheShop.Backend.Domain.BoundedContexts.Inventory.Products;
public class ProductImage
{
    private Guid _id;
    public Guid Id { get => _id; private init => _id = value; }

    private Guid _productId;
    public Guid ProductId { get => _productId; private init => _productId = value; }

    private string _imageSource;
    public string ImageSource { get => _imageSource; private set => _imageSource = value; }

    private int _imageOrder;
    public int ImageOrder { get => _imageOrder; private set => _imageOrder = value; }
}
