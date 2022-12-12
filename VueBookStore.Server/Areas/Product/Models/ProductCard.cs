using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;
using VueBookStore.Server.Areas.Manufacturer.Models;
using VueBookStore.Server.Models;

namespace VueBookStore.Server.Areas.Product.Models;

/// <summary>
/// Товар.
/// </summary>
[Table("ProductCard")]
public abstract class ProductCard : Entity<Guid>
{
    [Display(Name = "Название")]
    public string Name { get; set; }
    
    [Display(Name = "Изображение на странице товара")]
    public string? CoverImagePath { get; set; }
    
    [Display(Name = "Изображение в каталоге")]
    public string? ThumbImagePath { get; set; }
    
    [Display(Name = "Дата поступления")]
    public DateTime ReceiptDate { get; set; }

    [Display(Name = "Цена со скидкой")]
    [Range(1, double.MaxValue, ErrorMessage = "Value for {0} must be between {1} and {2}.")]
    public decimal? NewPrice { get; set; }
    
    [Display(Name = "Цена без скидки")]
    [Range(1, double.MaxValue, ErrorMessage = "Value for {0} must be between {1} and {2}.")]
    public decimal OldPrice { get; set; }

    [NotMapped]
    [Display(Name = "Скидка в процентах")]
    public decimal DiscountPercent => NewPrice == null ? 0 : 1 - (OldPrice - (decimal) NewPrice) / OldPrice;

    [NotMapped]
    [Display(Name = "Скидка в рублях")]
    public decimal Discount => NewPrice == null ? 0 : OldPrice - (decimal) NewPrice;

    [Display(Name = "Короткое описание")]
    public string? ShortDescription { get; set; }
    
    [Display(Name = "Длинное описание")]
    public string? LongDescription { get; set; }
    
    /// <summary>
    /// Id Производителя.
    /// </summary>
    public Guid ManufacturerId { get; set; }
    
    /// <summary>
    /// Производитель.
    /// </summary>
    [JsonIgnore]
    [Display(Name = "Производитель")]
    public ManufacturerCard? Manufacturer { get; set; }
    
    /// <summary>
    /// Оценка.
    /// </summary>
    /// <remarks>Сколько звезд.</remarks>
    [Range(0, 5, ErrorMessage = "Value for {0} must be between {1} and {2}.")]
    [Display(Name = "Оценка")]
    public decimal Rating { get; set; }

    /// <summary>
    /// Участвует ли в распродаже.
    /// </summary>
    [Display(Name = "Распродажа")]
    public bool IsOnSale { get; set; }
}