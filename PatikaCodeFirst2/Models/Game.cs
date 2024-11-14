using System.ComponentModel.DataAnnotations;

namespace PatikaCodeFirst2.Models
{
    public class Game
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Platform { get; set; }
        public decimal Rating { get; set; }
    }
}
