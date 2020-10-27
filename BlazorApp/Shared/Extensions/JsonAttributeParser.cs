using Newtonsoft.Json;
using System;
using System.Linq;
using System.Reflection;

namespace BlazorApp.Pwa.Shared.Extensions
{
    public static class JsonAttributeParser
    {
        public static string GetAttributeValues(this Type t)
        {
            return string.Join(" ",
                t.GetProperties()
                .Select(p => p.GetCustomAttribute<JsonPropertyAttribute>())
                .Select(jp => jp?.PropertyName));
        }

        public static string GetObjectAttributeValue(this Type t)
        {
            var attributes = t.GetProperties()
                .Select(p => p.GetCustomAttributes<JsonObjectAttribute>());

            return attributes.FirstOrDefault().Select(e => e.Title).FirstOrDefault();
        }
    }
}
