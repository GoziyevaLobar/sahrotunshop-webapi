using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SahrotunShop.Domain.Exceptions
{
    public class AlreadyExistsException : Exception
    {
        public HttpStatusCode statusCode { get; } = HttpStatusCode.NotFound; 
        public string TitleMessage { get; protected set; } = string.Empty;  
    }
}
