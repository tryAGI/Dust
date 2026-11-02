#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Dust
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ConversationSharingChange : global::System.IEquatable<ConversationSharingChange>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Dust.ConversationSharingChangeVariant1? ConversationSharingChangeVariant1 { get; init; }
#else
        public global::Dust.ConversationSharingChangeVariant1? ConversationSharingChangeVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConversationSharingChangeVariant1))]
#endif
        public bool IsConversationSharingChangeVariant1 => ConversationSharingChangeVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickConversationSharingChangeVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Dust.ConversationSharingChangeVariant1? value)
        {
            value = ConversationSharingChangeVariant1;
            return IsConversationSharingChangeVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Dust.ConversationSharingChangeVariant1 PickConversationSharingChangeVariant1() => ConversationSharingChangeVariant1 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ConversationSharingChangeVariant1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Dust.ConversationSharingChangeVariant2? ConversationSharingChangeVariant2 { get; init; }
#else
        public global::Dust.ConversationSharingChangeVariant2? ConversationSharingChangeVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConversationSharingChangeVariant2))]
#endif
        public bool IsConversationSharingChangeVariant2 => ConversationSharingChangeVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickConversationSharingChangeVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Dust.ConversationSharingChangeVariant2? value)
        {
            value = ConversationSharingChangeVariant2;
            return IsConversationSharingChangeVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Dust.ConversationSharingChangeVariant2 PickConversationSharingChangeVariant2() => ConversationSharingChangeVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ConversationSharingChangeVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ConversationSharingChange(global::Dust.ConversationSharingChangeVariant1 value) => new ConversationSharingChange((global::Dust.ConversationSharingChangeVariant1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Dust.ConversationSharingChangeVariant1?(ConversationSharingChange @this) => @this.ConversationSharingChangeVariant1;

        /// <summary>
        ///
        /// </summary>
        public ConversationSharingChange(global::Dust.ConversationSharingChangeVariant1? value)
        {
            ConversationSharingChangeVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ConversationSharingChange FromConversationSharingChangeVariant1(global::Dust.ConversationSharingChangeVariant1? value) => new ConversationSharingChange(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ConversationSharingChange(global::Dust.ConversationSharingChangeVariant2 value) => new ConversationSharingChange((global::Dust.ConversationSharingChangeVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Dust.ConversationSharingChangeVariant2?(ConversationSharingChange @this) => @this.ConversationSharingChangeVariant2;

        /// <summary>
        ///
        /// </summary>
        public ConversationSharingChange(global::Dust.ConversationSharingChangeVariant2? value)
        {
            ConversationSharingChangeVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ConversationSharingChange FromConversationSharingChangeVariant2(global::Dust.ConversationSharingChangeVariant2? value) => new ConversationSharingChange(value);

        /// <summary>
        ///
        /// </summary>
        public ConversationSharingChange(
            global::Dust.ConversationSharingChangeVariant1? conversationSharingChangeVariant1,
            global::Dust.ConversationSharingChangeVariant2? conversationSharingChangeVariant2
            )
        {
            ConversationSharingChangeVariant1 = conversationSharingChangeVariant1;
            ConversationSharingChangeVariant2 = conversationSharingChangeVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ConversationSharingChangeVariant2 as object ??
            ConversationSharingChangeVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            ConversationSharingChangeVariant1?.ToString() ??
            ConversationSharingChangeVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsConversationSharingChangeVariant1 && !IsConversationSharingChangeVariant2 || !IsConversationSharingChangeVariant1 && IsConversationSharingChangeVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Dust.ConversationSharingChangeVariant1, TResult>? conversationSharingChangeVariant1 = null,
            global::System.Func<global::Dust.ConversationSharingChangeVariant2, TResult>? conversationSharingChangeVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ConversationSharingChangeVariant1 is { } __value0 && conversationSharingChangeVariant1 != null)
            {
                return conversationSharingChangeVariant1(__value0);
            }
            else if (ConversationSharingChangeVariant2 is { } __value1 && conversationSharingChangeVariant2 != null)
            {
                return conversationSharingChangeVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Dust.ConversationSharingChangeVariant1>? conversationSharingChangeVariant1 = null,

            global::System.Action<global::Dust.ConversationSharingChangeVariant2>? conversationSharingChangeVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ConversationSharingChangeVariant1 is { } __value0)
            {
                conversationSharingChangeVariant1?.Invoke(__value0);
            }
            else if (ConversationSharingChangeVariant2 is { } __value1)
            {
                conversationSharingChangeVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Dust.ConversationSharingChangeVariant1>? conversationSharingChangeVariant1 = null,
            global::System.Action<global::Dust.ConversationSharingChangeVariant2>? conversationSharingChangeVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ConversationSharingChangeVariant1 is { } __value0)
            {
                conversationSharingChangeVariant1?.Invoke(__value0);
            }
            else if (ConversationSharingChangeVariant2 is { } __value1)
            {
                conversationSharingChangeVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ConversationSharingChangeVariant1,
                typeof(global::Dust.ConversationSharingChangeVariant1),
                ConversationSharingChangeVariant2,
                typeof(global::Dust.ConversationSharingChangeVariant2),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        ///
        /// </summary>
        public bool Equals(ConversationSharingChange other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Dust.ConversationSharingChangeVariant1?>.Default.Equals(ConversationSharingChangeVariant1, other.ConversationSharingChangeVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::Dust.ConversationSharingChangeVariant2?>.Default.Equals(ConversationSharingChangeVariant2, other.ConversationSharingChangeVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ConversationSharingChange obj1, ConversationSharingChange obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ConversationSharingChange>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ConversationSharingChange obj1, ConversationSharingChange obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ConversationSharingChange o && Equals(o);
        }
    }
}
