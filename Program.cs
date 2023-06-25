using ef_core_101.Data;
using ef_core_101.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

//var serviceCollection = new ServiceCollection();
//serviceCollection.AddDbContext<ContosoPizzaContext>(options => options.UseSqlServer("Server=127.0.0.1,1433;Database=ef-core-101;User Id=sa;Password=&hq9%8Tb6X;TrustServerCertificate=true"));

//var serviceProvider = serviceCollection.BuildServiceProvider();
//var context = serviceProvider.GetServices<ContosoPizzaContext>();

// "using" makes sure that the contosoPizzaContext object is disposed off correctly once it is done being used.
using var contosoPizzaContext = new ContosoPizzaContext();

Console.WriteLine("App begins running...");

// Create two products and add them to db.
//var veggiPizza = new Product
//{
//    Name = "Grilled Vegetables Pizza",
//    Price = 19.99m
//};

//contosoPizzaContext.Add(veggiPizza);

var pestoPizza = new Product
{
    Name = "Pesto Pizza",
    Price = 16.99m
};

contosoPizzaContext.Products.Add(pestoPizza);

contosoPizzaContext.SaveChanges();

Console.WriteLine("App ran successfully!");
