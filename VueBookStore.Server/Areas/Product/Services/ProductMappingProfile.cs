using AutoMapper;
using VueBookStore.Server.Helpers;
using VueBookStore.Server.Areas.Author.Models;
using VueBookStore.Server.Areas.Manufacturer.Models;
using VueBookStore.Server.Areas.Product.DTO;
using VueBookStore.Server.Areas.Product.Models;

namespace VueBookStore.Server.Areas.Product.Services;

public class ProductMappingProfile : Profile
{
    public ProductMappingProfile()
    {
        CreateMap<ProductCard, ProductPreviewDTO>();
        CreateMap<BookCard, ProductPreviewDTO>();
        CreateMap<StationeryCard, ProductPreviewDTO>();
        CreateMap<AuthorCard, ProductPreviewDTO.AuthorDTO>();
        CreateMap<ManufacturerCard, string>().ConvertUsing(x => x.Name);
        CreateMap<BookGenre, List<string?>>().ConvertUsing(x => x.GetDisplayNames());
    }
}