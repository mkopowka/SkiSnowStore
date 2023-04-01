namespace API.Errors
{
    public class ApiValidationErrorResponse : ApiResponse
    {
        public ApiValidationErrorResponse(string message = null) : base(400)
        {
        }

        public IEnumerable<string> Errors { get; set; }
    }
}