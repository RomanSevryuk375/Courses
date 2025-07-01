namespace H13_T1_2._0;

public class NewsEventArgs : EventArgs
{
    public string Message { get; }
    public NewsEventArgs(string message) => Message = message;
}
