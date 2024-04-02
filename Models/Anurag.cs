using System.ComponentModel.DataAnnotations;

namespace DemoForGit.Models
{
    public class Anurag
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]

        public string Email { get; set; }
        [Required]

        public string Address { get; set; }
        [Required]

        public string Phone { get; set; }
        

    }
}
