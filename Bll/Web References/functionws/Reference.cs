﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

// 
// 此源代码是由 Microsoft.VSDesigner 4.0.30319.42000 版自动生成。
// 
#pragma warning disable 1591

namespace Bll.functionws {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    using System.Data;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1087.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="FunctionOfServiceSoap", Namespace="http://tempuri.org/")]
    public partial class FunctionOfService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GetMenusOperationCompleted;
        
        private System.Threading.SendOrPostCallback EnableFunctionOperationCompleted;
        
        private System.Threading.SendOrPostCallback EnableFunctionsOperationCompleted;
        
        private System.Threading.SendOrPostCallback CancelFunctionOperationCompleted;
        
        private System.Threading.SendOrPostCallback CancelFunctionsOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetFunctionsOfPositionOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetAwardsOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public FunctionOfService() {
            this.Url = global::Bll.Properties.Settings.Default.Bll_functionws_FunctionOfService;
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
        public event GetMenusCompletedEventHandler GetMenusCompleted;
        
        /// <remarks/>
        public event EnableFunctionCompletedEventHandler EnableFunctionCompleted;
        
        /// <remarks/>
        public event EnableFunctionsCompletedEventHandler EnableFunctionsCompleted;
        
        /// <remarks/>
        public event CancelFunctionCompletedEventHandler CancelFunctionCompleted;
        
        /// <remarks/>
        public event CancelFunctionsCompletedEventHandler CancelFunctionsCompleted;
        
        /// <remarks/>
        public event GetFunctionsOfPositionCompletedEventHandler GetFunctionsOfPositionCompleted;
        
        /// <remarks/>
        public event GetAwardsCompletedEventHandler GetAwardsCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetMenus", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataTable GetMenus() {
            object[] results = this.Invoke("GetMenus", new object[0]);
            return ((System.Data.DataTable)(results[0]));
        }
        
        /// <remarks/>
        public void GetMenusAsync() {
            this.GetMenusAsync(null);
        }
        
        /// <remarks/>
        public void GetMenusAsync(object userState) {
            if ((this.GetMenusOperationCompleted == null)) {
                this.GetMenusOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetMenusOperationCompleted);
            }
            this.InvokeAsync("GetMenus", new object[0], this.GetMenusOperationCompleted, userState);
        }
        
        private void OnGetMenusOperationCompleted(object arg) {
            if ((this.GetMenusCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetMenusCompleted(this, new GetMenusCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/EnableFunction", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void EnableFunction(int positionId, string nodeId) {
            this.Invoke("EnableFunction", new object[] {
                        positionId,
                        nodeId});
        }
        
        /// <remarks/>
        public void EnableFunctionAsync(int positionId, string nodeId) {
            this.EnableFunctionAsync(positionId, nodeId, null);
        }
        
        /// <remarks/>
        public void EnableFunctionAsync(int positionId, string nodeId, object userState) {
            if ((this.EnableFunctionOperationCompleted == null)) {
                this.EnableFunctionOperationCompleted = new System.Threading.SendOrPostCallback(this.OnEnableFunctionOperationCompleted);
            }
            this.InvokeAsync("EnableFunction", new object[] {
                        positionId,
                        nodeId}, this.EnableFunctionOperationCompleted, userState);
        }
        
        private void OnEnableFunctionOperationCompleted(object arg) {
            if ((this.EnableFunctionCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.EnableFunctionCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/EnableFunctions", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void EnableFunctions(int positionId, string nodePrex) {
            this.Invoke("EnableFunctions", new object[] {
                        positionId,
                        nodePrex});
        }
        
        /// <remarks/>
        public void EnableFunctionsAsync(int positionId, string nodePrex) {
            this.EnableFunctionsAsync(positionId, nodePrex, null);
        }
        
        /// <remarks/>
        public void EnableFunctionsAsync(int positionId, string nodePrex, object userState) {
            if ((this.EnableFunctionsOperationCompleted == null)) {
                this.EnableFunctionsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnEnableFunctionsOperationCompleted);
            }
            this.InvokeAsync("EnableFunctions", new object[] {
                        positionId,
                        nodePrex}, this.EnableFunctionsOperationCompleted, userState);
        }
        
        private void OnEnableFunctionsOperationCompleted(object arg) {
            if ((this.EnableFunctionsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.EnableFunctionsCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/CancelFunction", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void CancelFunction(int positionId, string nodeId) {
            this.Invoke("CancelFunction", new object[] {
                        positionId,
                        nodeId});
        }
        
        /// <remarks/>
        public void CancelFunctionAsync(int positionId, string nodeId) {
            this.CancelFunctionAsync(positionId, nodeId, null);
        }
        
        /// <remarks/>
        public void CancelFunctionAsync(int positionId, string nodeId, object userState) {
            if ((this.CancelFunctionOperationCompleted == null)) {
                this.CancelFunctionOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCancelFunctionOperationCompleted);
            }
            this.InvokeAsync("CancelFunction", new object[] {
                        positionId,
                        nodeId}, this.CancelFunctionOperationCompleted, userState);
        }
        
        private void OnCancelFunctionOperationCompleted(object arg) {
            if ((this.CancelFunctionCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CancelFunctionCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/CancelFunctions", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void CancelFunctions(int positionId, string nodePrex) {
            this.Invoke("CancelFunctions", new object[] {
                        positionId,
                        nodePrex});
        }
        
        /// <remarks/>
        public void CancelFunctionsAsync(int positionId, string nodePrex) {
            this.CancelFunctionsAsync(positionId, nodePrex, null);
        }
        
        /// <remarks/>
        public void CancelFunctionsAsync(int positionId, string nodePrex, object userState) {
            if ((this.CancelFunctionsOperationCompleted == null)) {
                this.CancelFunctionsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCancelFunctionsOperationCompleted);
            }
            this.InvokeAsync("CancelFunctions", new object[] {
                        positionId,
                        nodePrex}, this.CancelFunctionsOperationCompleted, userState);
        }
        
        private void OnCancelFunctionsOperationCompleted(object arg) {
            if ((this.CancelFunctionsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CancelFunctionsCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetFunctionsOfPosition", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string[] GetFunctionsOfPosition(int positionId) {
            object[] results = this.Invoke("GetFunctionsOfPosition", new object[] {
                        positionId});
            return ((string[])(results[0]));
        }
        
        /// <remarks/>
        public void GetFunctionsOfPositionAsync(int positionId) {
            this.GetFunctionsOfPositionAsync(positionId, null);
        }
        
        /// <remarks/>
        public void GetFunctionsOfPositionAsync(int positionId, object userState) {
            if ((this.GetFunctionsOfPositionOperationCompleted == null)) {
                this.GetFunctionsOfPositionOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetFunctionsOfPositionOperationCompleted);
            }
            this.InvokeAsync("GetFunctionsOfPosition", new object[] {
                        positionId}, this.GetFunctionsOfPositionOperationCompleted, userState);
        }
        
        private void OnGetFunctionsOfPositionOperationCompleted(object arg) {
            if ((this.GetFunctionsOfPositionCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetFunctionsOfPositionCompleted(this, new GetFunctionsOfPositionCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetAwards", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataTable GetAwards() {
            object[] results = this.Invoke("GetAwards", new object[0]);
            return ((System.Data.DataTable)(results[0]));
        }
        
        /// <remarks/>
        public void GetAwardsAsync() {
            this.GetAwardsAsync(null);
        }
        
        /// <remarks/>
        public void GetAwardsAsync(object userState) {
            if ((this.GetAwardsOperationCompleted == null)) {
                this.GetAwardsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetAwardsOperationCompleted);
            }
            this.InvokeAsync("GetAwards", new object[0], this.GetAwardsOperationCompleted, userState);
        }
        
        private void OnGetAwardsOperationCompleted(object arg) {
            if ((this.GetAwardsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetAwardsCompleted(this, new GetAwardsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1087.0")]
    public delegate void GetMenusCompletedEventHandler(object sender, GetMenusCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1087.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetMenusCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetMenusCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataTable Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataTable)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1087.0")]
    public delegate void EnableFunctionCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1087.0")]
    public delegate void EnableFunctionsCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1087.0")]
    public delegate void CancelFunctionCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1087.0")]
    public delegate void CancelFunctionsCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1087.0")]
    public delegate void GetFunctionsOfPositionCompletedEventHandler(object sender, GetFunctionsOfPositionCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1087.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetFunctionsOfPositionCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetFunctionsOfPositionCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1087.0")]
    public delegate void GetAwardsCompletedEventHandler(object sender, GetAwardsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1087.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetAwardsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetAwardsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataTable Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataTable)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591