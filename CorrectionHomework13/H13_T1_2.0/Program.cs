namespace H13_T1_2._0;

internal class Program
{
    static void Main()
    {
        var provider = new NewsProvider();

        var roman = new Client("Roman");
        var denis = new Client("Denis");

        roman.Subscribe(provider, NewsCategory.Weather);
        roman.Subscribe(provider, NewsCategory.Fun);

        denis.Subscribe(provider, NewsCategory.News);
        denis.Subscribe(provider, NewsCategory.Sport);

        provider.Publish(NewsCategory.Weather, "It's sunny today.");
        provider.Publish(NewsCategory.Fun, "Joke of the day: 42 is the answer to everything.");
        provider.Publish(NewsCategory.News, "A new version of .NET has been released.");
        provider.Publish(NewsCategory.Sport, "The team won with a score of 3:2.");
    }
}
