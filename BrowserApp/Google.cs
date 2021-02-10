namespace BrowserFactory
{
    public class Google : IBrowser
    {
        public string Name { get; set; }
        public string Version { get; set; }
        public string WhoAmI() => $"{Name}, Google V.{Version}";
    }
}