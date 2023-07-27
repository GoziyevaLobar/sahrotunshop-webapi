using System.Net;

namespace SahrotunShop.Domain.Exceptions;

public class BadRequestException : ClientException
{
    public override HttpStatusCode StatusCode { get; } = HttpStatusCode.BadRequest;

    public override string TitleMessage { get; protected set; } = String.Empty;
}
