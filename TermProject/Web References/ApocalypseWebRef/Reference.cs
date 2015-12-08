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

namespace TermProject.ApocalypseWebRef {
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
    [System.Web.Services.WebServiceBindingAttribute(Name="TP_WebServiceSoap", Namespace="http://tempuri.org/")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(object[]))]
    public partial class TP_WebService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback getDepartmentOperationCompleted;
        
        private System.Threading.SendOrPostCallback getCatalogOperationCompleted;
        
        private System.Threading.SendOrPostCallback getColNamesOperationCompleted;
        
        private System.Threading.SendOrPostCallback addMerchantOperationCompleted;
        
        private System.Threading.SendOrPostCallback PurchaseOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public TP_WebService() {
            this.Url = global::TermProject.Properties.Settings.Default.TermProject_ApocalypseWebRef_TP_WebService;
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
        public event getDepartmentCompletedEventHandler getDepartmentCompleted;
        
        /// <remarks/>
        public event getCatalogCompletedEventHandler getCatalogCompleted;
        
        /// <remarks/>
        public event getColNamesCompletedEventHandler getColNamesCompleted;
        
        /// <remarks/>
        public event addMerchantCompletedEventHandler addMerchantCompleted;
        
        /// <remarks/>
        public event PurchaseCompletedEventHandler PurchaseCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/getDepartment", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet getDepartment() {
            object[] results = this.Invoke("getDepartment", new object[0]);
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void getDepartmentAsync() {
            this.getDepartmentAsync(null);
        }
        
        /// <remarks/>
        public void getDepartmentAsync(object userState) {
            if ((this.getDepartmentOperationCompleted == null)) {
                this.getDepartmentOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetDepartmentOperationCompleted);
            }
            this.InvokeAsync("getDepartment", new object[0], this.getDepartmentOperationCompleted, userState);
        }
        
        private void OngetDepartmentOperationCompleted(object arg) {
            if ((this.getDepartmentCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getDepartmentCompleted(this, new getDepartmentCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/getCatalog", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet getCatalog(int departmentNumber) {
            object[] results = this.Invoke("getCatalog", new object[] {
                        departmentNumber});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void getCatalogAsync(int departmentNumber) {
            this.getCatalogAsync(departmentNumber, null);
        }
        
        /// <remarks/>
        public void getCatalogAsync(int departmentNumber, object userState) {
            if ((this.getCatalogOperationCompleted == null)) {
                this.getCatalogOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetCatalogOperationCompleted);
            }
            this.InvokeAsync("getCatalog", new object[] {
                        departmentNumber}, this.getCatalogOperationCompleted, userState);
        }
        
        private void OngetCatalogOperationCompleted(object arg) {
            if ((this.getCatalogCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getCatalogCompleted(this, new getCatalogCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/getColNames", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public object[] getColNames(System.Data.DataSet ds) {
            object[] results = this.Invoke("getColNames", new object[] {
                        ds});
            return ((object[])(results[0]));
        }
        
        /// <remarks/>
        public void getColNamesAsync(System.Data.DataSet ds) {
            this.getColNamesAsync(ds, null);
        }
        
        /// <remarks/>
        public void getColNamesAsync(System.Data.DataSet ds, object userState) {
            if ((this.getColNamesOperationCompleted == null)) {
                this.getColNamesOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetColNamesOperationCompleted);
            }
            this.InvokeAsync("getColNames", new object[] {
                        ds}, this.getColNamesOperationCompleted, userState);
        }
        
        private void OngetColNamesOperationCompleted(object arg) {
            if ((this.getColNamesCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getColNamesCompleted(this, new getColNamesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/addMerchant", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void addMerchant(Merchant merch) {
            this.Invoke("addMerchant", new object[] {
                        merch});
        }
        
        /// <remarks/>
        public void addMerchantAsync(Merchant merch) {
            this.addMerchantAsync(merch, null);
        }
        
        /// <remarks/>
        public void addMerchantAsync(Merchant merch, object userState) {
            if ((this.addMerchantOperationCompleted == null)) {
                this.addMerchantOperationCompleted = new System.Threading.SendOrPostCallback(this.OnaddMerchantOperationCompleted);
            }
            this.InvokeAsync("addMerchant", new object[] {
                        merch}, this.addMerchantOperationCompleted, userState);
        }
        
        private void OnaddMerchantOperationCompleted(object arg) {
            if ((this.addMerchantCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.addMerchantCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Purchase", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool Purchase(string ProductID, int Quantity, string MerchantID, string APIKey, string[] CustomerCreditInformation) {
            object[] results = this.Invoke("Purchase", new object[] {
                        ProductID,
                        Quantity,
                        MerchantID,
                        APIKey,
                        CustomerCreditInformation});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void PurchaseAsync(string ProductID, int Quantity, string MerchantID, string APIKey, string[] CustomerCreditInformation) {
            this.PurchaseAsync(ProductID, Quantity, MerchantID, APIKey, CustomerCreditInformation, null);
        }
        
        /// <remarks/>
        public void PurchaseAsync(string ProductID, int Quantity, string MerchantID, string APIKey, string[] CustomerCreditInformation, object userState) {
            if ((this.PurchaseOperationCompleted == null)) {
                this.PurchaseOperationCompleted = new System.Threading.SendOrPostCallback(this.OnPurchaseOperationCompleted);
            }
            this.InvokeAsync("Purchase", new object[] {
                        ProductID,
                        Quantity,
                        MerchantID,
                        APIKey,
                        CustomerCreditInformation}, this.PurchaseOperationCompleted, userState);
        }
        
        private void OnPurchaseOperationCompleted(object arg) {
            if ((this.PurchaseCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.PurchaseCompleted(this, new PurchaseCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.79.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Merchant {
        
        private string merchantIDField;
        
        private string storeNameField;
        
        private string firstNameField;
        
        private string lastNameField;
        
        private string storeDescripField;
        
        private string loginIDField;
        
        /// <remarks/>
        public string merchantID {
            get {
                return this.merchantIDField;
            }
            set {
                this.merchantIDField = value;
            }
        }
        
        /// <remarks/>
        public string storeName {
            get {
                return this.storeNameField;
            }
            set {
                this.storeNameField = value;
            }
        }
        
        /// <remarks/>
        public string firstName {
            get {
                return this.firstNameField;
            }
            set {
                this.firstNameField = value;
            }
        }
        
        /// <remarks/>
        public string lastName {
            get {
                return this.lastNameField;
            }
            set {
                this.lastNameField = value;
            }
        }
        
        /// <remarks/>
        public string storeDescrip {
            get {
                return this.storeDescripField;
            }
            set {
                this.storeDescripField = value;
            }
        }
        
        /// <remarks/>
        public string loginID {
            get {
                return this.loginIDField;
            }
            set {
                this.loginIDField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.79.0")]
    public delegate void getDepartmentCompletedEventHandler(object sender, getDepartmentCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.79.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getDepartmentCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getDepartmentCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void getCatalogCompletedEventHandler(object sender, getCatalogCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.79.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getCatalogCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getCatalogCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void getColNamesCompletedEventHandler(object sender, getColNamesCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.79.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getColNamesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getColNamesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public object[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((object[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.79.0")]
    public delegate void addMerchantCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
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
}

#pragma warning restore 1591