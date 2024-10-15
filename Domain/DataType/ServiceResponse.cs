using Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DataType
{
    internal class ServiceResponse<T>
    {
        T? Data { get; set; }
        public bool Success { get; set; }
        public bool Message { get; set; }
        public ErrorType Error { get; set; }
    }
}
