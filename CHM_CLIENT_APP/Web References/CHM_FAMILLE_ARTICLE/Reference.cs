﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// Ce code source a été automatiquement généré par Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace CHM_CLIENT_APP.CHM_FAMILLE_ARTICLE {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    using System.Data;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="CHM_FAMILLE_ARTICLESoap", Namespace="http://192.168.1.213:10001/")]
    public partial class CHM_FAMILLE_ARTICLE : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback ConnectionOperationCompleted;
        
        private System.Threading.SendOrPostCallback closeOperationCompleted;
        
        private System.Threading.SendOrPostCallback getDateSOperationCompleted;
        
        private System.Threading.SendOrPostCallback getListeFamilleArticleOperationCompleted;
        
        private System.Threading.SendOrPostCallback getNewRefFAMILLEOperationCompleted;
        
        private System.Threading.SendOrPostCallback loadFamilleArticleOperationCompleted;
        
        private System.Threading.SendOrPostCallback insertFAMILLEOperationCompleted;
        
        private System.Threading.SendOrPostCallback updateFamilleOperationCompleted;
        
        private System.Threading.SendOrPostCallback deleteFamilleOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public CHM_FAMILLE_ARTICLE() {
            this.Url = global::CHM_CLIENT_APP.Properties.Settings.Default.CHM_CLIENT_APP_CHM_FAMILLE_ARTICLE_CHM_FAMILLE_ARTICLE;
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
        public event ConnectionCompletedEventHandler ConnectionCompleted;
        
        /// <remarks/>
        public event closeCompletedEventHandler closeCompleted;
        
        /// <remarks/>
        public event getDateSCompletedEventHandler getDateSCompleted;
        
        /// <remarks/>
        public event getListeFamilleArticleCompletedEventHandler getListeFamilleArticleCompleted;
        
        /// <remarks/>
        public event getNewRefFAMILLECompletedEventHandler getNewRefFAMILLECompleted;
        
        /// <remarks/>
        public event loadFamilleArticleCompletedEventHandler loadFamilleArticleCompleted;
        
        /// <remarks/>
        public event insertFAMILLECompletedEventHandler insertFAMILLECompleted;
        
        /// <remarks/>
        public event updateFamilleCompletedEventHandler updateFamilleCompleted;
        
        /// <remarks/>
        public event deleteFamilleCompletedEventHandler deleteFamilleCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://192.168.1.213:10001/Connection", RequestNamespace="http://192.168.1.213:10001/", ResponseNamespace="http://192.168.1.213:10001/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void Connection() {
            this.Invoke("Connection", new object[0]);
        }
        
        /// <remarks/>
        public void ConnectionAsync() {
            this.ConnectionAsync(null);
        }
        
        /// <remarks/>
        public void ConnectionAsync(object userState) {
            if ((this.ConnectionOperationCompleted == null)) {
                this.ConnectionOperationCompleted = new System.Threading.SendOrPostCallback(this.OnConnectionOperationCompleted);
            }
            this.InvokeAsync("Connection", new object[0], this.ConnectionOperationCompleted, userState);
        }
        
        private void OnConnectionOperationCompleted(object arg) {
            if ((this.ConnectionCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ConnectionCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://192.168.1.213:10001/close", RequestNamespace="http://192.168.1.213:10001/", ResponseNamespace="http://192.168.1.213:10001/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void close() {
            this.Invoke("close", new object[0]);
        }
        
        /// <remarks/>
        public void closeAsync() {
            this.closeAsync(null);
        }
        
        /// <remarks/>
        public void closeAsync(object userState) {
            if ((this.closeOperationCompleted == null)) {
                this.closeOperationCompleted = new System.Threading.SendOrPostCallback(this.OncloseOperationCompleted);
            }
            this.InvokeAsync("close", new object[0], this.closeOperationCompleted, userState);
        }
        
        private void OncloseOperationCompleted(object arg) {
            if ((this.closeCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.closeCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://192.168.1.213:10001/getDateS", RequestNamespace="http://192.168.1.213:10001/", ResponseNamespace="http://192.168.1.213:10001/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.DateTime getDateS() {
            object[] results = this.Invoke("getDateS", new object[0]);
            return ((System.DateTime)(results[0]));
        }
        
        /// <remarks/>
        public void getDateSAsync() {
            this.getDateSAsync(null);
        }
        
        /// <remarks/>
        public void getDateSAsync(object userState) {
            if ((this.getDateSOperationCompleted == null)) {
                this.getDateSOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetDateSOperationCompleted);
            }
            this.InvokeAsync("getDateS", new object[0], this.getDateSOperationCompleted, userState);
        }
        
        private void OngetDateSOperationCompleted(object arg) {
            if ((this.getDateSCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getDateSCompleted(this, new getDateSCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://192.168.1.213:10001/getListeFamilleArticle", RequestNamespace="http://192.168.1.213:10001/", ResponseNamespace="http://192.168.1.213:10001/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataTable getListeFamilleArticle() {
            object[] results = this.Invoke("getListeFamilleArticle", new object[0]);
            return ((System.Data.DataTable)(results[0]));
        }
        
        /// <remarks/>
        public void getListeFamilleArticleAsync() {
            this.getListeFamilleArticleAsync(null);
        }
        
        /// <remarks/>
        public void getListeFamilleArticleAsync(object userState) {
            if ((this.getListeFamilleArticleOperationCompleted == null)) {
                this.getListeFamilleArticleOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetListeFamilleArticleOperationCompleted);
            }
            this.InvokeAsync("getListeFamilleArticle", new object[0], this.getListeFamilleArticleOperationCompleted, userState);
        }
        
        private void OngetListeFamilleArticleOperationCompleted(object arg) {
            if ((this.getListeFamilleArticleCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getListeFamilleArticleCompleted(this, new getListeFamilleArticleCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://192.168.1.213:10001/getNewRefFAMILLE", RequestNamespace="http://192.168.1.213:10001/", ResponseNamespace="http://192.168.1.213:10001/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public RESULT_QUERY getNewRefFAMILLE() {
            object[] results = this.Invoke("getNewRefFAMILLE", new object[0]);
            return ((RESULT_QUERY)(results[0]));
        }
        
        /// <remarks/>
        public void getNewRefFAMILLEAsync() {
            this.getNewRefFAMILLEAsync(null);
        }
        
        /// <remarks/>
        public void getNewRefFAMILLEAsync(object userState) {
            if ((this.getNewRefFAMILLEOperationCompleted == null)) {
                this.getNewRefFAMILLEOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetNewRefFAMILLEOperationCompleted);
            }
            this.InvokeAsync("getNewRefFAMILLE", new object[0], this.getNewRefFAMILLEOperationCompleted, userState);
        }
        
        private void OngetNewRefFAMILLEOperationCompleted(object arg) {
            if ((this.getNewRefFAMILLECompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getNewRefFAMILLECompleted(this, new getNewRefFAMILLECompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://192.168.1.213:10001/loadFamilleArticle", RequestNamespace="http://192.168.1.213:10001/", ResponseNamespace="http://192.168.1.213:10001/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataTable loadFamilleArticle(decimal CODE_FAMILLE) {
            object[] results = this.Invoke("loadFamilleArticle", new object[] {
                        CODE_FAMILLE});
            return ((System.Data.DataTable)(results[0]));
        }
        
        /// <remarks/>
        public void loadFamilleArticleAsync(decimal CODE_FAMILLE) {
            this.loadFamilleArticleAsync(CODE_FAMILLE, null);
        }
        
        /// <remarks/>
        public void loadFamilleArticleAsync(decimal CODE_FAMILLE, object userState) {
            if ((this.loadFamilleArticleOperationCompleted == null)) {
                this.loadFamilleArticleOperationCompleted = new System.Threading.SendOrPostCallback(this.OnloadFamilleArticleOperationCompleted);
            }
            this.InvokeAsync("loadFamilleArticle", new object[] {
                        CODE_FAMILLE}, this.loadFamilleArticleOperationCompleted, userState);
        }
        
        private void OnloadFamilleArticleOperationCompleted(object arg) {
            if ((this.loadFamilleArticleCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.loadFamilleArticleCompleted(this, new loadFamilleArticleCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://192.168.1.213:10001/insertFAMILLE", RequestNamespace="http://192.168.1.213:10001/", ResponseNamespace="http://192.168.1.213:10001/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public RESULT_QUERY insertFAMILLE(string REF_FAMILLE, string DESIGNATION_FAMILLE, string DESCRIPTION_FAMILLE, decimal PARENT, string TYPE) {
            object[] results = this.Invoke("insertFAMILLE", new object[] {
                        REF_FAMILLE,
                        DESIGNATION_FAMILLE,
                        DESCRIPTION_FAMILLE,
                        PARENT,
                        TYPE});
            return ((RESULT_QUERY)(results[0]));
        }
        
        /// <remarks/>
        public void insertFAMILLEAsync(string REF_FAMILLE, string DESIGNATION_FAMILLE, string DESCRIPTION_FAMILLE, decimal PARENT, string TYPE) {
            this.insertFAMILLEAsync(REF_FAMILLE, DESIGNATION_FAMILLE, DESCRIPTION_FAMILLE, PARENT, TYPE, null);
        }
        
        /// <remarks/>
        public void insertFAMILLEAsync(string REF_FAMILLE, string DESIGNATION_FAMILLE, string DESCRIPTION_FAMILLE, decimal PARENT, string TYPE, object userState) {
            if ((this.insertFAMILLEOperationCompleted == null)) {
                this.insertFAMILLEOperationCompleted = new System.Threading.SendOrPostCallback(this.OninsertFAMILLEOperationCompleted);
            }
            this.InvokeAsync("insertFAMILLE", new object[] {
                        REF_FAMILLE,
                        DESIGNATION_FAMILLE,
                        DESCRIPTION_FAMILLE,
                        PARENT,
                        TYPE}, this.insertFAMILLEOperationCompleted, userState);
        }
        
        private void OninsertFAMILLEOperationCompleted(object arg) {
            if ((this.insertFAMILLECompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.insertFAMILLECompleted(this, new insertFAMILLECompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://192.168.1.213:10001/updateFamille", RequestNamespace="http://192.168.1.213:10001/", ResponseNamespace="http://192.168.1.213:10001/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public RESULT_QUERY updateFamille(decimal CODE_FAMILLE, string REF_FAMILLE, string DESIGNATION_FAMILLE, string DESCRIPTION_FAMILLE, decimal PARENT) {
            object[] results = this.Invoke("updateFamille", new object[] {
                        CODE_FAMILLE,
                        REF_FAMILLE,
                        DESIGNATION_FAMILLE,
                        DESCRIPTION_FAMILLE,
                        PARENT});
            return ((RESULT_QUERY)(results[0]));
        }
        
        /// <remarks/>
        public void updateFamilleAsync(decimal CODE_FAMILLE, string REF_FAMILLE, string DESIGNATION_FAMILLE, string DESCRIPTION_FAMILLE, decimal PARENT) {
            this.updateFamilleAsync(CODE_FAMILLE, REF_FAMILLE, DESIGNATION_FAMILLE, DESCRIPTION_FAMILLE, PARENT, null);
        }
        
        /// <remarks/>
        public void updateFamilleAsync(decimal CODE_FAMILLE, string REF_FAMILLE, string DESIGNATION_FAMILLE, string DESCRIPTION_FAMILLE, decimal PARENT, object userState) {
            if ((this.updateFamilleOperationCompleted == null)) {
                this.updateFamilleOperationCompleted = new System.Threading.SendOrPostCallback(this.OnupdateFamilleOperationCompleted);
            }
            this.InvokeAsync("updateFamille", new object[] {
                        CODE_FAMILLE,
                        REF_FAMILLE,
                        DESIGNATION_FAMILLE,
                        DESCRIPTION_FAMILLE,
                        PARENT}, this.updateFamilleOperationCompleted, userState);
        }
        
        private void OnupdateFamilleOperationCompleted(object arg) {
            if ((this.updateFamilleCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.updateFamilleCompleted(this, new updateFamilleCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://192.168.1.213:10001/deleteFamille", RequestNamespace="http://192.168.1.213:10001/", ResponseNamespace="http://192.168.1.213:10001/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public RESULT_QUERY deleteFamille(decimal CODE_FAMILLE) {
            object[] results = this.Invoke("deleteFamille", new object[] {
                        CODE_FAMILLE});
            return ((RESULT_QUERY)(results[0]));
        }
        
        /// <remarks/>
        public void deleteFamilleAsync(decimal CODE_FAMILLE) {
            this.deleteFamilleAsync(CODE_FAMILLE, null);
        }
        
        /// <remarks/>
        public void deleteFamilleAsync(decimal CODE_FAMILLE, object userState) {
            if ((this.deleteFamilleOperationCompleted == null)) {
                this.deleteFamilleOperationCompleted = new System.Threading.SendOrPostCallback(this.OndeleteFamilleOperationCompleted);
            }
            this.InvokeAsync("deleteFamille", new object[] {
                        CODE_FAMILLE}, this.deleteFamilleOperationCompleted, userState);
        }
        
        private void OndeleteFamilleOperationCompleted(object arg) {
            if ((this.deleteFamilleCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.deleteFamilleCompleted(this, new deleteFamilleCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://192.168.1.213:10001/")]
    public partial class RESULT_QUERY {
        
        private string cODEField;
        
        private bool okField;
        
        private string mESSAGEField;
        
        /// <remarks/>
        public string CODE {
            get {
                return this.cODEField;
            }
            set {
                this.cODEField = value;
            }
        }
        
        /// <remarks/>
        public bool OK {
            get {
                return this.okField;
            }
            set {
                this.okField = value;
            }
        }
        
        /// <remarks/>
        public string MESSAGE {
            get {
                return this.mESSAGEField;
            }
            set {
                this.mESSAGEField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void ConnectionCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void closeCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void getDateSCompletedEventHandler(object sender, getDateSCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getDateSCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getDateSCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.DateTime Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.DateTime)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void getListeFamilleArticleCompletedEventHandler(object sender, getListeFamilleArticleCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getListeFamilleArticleCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getListeFamilleArticleCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void getNewRefFAMILLECompletedEventHandler(object sender, getNewRefFAMILLECompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getNewRefFAMILLECompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getNewRefFAMILLECompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public RESULT_QUERY Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((RESULT_QUERY)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void loadFamilleArticleCompletedEventHandler(object sender, loadFamilleArticleCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class loadFamilleArticleCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal loadFamilleArticleCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void insertFAMILLECompletedEventHandler(object sender, insertFAMILLECompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class insertFAMILLECompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal insertFAMILLECompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public RESULT_QUERY Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((RESULT_QUERY)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void updateFamilleCompletedEventHandler(object sender, updateFamilleCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class updateFamilleCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal updateFamilleCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public RESULT_QUERY Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((RESULT_QUERY)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void deleteFamilleCompletedEventHandler(object sender, deleteFamilleCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class deleteFamilleCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal deleteFamilleCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public RESULT_QUERY Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((RESULT_QUERY)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591