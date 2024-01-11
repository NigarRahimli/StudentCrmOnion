using System;

namespace StudentCrm.Application.Responses.Abstract
{
    public interface IResult
    {
        public bool Success { get; }
        public string Message { get; }
    }
}

