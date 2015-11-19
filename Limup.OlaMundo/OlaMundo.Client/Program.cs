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
            using (ServiceOlaMundo.ServiceClient proxy = new ServiceOlaMundo.ServiceClient())
            {
                proxy.Open();
                Console.WriteLine("Serviço conectado...");
                Console.WriteLine("Entre com o usuário:");

                Console.WriteLine(proxy.TrataOlaMundo(Console.ReadLine()));
                Console.ReadKey();
                proxy.Close();
            }
        }
    }
}
