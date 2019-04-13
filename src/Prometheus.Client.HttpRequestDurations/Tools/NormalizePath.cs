using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Http;

[assembly: InternalsVisibleTo("Prometheus.Client.HttpRequestDurations.Tests" +
    ", PublicKey=002400000480000094000000060200000024000052534131000400000100010043c098de06c8d023082f50046903a938a6357a83ac284dc6caaa4522d1dd4febe72ff9287e2db59bee71183be94be70cc8199e80c38c6bf970037839748071b1628c76fe975e803d31f6f59ff710d4a83bb78783d69ae06db640234a01b7b78707e185c8a8b50641e42335d309f82a311ae8b48d957a6c563e23c1f76108008d")]

namespace Prometheus.Client.HttpRequestDurations.Tools
{
    internal static class NormalizePath
    {
        public static string Execute(PathString pathString, HttpRequestDurationsOptions options)
        {
            var result = pathString.ToString().ToLowerInvariant();
            if (options.IncludeCustomNormalizePath)
                foreach (var normalizePath in options.CustomNormalizePath)
                    result = normalizePath.Key.Replace(result, normalizePath.Value);
            return result;
        }
    }
}
