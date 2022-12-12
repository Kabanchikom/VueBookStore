using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using VueBookStore.Server.Areas.Author.Models;

namespace VueBookStore.Server.Areas.Product.Models;

/// <summary>
/// Книга.
/// </summary>
public class BookCard : ProductCard
{
    [Flags]
    public enum BookType
    {
        [Display(Name = "Бумажное издание")]
        Paper = 1 << 0,
        [Display(Name = "Электронное издание")]
        Ebook = 1 << 1
    }
    
    /// <remarks>Книга может быть в наличии на бумажном и на электронном носителе.</remarks>
    [Display(Name = "Тип издания")]
    public BookType BookTypes { get; set; }

    [JsonIgnore]
    [Display(Name = "Авторы")] 
    public List<AuthorCard> Authors { get; set; } = new();
    
    [Display(Name = "Жанры")] 
    public BookGenre Genres { get; set; }
}