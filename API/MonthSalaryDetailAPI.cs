using CLIENT.DataTier.Models;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CLIENT.API
{
    public class MonthSalaryDetailAPI
    {
        private static readonly string _baseUrl = "https://localhost:7102/";
        public async Task<string> GetMonthSalary(string month)
        {
            using (HttpClient client = new HttpClient())
            {

                using (HttpResponseMessage res = await client.GetAsync($"{_baseUrl}GetMonthSalary?month={month}"))
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
        public async Task<string> CreateMonthSalaryDetail(MonthSalaryDetail monthSalaryDetail)
        {
            using (HttpClient client = new HttpClient())
            {
                string json = JsonConvert.SerializeObject(monthSalaryDetail);

                var content = new StringContent(json, Encoding.UTF8, "application/json");

                using (HttpResponseMessage res = await client.PostAsync($"{_baseUrl}CreateMonthSalaryDetailServices", content))
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
        public async Task<string> UpdateMonthSalaryDetail(string month)
        {
            using (HttpClient client = new HttpClient())
            {
                string json = JsonConvert.SerializeObject(month);

                var content = new StringContent(json, Encoding.UTF8, "application/json");

                using (HttpResponseMessage res = await client.PutAsync($"{_baseUrl}AutoUpdateMonthSalaryDetail?month={month}", content))
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
