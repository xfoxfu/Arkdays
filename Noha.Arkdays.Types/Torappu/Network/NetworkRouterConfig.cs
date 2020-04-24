using System.Collections.Generic;

namespace Torappu.Network
{
    public class NetworkRouterConfig
    {
        public class Content
        {
            public string configVer;

            public string funcVer;

            public Dictionary<string, Config> configs;
        }

        public class Config
        {
            public bool useOverride;

            public UrlConfiguration network;
        }

        public string sign;

        public string content;

    }
}
