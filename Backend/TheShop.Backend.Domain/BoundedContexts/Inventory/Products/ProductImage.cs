using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheShop.Backend.Domain.BoundedContexts.Inventory.Products;
public class ProductImage
{
    public Guid Id { get; private init; }

    public string ImageSource { get; private set; }
    public int ImageOrder { get; private set; }
}
