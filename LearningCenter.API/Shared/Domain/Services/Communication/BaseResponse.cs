using System;

namespace LearningCenter.API.Shared.Domain.Services.Communication
{
    public class BaseResponse<T>
    {
        public BaseResponse(T resource)
        {
            Success = true;
            Resource = resource;
            Message = string.Empty;
        }

        public BaseResponse(string message)
        {
            Success = false;
            Resource = default;
            Message = message;
        }

        public bool Success { get; private set; } //la propiedad Success hace que sea visible completamente para
        public string Message { get; private set; }//lectura pero a nivel de escritura (set) le ponemos private 
        public T Resource { get; private set; }     // Para que solo sea privado de la clase
    }
}