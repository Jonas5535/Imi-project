﻿namespace Imi.Project.Mobile.Core.Domain.Models
{
    public class BaseResponse<T>
    {
        public bool IsSucces { get; set; } = true;
        public string Reason { get; set; }
        public string ErrorMessage { get; set; }
        public T Data { get; set; }
    }
}
