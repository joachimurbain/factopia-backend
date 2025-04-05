namespace factopia_backend.BLL.CustomExceptions;

public class InvalidCredentialsException : Exception
{
    public InvalidCredentialsException() : base("L'email ou le mot de passe est incorrect.") { }
    public InvalidCredentialsException(string message, Exception innerException) : base(message, innerException) { }
}
