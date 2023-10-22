using System.Text.Json;
using Catalog.Core.Entities;
using MongoDB.Driver;

namespace Catalog.Infrastructure.Data;

public static class CatalogContextSeed
{
    public static void SeedData(IMongoCollection<Product> productCollection)
    {
        var checkProducts = productCollection.Find(b => true).Any();
        if (!checkProducts)
        {

            var productsData = File.ReadAllText("../Catalog.Infrastructure/Data/SeedData/products.json");            var products = JsonSerializer.Deserialize<List<Product>>(productsData);
            if (products != null)
                foreach (var item in products)
                    productCollection.InsertOneAsync(item);
        }
    }
}