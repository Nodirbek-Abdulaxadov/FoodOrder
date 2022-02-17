using FoodOrder.Models;
using FoodOrder.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrder.Winform.Services
{
    public class CategoryAPIService
    {
        string baseUrl = "https://foodorderapi20220210145144.azurewebsites.net/api/";
        public List<Kategoriya> Kategoriyalar { get; set; }
        HttpClient client;
        public List<Kategoriya> GetKategoriyalar()
        {
            string url = baseUrl + "category/getall";
            client = new HttpClient();

            var json = client.GetStringAsync(url).Result;
            var list = JsonConvert.DeserializeObject<List<Kategoriya>>(json);

            return list;
        }

        public async Task<bool> AddCategory(string nomi)
        {
            client = new HttpClient();
            client.BaseAddress = new Uri(baseUrl);

            KategoriyaViewModel viewModel = new KategoriyaViewModel()
            {
                Id = Guid.NewGuid(),
                Nomi = nomi,
            };

            var json = JsonConvert.SerializeObject(viewModel);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            
            var res = client.PostAsync("category/add", data).Result;
            
            if (res.IsSuccessStatusCode)
            {
                return true;
            }

            return false;
        }

        public async Task<bool> UpdateCategory(Guid id, string text)
        {
            client = new HttpClient();
            client.BaseAddress = new Uri(baseUrl);

            KategoriyaViewModel viewModel = new KategoriyaViewModel()
            {
                Id = id,
                Nomi = text,
            };

            var json = JsonConvert.SerializeObject(viewModel);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            var res = client.PutAsync("category/update", data).Result;

            if (res.IsSuccessStatusCode)
            {
                return true;
            }

            return false;
        }

        public bool DeleteCategory(string id)
        {
            client = new HttpClient();
            string url = baseUrl + "category/delete/" + id;
            var res = client.DeleteAsync(url).Result;

            if (res.IsSuccessStatusCode)
            {
                return true;
            }

            return false;
        }
    }
}
