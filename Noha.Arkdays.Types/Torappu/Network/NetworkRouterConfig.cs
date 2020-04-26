using System.Collections.Generic;

namespace Torappu.Network
{
    public class NetworkRouterConfig
    {
        public class Content
        {
            public string configVer { get; set; }

            public string funcVer { get; set; }

            public Dictionary<string, Config> configs { get; set; }
        }

        public class Config
        {
            public bool useOverride { get; set; }

            public UrlConfiguration network { get; set; }
        }

        public string sign { get; set; }

        public string content { get; set; }

    }
}
