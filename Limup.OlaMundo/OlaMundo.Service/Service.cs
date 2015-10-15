using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlaMundo.Service
{
    public class Service : IService
    {
        public string TrataOlaMundo(string nome)
        {
            return "Olá! Seja Bem Vindo " + nome;
        }
    }
}
