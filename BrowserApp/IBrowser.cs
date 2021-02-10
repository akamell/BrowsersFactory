namespace BrowserFactory
{
    public interface IBrowser
    {
        string Name { get; set; }
        string Version { get; set; }
        string WhoAmI();
    }
}