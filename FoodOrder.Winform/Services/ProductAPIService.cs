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
    public class ProductAPIService
    {
        string baseUrl = "https://foodorderapi20220210145144.azurewebsites.net/api/mahsulot/";
        public List<Mahsulot> Mahsulotlar { get; set; }
        HttpClient client;
        public List<Mahsulot> GetMahsulotlar()
        {
            string url = baseUrl + "getall";
            client = new HttpClient();

            var json = client.GetStringAsync(url).Result;
            var list = JsonConvert.DeserializeObject<List<Mahsulot>>(json);

            return list;
        }

        public async Task<bool> AddProduct(MahsulotViewModel mahsulot)
        {
            try
            {
                client = new HttpClient();
                client.BaseAddress = new Uri(baseUrl);

                var json = JsonConvert.SerializeObject(mahsulot);
                var data = new StringContent(json, Encoding.UTF8, "application/json");

                var res = client.PostAsync("add", data).Result;

                if (res.IsSuccessStatusCode)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);                
            }

            return false;
        }

        internal HttpResponseMessage UpdateProduct(Mahsulot p)
        {
            client = new HttpClient();
            client.BaseAddress = new Uri(baseUrl);

            var json = JsonConvert.SerializeObject(p);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            var res = client.PutAsync("update", data).Result;

            return res;
        }

        internal HttpResponseMessage DeleteProduct(string? selectedId)
        {
            client = new HttpClient();
            string url = baseUrl + "delete/" + selectedId;
            var res = client.DeleteAsync(url).Result;

            return res;
        }

        internal Mahsulot GetById(string? selectedId)
        {
            client = new HttpClient();
            string url = baseUrl + "get/" + selectedId;
            var json = client.GetStringAsync(url).Result;
            var item = JsonConvert.DeserializeObject<Mahsulot>(json);

            return item;
        }
    }
}
