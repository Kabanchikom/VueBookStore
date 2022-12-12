using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using VueBookStore.Server.Areas.Author.Models;
using VueBookStore.Server.Areas.Product.DTO;
using VueBookStore.Server.Areas.Product.Models;
using VueBookStore.Server.EF;

namespace VueBookStore.Server.Areas.Product.Services;

public class ProductService
{
    private readonly BookStoreDbContext _context;
    private readonly IMapper _mapper;
    
    public ProductService(BookStoreDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<List<ProductPreviewDTO>> GetPreviewsAsync()
    {
        var books = _context
            .Books
            .Include(x => x.Manufacturer)
            .Include(x => x.Authors);

        var stationery = _context.Stationary;
        var stationeryDto = _mapper.Map<DbSet<StationeryCard>, List<ProductPreviewDTO>>(stationery);
        var booksDto = _mapper.Map<IIncludableQueryable<BookCard,List<AuthorCard>>?, List<ProductPreviewDTO>>(books);
        return booksDto.Union(stationeryDto).ToList();
    }
}