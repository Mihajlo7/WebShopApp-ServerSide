namespace ExceptionModel
{
    public class BaseException : Exception
    {
        public string Title { get; set;  }

        public string ErrorCode { get; set; }
        public int StatusCode { get; set; }

        public BaseException(string message,string title,string errorCode,int statusCode): base(message)
        {
            Title = title;
            ErrorCode = errorCode;
            StatusCode = statusCode;
        }

    }
}
