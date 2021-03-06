// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Management.WebSites.Models;

namespace Microsoft.WindowsAzure.Management.WebSites.Models
{
    /// <summary>
    /// The Get Configuration Web Site operation response.
    /// </summary>
    public partial class WebSiteGetConfigurationResponse : OperationResponse
    {
        private bool? _alwaysOn;
        
        /// <summary>
        /// Optional. Indicates if site's Always On feature is enabled.
        /// </summary>
        public bool? AlwaysOn
        {
            get { return this._alwaysOn; }
            set { this._alwaysOn = value; }
        }
        
        private IDictionary<string, string> _appSettings;
        
        /// <summary>
        /// Optional. A set of name/value pairs that contain application
        /// settings for a web site.
        /// </summary>
        public IDictionary<string, string> AppSettings
        {
            get { return this._appSettings; }
            set { this._appSettings = value; }
        }
        
        private IList<WebSiteGetConfigurationResponse.ConnectionStringInfo> _connectionStrings;
        
        /// <summary>
        /// Optional. The connection strings for database and other external
        /// resources.
        /// </summary>
        public IList<WebSiteGetConfigurationResponse.ConnectionStringInfo> ConnectionStrings
        {
            get { return this._connectionStrings; }
            set { this._connectionStrings = value; }
        }
        
        private IList<string> _defaultDocuments;
        
        /// <summary>
        /// Optional. One or more string elements that list, in order of
        /// preference, the name of the file that a web site returns when the
        /// web site's domain name is requested by itself. For example, if the
        /// default document for http://contoso.com is default.htm, the page
        /// http://www.contoso.com/default.htm is returned when the browser is
        /// pointed to http://www.contoso.com.
        /// </summary>
        public IList<string> DefaultDocuments
        {
            get { return this._defaultDocuments; }
            set { this._defaultDocuments = value; }
        }
        
        private bool? _detailedErrorLoggingEnabled;
        
        /// <summary>
        /// Optional. Indicates if detailed error logging is enabled.
        /// </summary>
        public bool? DetailedErrorLoggingEnabled
        {
            get { return this._detailedErrorLoggingEnabled; }
            set { this._detailedErrorLoggingEnabled = value; }
        }
        
        private string _documentRoot;
        
        /// <summary>
        /// Optional. The document root.
        /// </summary>
        public string DocumentRoot
        {
            get { return this._documentRoot; }
            set { this._documentRoot = value; }
        }
        
        private IList<WebSiteGetConfigurationResponse.HandlerMapping> _handlerMappings;
        
        /// <summary>
        /// Optional. Specifies custom executable programs for handling
        /// requests for specific file name extensions.
        /// </summary>
        public IList<WebSiteGetConfigurationResponse.HandlerMapping> HandlerMappings
        {
            get { return this._handlerMappings; }
            set { this._handlerMappings = value; }
        }
        
        private bool? _httpLoggingEnabled;
        
        /// <summary>
        /// Optional. Indicates if HTTP error logging is enabled.
        /// </summary>
        public bool? HttpLoggingEnabled
        {
            get { return this._httpLoggingEnabled; }
            set { this._httpLoggingEnabled = value; }
        }
        
        private int? _logsDirectorySizeLimit;
        
        /// <summary>
        /// Optional. The size limit of the logs directory.
        /// </summary>
        public int? LogsDirectorySizeLimit
        {
            get { return this._logsDirectorySizeLimit; }
            set { this._logsDirectorySizeLimit = value; }
        }
        
        private Microsoft.WindowsAzure.Management.WebSites.Models.ManagedPipelineMode? _managedPipelineMode;
        
        /// <summary>
        /// Optional. The managed pipeline mode.
        /// </summary>
        public Microsoft.WindowsAzure.Management.WebSites.Models.ManagedPipelineMode? ManagedPipelineMode
        {
            get { return this._managedPipelineMode; }
            set { this._managedPipelineMode = value; }
        }
        
        private IDictionary<string, string> _metadata;
        
        /// <summary>
        /// Optional. Name/value pairs for source control or other information.
        /// </summary>
        public IDictionary<string, string> Metadata
        {
            get { return this._metadata; }
            set { this._metadata = value; }
        }
        
        private string _netFrameworkVersion;
        
        /// <summary>
        /// Optional. The .NET Framework version. Supported values are v2.0 and
        /// v4.0.
        /// </summary>
        public string NetFrameworkVersion
        {
            get { return this._netFrameworkVersion; }
            set { this._netFrameworkVersion = value; }
        }
        
        private int? _numberOfWorkers;
        
        /// <summary>
        /// Optional. The number of web workers allotted to the web site. If
        /// the web site mode is Free, this value is 1. If the web site mode
        /// is Shared, this value can range from 1 through 6. If the web site
        /// mode is Standard, this value can range from 1 through 10.
        /// </summary>
        public int? NumberOfWorkers
        {
            get { return this._numberOfWorkers; }
            set { this._numberOfWorkers = value; }
        }
        
        private string _phpVersion;
        
        /// <summary>
        /// Optional. The web site PHP version. Supported values are an empty
        /// string (an empty string disables PHP), 5.3, and 5.4.
        /// </summary>
        public string PhpVersion
        {
            get { return this._phpVersion; }
            set { this._phpVersion = value; }
        }
        
        private string _publishingPassword;
        
        /// <summary>
        /// Optional. Hash value of the password used for publishing the web
        /// site.
        /// </summary>
        public string PublishingPassword
        {
            get { return this._publishingPassword; }
            set { this._publishingPassword = value; }
        }
        
        private string _publishingUserName;
        
