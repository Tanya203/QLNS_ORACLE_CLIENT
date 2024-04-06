using CLIENT.DataTier.Models;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CLIENT.API
{
    public class WorkScheduleDetailApi
    {
        private static readonly string _baseUrl = "https://localhost:7102/";
        public async Task<string> CreateWorkScheduleDetail(WorkScheduleDetail workScheduleDetail)
        {
            using (HttpClient client = new HttpClient())
            {
                string json = JsonConvert.SerializeObject(workScheduleDetail);

                var content = new StringContent(json, Encoding.UTF8, "application/json");

                using (HttpResponseMessage res = await client.PostAsync($"{_baseUrl}AddWorkScheduleDetail", content))
                {
                    using (HttpContent responseContent = res.Content)
                    {
                        string data = await responseContent.ReadAsStringAsync();
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
