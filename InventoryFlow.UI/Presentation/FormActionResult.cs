namespace InventoryFlow.UI.Presentation
{
    public sealed class FormActionResult
    {
        public bool Success { get; }
        public string Message { get; }
        public string Title { get; }

        private FormActionResult(bool success, string message, string title)
        {
            Success = success;
            Message = message;
            Title = title;
        }

        public static FormActionResult Ok(string message)
        {
            return new FormActionResult(true, message, "Success");
        }

        public static FormActionResult Fail(string message, string title = "Error")
        {
            return new FormActionResult(false, message, title);
        }
    }
}
