
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Dust
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.User))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.Workspace))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.Context))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.ContextAgenticMessageData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.ContextAgenticMessageDataType), TypeInfoPropertyName = "ContextAgenticMessageDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.AgentConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.AgentConfigurationModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.AgentSkill>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.AgentSkill))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.AgentConfigurationTag>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.AgentConfigurationTag))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.AgentConfigurationTagKind), TypeInfoPropertyName = "AgentConfigurationTagKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.Conversation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.ConversationConversation1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Dust.ConversationConversation1ContentItemItem>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.ConversationConversation1ContentItemItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.ConversationConversation1ContentItemItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.Mention>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.Mention))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.ConversationConversation1ContentItemItemAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.ConversationConversation1ContentItemItemAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.ConversationConversation1ContentItemItemActionGeneratedFile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.ConversationConversation1ContentItemItemActionGeneratedFile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.ConversationConversation1ContentItemItemRawContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.ConversationConversation1ContentItemItemRawContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.Message))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.ModelSelection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.ModelSelectionReasoningEffort), TypeInfoPropertyName = "ModelSelectionReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.ContentFragment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantConversationsCancelRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.OneOf<global::Dust.PatchWAssistantConversationsRequestVariant1, global::Dust.PatchWAssistantConversationsRequestVariant2>), TypeInfoPropertyName = "OneOfPatchWAssistantConversationsRequestVariant1PatchWAssistantConversationsRequestVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PatchWAssistantConversationsRequestVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PatchWAssistantConversationsRequestVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantConversationsMessagesAnswerQuestionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantConversationsMessagesAnswerQuestionRequestAnswer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantConversationsMessagesEditRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.CreateWAssistantConversationsMessagesEditRequestMention>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantConversationsMessagesEditRequestMention))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantConversationsMessagesValidateActionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantConversationsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.ContentFragment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWFilesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantConversationsCancelResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PatchWAssistantConversationsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantConversationsMessagesAnswerQuestionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantConversationsMessagesEditResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWAssistantConversationsMessagesEventsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.GetWAssistantConversationsMessagesEventsResponseEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWAssistantConversationsMessagesEventsResponseEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantConversationsMessagesValidateActionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWFilesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWFilesResponseFile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.ContextAgenticMessageDataType?), TypeInfoPropertyName = "NullableContextAgenticMessageDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.AgentConfigurationTagKind?), TypeInfoPropertyName = "NullableAgentConfigurationTagKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.ModelSelectionReasoningEffort?), TypeInfoPropertyName = "NullableModelSelectionReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.OneOf<global::Dust.PatchWAssistantConversationsRequestVariant1, global::Dust.PatchWAssistantConversationsRequestVariant2>?), TypeInfoPropertyName = "NullableOneOfPatchWAssistantConversationsRequestVariant1PatchWAssistantConversationsRequestVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.AgentSkill>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.AgentConfigurationTag>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::Dust.ConversationConversation1ContentItemItem>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.ConversationConversation1ContentItemItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.Mention>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.ConversationConversation1ContentItemItemAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.ConversationConversation1ContentItemItemActionGeneratedFile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.ConversationConversation1ContentItemItemRawContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.CreateWAssistantConversationsMessagesEditRequestMention>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.ContentFragment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.GetWAssistantConversationsMessagesEventsResponseEvent>))]
    internal sealed partial class ConversationsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ConversationsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ConversationsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ConversationsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::Dust.JsonConverters.OneOfJsonConverter<global::Dust.PatchWAssistantConversationsRequestVariant1, global::Dust.PatchWAssistantConversationsRequestVariant2>());
            options.Converters.Add(new global::Dust.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::Dust.ContextAgenticMessageDataType)

                    || typeToConvert == typeof(global::Dust.ContextAgenticMessageDataType?)

                    || typeToConvert == typeof(global::Dust.AgentConfigurationTagKind)

                    || typeToConvert == typeof(global::Dust.AgentConfigurationTagKind?)

                    || typeToConvert == typeof(global::Dust.ModelSelectionReasoningEffort)

                    || typeToConvert == typeof(global::Dust.ModelSelectionReasoningEffort?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Dust.ContextAgenticMessageDataType))
                {
                    return new global::Dust.JsonConverters.ContextAgenticMessageDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.ContextAgenticMessageDataType?))
                {
                    return new global::Dust.JsonConverters.ContextAgenticMessageDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.AgentConfigurationTagKind))
                {
                    return new global::Dust.JsonConverters.AgentConfigurationTagKindJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.AgentConfigurationTagKind?))
                {
                    return new global::Dust.JsonConverters.AgentConfigurationTagKindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.ModelSelectionReasoningEffort))
                {
                    return new global::Dust.JsonConverters.ModelSelectionReasoningEffortJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.ModelSelectionReasoningEffort?))
                {
                    return new global::Dust.JsonConverters.ModelSelectionReasoningEffortNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new ConversationsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}