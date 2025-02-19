// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Cdn.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Cdn
{
    public partial class CdnWebApplicationFirewallPolicyData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            writer.WritePropertyName("sku"u8);
            writer.WriteObjectValue(Sku);
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(PolicySettings))
            {
                writer.WritePropertyName("policySettings"u8);
                writer.WriteObjectValue(PolicySettings);
            }
            if (Optional.IsDefined(RateLimitSettings))
            {
                writer.WritePropertyName("rateLimitRules"u8);
                writer.WriteObjectValue(RateLimitSettings);
            }
            if (Optional.IsDefined(CustomSettings))
            {
                writer.WritePropertyName("customRules"u8);
                writer.WriteObjectValue(CustomSettings);
            }
            if (Optional.IsDefined(ManagedRules))
            {
                writer.WritePropertyName("managedRules"u8);
                writer.WriteObjectValue(ManagedRules);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static CdnWebApplicationFirewallPolicyData DeserializeCdnWebApplicationFirewallPolicyData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ETag> etag = default;
            CdnSku sku = default;
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<WafPolicySettings> policySettings = default;
            Optional<RateLimitRuleList> rateLimitRules = default;
            Optional<CustomRuleList> customRules = default;
            Optional<ManagedRuleSetList> managedRules = default;
            Optional<IReadOnlyList<SubResource>> endpointLinks = default;
            Optional<WebApplicationFirewallPolicyProvisioningState> provisioningState = default;
            Optional<PolicyResourceState> resourceState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sku"u8))
                {
                    sku = CdnSku.DeserializeCdnSku(property.Value);
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("policySettings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            policySettings = WafPolicySettings.DeserializeWafPolicySettings(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("rateLimitRules"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            rateLimitRules = RateLimitRuleList.DeserializeRateLimitRuleList(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("customRules"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            customRules = CustomRuleList.DeserializeCustomRuleList(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("managedRules"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            managedRules = ManagedRuleSetList.DeserializeManagedRuleSetList(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("endpointLinks"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<SubResource> array = new List<SubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(JsonSerializer.Deserialize<SubResource>(item.GetRawText()));
                            }
                            endpointLinks = array;
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = new WebApplicationFirewallPolicyProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("resourceState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            resourceState = new PolicyResourceState(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new CdnWebApplicationFirewallPolicyData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, Optional.ToNullable(etag), sku, policySettings.Value, rateLimitRules.Value, customRules.Value, managedRules.Value, Optional.ToList(endpointLinks), Optional.ToNullable(provisioningState), Optional.ToNullable(resourceState));
        }
    }
}
