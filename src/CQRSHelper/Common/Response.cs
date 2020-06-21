using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace CQRSHelper._Common
{

    public class Response<T> : Response
    {
        public T Result { get; set; }
    }
    public class ResponseList<T> : Response
    {
        public List<T> Result { get; set; }
    }
    public class Response
    {
        public string Message { get; set; } = null;
        public string RequestId { get; set; } = null;
        public bool Status { get; set; } = true;

        public Response()
        {

        }

        public Response(Guid RequestId, string message) : this(RequestId.ToString(), message) { }

        public Response(string requestId, string message) =>
            (RequestId, Message) = (requestId, message);

        public Response(string message, bool status) =>
            (Message, Status) = (message, status);

        public void Error(string validation)
        {
            this.Message = validation;
            this.Status = false;
        }
    }
}
