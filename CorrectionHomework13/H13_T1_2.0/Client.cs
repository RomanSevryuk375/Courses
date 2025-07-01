namespace H13_T1_2._0;

public class Client
{
    public string Name { get; }
    public Client(string name) => Name = name;

    public void Subscribe(NewsProvider provider, NewsCategory category)
    {
        EventHandler<NewsEventArgs> handler = (s, e) =>
            Console.WriteLine($"{Name} received ({category}): {e.Message}");

        switch (category)
        {
            case NewsCategory.News: provider.News += handler; break;
            case NewsCategory.Weather: provider.Weather += handler; break;
            case NewsCategory.Sport: provider.Sport += handler; break;
            case NewsCategory.Incident: provider.Incident += handler; break;
            case NewsCategory.Fun: provider.Fun += handler; break;
        }
    }
}