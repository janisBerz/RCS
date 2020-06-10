using Newtonsoft.Json;
using System;
using System.Net;

namespace Day18_REST
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "http://dummy.restapiexample.com/api/v1/employees";

            WebClient webClient = new WebClient();

            string response = webClient.DownloadString(url);

            Conainer data = JsonConvert.DeserializeObject<Conainer>(response);

            if (data.Status == "success")
            {
                foreach (Employee item in data.data)
                {
                    Console.WriteLine(item.Employee_name);
                }
            }
        }
    }
}
