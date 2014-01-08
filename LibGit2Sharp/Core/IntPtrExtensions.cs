using System;
using System.Runtime.InteropServices;

namespace LibGit2Sharp.Core
{
    internal static class IntPtrExtensions
    {
        public static T MarshalAs<T>(this IntPtr ptr)
        {
            if (ptr == IntPtr.Zero)
            {
                return default(T);
            }
            return (T)Marshal.PtrToStructure(ptr, typeof(T));
        }
    }
}
