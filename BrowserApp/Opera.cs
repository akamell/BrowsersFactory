namespace BrowserFactory
{
    public class Opera : IBrowser
    {
        public string Name { get; set; }
        public string Version { get; set; }
        public string WhoAmI() => $"{Name}, Opera V.{Version}";
    }
}