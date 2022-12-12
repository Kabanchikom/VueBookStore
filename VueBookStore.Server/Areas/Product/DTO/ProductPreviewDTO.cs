using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace VueBookStore.Server.Areas.Product.DTO;

public class ProductPreviewDTO
{
    public string Id { get; set; }
    
    [Display(Name = "Название")]
    public string Name { get; set; }
    
    [Display(Name = "Изображение в каталоге")]
    public string? ThumbImagePath { get; set; }
    
    [Display(Name = "Цена до скидки")]
    public decimal OldPrice { get; set; }
    
    [Display(Name = "Цена со скидкой")]
    public decimal? NewPrice { get; set; }

    /// <summary>
    /// Производитель.
    /// </summary>
    [Display(Name = "Производитель")]
    public string? Manufacturer { get; set; }
    
    /// <summary>
    /// Оценка.
    /// </summary>
    /// <remarks>Сколько звезд.</remarks>
    [Display(Name = "Оценка")]
    public decimal Rating { get; set; }
    
    /// <summary>
    /// Участвует ли в распродаже.
    /// </summary>
    [Display(Name = "Распродажа")]
    public bool IsOnSale { get; set; }
    
    /// <summary>
    /// Величина скидки.
    /// </summary>
    /// <remarks>В процентах.</remarks>
    [Display(Name = "Скидка")]
    public decimal Discount { get; set; }

    public class AuthorDTO
    {
        [Display(Name = "Фамилия")] 
        public string? Surname { get; set; }

        [Display(Name = "Имя")] 
        public string Name { get; set; }

        [Display(Name = "Отчество")]
        public string? Patronimic { get; set; }
    }
    
    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
    [Display(Name = "Авторы")] 
    public List<AuthorDTO>? Authors { get; set; }

    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
    [Display(Name = "Жанры")] 
    public List<string>? Genres { get; set; }

    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
    [Display(Name = "Тип канцелярского товара")] 
    public string? StationeryType { get; set; }
}