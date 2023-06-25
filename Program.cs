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


// ************** Create two products and add them to db. ****************
//var veggiPizza = new Product
//{
//    Name = "Grilled Vegetables Pizza",
//    Price = 19.99m
//};

//contosoPizzaContext.Add(veggiPizza);

//var pestoPizza = new Product
//{
//    Name = "Pesto Pizza",
//    Price = 16.99m
//};

//contosoPizzaContext.Products.Add(pestoPizza);

//contosoPizzaContext.SaveChanges();

// ************** Read products from the db. ****************
Console.WriteLine("\n*** Reading all pizzas ***");
foreach (var product in contosoPizzaContext.Products)
{
    Console.WriteLine(product);
}

//var hawaiianVeggie = new Product
//{
//    Name = "hawaiian Veggie Pizza",
//    Price = 25.79m
//};

//contosoPizzaContext.Products.Add(hawaiianVeggie);

//contosoPizzaContext.SaveChanges();

// Filter products using Fluent API.
var expensivePizzas = contosoPizzaContext.Products
    .Where(p => p.Price > 18m).
    OrderByDescending(p => p.Price);

Console.WriteLine("\n*** Reading expensive pizzas ***");
foreach (var pizza in expensivePizzas)
{
    Console.WriteLine(pizza);
}

// Update products
var hawaiian = contosoPizzaContext.Products.FirstOrDefault(p => p.Name.StartsWith("Hawaiian"));

if (hawaiian != null)
{
    contosoPizzaContext.Products.Update(hawaiian);
    hawaiian.Name = "Hawaiian-Veggie-Double-Fresh Pizza";
    hawaiian.Price = 31.39m;
}

contosoPizzaContext.SaveChanges();

Console.WriteLine("\n*** Reading all pizzas after updating Hawaiian Veggie Pizza's name and price");
foreach (var product in contosoPizzaContext.Products)
{
    Console.WriteLine(product);
}

// Delete a product
var pestoPizza = contosoPizzaContext.Products.FirstOrDefault(p => EF.Functions.Like(p.Name, "%pesto%"));

if (pestoPizza != null)
{
    contosoPizzaContext.Products.Remove(pestoPizza);
}
contosoPizzaContext.SaveChanges();

Console.WriteLine("\n*** Reading pizza after renmoving Pesto pizza ***");
foreach (var product in contosoPizzaContext.Products)
{
    Console.WriteLine(product);
}

Console.WriteLine("\nApp ran successfully!");
