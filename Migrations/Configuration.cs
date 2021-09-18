namespace KurumsalWebProj.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<KurumsalWebProj.Models.DataContext.KurumsalDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;//Add migrations yerine update databse ile güncellemelr yapılır. Küçük çaplı projelerde tercih edilir.
        }

        protected override void Seed(KurumsalWebProj.Models.DataContext.KurumsalDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
