// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Resources.Models
{
    public partial class ArmDeploymentPropertiesExtended
    {
        internal static ArmDeploymentPropertiesExtended DeserializeArmDeploymentPropertiesExtended(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourcesProvisioningState> provisioningState = default;
            Optional<string> correlationId = default;
            Optional<DateTimeOffset> timestamp = default;
            Optional<TimeSpan> duration = default;
            Optional<BinaryData> outputs = default;
            Optional<IReadOnlyList<ResourceProviderData>> providers = default;
            Optional<IReadOnlyList<ArmDependency>> dependencies = default;
            Optional<ArmDeploymentTemplateLink> templateLink = default;
            Optional<BinaryData> parameters = default;
            Optional<ArmDeploymentParametersLink> parametersLink = default;
            Optional<ArmDeploymentMode> mode = default;
            Optional<DebugSetting> debugSetting = default;
            Optional<ErrorDeploymentExtended> onErrorDeployment = default;
            Optional<string> templateHash = default;
            Optional<IReadOnlyList<SubResource>> outputResources = default;
            Optional<IReadOnlyList<SubResource>> validatedResources = default;
            Optional<ResponseError> error = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    provisioningState = new ResourcesProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("correlationId"u8))
                {
                    correlationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("timestamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    timestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("duration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    duration = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("outputs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    outputs = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("providers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ResourceProviderData> array = new List<ResourceProviderData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(JsonSerializer.Deserialize<ResourceProviderData>(item.GetRawText()));
                    }
                    providers = array;
                    continue;
                }
                if (property.NameEquals("dependencies"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ArmDependency> array = new List<ArmDependency>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ArmDependency.DeserializeArmDependency(item));
                    }
                    dependencies = array;
                    continue;
                }
                if (property.NameEquals("templateLink"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    templateLink = ArmDeploymentTemplateLink.DeserializeArmDeploymentTemplateLink(property.Value);
                    continue;
                }
                if (property.NameEquals("parameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    parameters = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("parametersLink"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    parametersLink = ArmDeploymentParametersLink.DeserializeArmDeploymentParametersLink(property.Value);
                    continue;
                }
                if (property.NameEquals("mode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    mode = property.Value.GetString().ToArmDeploymentMode();
                    continue;
                }
                if (property.NameEquals("debugSetting"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    debugSetting = DebugSetting.DeserializeDebugSetting(property.Value);
                    continue;
                }
                if (property.NameEquals("onErrorDeployment"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    onErrorDeployment = ErrorDeploymentExtended.DeserializeErrorDeploymentExtended(property.Value);
                    continue;
                }
                if (property.NameEquals("templateHash"u8))
                {
                    templateHash = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("outputResources"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<SubResource> array = new List<SubResource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(JsonSerializer.Deserialize<SubResource>(item.GetRawText()));
                    }
                    outputResources = array;
                    continue;
                }
                if (property.NameEquals("validatedResources"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<SubResource> array = new List<SubResource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(JsonSerializer.Deserialize<SubResource>(item.GetRawText()));
                    }
                    validatedResources = array;
                    continue;
                }
                if (property.NameEquals("error"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    error = JsonSerializer.Deserialize<ResponseError>(property.Value.GetRawText());
                    continue;
                }
            }
            return new ArmDeploymentPropertiesExtended(Optional.ToNullable(provisioningState), correlationId.Value, Optional.ToNullable(timestamp), Optional.ToNullable(duration), outputs.Value, Optional.ToList(providers), Optional.ToList(dependencies), templateLink.Value, parameters.Value, parametersLink.Value, Optional.ToNullable(mode), debugSetting.Value, onErrorDeployment.Value, templateHash.Value, Optional.ToList(outputResources), Optional.ToList(validatedResources), error.Value);
        }
    }
}
