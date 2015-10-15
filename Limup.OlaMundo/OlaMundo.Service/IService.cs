using System;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace OlaMundo.Service
{
    [ServiceContract]
    public interface IService
    {
        [WebGet(ResponseFormat = WebMessageFormat.Json,UriTemplate = "TrataOlaMundo?Nome={Nome}")]
        [OperationContract]
        string TrataOlaMundo(String nome);
    }
}
