using System;
using System.Collections.Generic;
using System.Text;

namespace GetTogether.Data.Services.Communication
{
    public abstract class BadResponse
    {
        public bool Success { get; protected set; }
        public string Message { get; protected set; }

        public BadResponse(bool success, string message)
        {
            Success = success;
            Message = message;
        }
    }
}
