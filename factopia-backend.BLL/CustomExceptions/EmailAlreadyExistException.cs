namespace factopia_backend.BLL.CustomExceptions;

public class EmailAlreadyExistException : Exception
{
    public EmailAlreadyExistException() : base("L'email existe déjà.") { }
    public EmailAlreadyExistException(string message, Exception innerException) : base(message, innerException) { }
}
