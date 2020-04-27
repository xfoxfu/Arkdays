using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Torappu
{
    public class StoryDB : Dictionary<string, StoryData>
    {
        private const char KEY_SEPARATOR = '|';
    }
}
