namespace VueBookStore.Server.Areas.Product.Services;

public static class ProductSetupExtensions
{
    public static IServiceCollection AddProducts(this IServiceCollection services)
    {
        services.AddScoped<ProductService>();
        services.AddAutoMapper(typeof(ProductMappingProfile));
            
        return services;
    }
}