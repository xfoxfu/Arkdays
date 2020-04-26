using System.Collections.Generic;
namespace Torappu.Resource
{
    public class HotUpdateInfo
    {
        public struct ABInfo
        {
            public string name { get; set; }
            public string hash { get; set; }
            public string md5 { get; set; }
            public long totalSize { get; set; }
            public long abSize { get; set; }
        }
        public ABInfo fullPack { get; set; }
        public string versionId { get; set; }
        public List<ABInfo> abInfos { get; set; }
    }
}
