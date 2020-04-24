using System.Collections.Generic;

namespace Torappu.Resource
{
    public class HotUpdateInfo
    {
        public struct ABInfo
        {
            public static readonly ABInfo EMPTY;

            public string name;

            public string hash;

            public string md5;

            public long totalSize;

            public long abSize;
        }

        public ABInfo fullPack;

        public string versionId;

        public List<ABInfo> abInfos;

    }
}
