namespace H11_T1;

public sealed class EmptyStringException : Exception
{
    public EmptyStringException()
        : base("Аргумент не может быть пустой строкой.") { }

    public EmptyStringException(string paramName)
        : base($"Аргумент \"{paramName}\" не может быть пустой строкой.") { }
}
