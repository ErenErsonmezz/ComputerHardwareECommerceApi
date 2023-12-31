
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ComputerHardwareECommerceApi.Application.Dtos
{
    public class CustomResponseDto<T>
    {
       public T Data { get; set; }

       [JsonIgnore]
       public int StatusCode { get; set; }
       public List<string> Errors { get; set; }
       public int DataTotalCount { get; set; }

       public static CustomResponseDto<T> Success(int statusCode,T data,int dataTotalCount)
       => new CustomResponseDto<T> { StatusCode = statusCode, Data = data, DataTotalCount = dataTotalCount };

       public static CustomResponseDto<T> Success(int statusCode, T data)
       => new CustomResponseDto<T> { StatusCode = statusCode, Data = data };

       public static CustomResponseDto<T> Success(int statusCode) => new CustomResponseDto<T> { StatusCode=statusCode };


        public static CustomResponseDto<T> Fail(int statusCode, List<string> errors)
        => new CustomResponseDto<T> { StatusCode = statusCode,Errors=errors};
        public static CustomResponseDto<T> Fail(int statusCode, string error)
       => new CustomResponseDto<T> { StatusCode = statusCode, Errors = new List<string> { error } };
        
    }
}
