using VueBookStore.Server.Areas.Product.Models;
using VueBookStore.Server.Models;

namespace VueBookStore.Server.Areas.Shop.Models;

/// <summary>
/// Позиция в корзине.
/// </summary>
public class CartLine : Entity<Guid>
{
    public ProductCard Product { get; set; }
    public int Quantity { get; set; }

    public decimal Total => Product.OldPrice * Quantity;
}