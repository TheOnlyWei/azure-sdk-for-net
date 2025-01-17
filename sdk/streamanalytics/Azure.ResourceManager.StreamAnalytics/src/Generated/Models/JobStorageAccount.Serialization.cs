// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    public partial class JobStorageAccount : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(AccountName))
            {
                writer.WritePropertyName("accountName");
                writer.WriteStringValue(AccountName);
            }
            if (Optional.IsDefined(AccountKey))
            {
                writer.WritePropertyName("accountKey");
                writer.WriteStringValue(AccountKey);
            }
            if (Optional.IsDefined(AuthenticationMode))
            {
                writer.WritePropertyName("authenticationMode");
                writer.WriteStringValue(AuthenticationMode.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static JobStorageAccount DeserializeJobStorageAccount(JsonElement element)
        {
            Optional<string> accountName = default;
            Optional<string> accountKey = default;
            Optional<AuthenticationMode> authenticationMode = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("accountName"))
                {
                    accountName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("accountKey"))
                {
                    accountKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("authenticationMode"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    authenticationMode = new AuthenticationMode(property.Value.GetString());
                    continue;
                }
            }
            return new JobStorageAccount(accountName.Value, accountKey.Value, Optional.ToNullable(authenticationMode));
        }
    }
}
