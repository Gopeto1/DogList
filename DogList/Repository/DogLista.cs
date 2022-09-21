using DogList.Models;
using DogList.Data;
namespace DogLista.Repository
{
    public class DogLista
    {
        private readonly ApplicationDbContext db;
        public DogLista()
        {
            db = new ApplicationDbContext();
        }
    }
}
