﻿//
// Copyright (c) Microsoft.  All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using Microsoft.WindowsAzure.Common;
using Microsoft.WindowsAzure.Common.Internals;
using Microsoft.WindowsAzure.Management.WebSites;
using Microsoft.WindowsAzure.Management.WebSites.Models;

namespace Microsoft.WindowsAzure
{
    public static class WebSiteManagementDiscoveryExtensions
    {
        public static WebSiteManagementClient CreateWebSiteManagementClient(this CloudClients clients, SubscriptionCloudCredentials credentials)
        {
            return new WebSiteManagementClient(credentials);
        }

        public static WebSiteManagementClient CreateWebSiteManagementClient(this CloudClients clients, SubscriptionCloudCredentials credentials, Uri baseUri)
        {
            return new WebSiteManagementClient(credentials, baseUri);
        }

        public static WebSiteManagementClient CreateWebSiteManagementClient(this CloudClients clients)
        {
            return ConfigurationHelper.CreateFromSettings<WebSiteManagementClient>(WebSiteManagementClient.Create);
        }
    }
}

namespace Microsoft.WindowsAzure.Management.WebSites
{
    public partial class WebSiteManagementClient
    {
        public static WebSiteManagementClient Create(IDictionary<string, object> settings)
        {
            if (settings == null)
            {
                throw new ArgumentNullException("settings");
            }

            SubscriptionCloudCredentials credentials = ConfigurationHelper.GetCredentials<SubscriptionCloudCredentials>(settings);

            Uri baseUri = ConfigurationHelper.GetUri(settings, "BaseUri", false);

            return baseUri != null ?
                new WebSiteManagementClient(credentials, baseUri) :
                new WebSiteManagementClient(credentials);
        }

        /// <summary>
        /// Convert an enum of type ManagedPipelineMode to a string.
        /// This is temp workaround for hydra generation issue with nulable enums with custom values
        /// </summary>
        /// <param name='value'>
        /// The value to convert to a string.
        /// </param>
        /// <returns>
        /// The enum value as a string.
        /// </returns>
        internal static string ManagedPipelineModeToString(ManagedPipelineMode? value)
        {
            if (!value.HasValue)
            {
                return null;
            }

            return ManagedPipelineModeToString(value.GetValueOrDefault());
        }

        public override WebSiteManagementClient WithHandler(DelegatingHandler handler)
        {
            return (WebSiteManagementClient)WithHandler(new WebSiteManagementClient(), handler);
        }
    }
}
