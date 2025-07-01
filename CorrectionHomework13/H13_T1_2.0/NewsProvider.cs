namespace H13_T1_2._0;

public class NewsProvider
{
    public event EventHandler<NewsEventArgs>? News;
    public event EventHandler<NewsEventArgs>? Weather;
    public event EventHandler<NewsEventArgs>? Sport;
    public event EventHandler<NewsEventArgs>? Incident;
    public event EventHandler<NewsEventArgs>? Fun;

    public void Publish(NewsCategory category, string message)
    {
        var args = new NewsEventArgs(message);
        switch (category)
        {
            case NewsCategory.News: News?.Invoke(this, args); break;
            case NewsCategory.Weather: Weather?.Invoke(this, args); break;
            case NewsCategory.Sport: Sport?.Invoke(this, args); break;
            case NewsCategory.Incident: Incident?.Invoke(this, args); break;
            case NewsCategory.Fun: Fun?.Invoke(this, args); break;
        }
    }
}
