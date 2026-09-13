
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.SkillSourceMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.Skill))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.SkillStatus), TypeInfoPropertyName = "SkillStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.SkillSource), TypeInfoPropertyName = "SkillSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.SkillReinforcement), TypeInfoPropertyName = "SkillReinforcement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.SkillFileAttachment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.SkillFileAttachment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.SkillAvailability), TypeInfoPropertyName = "SkillAvailability2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.MCPServerView>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.MCPServerView))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.MCPServerViewServerType), TypeInfoPropertyName = "MCPServerViewServerType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.MCPServerViewServer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.MCPServerViewServerAuthorization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.MCPServerViewServerAuthorizationSupportedUseCase>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.MCPServerViewServerAuthorizationSupportedUseCase), TypeInfoPropertyName = "MCPServerViewServerAuthorizationSupportedUseCase2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.MCPServerViewServerTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.MCPServerViewServerTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.MCPServerViewOAuthUseCase), TypeInfoPropertyName = "MCPServerViewOAuthUseCase2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.MCPServerViewEditedByUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWSkillsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<byte[]>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWSkillsRequestOnConflict), TypeInfoPropertyName = "CreateWSkillsRequestOnConflict2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWSkillsRequestAvailability), TypeInfoPropertyName = "CreateWSkillsRequestAvailability2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWSkillsStatus), TypeInfoPropertyName = "GetWSkillsStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.GetWSkillsAvailabilityItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWSkillsAvailabilityItem), TypeInfoPropertyName = "GetWSkillsAvailabilityItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.DeleteWSkillsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWSkillsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.Skill>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWSkillsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.CreateWSkillsResponseSkippedItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWSkillsResponseSkippedItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.SkillStatus?), TypeInfoPropertyName = "NullableSkillStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.SkillSource?), TypeInfoPropertyName = "NullableSkillSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.SkillReinforcement?), TypeInfoPropertyName = "NullableSkillReinforcement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.SkillAvailability?), TypeInfoPropertyName = "NullableSkillAvailability2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.MCPServerViewServerType?), TypeInfoPropertyName = "NullableMCPServerViewServerType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.MCPServerViewServerAuthorizationSupportedUseCase?), TypeInfoPropertyName = "NullableMCPServerViewServerAuthorizationSupportedUseCase2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.MCPServerViewOAuthUseCase?), TypeInfoPropertyName = "NullableMCPServerViewOAuthUseCase2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWSkillsRequestOnConflict?), TypeInfoPropertyName = "NullableCreateWSkillsRequestOnConflict2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWSkillsRequestAvailability?), TypeInfoPropertyName = "NullableCreateWSkillsRequestAvailability2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWSkillsStatus?), TypeInfoPropertyName = "NullableGetWSkillsStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWSkillsAvailabilityItem?), TypeInfoPropertyName = "NullableGetWSkillsAvailabilityItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.SkillFileAttachment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.MCPServerView>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.MCPServerViewServerAuthorizationSupportedUseCase>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.MCPServerViewServerTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<byte[]>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.GetWSkillsAvailabilityItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.Skill>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.CreateWSkillsResponseSkippedItem>))]
    internal sealed partial class SkillsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SkillsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SkillsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private SkillsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::Dust.SkillStatus)

                    || typeToConvert == typeof(global::Dust.SkillStatus?)

                    || typeToConvert == typeof(global::Dust.SkillSource)

                    || typeToConvert == typeof(global::Dust.SkillSource?)

                    || typeToConvert == typeof(global::Dust.SkillReinforcement)

                    || typeToConvert == typeof(global::Dust.SkillReinforcement?)

                    || typeToConvert == typeof(global::Dust.SkillAvailability)

                    || typeToConvert == typeof(global::Dust.SkillAvailability?)

                    || typeToConvert == typeof(global::Dust.MCPServerViewServerType)

                    || typeToConvert == typeof(global::Dust.MCPServerViewServerType?)

                    || typeToConvert == typeof(global::Dust.MCPServerViewServerAuthorizationSupportedUseCase)

                    || typeToConvert == typeof(global::Dust.MCPServerViewServerAuthorizationSupportedUseCase?)

                    || typeToConvert == typeof(global::Dust.MCPServerViewOAuthUseCase)

                    || typeToConvert == typeof(global::Dust.MCPServerViewOAuthUseCase?)

                    || typeToConvert == typeof(global::Dust.CreateWSkillsRequestOnConflict)

                    || typeToConvert == typeof(global::Dust.CreateWSkillsRequestOnConflict?)

                    || typeToConvert == typeof(global::Dust.CreateWSkillsRequestAvailability)

                    || typeToConvert == typeof(global::Dust.CreateWSkillsRequestAvailability?)

                    || typeToConvert == typeof(global::Dust.GetWSkillsStatus)

                    || typeToConvert == typeof(global::Dust.GetWSkillsStatus?)

                    || typeToConvert == typeof(global::Dust.GetWSkillsAvailabilityItem)

                    || typeToConvert == typeof(global::Dust.GetWSkillsAvailabilityItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Dust.SkillStatus))
                {
                    return new global::Dust.JsonConverters.SkillStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.SkillStatus?))
                {
                    return new global::Dust.JsonConverters.SkillStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.SkillSource))
                {
                    return new global::Dust.JsonConverters.SkillSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.SkillSource?))
                {
                    return new global::Dust.JsonConverters.SkillSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.SkillReinforcement))
                {
                    return new global::Dust.JsonConverters.SkillReinforcementJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.SkillReinforcement?))
                {
                    return new global::Dust.JsonConverters.SkillReinforcementNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.SkillAvailability))
                {
                    return new global::Dust.JsonConverters.SkillAvailabilityJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.SkillAvailability?))
                {
                    return new global::Dust.JsonConverters.SkillAvailabilityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.MCPServerViewServerType))
                {
                    return new global::Dust.JsonConverters.MCPServerViewServerTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.MCPServerViewServerType?))
                {
                    return new global::Dust.JsonConverters.MCPServerViewServerTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.MCPServerViewServerAuthorizationSupportedUseCase))
                {
                    return new global::Dust.JsonConverters.MCPServerViewServerAuthorizationSupportedUseCaseJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.MCPServerViewServerAuthorizationSupportedUseCase?))
                {
                    return new global::Dust.JsonConverters.MCPServerViewServerAuthorizationSupportedUseCaseNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.MCPServerViewOAuthUseCase))
                {
                    return new global::Dust.JsonConverters.MCPServerViewOAuthUseCaseJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.MCPServerViewOAuthUseCase?))
                {
                    return new global::Dust.JsonConverters.MCPServerViewOAuthUseCaseNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.CreateWSkillsRequestOnConflict))
                {
                    return new global::Dust.JsonConverters.CreateWSkillsRequestOnConflictJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.CreateWSkillsRequestOnConflict?))
                {
                    return new global::Dust.JsonConverters.CreateWSkillsRequestOnConflictNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.CreateWSkillsRequestAvailability))
                {
                    return new global::Dust.JsonConverters.CreateWSkillsRequestAvailabilityJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.CreateWSkillsRequestAvailability?))
                {
                    return new global::Dust.JsonConverters.CreateWSkillsRequestAvailabilityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.GetWSkillsStatus))
                {
                    return new global::Dust.JsonConverters.GetWSkillsStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.GetWSkillsStatus?))
                {
                    return new global::Dust.JsonConverters.GetWSkillsStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.GetWSkillsAvailabilityItem))
                {
                    return new global::Dust.JsonConverters.GetWSkillsAvailabilityItemJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.GetWSkillsAvailabilityItem?))
                {
                    return new global::Dust.JsonConverters.GetWSkillsAvailabilityItemNullableJsonConverter();
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
                    0 => new SkillsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}