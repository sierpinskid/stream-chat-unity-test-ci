﻿using System;

namespace StreamChat.Core.Exceptions
{
    /// <summary>
    /// Thrown when deserialization fails
    /// </summary>
    public class StreamDeserializationException : Exception
    {
        public string Content { get; }
        public Type TargetType { get; }

        public StreamDeserializationException(string content, Type targetType, Exception innerException)
            : base($"Failed to deserialize string to type: `{targetType.Name}`", innerException)
        {
            TargetType = targetType;
            Content = content;
        }
        
        public override string ToString()
        {
            var innerExceptionMessage = InnerException != null ? InnerException.ToString() : string.Empty;
            return $"Failed to deserialize string to type: `{TargetType.Name}`\nContent: {Content}\nInnerException: {innerExceptionMessage}";
        }
    }
}