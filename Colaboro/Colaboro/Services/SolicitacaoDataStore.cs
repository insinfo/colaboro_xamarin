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
    public class SolicitacaoDataStore : IDataStore<Solicitacao>
    {
        HttpClient client;
        IEnumerable<Solicitacao> items;

        public SolicitacaoDataStore()
        {
            client = new HttpClient();
            client.DefaultRequestHeaders.Add("User-Agent", "appjubarte");
            if (AppSettings.AuthInfo != null)
            {
                var token = "Bearer " + AppSettings.AuthInfo.accessToken;              
                this.client.DefaultRequestHeaders.Add("Authorization", token);
            }
            client.BaseAddress = new Uri($"{AppSettings.WebServiceBaseURL}/");

            items = new List<Solicitacao>();
        }

        public async Task<IEnumerable<Solicitacao>> GetItemsAsync(bool forceRefresh = false)
        {
            if (forceRefresh)
            {
                var json = await client.GetStringAsync($"ciente/api/app/solicitacao");
                items = await Task.Run(() => SolicitacaoData.GetFromJson(json).data);
            }

            return items;
        }

        public async Task<Solicitacao> GetItemAsync(string id)
        {
            if (id != null)
            {
                var json = await client.GetStringAsync($"api/item/{id}");
                return await Task.Run(() => JsonConvert.DeserializeObject<Solicitacao>(json));
            }

            return null;
        }

        public async Task<bool> AddItemAsync(Solicitacao item)
        {
            if (item == null)
                return false;

            var serializedItem = JsonConvert.SerializeObject(item);

            var response = await client.PostAsync($"api/item", new StringContent(serializedItem, Encoding.UTF8, "application/json"));

            return response.IsSuccessStatusCode;
        }

        public async Task<bool> UpdateItemAsync(Solicitacao item)
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