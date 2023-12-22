using StudentCrm.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCrm.Application.Responses
{
    public class Result
    {
        public bool Success { get; }
        public string Message { get;  }
        public List<string> Errors { get;  }
        public Result(bool succes)
        {
            Success = succes;
        }
        public Result(bool succes, string message):this(succes)
        {
            Message = message;
        }
        public Result(bool succes, List<string> errors) : this(succes)
        {
            Errors = errors;
        }
    }
}
