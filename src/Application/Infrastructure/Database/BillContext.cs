using Domain.Models;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;


namespace Infrastructure.Database
{
    public class BillContext
    {
        public BillContext(IConfiguration configration)
        {
            var client = new MongoClient(configration.GetSection("MongoSettings:ConnectionString").Value);
            var database = client.GetDatabase(configration.GetSection("MongoSettings:DatabaseName").Value);

            bills = database.GetCollection<Bill>(configration.GetSection("MongoSettings:BillsConnectionName").Value);

            //BillContextSeed.SeedData(products, categories);
        }

        public IMongoCollection<Bill> bills { get; }
    }
}
