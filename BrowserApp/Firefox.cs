namespace BrowserFactory
{
    public class Firefox : IBrowser
    {
        public string Name { get; set; }
        public string Version { get; set; }
        public string WhoAmI() => $"{Name}, Firefox V.{Version}";
    }
}