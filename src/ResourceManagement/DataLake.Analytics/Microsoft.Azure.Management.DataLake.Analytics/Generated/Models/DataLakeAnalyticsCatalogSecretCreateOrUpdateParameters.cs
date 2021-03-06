// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataLake.Analytics.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// DataLakeAnalytics DataLakeAnalyticsAccount information.
    /// </summary>
    public partial class DataLakeAnalyticsCatalogSecretCreateOrUpdateParameters
    {
        /// <summary>
        /// Initializes a new instance of the
        /// DataLakeAnalyticsCatalogSecretCreateOrUpdateParameters class.
        /// </summary>
        public DataLakeAnalyticsCatalogSecretCreateOrUpdateParameters() { }

        /// <summary>
        /// Initializes a new instance of the
        /// DataLakeAnalyticsCatalogSecretCreateOrUpdateParameters class.
        /// </summary>
        /// <param name="password">the password for the secret to pass
        /// in</param>
        /// <param name="uri">the URI identifier for the secret in the format
        /// <hostname>:<port></param>
        public DataLakeAnalyticsCatalogSecretCreateOrUpdateParameters(string password, string uri = default(string))
        {
            Password = password;
            Uri = uri;
        }

        /// <summary>
        /// Gets or sets the password for the secret to pass in
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets the URI identifier for the secret in the format
        /// &lt;hostname&gt;:&lt;port&gt;
        /// </summary>
        [JsonProperty(PropertyName = "uri")]
        public string Uri { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Password == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Password");
            }
        }
    }
}
