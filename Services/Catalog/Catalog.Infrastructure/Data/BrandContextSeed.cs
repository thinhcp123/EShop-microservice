using System.Text.Json;
using Catalog.Core.Entities;
using MongoDB.Driver;

namespace Catalog.Infrastructure.Data;

public static class BrandContextSeed
{
    public static void SeedData(IMongoCollection<ProductBrand> brandCollection)
    {
        var checkBrands = brandCollection.Find(b => true).Any();
        var path = Path.Combine("Data", "SeedData", "brands.json");
        if (!checkBrands)
        {
            var brandsData = File.ReadAllText("../Catalog.Infrastructure/Data/SeedData/brands.json");
            var brands = JsonSerializer.Deserialize<List<ProductBrand>>(brandsData);
            if (brands != null)
                foreach (var item in brands)
                    brandCollection.InsertOneAsync(item);
        }
    }
}