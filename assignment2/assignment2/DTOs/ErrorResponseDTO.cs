namespace assignment2.DTOs
{
    public class ErrorResponseDTO
    {
        public string Message { get; set; }
        public string Path { get; set; }
        public int StatusCode { get; set; }
        public DateTime TimeStamp;

        public ErrorResponseDTO(string message, string path, DateTime timeStamp, int statusCode)
        {
            Message = message;
            Path = path;
            StatusCode = statusCode;
            TimeStamp = timeStamp;
        }
    }
}
