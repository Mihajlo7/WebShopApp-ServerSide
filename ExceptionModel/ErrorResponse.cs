using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionModel
{
    public class ErrorResponse
    {
        public string Title { get; set; }
        public string Message { get; set; }
        public string ErrorCode { get; set; }
        public int StatusCode { get; set; }
        public string DetailedMessage { get; set; } 
        public string Instance {  get; set; }
        public string Body { get; set; }
    }
}
