namespace Mercadinho.Application.SharedContext;

public record ErrorModel(string Message, ErrorType ErrorType)
{
    public static ErrorModel FromError(Error error)
        => new(error.Message, error.ErrorType);
}