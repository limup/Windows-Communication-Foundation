﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OlaMundo.Client.ServiceOlaMundo {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceOlaMundo.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/TrataOlaMundo", ReplyAction="http://tempuri.org/IService/TrataOlaMundoResponse")]
        string TrataOlaMundo(string nome);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/TrataOlaMundo", ReplyAction="http://tempuri.org/IService/TrataOlaMundoResponse")]
        System.Threading.Tasks.Task<string> TrataOlaMundoAsync(string nome);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : OlaMundo.Client.ServiceOlaMundo.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<OlaMundo.Client.ServiceOlaMundo.IService>, OlaMundo.Client.ServiceOlaMundo.IService {
        
        public ServiceClient() {
        }
        
        public ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string TrataOlaMundo(string nome) {
            return base.Channel.TrataOlaMundo(nome);
        }
        
        public System.Threading.Tasks.Task<string> TrataOlaMundoAsync(string nome) {
            return base.Channel.TrataOlaMundoAsync(nome);
        }
    }
}
