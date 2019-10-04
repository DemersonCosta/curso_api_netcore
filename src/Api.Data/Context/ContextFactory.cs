using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Api.Data.Context {
    public class ContextFactory : IDesignTimeDbContextFactory<MyContext> {
        public MyContext CreateDbContext (string[] args) {
            //Usado para Criar as Migrações
            // var connectionString = "Server=localhost;Port=3306;Database=dbAPI;Uid=root;Pwd=32358115";
            var connectionString = "Server=DESKTOP-C09Q4UF;Database=dbAPI;User Id=demerson;Password=32358115";

            var optionsBuilder = new DbContextOptionsBuilder<MyContext> ();
            //optionsBuilder.UseMySql(connectionString);
            optionsBuilder.UseSqlServer (connectionString);
            return new MyContext (optionsBuilder.Options);
        }

    }
}