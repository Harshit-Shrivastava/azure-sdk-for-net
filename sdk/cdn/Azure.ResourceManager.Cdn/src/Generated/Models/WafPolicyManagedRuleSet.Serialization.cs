// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class WafPolicyManagedRuleSet : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("ruleSetType"u8);
            writer.WriteStringValue(RuleSetType);
            writer.WritePropertyName("ruleSetVersion"u8);
            writer.WriteStringValue(RuleSetVersion);
            if (Optional.IsDefined(AnomalyScore))
            {
                writer.WritePropertyName("anomalyScore"u8);
                writer.WriteNumberValue(AnomalyScore.Value);
            }
            if (Optional.IsCollectionDefined(RuleGroupOverrides))
            {
                writer.WritePropertyName("ruleGroupOverrides"u8);
                writer.WriteStartArray();
                foreach (var item in RuleGroupOverrides)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static WafPolicyManagedRuleSet DeserializeWafPolicyManagedRuleSet(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string ruleSetType = default;
            string ruleSetVersion = default;
            Optional<int> anomalyScore = default;
            Optional<IList<ManagedRuleGroupOverrideSetting>> ruleGroupOverrides = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ruleSetType"u8))
                {
                    ruleSetType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ruleSetVersion"u8))
                {
                    ruleSetVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("anomalyScore"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    anomalyScore = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("ruleGroupOverrides"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ManagedRuleGroupOverrideSetting> array = new List<ManagedRuleGroupOverrideSetting>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ManagedRuleGroupOverrideSetting.DeserializeManagedRuleGroupOverrideSetting(item));
                    }
                    ruleGroupOverrides = array;
                    continue;
                }
            }
            return new WafPolicyManagedRuleSet(ruleSetType, ruleSetVersion, Optional.ToNullable(anomalyScore), Optional.ToList(ruleGroupOverrides));
        }
    }
}
