// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using OpenAI;

namespace OpenAI.RealtimeConversation
{
    public partial class ConversationItemStreamingAudioTranscriptionFinishedUpdate : IJsonModel<ConversationItemStreamingAudioTranscriptionFinishedUpdate>
    {
        internal ConversationItemStreamingAudioTranscriptionFinishedUpdate()
        {
        }

        void IJsonModel<ConversationItemStreamingAudioTranscriptionFinishedUpdate>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<ConversationItemStreamingAudioTranscriptionFinishedUpdate>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConversationItemStreamingAudioTranscriptionFinishedUpdate)} does not support writing '{format}' format.");
            }
            base.JsonModelWriteCore(writer, options);
            if (_additionalBinaryDataProperties?.ContainsKey("response_id") != true)
            {
                writer.WritePropertyName("response_id"u8);
                writer.WriteStringValue(ResponseId);
            }
            if (_additionalBinaryDataProperties?.ContainsKey("item_id") != true)
            {
                writer.WritePropertyName("item_id"u8);
                writer.WriteStringValue(ItemId);
            }
            if (_additionalBinaryDataProperties?.ContainsKey("output_index") != true)
            {
                writer.WritePropertyName("output_index"u8);
                writer.WriteNumberValue(OutputIndex);
            }
            if (_additionalBinaryDataProperties?.ContainsKey("content_index") != true)
            {
                writer.WritePropertyName("content_index"u8);
                writer.WriteNumberValue(ContentIndex);
            }
            if (_additionalBinaryDataProperties?.ContainsKey("transcript") != true)
            {
                writer.WritePropertyName("transcript"u8);
                writer.WriteStringValue(Transcript);
            }
        }

        ConversationItemStreamingAudioTranscriptionFinishedUpdate IJsonModel<ConversationItemStreamingAudioTranscriptionFinishedUpdate>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => (ConversationItemStreamingAudioTranscriptionFinishedUpdate)JsonModelCreateCore(ref reader, options);

        protected override ConversationUpdate JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<ConversationItemStreamingAudioTranscriptionFinishedUpdate>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConversationItemStreamingAudioTranscriptionFinishedUpdate)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeConversationItemStreamingAudioTranscriptionFinishedUpdate(document.RootElement, options);
        }

        internal static ConversationItemStreamingAudioTranscriptionFinishedUpdate DeserializeConversationItemStreamingAudioTranscriptionFinishedUpdate(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string eventId = default;
            RealtimeConversation.ConversationUpdateKind kind = default;
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            string responseId = default;
            string itemId = default;
            int outputIndex = default;
            int contentIndex = default;
            string transcript = default;
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("event_id"u8))
                {
                    eventId = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("type"u8))
                {
                    kind = prop.Value.GetString().ToConversationUpdateKind();
                    continue;
                }
                if (prop.NameEquals("response_id"u8))
                {
                    responseId = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("item_id"u8))
                {
                    itemId = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("output_index"u8))
                {
                    outputIndex = prop.Value.GetInt32();
                    continue;
                }
                if (prop.NameEquals("content_index"u8))
                {
                    contentIndex = prop.Value.GetInt32();
                    continue;
                }
                if (prop.NameEquals("transcript"u8))
                {
                    transcript = prop.Value.GetString();
                    continue;
                }
                if (true)
                {
                    additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
                }
            }
            return new ConversationItemStreamingAudioTranscriptionFinishedUpdate(
                eventId,
                kind,
                additionalBinaryDataProperties,
                responseId,
                itemId,
                outputIndex,
                contentIndex,
                transcript);
        }

        BinaryData IPersistableModel<ConversationItemStreamingAudioTranscriptionFinishedUpdate>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected override BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<ConversationItemStreamingAudioTranscriptionFinishedUpdate>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ConversationItemStreamingAudioTranscriptionFinishedUpdate)} does not support writing '{options.Format}' format.");
            }
        }

        ConversationItemStreamingAudioTranscriptionFinishedUpdate IPersistableModel<ConversationItemStreamingAudioTranscriptionFinishedUpdate>.Create(BinaryData data, ModelReaderWriterOptions options) => (ConversationItemStreamingAudioTranscriptionFinishedUpdate)PersistableModelCreateCore(data, options);

        protected override ConversationUpdate PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<ConversationItemStreamingAudioTranscriptionFinishedUpdate>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeConversationItemStreamingAudioTranscriptionFinishedUpdate(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ConversationItemStreamingAudioTranscriptionFinishedUpdate)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ConversationItemStreamingAudioTranscriptionFinishedUpdate>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        public static implicit operator BinaryContent(ConversationItemStreamingAudioTranscriptionFinishedUpdate conversationItemStreamingAudioTranscriptionFinishedUpdate)
        {
            if (conversationItemStreamingAudioTranscriptionFinishedUpdate == null)
            {
                return null;
            }
            return BinaryContent.Create(conversationItemStreamingAudioTranscriptionFinishedUpdate, ModelSerializationExtensions.WireOptions);
        }

        public static explicit operator ConversationItemStreamingAudioTranscriptionFinishedUpdate(ClientResult result)
        {
            using PipelineResponse response = result.GetRawResponse();
            using JsonDocument document = JsonDocument.Parse(response.Content);
            return DeserializeConversationItemStreamingAudioTranscriptionFinishedUpdate(document.RootElement, ModelSerializationExtensions.WireOptions);
        }
    }
}
