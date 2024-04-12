using CLIENT.DataTier.Models;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CLIENT.API
{
    public class ShiftTypeAPI
    {
        private static readonly string _baseUrl = "https://localhost:7102/";
        public async Task<string> GetAllShiftType()
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.GetAsync($"{_baseUrl}GetAllShiftType"))
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
        public async Task<string> SearchShiftType(string search)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.GetAsync($"{_baseUrl}SearchShiftType?search={search}"))
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
        public async Task<string> CreateShiftType(ShiftType shiftType)
        {
            using (HttpClient client = new HttpClient())
            {
                string json = JsonConvert.SerializeObject(shiftType);

                var content = new StringContent(json, Encoding.UTF8, "application/json");

                using (HttpResponseMessage res = await client.PostAsync($"{_baseUrl}AddShiftType", content))
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
        public async Task<string> UpdateShiftType(ShiftType shiftType)
        {
            using (HttpClient client = new HttpClient())
            {
                string json = JsonConvert.SerializeObject(shiftType);

                var content = new StringContent(json, Encoding.UTF8, "application/json");

                using (HttpResponseMessage res = await client.PutAsync($"{_baseUrl}UpdateShiftType", content))
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
        public async Task<string> DeleteBenefit(string stID)
        {
            using (HttpClient client = new HttpClient())
            {
                string requestUrl = $"{_baseUrl}DeleteShiftType?stID={stID}";

                using (HttpResponseMessage res = await client.DeleteAsync(requestUrl))
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