        /// <summary>
        /// Optional. The user name used for publishing the web site. This is
        /// normally a dollar sign prepended to the web site name (for
        /// example, "$contoso").
        /// </summary>
        public string PublishingUserName
        {
            get { return this._publishingUserName; }
            set { this._publishingUserName = value; }
        }
        
        private bool? _remoteDebuggingEnabled;
        
        /// <summary>
        /// Optional. Indicates if remote debugging is enabled.
        /// </summary>
        public bool? RemoteDebuggingEnabled
        {
            get { return this._remoteDebuggingEnabled; }
            set { this._remoteDebuggingEnabled = value; }
        }
        
        private Microsoft.WindowsAzure.Management.WebSites.Models.RemoteDebuggingVersion? _remoteDebuggingVersion;
        
        /// <summary>
        /// Optional. The remote debugging version.
        /// </summary>
        public Microsoft.WindowsAzure.Management.WebSites.Models.RemoteDebuggingVersion? RemoteDebuggingVersion
        {
            get { return this._remoteDebuggingVersion; }
            set { this._remoteDebuggingVersion = value; }
        }
        
        private bool? _requestTracingEnabled;
        
        /// <summary>
        /// Optional. Indicates if request tracing is enabled.
        /// </summary>
        public bool? RequestTracingEnabled
        {
            get { return this._requestTracingEnabled; }
            set { this._requestTracingEnabled = value; }
        }
        
        private System.DateTime? _requestTracingExpirationTime;
        
        /// <summary>
        /// Optional. Time remaining until request tracing expires.
        /// </summary>
        public System.DateTime? RequestTracingExpirationTime
        {
            get { return this._requestTracingExpirationTime; }
            set { this._requestTracingExpirationTime = value; }
        }
        
        private IList<RoutingRule> _routingRules;
        
        /// <summary>
        /// Optional. List of routing rules for the website.
        /// </summary>
        public IList<RoutingRule> RoutingRules
        {
            get { return this._routingRules; }
            set { this._routingRules = value; }
        }
        
        private string _scmType;
        
        /// <summary>
        /// Optional. The source control method that the web site is using (for
        /// example, Local Git). If deployment from source control has not
        /// been set up for the web site, this value is None.
        /// </summary>
        public string ScmType
        {
            get { return this._scmType; }
            set { this._scmType = value; }
        }
        
        private bool? _use32BitWorkerProcess;
        
        /// <summary>
        /// Optional. Indicates if 32-bit mode is enabled.
        /// </summary>
        public bool? Use32BitWorkerProcess
        {
            get { return this._use32BitWorkerProcess; }
            set { this._use32BitWorkerProcess = value; }
        }
        
        private bool? _webSocketsEnabled;
        
        /// <summary>
        /// Optional. Indicates if Web Sockets are enabled.
        /// </summary>
        public bool? WebSocketsEnabled
        {
            get { return this._webSocketsEnabled; }
            set { this._webSocketsEnabled = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the WebSiteGetConfigurationResponse
        /// class.
        /// </summary>
        public WebSiteGetConfigurationResponse()
        {
            this.AppSettings = new Dictionary<string, string>();
            this.ConnectionStrings = new List<WebSiteGetConfigurationResponse.ConnectionStringInfo>();
            this.DefaultDocuments = new List<string>();
            this.HandlerMappings = new List<WebSiteGetConfigurationResponse.HandlerMapping>();
            this.Metadata = new Dictionary<string, string>();
            this.RoutingRules = new List<RoutingRule>();
        }
        
        /// <summary>
        /// Connection string for database and other external resources.
        /// </summary>
        public partial class ConnectionStringInfo
        {
            private string _connectionString;
            
            /// <summary>
            /// Optional. The database connection string.
            /// </summary>
            public string ConnectionString
            {
                get { return this._connectionString; }
                set { this._connectionString = value; }
            }
            
            private string _name;
            
            /// <summary>
            /// Optional. The name of the connection string.
            /// </summary>
            public string Name
            {
                get { return this._name; }
                set { this._name = value; }
            }
            
            private ConnectionStringType _type;
            
            /// <summary>
            /// Optional. The type of the connection string (for example,
            /// "MySQL").
            /// </summary>
            public ConnectionStringType Type
            {
                get { return this._type; }
                set { this._type = value; }
            }
            
            /// <summary>
            /// Initializes a new instance of the ConnectionStringInfo class.
            /// </summary>
            public ConnectionStringInfo()
            {
            }
        }
        
        /// <summary>
        /// Specifies a custom executable program for handling requests for
        /// specific file name extensions.
        /// </summary>
        public partial class HandlerMapping
        {
            private string _arguments;
            
            /// <summary>
            /// Optional. A string that contains optional arguments for the
            /// script processor specified by the
            /// SiteConfig.HandlerMappings.HandlerMapping.ScriptProcessor
            /// element.
            /// </summary>
            public string Arguments
            {
                get { return this._arguments; }
                set { this._arguments = value; }
            }
            
            private string _extension;
            
            /// <summary>
            /// Optional. A string that specifies the extension of the file
            /// type that the script processor will handle (for example,
            /// *.php).
            /// </summary>
            public string Extension
            {
                get { return this._extension; }
                set { this._extension = value; }
            }
            
            private string _scriptProcessor;
            
            /// <summary>
            /// Optional. The absolute path to the location of the executable
            /// file that will handle the files specified in the
            /// SiteConfig.HandlerMappings.HandlerMapping.Extension element.
            /// </summary>
            public string ScriptProcessor
            {
                get { return this._scriptProcessor; }
                set { this._scriptProcessor = value; }
            }
            
            /// <summary>
            /// Initializes a new instance of the HandlerMapping class.
            /// </summary>
            public HandlerMapping()
            {
            }
        }
    }
}
