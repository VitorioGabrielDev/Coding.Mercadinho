namespace Mercadinho.Application.SharedContext;

public record ErrorType
{
    private ErrorType(string code) { }

    public static readonly ErrorType BusinessRuleViolation = new("BUSINESS_RULE_VIOLATION");
    public static readonly ErrorType InternalError = new("INTERNAL_ERROR");
    public static readonly ErrorType ValidationError = new("VALIDATION_ERROR");
}