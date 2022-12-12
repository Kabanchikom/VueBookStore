using System.ComponentModel.DataAnnotations;

namespace VueBookStore.Server.Areas.Order.Models;

public enum DeliveryType
{
    [Display(Name = "Самовывоз")]
    PickUp = 0,

    [Display(Name = "Курьер")]
    Courier = 1,
}