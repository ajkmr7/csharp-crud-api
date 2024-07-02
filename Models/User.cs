using System.ComponentModel.DataAnnotations.Schema;

namespace csharp_crud_api.Models
{
    [Table("users")]
    public class User
    {
        [Column("id")]
        public int Id { get; set; }
        
        [Column("name")]
        public String Name { get; set; }
        
        [Column("email")]
        public String Email { get; set; }
    }
}

