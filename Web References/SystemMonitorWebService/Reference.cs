﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// Этот исходный текст был создан автоматически: Microsoft.VSDesigner, версия: 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace SystemActivityMonitor.SystemMonitorWebService {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="SystemMonitorServiceSoap", Namespace="https://localhost:44390/SystemMonitorService.asmx")]
    public partial class SystemMonitorService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GetMemoryPerformanceOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetCpuPerformanceOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetOpenWindowsOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetMostOpenWindowsOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public SystemMonitorService() {
            this.Url = global::SystemActivityMonitor.Properties.Settings.Default.SystemActivityMonitor_SystemMonitorWebService_SystemMonitorService;
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
        public event GetMemoryPerformanceCompletedEventHandler GetMemoryPerformanceCompleted;
        
        /// <remarks/>
        public event GetCpuPerformanceCompletedEventHandler GetCpuPerformanceCompleted;
        
        /// <remarks/>
        public event GetOpenWindowsCompletedEventHandler GetOpenWindowsCompleted;
        
        /// <remarks/>
        public event GetMostOpenWindowsCompletedEventHandler GetMostOpenWindowsCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("https://localhost:44390/SystemMonitorService.asmx/GetMemoryPerformance", RequestNamespace="https://localhost:44390/SystemMonitorService.asmx", ResponseNamespace="https://localhost:44390/SystemMonitorService.asmx", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Performance[] GetMemoryPerformance() {
            object[] results = this.Invoke("GetMemoryPerformance", new object[0]);
            return ((Performance[])(results[0]));
        }
        
        /// <remarks/>
        public void GetMemoryPerformanceAsync() {
            this.GetMemoryPerformanceAsync(null);
        }
        
        /// <remarks/>
        public void GetMemoryPerformanceAsync(object userState) {
            if ((this.GetMemoryPerformanceOperationCompleted == null)) {
                this.GetMemoryPerformanceOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetMemoryPerformanceOperationCompleted);
            }
            this.InvokeAsync("GetMemoryPerformance", new object[0], this.GetMemoryPerformanceOperationCompleted, userState);
        }
        
        private void OnGetMemoryPerformanceOperationCompleted(object arg) {
            if ((this.GetMemoryPerformanceCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetMemoryPerformanceCompleted(this, new GetMemoryPerformanceCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("https://localhost:44390/SystemMonitorService.asmx/GetCpuPerformance", RequestNamespace="https://localhost:44390/SystemMonitorService.asmx", ResponseNamespace="https://localhost:44390/SystemMonitorService.asmx", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Performance[] GetCpuPerformance() {
            object[] results = this.Invoke("GetCpuPerformance", new object[0]);
            return ((Performance[])(results[0]));
        }
        
        /// <remarks/>
        public void GetCpuPerformanceAsync() {
            this.GetCpuPerformanceAsync(null);
        }
        
        /// <remarks/>
        public void GetCpuPerformanceAsync(object userState) {
            if ((this.GetCpuPerformanceOperationCompleted == null)) {
                this.GetCpuPerformanceOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetCpuPerformanceOperationCompleted);
            }
            this.InvokeAsync("GetCpuPerformance", new object[0], this.GetCpuPerformanceOperationCompleted, userState);
        }
        
        private void OnGetCpuPerformanceOperationCompleted(object arg) {
            if ((this.GetCpuPerformanceCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetCpuPerformanceCompleted(this, new GetCpuPerformanceCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("https://localhost:44390/SystemMonitorService.asmx/GetOpenWindows", RequestNamespace="https://localhost:44390/SystemMonitorService.asmx", ResponseNamespace="https://localhost:44390/SystemMonitorService.asmx", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public WindowInfo[] GetOpenWindows() {
            object[] results = this.Invoke("GetOpenWindows", new object[0]);
            return ((WindowInfo[])(results[0]));
        }
        
        /// <remarks/>
        public void GetOpenWindowsAsync() {
            this.GetOpenWindowsAsync(null);
        }
        
        /// <remarks/>
        public void GetOpenWindowsAsync(object userState) {
            if ((this.GetOpenWindowsOperationCompleted == null)) {
                this.GetOpenWindowsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetOpenWindowsOperationCompleted);
            }
            this.InvokeAsync("GetOpenWindows", new object[0], this.GetOpenWindowsOperationCompleted, userState);
        }
        
        private void OnGetOpenWindowsOperationCompleted(object arg) {
            if ((this.GetOpenWindowsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetOpenWindowsCompleted(this, new GetOpenWindowsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("https://localhost:44390/SystemMonitorService.asmx/GetMostOpenWindows", RequestNamespace="https://localhost:44390/SystemMonitorService.asmx", ResponseNamespace="https://localhost:44390/SystemMonitorService.asmx", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public StatisticsModel[] GetMostOpenWindows(int n, string startDate, string stopDate) {
            object[] results = this.Invoke("GetMostOpenWindows", new object[] {
                        n,
                        startDate,
                        stopDate});
            return ((StatisticsModel[])(results[0]));
        }
        
        /// <remarks/>
        public void GetMostOpenWindowsAsync(int n, string startDate, string stopDate) {
            this.GetMostOpenWindowsAsync(n, startDate, stopDate, null);
        }
        
        /// <remarks/>
        public void GetMostOpenWindowsAsync(int n, string startDate, string stopDate, object userState) {
            if ((this.GetMostOpenWindowsOperationCompleted == null)) {
                this.GetMostOpenWindowsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetMostOpenWindowsOperationCompleted);
            }
            this.InvokeAsync("GetMostOpenWindows", new object[] {
                        n,
                        startDate,
                        stopDate}, this.GetMostOpenWindowsOperationCompleted, userState);
        }
        
        private void OnGetMostOpenWindowsOperationCompleted(object arg) {
            if ((this.GetMostOpenWindowsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetMostOpenWindowsCompleted(this, new GetMostOpenWindowsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://localhost:44390/SystemMonitorService.asmx")]
    public partial class Performance {
        
        private System.DateTime timeField;
        
        private float valueField;
        
        /// <remarks/>
        public System.DateTime Time {
            get {
                return this.timeField;
            }
            set {
                this.timeField = value;
            }
        }
        
        /// <remarks/>
        public float Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://localhost:44390/SystemMonitorService.asmx")]
    public partial class StatisticsModel {
        
        private int amountField;
        
        private string titleField;
        
        /// <remarks/>
        public int Amount {
            get {
                return this.amountField;
            }
            set {
                this.amountField = value;
            }
        }
        
        /// <remarks/>
        public string Title {
            get {
                return this.titleField;
            }
            set {
                this.titleField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://localhost:44390/SystemMonitorService.asmx")]
    public partial class WindowInfo {
        
        private int idField;
        
        private string titleField;
        
        private string dateField;
        
        /// <remarks/>
        public int ID {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        public string Title {
            get {
                return this.titleField;
            }
            set {
                this.titleField = value;
            }
        }
        
        /// <remarks/>
        public string Date {
            get {
                return this.dateField;
            }
            set {
                this.dateField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void GetMemoryPerformanceCompletedEventHandler(object sender, GetMemoryPerformanceCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetMemoryPerformanceCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetMemoryPerformanceCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Performance[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Performance[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void GetCpuPerformanceCompletedEventHandler(object sender, GetCpuPerformanceCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetCpuPerformanceCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetCpuPerformanceCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Performance[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Performance[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void GetOpenWindowsCompletedEventHandler(object sender, GetOpenWindowsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetOpenWindowsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetOpenWindowsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public WindowInfo[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((WindowInfo[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void GetMostOpenWindowsCompletedEventHandler(object sender, GetMostOpenWindowsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetMostOpenWindowsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetMostOpenWindowsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public StatisticsModel[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((StatisticsModel[])(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591