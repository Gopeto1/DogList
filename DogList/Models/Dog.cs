using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DogList.Models
{
    [Table("Dog")]
    public class Dog
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; } 
    }
}
