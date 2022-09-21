using System.Data.Entity;
using DogList.Models;

namespace DogList.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Dog> Dogs { get; set; }
        public ApplicationDbContext() : base("Server=(localdb)\\mssqllocaldb;Database=DogList;Trusted_Connection=True;MultipleActiveResultSets=True")
        {
            Dogs = this.Set<Dog>();
        }
    }
}
