﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AngulerWCFAndMVC.UserServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UserDataContract", Namespace="http://schemas.datacontract.org/2004/07/WCFRest")]
    [System.SerializableAttribute()]
    public partial class UserDataContract : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
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
        public string Address {
            get {
                return this.AddressField;
            }
            set {
                if ((object.ReferenceEquals(this.AddressField, value) != true)) {
                    this.AddressField = value;
                    this.RaisePropertyChanged("Address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string City {
            get {
                return this.CityField;
            }
            set {
                if ((object.ReferenceEquals(this.CityField, value) != true)) {
                    this.CityField = value;
                    this.RaisePropertyChanged("City");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="UserServiceReference.IUserService")]
    public interface IUserService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/GetAllUser", ReplyAction="http://tempuri.org/IUserService/GetAllUserResponse")]
        AngulerWCFAndMVC.UserServiceReference.UserDataContract[] GetAllUser();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/GetAllUser", ReplyAction="http://tempuri.org/IUserService/GetAllUserResponse")]
        System.Threading.Tasks.Task<AngulerWCFAndMVC.UserServiceReference.UserDataContract[]> GetAllUserAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/GetAllUserJson", ReplyAction="http://tempuri.org/IUserService/GetAllUserJsonResponse")]
        string GetAllUserJson();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/GetAllUserJson", ReplyAction="http://tempuri.org/IUserService/GetAllUserJsonResponse")]
        System.Threading.Tasks.Task<string> GetAllUserJsonAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/GetUserDetails", ReplyAction="http://tempuri.org/IUserService/GetUserDetailsResponse")]
        AngulerWCFAndMVC.UserServiceReference.UserDataContract GetUserDetails(int Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/GetUserDetails", ReplyAction="http://tempuri.org/IUserService/GetUserDetailsResponse")]
        System.Threading.Tasks.Task<AngulerWCFAndMVC.UserServiceReference.UserDataContract> GetUserDetailsAsync(int Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/AddNewUser", ReplyAction="http://tempuri.org/IUserService/AddNewUserResponse")]
        bool AddNewUser(AngulerWCFAndMVC.UserServiceReference.UserDataContract Users);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/AddNewUser", ReplyAction="http://tempuri.org/IUserService/AddNewUserResponse")]
        System.Threading.Tasks.Task<bool> AddNewUserAsync(AngulerWCFAndMVC.UserServiceReference.UserDataContract Users);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/UpdateUser", ReplyAction="http://tempuri.org/IUserService/UpdateUserResponse")]
        void UpdateUser(AngulerWCFAndMVC.UserServiceReference.UserDataContract Users);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/UpdateUser", ReplyAction="http://tempuri.org/IUserService/UpdateUserResponse")]
        System.Threading.Tasks.Task UpdateUserAsync(AngulerWCFAndMVC.UserServiceReference.UserDataContract Users);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/DeleteUser", ReplyAction="http://tempuri.org/IUserService/DeleteUserResponse")]
        void DeleteUser(int Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/DeleteUser", ReplyAction="http://tempuri.org/IUserService/DeleteUserResponse")]
        System.Threading.Tasks.Task DeleteUserAsync(int Id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IUserServiceChannel : AngulerWCFAndMVC.UserServiceReference.IUserService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UserServiceClient : System.ServiceModel.ClientBase<AngulerWCFAndMVC.UserServiceReference.IUserService>, AngulerWCFAndMVC.UserServiceReference.IUserService {
        
        public UserServiceClient() {
        }
        
        public UserServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public UserServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public AngulerWCFAndMVC.UserServiceReference.UserDataContract[] GetAllUser() {
            return base.Channel.GetAllUser();
        }
        
        public System.Threading.Tasks.Task<AngulerWCFAndMVC.UserServiceReference.UserDataContract[]> GetAllUserAsync() {
            return base.Channel.GetAllUserAsync();
        }
        
        public string GetAllUserJson() {
            return base.Channel.GetAllUserJson();
        }
        
        public System.Threading.Tasks.Task<string> GetAllUserJsonAsync() {
            return base.Channel.GetAllUserJsonAsync();
        }
        
        public AngulerWCFAndMVC.UserServiceReference.UserDataContract GetUserDetails(int Id) {
            return base.Channel.GetUserDetails(Id);
        }
        
        public System.Threading.Tasks.Task<AngulerWCFAndMVC.UserServiceReference.UserDataContract> GetUserDetailsAsync(int Id) {
            return base.Channel.GetUserDetailsAsync(Id);
        }
        
        public bool AddNewUser(AngulerWCFAndMVC.UserServiceReference.UserDataContract Users) {
            return base.Channel.AddNewUser(Users);
        }
        
        public System.Threading.Tasks.Task<bool> AddNewUserAsync(AngulerWCFAndMVC.UserServiceReference.UserDataContract Users) {
            return base.Channel.AddNewUserAsync(Users);
        }
        
        public void UpdateUser(AngulerWCFAndMVC.UserServiceReference.UserDataContract Users) {
            base.Channel.UpdateUser(Users);
        }
        
        public System.Threading.Tasks.Task UpdateUserAsync(AngulerWCFAndMVC.UserServiceReference.UserDataContract Users) {
            return base.Channel.UpdateUserAsync(Users);
        }
        
        public void DeleteUser(int Id) {
            base.Channel.DeleteUser(Id);
        }
        
        public System.Threading.Tasks.Task DeleteUserAsync(int Id) {
            return base.Channel.DeleteUserAsync(Id);
        }
    }
}