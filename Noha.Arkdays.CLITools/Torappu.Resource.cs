#nullable disable
using System;
using System.Collections.Generic;

namespace Noha.Arkdays.Types.Torappu.Resource
{

    public class HotUpdateInfo
    {
        public HotUpdateInfo.ABInfo fullPack { get; set; }
        public string versionId { get; set; }
        public List<HotUpdateInfo.ABInfo> abInfos { get; set; }
        public struct ABInfo
        {
            public string name { get; set; }
            public string hash { get; set; }
            public string md5 { get; set; }
            public long totalSize { get; set; }
            public long abSize { get; set; }
        }
    }


    public class PersistentResInfo
    {
        public List<HotUpdateInfo.ABInfo> abInfos { get; set; }
    }

    public class VersionInfo
    {
        // Fields
        public string resVersion { get; set; }
        public string clientVersion { get; set; }
    }
}
