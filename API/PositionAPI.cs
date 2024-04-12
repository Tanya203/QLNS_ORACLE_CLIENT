using CLIENT.DataTier.Models;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CLIENT.API
{
    public class PositionAPI
    {
        private static readonly string _baseUrl = "https://localhost:7102/";
        public async Task<string> GetAllPosition()
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.GetAsync($"{_baseUrl}GetAllPosition"))
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
        public async Task<string> GetPositionDetail()
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.GetAsync($"{_baseUrl}GetPositionDetail"))
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
        public async Task<string> SearchPositionDetail(string search)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.GetAsync($"{_baseUrl}SearchPositionDetail?search={search}"))
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
        public async Task<string> CreatePosition(Position position)
        {
            using (HttpClient client = new HttpClient())
            {
                string json = JsonConvert.SerializeObject(position);

                var content = new StringContent(json, Encoding.UTF8, "application/json");

                using (HttpResponseMessage res = await client.PostAsync($"{_baseUrl}AddPosition", content))
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
        public async Task<string> UpdatePosition(Position position)
        {
            using (HttpClient client = new HttpClient())
            {
                string json = JsonConvert.SerializeObject(position);

                var content = new StringContent(json, Encoding.UTF8, "application/json");

                using (HttpResponseMessage res = await client.PutAsync($"{_baseUrl}UpdatePosition", content))
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
        public async Task<string> DeletePosition(string psID)
        {
            using (HttpClient client = new HttpClient())
            {
                string requestUrl = $"{_baseUrl}DeletePosition?psID={psID}";

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
