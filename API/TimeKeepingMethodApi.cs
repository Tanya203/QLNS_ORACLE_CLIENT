using System.Net.Http;
using System.Threading.Tasks;

namespace CLIENT.API
{
    public class TimeKeepingMethodApi
    {
        private static readonly string _baseUrl = "https://localhost:7102/";
        public async Task<string> GetAllTimeKeepingMethod()
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.GetAsync($"{_baseUrl}GetAllTimeKeepingMethod"))
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
            return null;
        }
    }
}
