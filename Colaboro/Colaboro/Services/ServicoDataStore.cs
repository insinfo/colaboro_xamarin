using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Colaboro;
using Colaboro.Models;
using Newtonsoft.Json;

namespace Colaboro.Services
{
    public class ServicoDataStore : IDataStore<Servico>
    {
        HttpClient client;
        IEnumerable<Servico> items;

        public ServicoDataStore()
        {
            client = new HttpClient();
            client.DefaultRequestHeaders.Add("User-Agent", "appjubarte");
            if (AppSettings.AuthInfo != null)
            {
                var token = "Bearer " + AppSettings.AuthInfo.accessToken;              
                this.client.DefaultRequestHeaders.Add("Authorization", token);
            }
            client.BaseAddress = new Uri($"{AppSettings.WebServiceBaseURL}/");

            items = new List<Servico>();
        }

        public async Task<IEnumerable<Servico>> GetItemsAsync(bool forceRefresh = false)
        {
            if (forceRefresh)
            {
                var json = await client.GetStringAsync($"ciente/api/app/servicos");
                items = await Task.Run(() => ServicoData.GetFromJson(json).data);
            }

            return items;
        }

        public async Task<Servico> GetItemAsync(string id)
        {
            if (id != null)
            {
                var json = await client.GetStringAsync($"api/item/{id}");
                return await Task.Run(() => JsonConvert.DeserializeObject<Servico>(json));
            }

            return null;
        }

        public async Task<bool> AddItemAsync(Servico item)
        {
            if (item == null)
                return false;

            var serializedItem = JsonConvert.SerializeObject(item);

            var response = await client.PostAsync($"api/item", new StringContent(serializedItem, Encoding.UTF8, "application/json"));

            return response.IsSuccessStatusCode;
        }

        public async Task<bool> UpdateItemAsync(Servico item)
        {
            if (item == null || item.id == null)
                return false;

            var serializedItem = JsonConvert.SerializeObject(item);
            var buffer = Encoding.UTF8.GetBytes(serializedItem);
            var byteContent = new ByteArrayContent(buffer);

            var response = await client.PutAsync(new Uri($"api/item/{item.id}"), byteContent);

            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            if (string.IsNullOrEmpty(id))
                return false;

            var response = await client.DeleteAsync($"api/item/{id}");

            return response.IsSuccessStatusCode;
        }
    }
}