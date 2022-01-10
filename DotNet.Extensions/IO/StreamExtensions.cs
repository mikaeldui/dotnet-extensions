using System;
using System.Collections.Generic;
using System.Text;

namespace System.IO
{
    public static class StreamExtensions
    {
        public static byte[] ToByteArray(this Stream stream)
        {
            if (stream is MemoryStream ms)
                return ms.ToArray();
            else
            {
                using MemoryStream ms2 = new();
                stream.CopyTo(ms2);
                return ms2.ToArray();
            }
        }
    }
}
