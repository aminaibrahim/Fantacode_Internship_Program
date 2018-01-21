
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Models;

namespace ToDoApp.Sevices
{
    public class ToDoServices
    {
        private const string BaseUrl = "https://todointern.azurewebsites.net/api/";
        private HttpClient httpclient;
        public ToDoServices()
        {
            httpclient = new HttpClient();
            httpclient.BaseAddress = new System.Uri(BaseUrl);
        }
        async public Task<ObservableCollection<TodoItem>> GetTodoList()
        {
            try
            {
                var result = await httpclient.GetAsync("Todo");
                if (result.IsSuccessStatusCode)
                {
                    var json = await result.Content.ReadAsStringAsync();
                    var todolist = JsonConvert.DeserializeObject<ObservableCollection<TodoItem>>(json);
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

        async public Task<bool> PostTodo(TodoItem item)
        {
            try
            {
                var itemtosend = JsonConvert.SerializeObject(item);
                var content = new StringContent(itemtosend, Encoding.UTF8, "application/json");
                var result = await httpclient.PostAsync("Todo", content);
                if (result.IsSuccessStatusCode)
                    return true;
                return false;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        async public Task<bool> Delete(int id)
        {
            try
            {
                //  var itemtosend = JsonConvert.SerializeObject(item);
                // var content = new StringContent(itemtosend, Encoding.UTF8, "application/json");
                var result = await httpclient.DeleteAsync("Todo/" + id);
                if (result.IsSuccessStatusCode)
                    return true;
                return false;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        async public Task<bool> Update(TodoItem item)
        {
            try
            {
                var itemtosend = JsonConvert.SerializeObject(item);
                var content = new StringContent(itemtosend, Encoding.UTF8, "application/json");
                var result = await httpclient.PutAsync("Todo/" + item.todoId, content);
                if (result.IsSuccessStatusCode)
                    return true;
                return false;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        async public Task<bool> Done(TodoItem item)
        {
            try
            {
                var itemtosend = JsonConvert.SerializeObject(item);
                var content = new StringContent(itemtosend, Encoding.UTF8, "application/json");
                var result = await httpclient.PutAsync("Todo/" + item.todoId, content);
                if (result.IsSuccessStatusCode)
                    return true;
                return false;
            }
            catch (Exception e)
            {
                return false;
            }


        }
    }
}