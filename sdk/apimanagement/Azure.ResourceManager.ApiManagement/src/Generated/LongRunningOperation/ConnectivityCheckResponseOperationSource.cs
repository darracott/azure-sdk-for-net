// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager.ApiManagement.Models;

namespace Azure.ResourceManager.ApiManagement
{
    internal class ConnectivityCheckResponseOperationSource : IOperationSource<ConnectivityCheckResponse>
    {
        ConnectivityCheckResponse IOperationSource<ConnectivityCheckResponse>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return ConnectivityCheckResponse.DeserializeConnectivityCheckResponse(document.RootElement);
        }

        async ValueTask<ConnectivityCheckResponse> IOperationSource<ConnectivityCheckResponse>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return ConnectivityCheckResponse.DeserializeConnectivityCheckResponse(document.RootElement);
        }
    }
}
