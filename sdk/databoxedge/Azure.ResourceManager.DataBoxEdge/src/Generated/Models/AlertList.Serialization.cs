// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DataBoxEdge;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    internal partial class AlertList
    {
        internal static AlertList DeserializeAlertList(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<DataBoxEdgeAlertData>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<DataBoxEdgeAlertData> array = new List<DataBoxEdgeAlertData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataBoxEdgeAlertData.DeserializeDataBoxEdgeAlertData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new AlertList(Optional.ToList(value), nextLink.Value);
        }
    }
}
