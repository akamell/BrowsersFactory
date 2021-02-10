using System;
using System.Collections.Generic;

namespace BrowserFactory
{
    class FactoryBrowser : IFactoryBrowser
    {
        public IBrowser createBrowser<T>()
        {
            if (typeof(T) == typeof(Google)) return new Google() { Name = "Google", Version = "1.0.0" };
            else if (typeof(T) == typeof(Firefox)) return new Firefox() { Name = "Firefox", Version = "0.8.6" };
            else if (typeof(T) == typeof(Opera)) return new Opera() { Name = "Opera", Version = "100.1" };
            else throw new NotImplementedException($"{typeof(T)} isn't supported");
        }
    }
}