using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Models
{
    public class Value
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}