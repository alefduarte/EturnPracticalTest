using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETurnPracticalTest.Api.Models
{
    public class ServiceResponse<T>
    {
        public T Data { get; set; }
        public bool Success { get; set; } = true;
        public string Message { get; set; } = null;
    }
}
