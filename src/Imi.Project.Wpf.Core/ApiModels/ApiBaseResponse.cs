using System.Net;

namespace Imi.Project.Wpf.Core.ApiModels
{
    public class ApiBaseResponse<T>
    {
        public bool IsSucces { get; set; } = true;
        public string Status { get; set; }
        public string ErrorMessage { get; set; }
        public T Data { get; set; }
    }
}
