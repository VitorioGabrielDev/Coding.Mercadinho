namespace Mercadinho.Application.SharedContext;

public record Error(string Message, ErrorType ErrorType, string Payload = "")
{
    public static Error BusinessRule(string message, string payload = "") => new(message, ErrorType.BusinessRuleViolation, payload);
    public static Error ValidationError(string message, string payload = "") => new(message, ErrorType.ValidationError, payload);
    public static Error InternalError(string message, string payload = "") => new(message, ErrorType.InternalError, payload);
}