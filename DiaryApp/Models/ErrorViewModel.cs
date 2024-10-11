namespace DiaryApp.Models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; } // Property

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
