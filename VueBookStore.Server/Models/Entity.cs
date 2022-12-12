using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace VueBookStore.Server.Models;

public abstract class Entity<T>
{
    [Key]
    [JsonProperty(Order = -100)]
    public T Id { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime ModifiedAt { get; set; }
}