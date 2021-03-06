﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.19462
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.19462.
// 
#pragma warning disable 1591

namespace PlasmaShared.ModStats {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.19462")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="StatsCollectorSoap", Namespace="http://planet-wars.eu/ModStats")]
    public partial class StatsCollector : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback SubmitGameOperationCompleted;
        
        private System.Threading.SendOrPostCallback SubmitGameExOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public StatsCollector() {
            this.Url = global::PlasmaShared.Properties.Settings.Default.PlasmaShared_ModStats_StatsCollector;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event SubmitGameCompletedEventHandler SubmitGameCompleted;
        
        /// <remarks/>
        public event SubmitGameExCompletedEventHandler SubmitGameExCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://planet-wars.eu/ModStats/SubmitGame", RequestNamespace="http://planet-wars.eu/ModStats", ResponseNamespace="http://planet-wars.eu/ModStats", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void SubmitGame(string gameIDString, string mod, string[] data) {
            this.Invoke("SubmitGame", new object[] {
                        gameIDString,
                        mod,
                        data});
        }
        
        /// <remarks/>
        public void SubmitGameAsync(string gameIDString, string mod, string[] data) {
            this.SubmitGameAsync(gameIDString, mod, data, null);
        }
        
        /// <remarks/>
        public void SubmitGameAsync(string gameIDString, string mod, string[] data, object userState) {
            if ((this.SubmitGameOperationCompleted == null)) {
                this.SubmitGameOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSubmitGameOperationCompleted);
            }
            this.InvokeAsync("SubmitGame", new object[] {
                        gameIDString,
                        mod,
                        data}, this.SubmitGameOperationCompleted, userState);
        }
        
        private void OnSubmitGameOperationCompleted(object arg) {
            if ((this.SubmitGameCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SubmitGameCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://planet-wars.eu/ModStats/SubmitGameEx", RequestNamespace="http://planet-wars.eu/ModStats", ResponseNamespace="http://planet-wars.eu/ModStats", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void SubmitGameEx(string gameIDString, string mod, string map, string[] data) {
            this.Invoke("SubmitGameEx", new object[] {
                        gameIDString,
                        mod,
                        map,
                        data});
        }
        
        /// <remarks/>
        public void SubmitGameExAsync(string gameIDString, string mod, string map, string[] data) {
            this.SubmitGameExAsync(gameIDString, mod, map, data, null);
        }
        
        /// <remarks/>
        public void SubmitGameExAsync(string gameIDString, string mod, string map, string[] data, object userState) {
            if ((this.SubmitGameExOperationCompleted == null)) {
                this.SubmitGameExOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSubmitGameExOperationCompleted);
            }
            this.InvokeAsync("SubmitGameEx", new object[] {
                        gameIDString,
                        mod,
                        map,
                        data}, this.SubmitGameExOperationCompleted, userState);
        }
        
        private void OnSubmitGameExOperationCompleted(object arg) {
            if ((this.SubmitGameExCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SubmitGameExCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.19462")]
    public delegate void SubmitGameCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.19462")]
    public delegate void SubmitGameExCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
}

#pragma warning restore 1591