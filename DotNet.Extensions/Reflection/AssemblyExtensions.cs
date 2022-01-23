using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace System.Reflection
{
    public static class AssemblyExtensions
    {
        /// <summary>
        /// Like "1.2.3.0".
        /// </summary>
        public static string GetFileVersion(this Assembly assembly) =>
            assembly.GetCustomAttribute<AssemblyFileVersionAttribute>().Version;

        /// <summary>
        /// Like "1.2.3+1a2b3c4d".
        /// </summary>
        public static string GetInformationalVersion(this Assembly assembly) =>
            assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>().InformationalVersion.ToString();

        /// <summary>
        /// Like "1.2.3+1a2b3c4d". Doesn't work with WebAssembly! Use <see cref="GetInformationalVersion(Assembly)"/> instead.
        /// </summary>
        public static string GetProductVersion(this Assembly assembly) =>
            FileVersionInfo.GetVersionInfo(assembly.Location).ProductVersion;
    }
}
