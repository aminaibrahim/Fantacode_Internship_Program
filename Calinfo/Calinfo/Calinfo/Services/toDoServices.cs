using Calinfo.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Calinfo.Servicees
{
    class toDoServices
    {
        private const string BaseUrl = "http://localhost:5000/api/calinfo";
        private HttpClient httpclient;
        public toDoServices()
        {
            httpclient = new HttpClient();
            httpclient.BaseAddress = new System.Uri(BaseUrl);
        }
        async public Task<ObservableCollection<model>> GetTodoList()
        {
            try
            {
                var result = await httpclient.GetAsync("Todo");
                if (result.IsSuccessStatusCode)
                {
                    var json = await result.Content.ReadAsStringAsync();
                    var todolist = JsonConvert.DeserializeObject<ObservableCollection<model>>(json);
                    return todolist;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }

    }
}

