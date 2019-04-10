﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WarehouseManagementServiceClient.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Warehouse", Namespace="http://schemas.datacontract.org/2004/07/WarehouseManagementServiceApp1")]
    [System.SerializableAttribute()]
    public partial class Warehouse : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string companyNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string itemNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string locationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int quantityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int srNoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string warehouseCityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string warehouseNameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string companyName {
            get {
                return this.companyNameField;
            }
            set {
                if ((object.ReferenceEquals(this.companyNameField, value) != true)) {
                    this.companyNameField = value;
                    this.RaisePropertyChanged("companyName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string itemName {
            get {
                return this.itemNameField;
            }
            set {
                if ((object.ReferenceEquals(this.itemNameField, value) != true)) {
                    this.itemNameField = value;
                    this.RaisePropertyChanged("itemName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string location {
            get {
                return this.locationField;
            }
            set {
                if ((object.ReferenceEquals(this.locationField, value) != true)) {
                    this.locationField = value;
                    this.RaisePropertyChanged("location");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int quantity {
            get {
                return this.quantityField;
            }
            set {
                if ((this.quantityField.Equals(value) != true)) {
                    this.quantityField = value;
                    this.RaisePropertyChanged("quantity");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int srNo {
            get {
                return this.srNoField;
            }
            set {
                if ((this.srNoField.Equals(value) != true)) {
                    this.srNoField = value;
                    this.RaisePropertyChanged("srNo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string warehouseCity {
            get {
                return this.warehouseCityField;
            }
            set {
                if ((object.ReferenceEquals(this.warehouseCityField, value) != true)) {
                    this.warehouseCityField = value;
                    this.RaisePropertyChanged("warehouseCity");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string warehouseName {
            get {
                return this.warehouseNameField;
            }
            set {
                if ((object.ReferenceEquals(this.warehouseNameField, value) != true)) {
                    this.warehouseNameField = value;
                    this.RaisePropertyChanged("warehouseName");
                }
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InsertDetails", ReplyAction="http://tempuri.org/IService1/InsertDetailsResponse")]
        void InsertDetails(string warehosueCity, string warehouseName, string companyName, string itemName, int quantity, string location);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InsertDetails", ReplyAction="http://tempuri.org/IService1/InsertDetailsResponse")]
        System.Threading.Tasks.Task InsertDetailsAsync(string warehosueCity, string warehouseName, string companyName, string itemName, int quantity, string location);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDetails", ReplyAction="http://tempuri.org/IService1/GetDetailsResponse")]
        WarehouseManagementServiceClient.ServiceReference1.Warehouse[] GetDetails();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDetails", ReplyAction="http://tempuri.org/IService1/GetDetailsResponse")]
        System.Threading.Tasks.Task<WarehouseManagementServiceClient.ServiceReference1.Warehouse[]> GetDetailsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDetailsById", ReplyAction="http://tempuri.org/IService1/GetDetailsByIdResponse")]
        WarehouseManagementServiceClient.ServiceReference1.Warehouse GetDetailsById(int srNo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDetailsById", ReplyAction="http://tempuri.org/IService1/GetDetailsByIdResponse")]
        System.Threading.Tasks.Task<WarehouseManagementServiceClient.ServiceReference1.Warehouse> GetDetailsByIdAsync(int srNo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateDetails", ReplyAction="http://tempuri.org/IService1/UpdateDetailsResponse")]
        void UpdateDetails(int srNo, string warehouseCity, string warehouseName, string companyName, string itemName, int quantity, string location);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateDetails", ReplyAction="http://tempuri.org/IService1/UpdateDetailsResponse")]
        System.Threading.Tasks.Task UpdateDetailsAsync(int srNo, string warehouseCity, string warehouseName, string companyName, string itemName, int quantity, string location);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteDetails", ReplyAction="http://tempuri.org/IService1/DeleteDetailsResponse")]
        void DeleteDetails(int srNo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteDetails", ReplyAction="http://tempuri.org/IService1/DeleteDetailsResponse")]
        System.Threading.Tasks.Task DeleteDetailsAsync(int srNo);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : WarehouseManagementServiceClient.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<WarehouseManagementServiceClient.ServiceReference1.IService1>, WarehouseManagementServiceClient.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void InsertDetails(string warehosueCity, string warehouseName, string companyName, string itemName, int quantity, string location) {
            base.Channel.InsertDetails(warehosueCity, warehouseName, companyName, itemName, quantity, location);
        }
        
        public System.Threading.Tasks.Task InsertDetailsAsync(string warehosueCity, string warehouseName, string companyName, string itemName, int quantity, string location) {
            return base.Channel.InsertDetailsAsync(warehosueCity, warehouseName, companyName, itemName, quantity, location);
        }
        
        public WarehouseManagementServiceClient.ServiceReference1.Warehouse[] GetDetails() {
            return base.Channel.GetDetails();
        }
        
        public System.Threading.Tasks.Task<WarehouseManagementServiceClient.ServiceReference1.Warehouse[]> GetDetailsAsync() {
            return base.Channel.GetDetailsAsync();
        }
        
        public WarehouseManagementServiceClient.ServiceReference1.Warehouse GetDetailsById(int srNo) {
            return base.Channel.GetDetailsById(srNo);
        }
        
        public System.Threading.Tasks.Task<WarehouseManagementServiceClient.ServiceReference1.Warehouse> GetDetailsByIdAsync(int srNo) {
            return base.Channel.GetDetailsByIdAsync(srNo);
        }
        
        public void UpdateDetails(int srNo, string warehouseCity, string warehouseName, string companyName, string itemName, int quantity, string location) {
            base.Channel.UpdateDetails(srNo, warehouseCity, warehouseName, companyName, itemName, quantity, location);
        }
        
        public System.Threading.Tasks.Task UpdateDetailsAsync(int srNo, string warehouseCity, string warehouseName, string companyName, string itemName, int quantity, string location) {
            return base.Channel.UpdateDetailsAsync(srNo, warehouseCity, warehouseName, companyName, itemName, quantity, location);
        }
        
        public void DeleteDetails(int srNo) {
            base.Channel.DeleteDetails(srNo);
        }
        
        public System.Threading.Tasks.Task DeleteDetailsAsync(int srNo) {
            return base.Channel.DeleteDetailsAsync(srNo);
        }
    }
}
