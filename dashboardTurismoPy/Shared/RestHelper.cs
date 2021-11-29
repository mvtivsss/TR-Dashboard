using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace dashboardTurismoPy.Shared
{
    public static class RestHelper
    {
        private static readonly string baseUrl = "http://localhost:4000/api/";

        public static async Task<string> getAll()
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.GetAsync(baseUrl + "departments"))
                {
                    using (HttpContent content = res.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            return data;
                        }
                    } 
                }
            }
            return string.Empty;
        }

        public static string BeautifyJson(string jsonStr)
        {
            JToken parseJson = JToken.Parse(jsonStr);
            return parseJson.ToString(Formatting.Indented);
        }

        public static string CountJson(string jsonStr)
        {
            JObject jObj = (JObject)JsonConvert.DeserializeObject(jsonStr);
            int count = jObj.Count;
            return Convert.ToString(count);
        }
    }
}
