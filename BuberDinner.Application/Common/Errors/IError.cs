using System.Net;

namespace BuberDinner.Api.Common.Errors;

public interface IError
{
    public HttpStatusCode StatusCode { get; }
    public string ErrorMessage { get; }
}