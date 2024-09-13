using System.ComponentModel.DataAnnotations.Schema;

namespace PruebaTecninca.Models
{
    [Table("users")]
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
    }
}
