namespace API_CSHARP_PROFILE.Models
{
    public class BaseResponse<TData>
    {
        public bool Result { get; set; }
        public string? ResponseCode { get; set; }
        public string? ResponseMessage { get; set; }
        public string? ResponseDataSource { get; set; }
        public TData? Data { get; set; }
    }
}