using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace OlaMundo.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost client = new ServiceHost(typeof(Service.Service), new Uri[] {}))
            {
                client.Open();
                Console.WriteLine("Serviço rodando...");
                Console.WriteLine("Tecle  para finalizar.");
                Console.ReadKey();
                client.Close();
            }
        }
    }
}
