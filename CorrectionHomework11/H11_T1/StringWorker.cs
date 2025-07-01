namespace H11_T1;

public class StringWorker
{
    public int CountLetters(string text)
    {
        if (string.IsNullOrWhiteSpace(text))
            throw new EmptyStringException(nameof(text));

        return text.Replace(" ", "").Length;
    }
}
