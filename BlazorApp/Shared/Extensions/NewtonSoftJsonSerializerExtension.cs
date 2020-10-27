using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Newtonsoft.Json
{
    public static class NewtonSoftJsonSerializerExtension
    {
        public static async Task<T> DeSerializeAsync<T>(this JsonSerializer js, HttpResponseMessage Response) where T : class
        {
            var ResponseStream = await Response.Content.ReadAsStreamAsync();
            var streamReader = new StreamReader(ResponseStream);
            var jsonReader = new JsonTextReader(streamReader);

            var results = js.Deserialize<T>(jsonReader);

            if (results != null)
                return results;
            else
                return default;
        }

        public static async Task<object> DeSerializeAsync(this JsonSerializer js, HttpResponseMessage Response, Type type)
        {
            var ResponseStream = await Response.Content.ReadAsStreamAsync();
            var streamReader = new StreamReader(ResponseStream);
            var jsonReader = new JsonTextReader(streamReader);

            var results = js.Deserialize(jsonReader, type);

            if (results != null)
                return results;
            else
                return new object();
        }

        public static async Task<T> ParseHttp<T>(this JsonSerializer js, HttpResponseMessage Response)
        {
            var ResponseStream = await Response.Content.ReadAsStreamAsync();
            var streamReader = new StreamReader(ResponseStream);
            var jsonReader = new JsonTextReader(streamReader);

            var results = js.Deserialize<T>(jsonReader);

            if (results != null)
                return results;
            else
                return default;
        }
    }
}
