#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Dust
{
    /// <summary>
    /// Full conversation including content, owner, and visibility.
    /// </summary>
    public readonly partial struct PrivateFullConversation : global::System.IEquatable<PrivateFullConversation>
    {
        /// <summary>
        /// Conversation without content, used in list responses.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Dust.PrivateConversation? PrivateConversation { get; init; }
#else
        public global::Dust.PrivateConversation? PrivateConversation { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PrivateConversation))]
#endif
        public bool IsPrivateConversation => PrivateConversation != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Dust.PrivateFullConversationVariant2? PrivateFullConversationVariant2 { get; init; }
#else
        public global::Dust.PrivateFullConversationVariant2? PrivateFullConversationVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PrivateFullConversationVariant2))]
#endif
        public bool IsPrivateFullConversationVariant2 => PrivateFullConversationVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PrivateFullConversation(global::Dust.PrivateConversation value) => new PrivateFullConversation((global::Dust.PrivateConversation?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Dust.PrivateConversation?(PrivateFullConversation @this) => @this.PrivateConversation;

        /// <summary>
        /// 
        /// </summary>
        public PrivateFullConversation(global::Dust.PrivateConversation? value)
        {
            PrivateConversation = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PrivateFullConversation(global::Dust.PrivateFullConversationVariant2 value) => new PrivateFullConversation((global::Dust.PrivateFullConversationVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Dust.PrivateFullConversationVariant2?(PrivateFullConversation @this) => @this.PrivateFullConversationVariant2;

        /// <summary>
        /// 
        /// </summary>
        public PrivateFullConversation(global::Dust.PrivateFullConversationVariant2? value)
        {
            PrivateFullConversationVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public PrivateFullConversation(
            global::Dust.PrivateConversation? privateConversation,
            global::Dust.PrivateFullConversationVariant2? privateFullConversationVariant2
            )
        {
            PrivateConversation = privateConversation;
            PrivateFullConversationVariant2 = privateFullConversationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            PrivateFullConversationVariant2 as object ??
            PrivateConversation as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            PrivateConversation?.ToString() ??
            PrivateFullConversationVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsPrivateConversation && IsPrivateFullConversationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Dust.PrivateConversation?, TResult>? privateConversation = null,
            global::System.Func<global::Dust.PrivateFullConversationVariant2?, TResult>? privateFullConversationVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPrivateConversation && privateConversation != null)
            {
                return privateConversation(PrivateConversation!);
            }
            else if (IsPrivateFullConversationVariant2 && privateFullConversationVariant2 != null)
            {
                return privateFullConversationVariant2(PrivateFullConversationVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Dust.PrivateConversation?>? privateConversation = null,
            global::System.Action<global::Dust.PrivateFullConversationVariant2?>? privateFullConversationVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPrivateConversation)
            {
                privateConversation?.Invoke(PrivateConversation!);
            }
            else if (IsPrivateFullConversationVariant2)
            {
                privateFullConversationVariant2?.Invoke(PrivateFullConversationVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                PrivateConversation,
                typeof(global::Dust.PrivateConversation),
                PrivateFullConversationVariant2,
                typeof(global::Dust.PrivateFullConversationVariant2),
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
        public bool Equals(PrivateFullConversation other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Dust.PrivateConversation?>.Default.Equals(PrivateConversation, other.PrivateConversation) &&
                global::System.Collections.Generic.EqualityComparer<global::Dust.PrivateFullConversationVariant2?>.Default.Equals(PrivateFullConversationVariant2, other.PrivateFullConversationVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(PrivateFullConversation obj1, PrivateFullConversation obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PrivateFullConversation>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(PrivateFullConversation obj1, PrivateFullConversation obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PrivateFullConversation o && Equals(o);
        }
    }
}
