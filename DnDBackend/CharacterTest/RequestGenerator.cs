using DnDBackend.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace CharacterTest
{
    public class RequestGenerator
    {
        private HttpClient _httpClient = new HttpClient();
        private readonly string _uri = "https://localhost:5001/api/character";

        public async Task<HttpResponseMessage> PostCharacter (Character character) 
        {
            var reqJSON = JsonConvert.SerializeObject(character);
            var res = await _httpClient.PostAsJsonAsync(_uri, reqJSON);
            Assert.AreEqual(200, res.StatusCode);

            return res;
        }
        public async Task<Character> GetCharacter (string id) 
        {
            var res = await _uri.SetQueryParam("id", id).GetJsonAsync().Result;

            var deserializedRes = JsonConvert.DeserializeObject<Character>(res);

            return deserializedRes;
        }
    }
}
