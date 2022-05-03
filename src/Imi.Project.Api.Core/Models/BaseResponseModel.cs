namespace Imi.Project.Api.Core.Models
{
	public class BaseResponseModel<T>
	{
		public bool IsSucces { get; set; } = true;
		public string Status { get; set; }
		public string ErrorMessage { get; set; }
		public T Data { get; set; }
	}
}
