﻿using FoodOrder.Models;
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
                MessageBox.Show(res.ToString());

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
    }
}
