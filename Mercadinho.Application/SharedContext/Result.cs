using System.Text.Json.Serialization;

namespace Mercadinho.Application.SharedContext;

public class Result<T> : Result
{
    public T? Data { get; private set; }

    public Result(T? data)
    {
        Data = data;
        Success = true;
    }

    public Result() { }

    private Result(List<Error> errors)
    {
        _errors = errors;
    }

    private Result(Error error)
    {
        _errors.Add(error);
    }

    public void AddError(string error) => _errors.Add(Error.ValidationError(error));

    public void AddErrors(IList<string> errors)
    {
        foreach (var error in errors) _errors.Add(Error.ValidationError(error));
    }

    public void SetData(T? data)
    {
        Success = data != null;
        Data = data;
    }

    public static Result<T> Failure(List<Error> errors) => new(errors);

    public static Result<T> Failure(Error error) => new(error);

    public static Result<T> ValidationError(string message, string payload = "") => new(Error.ValidationError(message, payload));

    public static Result<T> BusinessRuleViolation(string message, string payload = "") => new(Error.BusinessRule(message, payload));

    public static Result<T> InternalError(string message, string payload = "") => new(Error.InternalError(message, payload));

    public static Result<T> FromFailureResult(Result other)
    {
        return new Result<T>
        {
            _errors = other.DetailedErrors.ToList(),
            Success = other.Success
        };
    }
}

public abstract class Result
{
    public bool Success { get; protected set; }
    protected List<Error> _errors = [];
    public IReadOnlyCollection<ErrorModel> Errors => _errors.Select(ErrorModel.FromError).ToList();
    
    [JsonIgnore]
    public IReadOnlyCollection<Error> DetailedErrors => _errors.AsReadOnly();
    public static Result<TData> Successfully<TData>(TData data) => new(data);
}