// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class NetworkConfigurationDiagnosticProfile : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("direction");
            writer.WriteStringValue(Direction.ToString());
            writer.WritePropertyName("protocol");
            writer.WriteStringValue(Protocol);
            writer.WritePropertyName("source");
            writer.WriteStringValue(Source);
            writer.WritePropertyName("destination");
            writer.WriteStringValue(Destination);
            writer.WritePropertyName("destinationPort");
            writer.WriteStringValue(DestinationPort);
            writer.WriteEndObject();
        }

        internal static NetworkConfigurationDiagnosticProfile DeserializeNetworkConfigurationDiagnosticProfile(JsonElement element)
        {
            Direction direction = default;
            string protocol = default;
            string source = default;
            string destination = default;
            string destinationPort = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("direction"))
                {
                    direction = new Direction(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("protocol"))
                {
                    protocol = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("source"))
                {
                    source = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("destination"))
                {
                    destination = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("destinationPort"))
                {
                    destinationPort = property.Value.GetString();
                    continue;
                }
            }
            return new NetworkConfigurationDiagnosticProfile(direction, protocol, source, destination, destinationPort);
        }
    }
}