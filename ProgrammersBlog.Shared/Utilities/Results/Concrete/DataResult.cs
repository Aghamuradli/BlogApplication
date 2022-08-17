using ProgrammersBlog.Shared.Utilities.Results.Abstract;
using ProgrammersBlog.Shared.Utilities.Results.ComplexTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersBlog.Shared.Utilities.Results.Concrete
{
    public class DataResult<T> : IDataResult<T>
    {
        public DataResult(T data, ResultStatus resultStatus)
        {
            Data = data;
            ResultStatus = resultStatus;
        }
        public DataResult(T data, string message, ResultStatus resultStatus)
        {
            Data = data;
            Message = message;
            ResultStatus = resultStatus;
        }
        public DataResult(T data, string message, ResultStatus resultStatus , Exception exception)
        {
            Data = data;
            Message = message;
            ResultStatus = resultStatus;
            Exception = exception;
        }
        public T Data { get; }

        public ResultStatus ResultStatus { get; }

        public string Message { get; }

        public Exception Exception { get; }
    }
}
