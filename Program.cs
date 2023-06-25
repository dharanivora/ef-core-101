using ef_core_101.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

var serviceCollection = new ServiceCollection();
serviceCollection.AddDbContext<ContosoPizzaContext>(options => options.UseSqlServer("Server=127.0.0.1,1433;Database=ef-core-101;User Id=sa;Password=&hq9%8Tb6X;TrustServerCertificate=true"));

var serviceProvider = serviceCollection.BuildServiceProvider();
var context = serviceProvider.GetServices<ContosoPizzaContext>();
