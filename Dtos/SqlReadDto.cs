namespace SpicyWebApi.Dtos
{
    public class SqlReadDto
    {
        public int SqlCmdId { get; set; }

        public string SqlCmdLine { get; set; }

        public string SqlCmdDescription { get; set; }

        public string Language { get; set; }
    }
}