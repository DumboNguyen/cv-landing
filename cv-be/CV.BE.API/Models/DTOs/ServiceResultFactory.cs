using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CV.BE.API.Models.DTOs
{
    public abstract class ServiceResult
    {
        public bool IsSuccess { get; protected set; }
        public string Error { get; protected set; }

        public static ServiceResult<T> Success<T>(T data, string message = null)
            => new ServiceResult<T>(true, data, message, null);

        public static ServiceResult Success(string message = null)
            => new SimpleServiceResult(true, message);

        public static ServiceResult Failure(string error, string message = null)
            => new SimpleServiceResult(false, message, error);

        public static ServiceResult<T> Failure<T>(string error, string message = null)
            => new ServiceResult<T>(false, default!, message, error);
    }

    public class ServiceResult<T> : ServiceResult
    {
        public T Data { get; }

        internal ServiceResult(bool isSuccess, T data, string message, string error)
        {
            IsSuccess = isSuccess;
            Data = data;
            Error = error;
        }
    }

    public class SimpleServiceResult : ServiceResult
    {
        internal SimpleServiceResult(bool isSuccess, string message, string error = null)
        {
            IsSuccess = isSuccess;
            Error = error;
        }
    }

}
