using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SpicyWebApi.Dtos
{
    public class SqlCreateDto
    {
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