﻿using CLIENT.Models;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CLIENT
{
    public class BenefitAPI
    {
        private static readonly string _baseUrl = "https://localhost:7102/";
        public async Task<string> GetAllBenefit()
        {
            using(HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.GetAsync($"{_baseUrl}GetAllBenefit"))
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
        public async Task<string> GetCountBenefit()
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.GetAsync($"{_baseUrl}CountBenefit"))
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
        public async Task<string> SearchCountBenefit(string search)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.GetAsync($"{_baseUrl}SearchCountBenefit?search={search}"))
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
        public async Task<string> CreateBenefit(Benefit benefit)
        {
            using (HttpClient client = new HttpClient())
            {
                string json = JsonConvert.SerializeObject(benefit);

                var content = new StringContent(json, Encoding.UTF8, "application/json");

                using (HttpResponseMessage res = await client.PostAsync($"{_baseUrl}AddBenefit", content))
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
        public async Task<string> UpdateBenefit(Benefit benefit)
        {
            using (HttpClient client = new HttpClient())
            {
                string json = JsonConvert.SerializeObject(benefit);

                var content = new StringContent(json, Encoding.UTF8, "application/json");

                using (HttpResponseMessage res = await client.PutAsync($"{_baseUrl}UpdateBenefit", content))
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
        public async Task<string> DeleteBenefit(string bnID)
        {
            using (HttpClient client = new HttpClient())
            {
                string requestUrl = $"{_baseUrl}DeleteBenefit?bnID={bnID}";

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
