﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WinApp.Servicio.Soap.Consultas {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://service.sunat.gob.pe", ConfigurationName="Consultas.billService")]
    public interface billService {
        
        // CODEGEN: El parámetro 'status' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="urn:getStatus", ReplyAction="http://service.sunat.gob.pe/billService/getStatusResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="status")]
        WinApp.Servicio.Soap.Consultas.getStatusResponse getStatus(WinApp.Servicio.Soap.Consultas.getStatusRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:getStatus", ReplyAction="http://service.sunat.gob.pe/billService/getStatusResponse")]
        System.Threading.Tasks.Task<WinApp.Servicio.Soap.Consultas.getStatusResponse> getStatusAsync(WinApp.Servicio.Soap.Consultas.getStatusRequest request);
        
        // CODEGEN: El parámetro 'statusCdr' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="urn:getStatusCdr", ReplyAction="http://service.sunat.gob.pe/billService/getStatusCdrResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="statusCdr")]
        WinApp.Servicio.Soap.Consultas.getStatusCdrResponse getStatusCdr(WinApp.Servicio.Soap.Consultas.getStatusCdrRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:getStatusCdr", ReplyAction="http://service.sunat.gob.pe/billService/getStatusCdrResponse")]
        System.Threading.Tasks.Task<WinApp.Servicio.Soap.Consultas.getStatusCdrResponse> getStatusCdrAsync(WinApp.Servicio.Soap.Consultas.getStatusCdrRequest request);
    }
    
    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://service.sunat.gob.pe")]
    public partial class statusResponse : object, System.ComponentModel.INotifyPropertyChanged {
        
        private byte[] contentField;
        
        private string statusCodeField;
        
        private string statusMessageField;
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="base64Binary", Order=0)]
        public byte[] content {
            get {
                return this.contentField;
            }
            set {
                this.contentField = value;
                this.RaisePropertyChanged("content");
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string statusCode {
            get {
                return this.statusCodeField;
            }
            set {
                this.statusCodeField = value;
                this.RaisePropertyChanged("statusCode");
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string statusMessage {
            get {
                return this.statusMessageField;
            }
            set {
                this.statusMessageField = value;
                this.RaisePropertyChanged("statusMessage");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getStatus", WrapperNamespace="http://service.sunat.gob.pe", IsWrapped=true)]
    public partial class getStatusRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service.sunat.gob.pe", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string rucComprobante;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service.sunat.gob.pe", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string tipoComprobante;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service.sunat.gob.pe", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string serieComprobante;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service.sunat.gob.pe", Order=3)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int numeroComprobante;
        
        public getStatusRequest() {
        }
        
        public getStatusRequest(string rucComprobante, string tipoComprobante, string serieComprobante, int numeroComprobante) {
            this.rucComprobante = rucComprobante;
            this.tipoComprobante = tipoComprobante;
            this.serieComprobante = serieComprobante;
            this.numeroComprobante = numeroComprobante;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getStatusResponse", WrapperNamespace="http://service.sunat.gob.pe", IsWrapped=true)]
    public partial class getStatusResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service.sunat.gob.pe", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public WinApp.Servicio.Soap.Consultas.statusResponse status;
        
        public getStatusResponse() {
        }
        
        public getStatusResponse(WinApp.Servicio.Soap.Consultas.statusResponse status) {
            this.status = status;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getStatusCdr", WrapperNamespace="http://service.sunat.gob.pe", IsWrapped=true)]
    public partial class getStatusCdrRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service.sunat.gob.pe", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string rucComprobante;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service.sunat.gob.pe", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string tipoComprobante;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service.sunat.gob.pe", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string serieComprobante;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service.sunat.gob.pe", Order=3)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int numeroComprobante;
        
        public getStatusCdrRequest() {
        }
        
        public getStatusCdrRequest(string rucComprobante, string tipoComprobante, string serieComprobante, int numeroComprobante) {
            this.rucComprobante = rucComprobante;
            this.tipoComprobante = tipoComprobante;
            this.serieComprobante = serieComprobante;
            this.numeroComprobante = numeroComprobante;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getStatusCdrResponse", WrapperNamespace="http://service.sunat.gob.pe", IsWrapped=true)]
    public partial class getStatusCdrResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service.sunat.gob.pe", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public WinApp.Servicio.Soap.Consultas.statusResponse statusCdr;
        
        public getStatusCdrResponse() {
        }
        
        public getStatusCdrResponse(WinApp.Servicio.Soap.Consultas.statusResponse statusCdr) {
            this.statusCdr = statusCdr;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface billServiceChannel : WinApp.Servicio.Soap.Consultas.billService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class billServiceClient : System.ServiceModel.ClientBase<WinApp.Servicio.Soap.Consultas.billService>, WinApp.Servicio.Soap.Consultas.billService {
        
        public billServiceClient() {
        }
        
        public billServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public billServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public billServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public billServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WinApp.Servicio.Soap.Consultas.getStatusResponse WinApp.Servicio.Soap.Consultas.billService.getStatus(WinApp.Servicio.Soap.Consultas.getStatusRequest request) {
            return base.Channel.getStatus(request);
        }
        
        public WinApp.Servicio.Soap.Consultas.statusResponse getStatus(string rucComprobante, string tipoComprobante, string serieComprobante, int numeroComprobante) {
            WinApp.Servicio.Soap.Consultas.getStatusRequest inValue = new WinApp.Servicio.Soap.Consultas.getStatusRequest();
            inValue.rucComprobante = rucComprobante;
            inValue.tipoComprobante = tipoComprobante;
            inValue.serieComprobante = serieComprobante;
            inValue.numeroComprobante = numeroComprobante;
            WinApp.Servicio.Soap.Consultas.getStatusResponse retVal = ((WinApp.Servicio.Soap.Consultas.billService)(this)).getStatus(inValue);
            return retVal.status;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WinApp.Servicio.Soap.Consultas.getStatusResponse> WinApp.Servicio.Soap.Consultas.billService.getStatusAsync(WinApp.Servicio.Soap.Consultas.getStatusRequest request) {
            return base.Channel.getStatusAsync(request);
        }
        
        public System.Threading.Tasks.Task<WinApp.Servicio.Soap.Consultas.getStatusResponse> getStatusAsync(string rucComprobante, string tipoComprobante, string serieComprobante, int numeroComprobante) {
            WinApp.Servicio.Soap.Consultas.getStatusRequest inValue = new WinApp.Servicio.Soap.Consultas.getStatusRequest();
            inValue.rucComprobante = rucComprobante;
            inValue.tipoComprobante = tipoComprobante;
            inValue.serieComprobante = serieComprobante;
            inValue.numeroComprobante = numeroComprobante;
            return ((WinApp.Servicio.Soap.Consultas.billService)(this)).getStatusAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WinApp.Servicio.Soap.Consultas.getStatusCdrResponse WinApp.Servicio.Soap.Consultas.billService.getStatusCdr(WinApp.Servicio.Soap.Consultas.getStatusCdrRequest request) {
            return base.Channel.getStatusCdr(request);
        }
        
        public WinApp.Servicio.Soap.Consultas.statusResponse getStatusCdr(string rucComprobante, string tipoComprobante, string serieComprobante, int numeroComprobante) {
            WinApp.Servicio.Soap.Consultas.getStatusCdrRequest inValue = new WinApp.Servicio.Soap.Consultas.getStatusCdrRequest();
            inValue.rucComprobante = rucComprobante;
            inValue.tipoComprobante = tipoComprobante;
            inValue.serieComprobante = serieComprobante;
            inValue.numeroComprobante = numeroComprobante;
            WinApp.Servicio.Soap.Consultas.getStatusCdrResponse retVal = ((WinApp.Servicio.Soap.Consultas.billService)(this)).getStatusCdr(inValue);
            return retVal.statusCdr;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WinApp.Servicio.Soap.Consultas.getStatusCdrResponse> WinApp.Servicio.Soap.Consultas.billService.getStatusCdrAsync(WinApp.Servicio.Soap.Consultas.getStatusCdrRequest request) {
            return base.Channel.getStatusCdrAsync(request);
        }
        
        public System.Threading.Tasks.Task<WinApp.Servicio.Soap.Consultas.getStatusCdrResponse> getStatusCdrAsync(string rucComprobante, string tipoComprobante, string serieComprobante, int numeroComprobante) {
            WinApp.Servicio.Soap.Consultas.getStatusCdrRequest inValue = new WinApp.Servicio.Soap.Consultas.getStatusCdrRequest();
            inValue.rucComprobante = rucComprobante;
            inValue.tipoComprobante = tipoComprobante;
            inValue.serieComprobante = serieComprobante;
            inValue.numeroComprobante = numeroComprobante;
            return ((WinApp.Servicio.Soap.Consultas.billService)(this)).getStatusCdrAsync(inValue);
        }
    }
}
