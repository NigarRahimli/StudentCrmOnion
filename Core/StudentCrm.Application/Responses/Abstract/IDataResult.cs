using System;

namespace StudentCrm.Application.Responses.Abstract
{
    public interface IDataResult<T> : IResult
    {
        public T Data { get; set; }
    }
}

