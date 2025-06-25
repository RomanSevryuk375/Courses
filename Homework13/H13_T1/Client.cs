namespace H13_T1;

public class Client
{
    private string _name;

    private string _id = Guid.NewGuid().ToString();

    public Client(string name, NewsProvider provider, params Category[] categories)
    {
        _name = (!string.IsNullOrEmpty(name)) ? name : "Default";

        if (categories.Length == 0)
        {
            foreach (var category in (Category[])Enum.GetValues(typeof(Category)))
            {
                provider.Subscribe(category, message =>
                    Console.WriteLine($"{_name} receives: {message}"));
            }
        }

        foreach (var category in categories)
        {
            provider.Subscribe(category, message =>
                Console.WriteLine($"{_name} receives: {message}"));
        }
    }
}