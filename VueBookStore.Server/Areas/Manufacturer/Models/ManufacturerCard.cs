using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using VueBookStore.Server.Areas.Product.Models;
using VueBookStore.Server.Models;

namespace VueBookStore.Server.Areas.Manufacturer.Models;

/// <summary>
/// Производитель.
/// </summary>
public class ManufacturerCard : Entity<Guid>
{
    [Display(Name = "Название")] 
    public string Name { get; set; }
    
    [JsonIgnore]
    public List<BookCard> Books { get; set; } = new();
}