// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Security
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// InformationProtectionPoliciesOperations operations.
    /// </summary>
    public partial interface IInformationProtectionPoliciesOperations
    {
        /// <summary>
        /// Details of the information protection policy.
        /// </summary>
        /// <param name='scope'>
        /// Scope of the query, can be subscription
        /// (/subscriptions/0b06d9ea-afe6-4779-bd59-30e5c2d9d13f) or management
        /// group (/providers/Microsoft.Management/managementGroups/mgName).
        /// </param>
        /// <param name='informationProtectionPolicyName'>
        /// Name of the information protection policy. Possible values include:
        /// 'effective', 'custom'
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<InformationProtectionPolicy>> GetWithHttpMessagesAsync(string scope, string informationProtectionPolicyName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Details of the information protection policy.
        /// </summary>
        /// <param name='scope'>
        /// Scope of the query, can be subscription
        /// (/subscriptions/0b06d9ea-afe6-4779-bd59-30e5c2d9d13f) or management
        /// group (/providers/Microsoft.Management/managementGroups/mgName).
        /// </param>
        /// <param name='informationProtectionPolicyName'>
        /// Name of the information protection policy. Possible values include:
        /// 'effective', 'custom'
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<InformationProtectionPolicy>> CreateOrUpdateWithHttpMessagesAsync(string scope, string informationProtectionPolicyName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Information protection policies of a specific management group.
        /// </summary>
        /// <param name='scope'>
        /// Scope of the query, can be subscription
        /// (/subscriptions/0b06d9ea-afe6-4779-bd59-30e5c2d9d13f) or management
        /// group (/providers/Microsoft.Management/managementGroups/mgName).
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<InformationProtectionPolicy>>> ListWithHttpMessagesAsync(string scope, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Information protection policies of a specific management group.
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<InformationProtectionPolicy>>> ListNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
