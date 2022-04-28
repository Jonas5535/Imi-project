using System.Net;

namespace Imi.Project.Wpf.Core.ApiModels
{
    public class ApiBaseResponse<T>
    {
        public HttpStatusCode Status { get; set; }
        public string Reason { get; set; }
        public string ErrorMessage { get; set; }
        public T Data { get; set; }
    }
}
