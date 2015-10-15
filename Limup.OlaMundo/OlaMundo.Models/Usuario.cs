using System;
using System.Runtime.Serialization;

namespace OlaMundo.Models
{
    [DataContract]
    public class Usuario
    {
        [DataMember]
        public String Nome { get; set; }
    }
}
