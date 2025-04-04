// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;
using OpenAI;

namespace OpenAI.Chat
{
    internal readonly partial struct InternalCreateChatCompletionFunctionResponseChoiceFinishReason : IEquatable<InternalCreateChatCompletionFunctionResponseChoiceFinishReason>
    {
        private readonly string _value;
        private const string StopValue = "stop";
        private const string LengthValue = "length";
        private const string FunctionCallValue = "function_call";
        private const string ContentFilterValue = "content_filter";

        public InternalCreateChatCompletionFunctionResponseChoiceFinishReason(string value)
        {
            Argument.AssertNotNull(value, nameof(value));

            _value = value;
        }

        public static InternalCreateChatCompletionFunctionResponseChoiceFinishReason Stop { get; } = new InternalCreateChatCompletionFunctionResponseChoiceFinishReason(StopValue);

        public static InternalCreateChatCompletionFunctionResponseChoiceFinishReason Length { get; } = new InternalCreateChatCompletionFunctionResponseChoiceFinishReason(LengthValue);

        public static InternalCreateChatCompletionFunctionResponseChoiceFinishReason FunctionCall { get; } = new InternalCreateChatCompletionFunctionResponseChoiceFinishReason(FunctionCallValue);

        public static InternalCreateChatCompletionFunctionResponseChoiceFinishReason ContentFilter { get; } = new InternalCreateChatCompletionFunctionResponseChoiceFinishReason(ContentFilterValue);

        public static bool operator ==(InternalCreateChatCompletionFunctionResponseChoiceFinishReason left, InternalCreateChatCompletionFunctionResponseChoiceFinishReason right) => left.Equals(right);

        public static bool operator !=(InternalCreateChatCompletionFunctionResponseChoiceFinishReason left, InternalCreateChatCompletionFunctionResponseChoiceFinishReason right) => !left.Equals(right);

        public static implicit operator InternalCreateChatCompletionFunctionResponseChoiceFinishReason(string value) => new InternalCreateChatCompletionFunctionResponseChoiceFinishReason(value);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is InternalCreateChatCompletionFunctionResponseChoiceFinishReason other && Equals(other);

        public bool Equals(InternalCreateChatCompletionFunctionResponseChoiceFinishReason other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;

        public override string ToString() => _value;
    }
}
