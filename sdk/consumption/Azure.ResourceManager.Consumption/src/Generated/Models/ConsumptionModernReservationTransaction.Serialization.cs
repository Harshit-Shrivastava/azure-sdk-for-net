// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Consumption.Models
{
    public partial class ConsumptionModernReservationTransaction
    {
        internal static ConsumptionModernReservationTransaction DeserializeConsumptionModernReservationTransaction(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<string>> tags = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<decimal> amount = default;
            Optional<string> armSkuName = default;
            Optional<string> billingFrequency = default;
            Optional<ResourceIdentifier> billingProfileId = default;
            Optional<string> billingProfileName = default;
            Optional<string> currency = default;
            Optional<string> description = default;
            Optional<DateTimeOffset> eventDate = default;
            Optional<string> eventType = default;
            Optional<string> invoice = default;
            Optional<ResourceIdentifier> invoiceId = default;
            Optional<ResourceIdentifier> invoiceSectionId = default;
            Optional<string> invoiceSectionName = default;
            Optional<Guid> purchasingSubscriptionGuid = default;
            Optional<string> purchasingSubscriptionName = default;
            Optional<decimal> quantity = default;
            Optional<string> region = default;
            Optional<string> reservationOrderId = default;
            Optional<string> reservationOrderName = default;
            Optional<string> term = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    tags = array;
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
                        if (property0.NameEquals("amount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            amount = property0.Value.GetDecimal();
                            continue;
                        }
                        if (property0.NameEquals("armSkuName"u8))
                        {
                            armSkuName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("billingFrequency"u8))
                        {
                            billingFrequency = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("billingProfileId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            billingProfileId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("billingProfileName"u8))
                        {
                            billingProfileName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("currency"u8))
                        {
                            currency = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("eventDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            eventDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("eventType"u8))
                        {
                            eventType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("invoice"u8))
                        {
                            invoice = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("invoiceId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            invoiceId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("invoiceSectionId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            invoiceSectionId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("invoiceSectionName"u8))
                        {
                            invoiceSectionName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("purchasingSubscriptionGuid"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            purchasingSubscriptionGuid = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("purchasingSubscriptionName"u8))
                        {
                            purchasingSubscriptionName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("quantity"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            quantity = property0.Value.GetDecimal();
                            continue;
                        }
                        if (property0.NameEquals("region"u8))
                        {
                            region = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("reservationOrderId"u8))
                        {
                            reservationOrderId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("reservationOrderName"u8))
                        {
                            reservationOrderName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("term"u8))
                        {
                            term = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ConsumptionModernReservationTransaction(id, name, type, systemData.Value, Optional.ToNullable(amount), armSkuName.Value, billingFrequency.Value, billingProfileId.Value, billingProfileName.Value, currency.Value, description.Value, Optional.ToNullable(eventDate), eventType.Value, invoice.Value, invoiceId.Value, invoiceSectionId.Value, invoiceSectionName.Value, Optional.ToNullable(purchasingSubscriptionGuid), purchasingSubscriptionName.Value, Optional.ToNullable(quantity), region.Value, reservationOrderId.Value, reservationOrderName.Value, term.Value, Optional.ToList(tags));
        }
    }
}
