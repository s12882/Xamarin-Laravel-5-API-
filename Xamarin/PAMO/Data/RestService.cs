using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace PAMO
{
    public class RestService : IRestService
    {
        public static HttpClient client;

        IStorageService storageService;

        public RestService()
        {
            client = new HttpClient();
            client.MaxResponseContentBufferSize = 256000;
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer");
        }

        public async Task<String> loginUser(string login, string password)
        {
            var uri = new Uri(string.Format("http://172.17.16.51:8000/api/login"));
            client.DefaultRequestHeaders.Accept
            .Add(new MediaTypeWithQualityHeaderValue("application/json"));

            List<KeyValuePair<string, string>> formFields = new List<KeyValuePair<string, string>>();
            formFields.Add(new KeyValuePair<string, string>("login", login));
            formFields.Add(new KeyValuePair<string, string>("password", password));
            var formContent = new FormUrlEncodedContent(formFields);

            try
            {
                var response = await client.PostAsync(uri, formContent);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var token = JObject.Parse(content)["token"];
                    return token.ToString(); 
                }
                else
                    return "";
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"ERROR {0}", ex.Message);
                return "";
            }    
        }

        public async Task<User> getUser(string token)
        {
            User currentUser = new User();
            var uri = new Uri(string.Format("http://192.168.0.192:8000/api/details"));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            client.DefaultRequestHeaders.Accept
            .Add(new MediaTypeWithQualityHeaderValue("application/json"));

            List<KeyValuePair<string, string>> formFields = new List<KeyValuePair<string, string>>();
            formFields.Add(new KeyValuePair<string, string>("id", ""));
            var formContent = new FormUrlEncodedContent(formFields);

            try
            {
                var response = await client.PostAsync(uri, formContent);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync(); 

                    currentUser.id = (int)JObject.Parse(content)["success"]["id"];
                    currentUser.name = JObject.Parse(content)["success"]["first_name"].ToString();
                    currentUser.username = JObject.Parse(content)["success"]["login"].ToString();
                    currentUser.email = JObject.Parse(content)["success"]["email"].ToString();
                    currentUser.surname = JObject.Parse(content)["success"]["surname"].ToString();
                    currentUser.section_id = JObject.Parse(content)["success"]["section_id"].ToString();

                    return currentUser;
                }
                else
                    return currentUser;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"ERROR {0}", ex.Message);
                return currentUser;
            }
        }

        public async Task<dynamic> getWeather(string queryString)
        {
            dynamic data = null;
            HttpClient client = new HttpClient();
            try
            {
                var response = await client.GetAsync(queryString);
                if (response != null)
                {
                    string json = response.Content.ReadAsStringAsync().Result;
                    data = JsonConvert.DeserializeObject(json);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"ERROR {0}", ex.Message);
            }

            return data;
        }
    }


}
