﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebServiceForm.ServiceWebFX {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://localhost/", ConfigurationName="ServiceWebFX.WebServiceFXSoap")]
    public interface WebServiceFXSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost/Fibonacci", ReplyAction="*")]
        int Fibonacci(int n);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost/Fibonacci", ReplyAction="*")]
        System.Threading.Tasks.Task<int> FibonacciAsync(int n);
        
        // CODEGEN : La génération du contrat de message depuis le nom d'élément xml de l'espace de noms http://localhost/ n'est pas marqué nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost/XmlToJson", ReplyAction="*")]
        WebServiceForm.ServiceWebFX.XmlToJsonResponse XmlToJson(WebServiceForm.ServiceWebFX.XmlToJsonRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost/XmlToJson", ReplyAction="*")]
        System.Threading.Tasks.Task<WebServiceForm.ServiceWebFX.XmlToJsonResponse> XmlToJsonAsync(WebServiceForm.ServiceWebFX.XmlToJsonRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class XmlToJsonRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="XmlToJson", Namespace="http://localhost/", Order=0)]
        public WebServiceForm.ServiceWebFX.XmlToJsonRequestBody Body;
        
        public XmlToJsonRequest() {
        }
        
        public XmlToJsonRequest(WebServiceForm.ServiceWebFX.XmlToJsonRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://localhost/")]
    public partial class XmlToJsonRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string xml;
        
        public XmlToJsonRequestBody() {
        }
        
        public XmlToJsonRequestBody(string xml) {
            this.xml = xml;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class XmlToJsonResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="XmlToJsonResponse", Namespace="http://localhost/", Order=0)]
        public WebServiceForm.ServiceWebFX.XmlToJsonResponseBody Body;
        
        public XmlToJsonResponse() {
        }
        
        public XmlToJsonResponse(WebServiceForm.ServiceWebFX.XmlToJsonResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://localhost/")]
    public partial class XmlToJsonResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string XmlToJsonResult;
        
        public XmlToJsonResponseBody() {
        }
        
        public XmlToJsonResponseBody(string XmlToJsonResult) {
            this.XmlToJsonResult = XmlToJsonResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebServiceFXSoapChannel : WebServiceForm.ServiceWebFX.WebServiceFXSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebServiceFXSoapClient : System.ServiceModel.ClientBase<WebServiceForm.ServiceWebFX.WebServiceFXSoap>, WebServiceForm.ServiceWebFX.WebServiceFXSoap {
        
        public WebServiceFXSoapClient() {
        }
        
        public WebServiceFXSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebServiceFXSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceFXSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceFXSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int Fibonacci(int n) {
            return base.Channel.Fibonacci(n);
        }
        
        public System.Threading.Tasks.Task<int> FibonacciAsync(int n) {
            return base.Channel.FibonacciAsync(n);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebServiceForm.ServiceWebFX.XmlToJsonResponse WebServiceForm.ServiceWebFX.WebServiceFXSoap.XmlToJson(WebServiceForm.ServiceWebFX.XmlToJsonRequest request) {
            return base.Channel.XmlToJson(request);
        }
        
        public string XmlToJson(string xml) {
            WebServiceForm.ServiceWebFX.XmlToJsonRequest inValue = new WebServiceForm.ServiceWebFX.XmlToJsonRequest();
            inValue.Body = new WebServiceForm.ServiceWebFX.XmlToJsonRequestBody();
            inValue.Body.xml = xml;
            WebServiceForm.ServiceWebFX.XmlToJsonResponse retVal = ((WebServiceForm.ServiceWebFX.WebServiceFXSoap)(this)).XmlToJson(inValue);
            return retVal.Body.XmlToJsonResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebServiceForm.ServiceWebFX.XmlToJsonResponse> WebServiceForm.ServiceWebFX.WebServiceFXSoap.XmlToJsonAsync(WebServiceForm.ServiceWebFX.XmlToJsonRequest request) {
            return base.Channel.XmlToJsonAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebServiceForm.ServiceWebFX.XmlToJsonResponse> XmlToJsonAsync(string xml) {
            WebServiceForm.ServiceWebFX.XmlToJsonRequest inValue = new WebServiceForm.ServiceWebFX.XmlToJsonRequest();
            inValue.Body = new WebServiceForm.ServiceWebFX.XmlToJsonRequestBody();
            inValue.Body.xml = xml;
            return ((WebServiceForm.ServiceWebFX.WebServiceFXSoap)(this)).XmlToJsonAsync(inValue);
        }
    }
}
