// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MobileNetwork.Models
{
    public partial class HttpsServerCertificate : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("certificateUrl"u8);
            writer.WriteStringValue(CertificateUri.AbsoluteUri);
            writer.WriteEndObject();
        }

        internal static HttpsServerCertificate DeserializeHttpsServerCertificate(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Uri certificateUrl = default;
            Optional<CertificateProvisioning> provisioning = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("certificateUrl"u8))
                {
                    certificateUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("provisioning"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    provisioning = CertificateProvisioning.DeserializeCertificateProvisioning(property.Value);
                    continue;
                }
            }
            return new HttpsServerCertificate(certificateUrl, provisioning.Value);
        }
    }
}
