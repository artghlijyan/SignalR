using Microsoft.AspNetCore.SignalR.Client;
using SignalR.Models;
using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace ChatClient
{
    internal class Program
    {
        private static HubConnection HubConnection { get; set; }

        private static async Task Main(string[] args)
        {
            //HttpClient client = new HttpClient();

            //var response = await client.GetAsync("http://localhost:48591/api/conversation/getall");
            //var jsString = await response.Content.ReadAsStringAsync();

            //var mess = JsonSerializer.Deserialize<ICollection<int>>(jsString);

            HubConnection = new HubConnectionBuilder()
                .WithUrl("http://localhost:48591/chat")
                .Build();

            HubConnection.On<string>("ReceiveMessage", message =>
            {
                Console.WriteLine(message);
                //Console.WriteLine($"Tittle: {message.Title}");
                //Console.WriteLine($"Body: {message.Text}");
                //Console.WriteLine($"Date: {message.CreatedDate}");
            });

            await HubConnection.StartAsync();

            var rnd = new Random();

            bool isExit = false;

            while (!isExit)
            {
                Console.WriteLine("Enter Message or Exit");

                var input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                    continue;

                if (input == "exit")
                {
                    isExit = true;
                }

                var message = new MessageRequestModel
                {
                    Title = rnd.Next(1000).ToString(),
                    Text = input,
                    CreatedDate = DateTime.Now
                };

                HttpClient client = new HttpClient();
                //await HubConnection.SendAsync("SendMessage", input);
                await client.GetAsync($"http://localhost:48591/api/conversation/Ba/{input}");
            }
        }
    }
}
