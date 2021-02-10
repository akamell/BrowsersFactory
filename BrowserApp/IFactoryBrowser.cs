namespace BrowserFactory
{
    public interface IFactoryBrowser
    {
        IBrowser createBrowser<T>();
    }
}