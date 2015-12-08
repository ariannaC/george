﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace TermProject.JungleServiceRef {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    using System.Data;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.79.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="MerchantStoreSoap", Namespace="http://tempuri.org/")]
    public partial class MerchantStore : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback PurchaseOperationCompleted;
        
        private System.Threading.SendOrPostCallback RegisterSiteOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetDepartmentsOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetProductCatalogOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public MerchantStore() {
            this.Url = global::TermProject.Properties.Settings.Default.TermProject_JungleServiceRef_MerchantStore;
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
        public event PurchaseCompletedEventHandler PurchaseCompleted;
        
        /// <remarks/>
        public event RegisterSiteCompletedEventHandler RegisterSiteCompleted;
        
        /// <remarks/>
        public event GetDepartmentsCompletedEventHandler GetDepartmentsCompleted;
        
        /// <remarks/>
        public event GetProductCatalogCompletedEventHandler GetProductCatalogCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Purchase", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool Purchase(string ProductNumber, int Quantity, string SiteID, string APIKey, string[] CustomerInfo) {
            object[] results = this.Invoke("Purchase", new object[] {
                        ProductNumber,
                        Quantity,
                        SiteID,
                        APIKey,
                        CustomerInfo});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void PurchaseAsync(string ProductNumber, int Quantity, string SiteID, string APIKey, string[] CustomerInfo) {
            this.PurchaseAsync(ProductNumber, Quantity, SiteID, APIKey, CustomerInfo, null);
        }
        
        /// <remarks/>
        public void PurchaseAsync(string ProductNumber, int Quantity, string SiteID, string APIKey, string[] CustomerInfo, object userState) {
            if ((this.PurchaseOperationCompleted == null)) {
                this.PurchaseOperationCompleted = new System.Threading.SendOrPostCallback(this.OnPurchaseOperationCompleted);
            }
            this.InvokeAsync("Purchase", new object[] {
                        ProductNumber,
                        Quantity,
                        SiteID,
                        APIKey,
                        CustomerInfo}, this.PurchaseOperationCompleted, userState);
        }
        
        private void OnPurchaseOperationCompleted(object arg) {
            if ((this.PurchaseCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.PurchaseCompleted(this, new PurchaseCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/RegisterSite", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool RegisterSite(string SiteID, string Description, string APIKey, string email) {
            object[] results = this.Invoke("RegisterSite", new object[] {
                        SiteID,
                        Description,
                        APIKey,
                        email});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void RegisterSiteAsync(string SiteID, string Description, string APIKey, string email) {
            this.RegisterSiteAsync(SiteID, Description, APIKey, email, null);
        }
        
        /// <remarks/>
        public void RegisterSiteAsync(string SiteID, string Description, string APIKey, string email, object userState) {
            if ((this.RegisterSiteOperationCompleted == null)) {
                this.RegisterSiteOperationCompleted = new System.Threading.SendOrPostCallback(this.OnRegisterSiteOperationCompleted);
            }
            this.InvokeAsync("RegisterSite", new object[] {
                        SiteID,
                        Description,
                        APIKey,
                        email}, this.RegisterSiteOperationCompleted, userState);
        }
        
        private void OnRegisterSiteOperationCompleted(object arg) {
            if ((this.RegisterSiteCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.RegisterSiteCompleted(this, new RegisterSiteCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetDepartments", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet GetDepartments() {
            object[] results = this.Invoke("GetDepartments", new object[0]);
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void GetDepartmentsAsync() {
            this.GetDepartmentsAsync(null);
        }
        
        /// <remarks/>
        public void GetDepartmentsAsync(object userState) {
            if ((this.GetDepartmentsOperationCompleted == null)) {
                this.GetDepartmentsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetDepartmentsOperationCompleted);
            }
            this.InvokeAsync("GetDepartments", new object[0], this.GetDepartmentsOperationCompleted, userState);
        }
        
        private void OnGetDepartmentsOperationCompleted(object arg) {
            if ((this.GetDepartmentsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetDepartmentsCompleted(this, new GetDepartmentsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetProductCatalog", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet GetProductCatalog(string DepartmentNumber) {
            object[] results = this.Invoke("GetProductCatalog", new object[] {
                        DepartmentNumber});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void GetProductCatalogAsync(string DepartmentNumber) {
            this.GetProductCatalogAsync(DepartmentNumber, null);
        }
        
        /// <remarks/>
        public void GetProductCatalogAsync(string DepartmentNumber, object userState) {
            if ((this.GetProductCatalogOperationCompleted == null)) {
                this.GetProductCatalogOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetProductCatalogOperationCompleted);
            }
            this.InvokeAsync("GetProductCatalog", new object[] {
                        DepartmentNumber}, this.GetProductCatalogOperationCompleted, userState);
        }
        
        private void OnGetProductCatalogOperationCompleted(object arg) {
            if ((this.GetProductCatalogCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetProductCatalogCompleted(this, new GetProductCatalogCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.79.0")]
    public delegate void PurchaseCompletedEventHandler(object sender, PurchaseCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.79.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class PurchaseCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal PurchaseCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.79.0")]
    public delegate void RegisterSiteCompletedEventHandler(object sender, RegisterSiteCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.79.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class RegisterSiteCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal RegisterSiteCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.79.0")]
    public delegate void GetDepartmentsCompletedEventHandler(object sender, GetDepartmentsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.79.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetDepartmentsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetDepartmentsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.79.0")]
    public delegate void GetProductCatalogCompletedEventHandler(object sender, GetProductCatalogCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.79.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetProductCatalogCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetProductCatalogCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591