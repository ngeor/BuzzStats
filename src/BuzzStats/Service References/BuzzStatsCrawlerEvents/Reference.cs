﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BuzzStats.BuzzStatsCrawlerEvents {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="StoryCheckedEventArgs", Namespace="http://schemas.datacontract.org/2004/07/BuzzStats.Web.api")]
    [System.SerializableAttribute()]
    public partial class StoryCheckedEventArgs : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool HadChangesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SelectorNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int StoryIdField;
        
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
        public bool HadChanges {
            get {
                return this.HadChangesField;
            }
            set {
                if ((this.HadChangesField.Equals(value) != true)) {
                    this.HadChangesField = value;
                    this.RaisePropertyChanged("HadChanges");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SelectorName {
            get {
                return this.SelectorNameField;
            }
            set {
                if ((object.ReferenceEquals(this.SelectorNameField, value) != true)) {
                    this.SelectorNameField = value;
                    this.RaisePropertyChanged("SelectorName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int StoryId {
            get {
                return this.StoryIdField;
            }
            set {
                if ((this.StoryIdField.Equals(value) != true)) {
                    this.StoryIdField = value;
                    this.RaisePropertyChanged("StoryId");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="BuzzStatsCrawlerEvents.ICrawlerEvents")]
    public interface ICrawlerEvents {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrawlerEvents/StoryChecked", ReplyAction="http://tempuri.org/ICrawlerEvents/StoryCheckedResponse")]
        void StoryChecked(BuzzStats.BuzzStatsCrawlerEvents.StoryCheckedEventArgs arguments);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrawlerEvents/StoryChecked", ReplyAction="http://tempuri.org/ICrawlerEvents/StoryCheckedResponse")]
        System.Threading.Tasks.Task StoryCheckedAsync(BuzzStats.BuzzStatsCrawlerEvents.StoryCheckedEventArgs arguments);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrawlerEventsChannel : BuzzStats.BuzzStatsCrawlerEvents.ICrawlerEvents, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CrawlerEventsClient : System.ServiceModel.ClientBase<BuzzStats.BuzzStatsCrawlerEvents.ICrawlerEvents>, BuzzStats.BuzzStatsCrawlerEvents.ICrawlerEvents {
        
        public CrawlerEventsClient() {
        }
        
        public CrawlerEventsClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrawlerEventsClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrawlerEventsClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrawlerEventsClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void StoryChecked(BuzzStats.BuzzStatsCrawlerEvents.StoryCheckedEventArgs arguments) {
            base.Channel.StoryChecked(arguments);
        }
        
        public System.Threading.Tasks.Task StoryCheckedAsync(BuzzStats.BuzzStatsCrawlerEvents.StoryCheckedEventArgs arguments) {
            return base.Channel.StoryCheckedAsync(arguments);
        }
    }
}
