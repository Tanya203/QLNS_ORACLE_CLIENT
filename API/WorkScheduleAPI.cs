using CLIENT.DataTier.Models;
using CLIENT.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CLIENT.API
{
    public class WorkScheduleAPI
    {
        private static readonly string _baseUrl = "https://localhost:7102/";
        public async Task<string> GetAllWorkSchedule()
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.GetAsync($"{_baseUrl}GetAllWorkSchedule"))
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
        public async Task<string> SearchWorkSchedule(string search)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.GetAsync($"{_baseUrl}SearchWorkSchedule?search={search}"))
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
        public async Task<string> CreateWorkSchedule(WorkSchedule workSchedule)
        {
            using (HttpClient client = new HttpClient())
            {
                string json = JsonConvert.SerializeObject(workSchedule);

                var content = new StringContent(json, Encoding.UTF8, "application/json");

                using (HttpResponseMessage res = await client.PostAsync($"{_baseUrl}AddWorkSchedule", content))
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
        public async Task<string> AutoSchedule(string month)
        {
            using (HttpClient client = new HttpClient())
            {
                string json = JsonConvert.SerializeObject(month);

                var content = new StringContent(json, Encoding.UTF8, "application/json");

                using (HttpResponseMessage res = await client.PostAsync($"{_baseUrl}AutoSchedule", content))
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
        public async Task<string> DeleteWorkSchedule(string wsID)
        {
            using (HttpClient client = new HttpClient())
            {
                string requestUrl = $"{_baseUrl}DeleteWorkSchedule?wsID={wsID}";

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
