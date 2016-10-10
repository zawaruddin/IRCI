/*
 * Contex itu untuk menangani cache query 
 * 
 */

using IRCI.EntityFramework.Models;
using System.Data.Entity;

namespace IRCI.EntityFramework
{
    public class Context : DbContext
    {
        static Context()
        {
            Database.SetInitializer<Context>(null);
        }


        public Context():base("new_cs") { }

        public DbSet<Record> Record => Set<Record>();
        public DbSet<Konfig> Konfig => Set<Konfig>();


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new Record.Mapping());
            modelBuilder.Configurations.Add(new Konfig.Mapping());
        }
    }
}