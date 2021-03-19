using System.ComponentModel.DataAnnotations;

namespace SpicyWebApi.Dtos
{
    public class SqlUpdateDto
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