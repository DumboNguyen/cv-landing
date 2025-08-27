using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CV.BE.API.Models.Responses
{
    public class JsonResultData
    {
        public JsonResultData()
        {
            errors = new List<string>();
        }

        public bool success { get; set; }
        public IEnumerable<string> errors { get; set; }
        public string message { get; set; }
    }

    public class JsonResultData<T> : JsonResultData
    {
        public T AdditionalData { get; set; }
    }

    public class ResultJson : JsonResult
    {
        public ResultJson(object value, JsonSerializerSettings serializerSettings) : base(value, serializerSettings)
        {

        }

        public ResultJson(object value) : base(value)
        {
        }
    }

    public static class ResponseFactory
    {
        public static ResultJson Success(string message = null)
        {
            return GetJsonResult(new JsonResultData { success = true, message = message });
        }

        public static ResultJson Success<T>(T t, string message = null)
        {
            return GetJsonResult(new JsonResultData<T> { success = true, AdditionalData = t, message = message });
        }

        public static ResultJson Fail(params string[] messages)
        {
            return GetJsonResult(new JsonResultData { success = false, errors = messages });
        }

        private static ResultJson GetJsonResult(JsonResultData data)
        {
            return new ResultJson(data);
        }
    }
}
