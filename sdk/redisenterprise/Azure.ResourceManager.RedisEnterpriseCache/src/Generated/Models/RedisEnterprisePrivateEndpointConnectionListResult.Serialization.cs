// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.RedisEnterpriseCache;

namespace Azure.ResourceManager.RedisEnterpriseCache.Models
{
    internal partial class RedisEnterprisePrivateEndpointConnectionListResult
    {
        internal static RedisEnterprisePrivateEndpointConnectionListResult DeserializeRedisEnterprisePrivateEndpointConnectionListResult(JsonElement element)
        {
            Optional<IReadOnlyList<RedisEnterprisePrivateEndpointConnectionData>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<RedisEnterprisePrivateEndpointConnectionData> array = new List<RedisEnterprisePrivateEndpointConnectionData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RedisEnterprisePrivateEndpointConnectionData.DeserializeRedisEnterprisePrivateEndpointConnectionData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new RedisEnterprisePrivateEndpointConnectionListResult(Optional.ToList(value));
        }
    }
}
