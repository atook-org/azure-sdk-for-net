// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The set of changes to be made to a user account on a node.
    /// </summary>
    public partial class NodeUpdateUserParameter
    {
        /// <summary>
        /// Initializes a new instance of the NodeUpdateUserParameter class.
        /// </summary>
        public NodeUpdateUserParameter()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NodeUpdateUserParameter class.
        /// </summary>
        /// <param name="password">The password of the account.</param>
        /// <param name="expiryTime">The time at which the account should
        /// expire.</param>
        /// <param name="sshPublicKey">The SSH public key that can be used for
        /// remote login to the compute node.</param>
        public NodeUpdateUserParameter(string password = default(string), System.DateTime? expiryTime = default(System.DateTime?), string sshPublicKey = default(string))
        {
            Password = password;
            ExpiryTime = expiryTime;
            SshPublicKey = sshPublicKey;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the password of the account.
        /// </summary>
        /// <remarks>
        /// The password is required for Windows nodes (those created with
        /// 'cloudServiceConfiguration', or created with
        /// 'virtualMachineConfiguration' using a Windows image reference). For
        /// Linux compute nodes, the password can optionally be specified along
        /// with the sshPublicKey property. If omitted, any existing password
        /// is removed.
        /// </remarks>
        [JsonProperty(PropertyName = "password")]
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets the time at which the account should expire.
        /// </summary>
        /// <remarks>
        /// If omitted, the default is 1 day from the current time. For Linux
        /// compute nodes, the expiryTime has a precision up to a day.
        /// </remarks>
        [JsonProperty(PropertyName = "expiryTime")]
        public System.DateTime? ExpiryTime { get; set; }

        /// <summary>
        /// Gets or sets the SSH public key that can be used for remote login
        /// to the compute node.
        /// </summary>
        /// <remarks>
        /// The public key should be compatible with OpenSSH encoding and
        /// should be base 64 encoded. This property can be specified only for
        /// Linux nodes. If this is specified for a Windows node, then the
        /// Batch service rejects the request; if you are calling the REST API
        /// directly, the HTTP status code is 400 (Bad Request). If omitted,
        /// any existing SSH public key is removed.
        /// </remarks>
        [JsonProperty(PropertyName = "sshPublicKey")]
        public string SshPublicKey { get; set; }

    }
}