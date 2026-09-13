
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.AgentConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.AgentConfigurationModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.AgentSkill>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.AgentSkill))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.AgentConfigurationTag>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.AgentConfigurationTag))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.AgentConfigurationTagKind), TypeInfoPropertyName = "AgentConfigurationTagKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PatchWAssistantAgentConfigurationsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PatchWAssistantAgentConfigurationsRequestAgent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PatchWAssistantAgentConfigurationsRequestAgentScope), TypeInfoPropertyName = "PatchWAssistantAgentConfigurationsRequestAgentScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PatchWAssistantAgentConfigurationsRequestGenerationSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.PatchWAssistantAgentConfigurationsRequestTag>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PatchWAssistantAgentConfigurationsRequestTag))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PatchWAssistantAgentConfigurationsRequestTagKind), TypeInfoPropertyName = "PatchWAssistantAgentConfigurationsRequestTagKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.PatchWAssistantAgentConfigurationsRequestSkill>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PatchWAssistantAgentConfigurationsRequestSkill))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.PatchWAssistantAgentConfigurationsRequestToolsetItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PatchWAssistantAgentConfigurationsRequestToolsetItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PatchWAssistantAgentConfigurationsRequestToolsetItemType), TypeInfoPropertyName = "PatchWAssistantAgentConfigurationsRequestToolsetItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PatchWAssistantAgentConfigurationsRequestToolsetItemConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantAgentConfigurationsImportRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantAgentConfigurationsImportRequestAgent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantAgentConfigurationsImportRequestAgentScope), TypeInfoPropertyName = "CreateWAssistantAgentConfigurationsImportRequestAgentScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantAgentConfigurationsImportRequestGenerationSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.CreateWAssistantAgentConfigurationsImportRequestTag>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantAgentConfigurationsImportRequestTag))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantAgentConfigurationsImportRequestTagKind), TypeInfoPropertyName = "CreateWAssistantAgentConfigurationsImportRequestTagKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.CreateWAssistantAgentConfigurationsImportRequestToolsetItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantAgentConfigurationsImportRequestToolsetItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantAgentConfigurationsImportRequestToolsetItemType), TypeInfoPropertyName = "CreateWAssistantAgentConfigurationsImportRequestToolsetItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWAssistantAgentConfigurationsView), TypeInfoPropertyName = "GetWAssistantAgentConfigurationsView2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWAssistantAgentConfigurationsWithAuthors), TypeInfoPropertyName = "GetWAssistantAgentConfigurationsWithAuthors2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWAssistantAgentConfigurationsVariant), TypeInfoPropertyName = "GetWAssistantAgentConfigurationsVariant2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWAssistantAgentConfigurationsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.AgentConfiguration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWAssistantAgentConfigurationsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PatchWAssistantAgentConfigurationsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.PatchWAssistantAgentConfigurationsResponseSkippedAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PatchWAssistantAgentConfigurationsResponseSkippedAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.DeleteWAssistantAgentConfigurationsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantAgentConfigurationsImportResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.CreateWAssistantAgentConfigurationsImportResponseSkippedAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantAgentConfigurationsImportResponseSkippedAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWAssistantAgentConfigurationsSearchResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.AgentConfigurationTagKind?), TypeInfoPropertyName = "NullableAgentConfigurationTagKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PatchWAssistantAgentConfigurationsRequestAgentScope?), TypeInfoPropertyName = "NullablePatchWAssistantAgentConfigurationsRequestAgentScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PatchWAssistantAgentConfigurationsRequestTagKind?), TypeInfoPropertyName = "NullablePatchWAssistantAgentConfigurationsRequestTagKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PatchWAssistantAgentConfigurationsRequestToolsetItemType?), TypeInfoPropertyName = "NullablePatchWAssistantAgentConfigurationsRequestToolsetItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantAgentConfigurationsImportRequestAgentScope?), TypeInfoPropertyName = "NullableCreateWAssistantAgentConfigurationsImportRequestAgentScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantAgentConfigurationsImportRequestTagKind?), TypeInfoPropertyName = "NullableCreateWAssistantAgentConfigurationsImportRequestTagKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantAgentConfigurationsImportRequestToolsetItemType?), TypeInfoPropertyName = "NullableCreateWAssistantAgentConfigurationsImportRequestToolsetItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWAssistantAgentConfigurationsView?), TypeInfoPropertyName = "NullableGetWAssistantAgentConfigurationsView2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWAssistantAgentConfigurationsWithAuthors?), TypeInfoPropertyName = "NullableGetWAssistantAgentConfigurationsWithAuthors2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWAssistantAgentConfigurationsVariant?), TypeInfoPropertyName = "NullableGetWAssistantAgentConfigurationsVariant2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.AgentSkill>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.AgentConfigurationTag>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.PatchWAssistantAgentConfigurationsRequestTag>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.PatchWAssistantAgentConfigurationsRequestSkill>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.PatchWAssistantAgentConfigurationsRequestToolsetItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.CreateWAssistantAgentConfigurationsImportRequestTag>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.CreateWAssistantAgentConfigurationsImportRequestToolsetItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.AgentConfiguration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.PatchWAssistantAgentConfigurationsResponseSkippedAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.CreateWAssistantAgentConfigurationsImportResponseSkippedAction>))]
    internal sealed partial class AgentsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static AgentsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private AgentsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::Dust.AgentConfigurationTagKind)

                    || typeToConvert == typeof(global::Dust.AgentConfigurationTagKind?)

                    || typeToConvert == typeof(global::Dust.PatchWAssistantAgentConfigurationsRequestAgentScope)

                    || typeToConvert == typeof(global::Dust.PatchWAssistantAgentConfigurationsRequestAgentScope?)

                    || typeToConvert == typeof(global::Dust.PatchWAssistantAgentConfigurationsRequestTagKind)

                    || typeToConvert == typeof(global::Dust.PatchWAssistantAgentConfigurationsRequestTagKind?)

                    || typeToConvert == typeof(global::Dust.PatchWAssistantAgentConfigurationsRequestToolsetItemType)

                    || typeToConvert == typeof(global::Dust.PatchWAssistantAgentConfigurationsRequestToolsetItemType?)

                    || typeToConvert == typeof(global::Dust.CreateWAssistantAgentConfigurationsImportRequestAgentScope)

                    || typeToConvert == typeof(global::Dust.CreateWAssistantAgentConfigurationsImportRequestAgentScope?)

                    || typeToConvert == typeof(global::Dust.CreateWAssistantAgentConfigurationsImportRequestTagKind)

                    || typeToConvert == typeof(global::Dust.CreateWAssistantAgentConfigurationsImportRequestTagKind?)

                    || typeToConvert == typeof(global::Dust.CreateWAssistantAgentConfigurationsImportRequestToolsetItemType)

                    || typeToConvert == typeof(global::Dust.CreateWAssistantAgentConfigurationsImportRequestToolsetItemType?)

                    || typeToConvert == typeof(global::Dust.GetWAssistantAgentConfigurationsView)

                    || typeToConvert == typeof(global::Dust.GetWAssistantAgentConfigurationsView?)

                    || typeToConvert == typeof(global::Dust.GetWAssistantAgentConfigurationsWithAuthors)

                    || typeToConvert == typeof(global::Dust.GetWAssistantAgentConfigurationsWithAuthors?)

                    || typeToConvert == typeof(global::Dust.GetWAssistantAgentConfigurationsVariant)

                    || typeToConvert == typeof(global::Dust.GetWAssistantAgentConfigurationsVariant?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Dust.AgentConfigurationTagKind))
                {
                    return new global::Dust.JsonConverters.AgentConfigurationTagKindJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.AgentConfigurationTagKind?))
                {
                    return new global::Dust.JsonConverters.AgentConfigurationTagKindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PatchWAssistantAgentConfigurationsRequestAgentScope))
                {
                    return new global::Dust.JsonConverters.PatchWAssistantAgentConfigurationsRequestAgentScopeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PatchWAssistantAgentConfigurationsRequestAgentScope?))
                {
                    return new global::Dust.JsonConverters.PatchWAssistantAgentConfigurationsRequestAgentScopeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PatchWAssistantAgentConfigurationsRequestTagKind))
                {
                    return new global::Dust.JsonConverters.PatchWAssistantAgentConfigurationsRequestTagKindJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PatchWAssistantAgentConfigurationsRequestTagKind?))
                {
                    return new global::Dust.JsonConverters.PatchWAssistantAgentConfigurationsRequestTagKindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PatchWAssistantAgentConfigurationsRequestToolsetItemType))
                {
                    return new global::Dust.JsonConverters.PatchWAssistantAgentConfigurationsRequestToolsetItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PatchWAssistantAgentConfigurationsRequestToolsetItemType?))
                {
                    return new global::Dust.JsonConverters.PatchWAssistantAgentConfigurationsRequestToolsetItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.CreateWAssistantAgentConfigurationsImportRequestAgentScope))
                {
                    return new global::Dust.JsonConverters.CreateWAssistantAgentConfigurationsImportRequestAgentScopeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.CreateWAssistantAgentConfigurationsImportRequestAgentScope?))
                {
                    return new global::Dust.JsonConverters.CreateWAssistantAgentConfigurationsImportRequestAgentScopeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.CreateWAssistantAgentConfigurationsImportRequestTagKind))
                {
                    return new global::Dust.JsonConverters.CreateWAssistantAgentConfigurationsImportRequestTagKindJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.CreateWAssistantAgentConfigurationsImportRequestTagKind?))
                {
                    return new global::Dust.JsonConverters.CreateWAssistantAgentConfigurationsImportRequestTagKindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.CreateWAssistantAgentConfigurationsImportRequestToolsetItemType))
                {
                    return new global::Dust.JsonConverters.CreateWAssistantAgentConfigurationsImportRequestToolsetItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.CreateWAssistantAgentConfigurationsImportRequestToolsetItemType?))
                {
                    return new global::Dust.JsonConverters.CreateWAssistantAgentConfigurationsImportRequestToolsetItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.GetWAssistantAgentConfigurationsView))
                {
                    return new global::Dust.JsonConverters.GetWAssistantAgentConfigurationsViewJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.GetWAssistantAgentConfigurationsView?))
                {
                    return new global::Dust.JsonConverters.GetWAssistantAgentConfigurationsViewNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.GetWAssistantAgentConfigurationsWithAuthors))
                {
                    return new global::Dust.JsonConverters.GetWAssistantAgentConfigurationsWithAuthorsJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.GetWAssistantAgentConfigurationsWithAuthors?))
                {
                    return new global::Dust.JsonConverters.GetWAssistantAgentConfigurationsWithAuthorsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.GetWAssistantAgentConfigurationsVariant))
                {
                    return new global::Dust.JsonConverters.GetWAssistantAgentConfigurationsVariantJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.GetWAssistantAgentConfigurationsVariant?))
                {
                    return new global::Dust.JsonConverters.GetWAssistantAgentConfigurationsVariantNullableJsonConverter();
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
                    0 => new AgentsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}