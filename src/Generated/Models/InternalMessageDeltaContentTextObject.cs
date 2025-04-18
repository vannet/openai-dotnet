// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Assistants
{
    internal partial class InternalMessageDeltaContentTextObject : InternalMessageDeltaContent
    {
        internal InternalMessageDeltaContentTextObject(int index) : base("text")
        {
            Index = index;
        }

        internal InternalMessageDeltaContentTextObject(string @type, IDictionary<string, BinaryData> additionalBinaryDataProperties, int index, InternalMessageDeltaContentTextObjectText text) : base(@type, additionalBinaryDataProperties)
        {
            Index = index;
            Text = text;
        }

        public int Index { get; }

        public InternalMessageDeltaContentTextObjectText Text { get; }
    }
}
