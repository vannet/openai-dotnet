// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using OpenAI;

namespace OpenAI.Assistants
{
    internal partial class InternalRunStepDetailsMessageCreationObject : IJsonModel<InternalRunStepDetailsMessageCreationObject>
    {
        internal InternalRunStepDetailsMessageCreationObject()
        {
        }

        void IJsonModel<InternalRunStepDetailsMessageCreationObject>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalRunStepDetailsMessageCreationObject>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalRunStepDetailsMessageCreationObject)} does not support writing '{format}' format.");
            }
            base.JsonModelWriteCore(writer, options);
            if (_additionalBinaryDataProperties?.ContainsKey("message_creation") != true)
            {
                writer.WritePropertyName("message_creation"u8);
                writer.WriteObjectValue<InternalRunStepDetailsMessageCreationObjectMessageCreation>(_messageCreation, options);
            }
        }

        InternalRunStepDetailsMessageCreationObject IJsonModel<InternalRunStepDetailsMessageCreationObject>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => (InternalRunStepDetailsMessageCreationObject)JsonModelCreateCore(ref reader, options);

        protected override RunStepDetails JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalRunStepDetailsMessageCreationObject>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalRunStepDetailsMessageCreationObject)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInternalRunStepDetailsMessageCreationObject(document.RootElement, options);
        }

        internal static InternalRunStepDetailsMessageCreationObject DeserializeInternalRunStepDetailsMessageCreationObject(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string @type = "message_creation";
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            InternalRunStepDetailsMessageCreationObjectMessageCreation messageCreation = default;
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("type"u8))
                {
                    @type = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("message_creation"u8))
                {
                    messageCreation = InternalRunStepDetailsMessageCreationObjectMessageCreation.DeserializeInternalRunStepDetailsMessageCreationObjectMessageCreation(prop.Value, options);
                    continue;
                }
                if (true)
                {
                    additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
                }
            }
            return new InternalRunStepDetailsMessageCreationObject(@type, additionalBinaryDataProperties, messageCreation);
        }

        BinaryData IPersistableModel<InternalRunStepDetailsMessageCreationObject>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected override BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalRunStepDetailsMessageCreationObject>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InternalRunStepDetailsMessageCreationObject)} does not support writing '{options.Format}' format.");
            }
        }

        InternalRunStepDetailsMessageCreationObject IPersistableModel<InternalRunStepDetailsMessageCreationObject>.Create(BinaryData data, ModelReaderWriterOptions options) => (InternalRunStepDetailsMessageCreationObject)PersistableModelCreateCore(data, options);

        protected override RunStepDetails PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalRunStepDetailsMessageCreationObject>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeInternalRunStepDetailsMessageCreationObject(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InternalRunStepDetailsMessageCreationObject)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InternalRunStepDetailsMessageCreationObject>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        public static implicit operator BinaryContent(InternalRunStepDetailsMessageCreationObject internalRunStepDetailsMessageCreationObject)
        {
            if (internalRunStepDetailsMessageCreationObject == null)
            {
                return null;
            }
            return BinaryContent.Create(internalRunStepDetailsMessageCreationObject, ModelSerializationExtensions.WireOptions);
        }

        public static explicit operator InternalRunStepDetailsMessageCreationObject(ClientResult result)
        {
            using PipelineResponse response = result.GetRawResponse();
            using JsonDocument document = JsonDocument.Parse(response.Content);
            return DeserializeInternalRunStepDetailsMessageCreationObject(document.RootElement, ModelSerializationExtensions.WireOptions);
        }
    }
}
