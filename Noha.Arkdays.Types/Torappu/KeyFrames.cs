
using System.Collections.Generic;

namespace Torappu
{
    public abstract class KeyFrames<TInput, TOutput> : List<KeyFrames<TInput, TOutput>.KeyFrame> where TInput : TOutput
    {
        public class KeyFrame
        {
            public int level;

            public TInput data;

        }

        public int frameCnt { get; }

        public int minLevel { get; }

        public int maxLevel { get; }




    }


    public abstract class KeyFrames<TData> : KeyFrames<TData, TData>
    {
    }
}
