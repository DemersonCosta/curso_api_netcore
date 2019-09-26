using Api.Data.Context;
using Api.Data.Implementations;
using Api.Data.Repository;
using Api.Domain.Interfaces;
using Api.Domain.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Api.CrossCutting.DependencyInjection
{
    public class ConfigureRepository
    {
        public static void ConfigureDependenciesRepository(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
            serviceCollection.AddScoped<IUserRepository, UserImplementation>();


            serviceCollection.AddDbContext<MyContext>(
            options => options.UseMySql("Server=localhost;Port=3306;Database=dbAPI;Uid=root;Pwd=32358115")
            //options => options.UseSqlServer("Server=127.0.0.1,1433;Database=dbAPI;User Id=demerson;Password=Itachi%100")

            );
        }

    }
}
