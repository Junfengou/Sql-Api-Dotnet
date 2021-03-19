using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SpicyWebApi.Models
{
    public class SqlCommands
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // same as IDENTITY(1,1)
        public int SqlCmdId { get; set; }

        [Required]
        [MaxLength(250)]
        public string SqlCmdLine { get; set; }

        [Required]
        [MaxLength(250)]
        public string SqlCmdDescription { get; set; }

        [Required]
        [MaxLength(250)]
        public string Language { get; set; }
    }
}