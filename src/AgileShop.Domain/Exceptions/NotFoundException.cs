
using System.Globalization;
using System.Net;

namespace AgileShop.Domain.Exceptions;

public class NotFoundException:Exception
{
    public HttpStatusCode statusCode { get; set; } = HttpStatusCode.NotFound;

    public string TitleMessage { get;protected set; } = string.Empty;
}
