using System;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace Family.Manager.Infrastructure.Configurations.JsonSettings
{
    public class CustomPropertyNamingPolicy : JsonNamingPolicy
    {
        public override string ConvertName(string name) => ToSnakeCase(name);

        private static string ToSnakeCase(string name)
        {
            return string.IsNullOrWhiteSpace(name)
                ? name
                : Regex.Replace(
                    name,
                    @"([a-z0-9])([A-Z])",
                    "$1_$2",
                    RegexOptions.Compiled,
                    TimeSpan.FromSeconds(0.2)).ToLower();
        }
    }
}
