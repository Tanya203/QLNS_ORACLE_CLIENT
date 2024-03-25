using System.Net.Http;
using System.Threading.Tasks;

namespace CLIENT
{
    internal class BenefitAPI
    {
        private static readonly string baseUrl = "https://localhost:7102/";
        public static async Task<string> GetAllBenefit()
        {
            using(HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.GetAsync(baseUrl + "GetAllBenefit"))
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
