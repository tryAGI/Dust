#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Dust
{
    /// <summary>
    /// Server-Sent Event for conversation-level streaming. Discriminated on the `type` field.
    /// </summary>
    public readonly partial struct PrivateConversationEvent : global::System.IEquatable<PrivateConversationEvent>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Dust.PrivateConversationEventDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Dust.PrivateUserMessageNewEvent? UserMessageNew { get; init; }
#else
        public global::Dust.PrivateUserMessageNewEvent? UserMessageNew { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UserMessageNew))]
#endif
        public bool IsUserMessageNew => UserMessageNew != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickUserMessageNew(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Dust.PrivateUserMessageNewEvent? value)
        {
            value = UserMessageNew;
            return IsUserMessageNew;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Dust.PrivateUserMessageNewEvent PickUserMessageNew() => IsUserMessageNew
            ? UserMessageNew!
            : throw new global::System.InvalidOperationException($"Expected union variant 'UserMessageNew' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Dust.PrivateAgentMessageNewEvent? AgentMessageNew { get; init; }
#else
        public global::Dust.PrivateAgentMessageNewEvent? AgentMessageNew { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentMessageNew))]
#endif
        public bool IsAgentMessageNew => AgentMessageNew != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAgentMessageNew(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Dust.PrivateAgentMessageNewEvent? value)
        {
            value = AgentMessageNew;
            return IsAgentMessageNew;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Dust.PrivateAgentMessageNewEvent PickAgentMessageNew() => IsAgentMessageNew
            ? AgentMessageNew!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AgentMessageNew' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Dust.PrivateAgentMessageDoneEvent? AgentMessageDone { get; init; }
#else
        public global::Dust.PrivateAgentMessageDoneEvent? AgentMessageDone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentMessageDone))]
#endif
        public bool IsAgentMessageDone => AgentMessageDone != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAgentMessageDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Dust.PrivateAgentMessageDoneEvent? value)
        {
            value = AgentMessageDone;
            return IsAgentMessageDone;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Dust.PrivateAgentMessageDoneEvent PickAgentMessageDone() => IsAgentMessageDone
            ? AgentMessageDone!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AgentMessageDone' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Dust.PrivateCompactionMessageNewEvent? CompactionMessageNew { get; init; }
#else
        public global::Dust.PrivateCompactionMessageNewEvent? CompactionMessageNew { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CompactionMessageNew))]
#endif
        public bool IsCompactionMessageNew => CompactionMessageNew != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickCompactionMessageNew(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Dust.PrivateCompactionMessageNewEvent? value)
        {
            value = CompactionMessageNew;
            return IsCompactionMessageNew;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Dust.PrivateCompactionMessageNewEvent PickCompactionMessageNew() => IsCompactionMessageNew
            ? CompactionMessageNew!
            : throw new global::System.InvalidOperationException($"Expected union variant 'CompactionMessageNew' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Dust.PrivateCompactionMessageDoneEvent? CompactionMessageDone { get; init; }
#else
        public global::Dust.PrivateCompactionMessageDoneEvent? CompactionMessageDone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CompactionMessageDone))]
#endif
        public bool IsCompactionMessageDone => CompactionMessageDone != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickCompactionMessageDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Dust.PrivateCompactionMessageDoneEvent? value)
        {
            value = CompactionMessageDone;
            return IsCompactionMessageDone;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Dust.PrivateCompactionMessageDoneEvent PickCompactionMessageDone() => IsCompactionMessageDone
            ? CompactionMessageDone!
            : throw new global::System.InvalidOperationException($"Expected union variant 'CompactionMessageDone' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Dust.PrivateConversationTitleEvent? ConversationTitle { get; init; }
#else
        public global::Dust.PrivateConversationTitleEvent? ConversationTitle { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConversationTitle))]
#endif
        public bool IsConversationTitle => ConversationTitle != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickConversationTitle(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Dust.PrivateConversationTitleEvent? value)
        {
            value = ConversationTitle;
            return IsConversationTitle;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Dust.PrivateConversationTitleEvent PickConversationTitle() => IsConversationTitle
            ? ConversationTitle!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ConversationTitle' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PrivateConversationEvent(global::Dust.PrivateUserMessageNewEvent value) => new PrivateConversationEvent((global::Dust.PrivateUserMessageNewEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Dust.PrivateUserMessageNewEvent?(PrivateConversationEvent @this) => @this.UserMessageNew;

        /// <summary>
        /// 
        /// </summary>
        public PrivateConversationEvent(global::Dust.PrivateUserMessageNewEvent? value)
        {
            UserMessageNew = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static PrivateConversationEvent FromUserMessageNew(global::Dust.PrivateUserMessageNewEvent? value) => new PrivateConversationEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PrivateConversationEvent(global::Dust.PrivateAgentMessageNewEvent value) => new PrivateConversationEvent((global::Dust.PrivateAgentMessageNewEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Dust.PrivateAgentMessageNewEvent?(PrivateConversationEvent @this) => @this.AgentMessageNew;

        /// <summary>
        /// 
        /// </summary>
        public PrivateConversationEvent(global::Dust.PrivateAgentMessageNewEvent? value)
        {
            AgentMessageNew = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static PrivateConversationEvent FromAgentMessageNew(global::Dust.PrivateAgentMessageNewEvent? value) => new PrivateConversationEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PrivateConversationEvent(global::Dust.PrivateAgentMessageDoneEvent value) => new PrivateConversationEvent((global::Dust.PrivateAgentMessageDoneEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Dust.PrivateAgentMessageDoneEvent?(PrivateConversationEvent @this) => @this.AgentMessageDone;

        /// <summary>
        /// 
        /// </summary>
        public PrivateConversationEvent(global::Dust.PrivateAgentMessageDoneEvent? value)
        {
            AgentMessageDone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static PrivateConversationEvent FromAgentMessageDone(global::Dust.PrivateAgentMessageDoneEvent? value) => new PrivateConversationEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PrivateConversationEvent(global::Dust.PrivateCompactionMessageNewEvent value) => new PrivateConversationEvent((global::Dust.PrivateCompactionMessageNewEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Dust.PrivateCompactionMessageNewEvent?(PrivateConversationEvent @this) => @this.CompactionMessageNew;

        /// <summary>
        /// 
        /// </summary>
        public PrivateConversationEvent(global::Dust.PrivateCompactionMessageNewEvent? value)
        {
            CompactionMessageNew = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static PrivateConversationEvent FromCompactionMessageNew(global::Dust.PrivateCompactionMessageNewEvent? value) => new PrivateConversationEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PrivateConversationEvent(global::Dust.PrivateCompactionMessageDoneEvent value) => new PrivateConversationEvent((global::Dust.PrivateCompactionMessageDoneEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Dust.PrivateCompactionMessageDoneEvent?(PrivateConversationEvent @this) => @this.CompactionMessageDone;

        /// <summary>
        /// 
        /// </summary>
        public PrivateConversationEvent(global::Dust.PrivateCompactionMessageDoneEvent? value)
        {
            CompactionMessageDone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static PrivateConversationEvent FromCompactionMessageDone(global::Dust.PrivateCompactionMessageDoneEvent? value) => new PrivateConversationEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PrivateConversationEvent(global::Dust.PrivateConversationTitleEvent value) => new PrivateConversationEvent((global::Dust.PrivateConversationTitleEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Dust.PrivateConversationTitleEvent?(PrivateConversationEvent @this) => @this.ConversationTitle;

        /// <summary>
        /// 
        /// </summary>
        public PrivateConversationEvent(global::Dust.PrivateConversationTitleEvent? value)
        {
            ConversationTitle = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static PrivateConversationEvent FromConversationTitle(global::Dust.PrivateConversationTitleEvent? value) => new PrivateConversationEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public PrivateConversationEvent(
            global::Dust.PrivateConversationEventDiscriminatorType? type,
            global::Dust.PrivateUserMessageNewEvent? userMessageNew,
            global::Dust.PrivateAgentMessageNewEvent? agentMessageNew,
            global::Dust.PrivateAgentMessageDoneEvent? agentMessageDone,
            global::Dust.PrivateCompactionMessageNewEvent? compactionMessageNew,
            global::Dust.PrivateCompactionMessageDoneEvent? compactionMessageDone,
            global::Dust.PrivateConversationTitleEvent? conversationTitle
            )
        {
            Type = type;

            UserMessageNew = userMessageNew;
            AgentMessageNew = agentMessageNew;
            AgentMessageDone = agentMessageDone;
            CompactionMessageNew = compactionMessageNew;
            CompactionMessageDone = compactionMessageDone;
            ConversationTitle = conversationTitle;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ConversationTitle as object ??
            CompactionMessageDone as object ??
            CompactionMessageNew as object ??
            AgentMessageDone as object ??
            AgentMessageNew as object ??
            UserMessageNew as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            UserMessageNew?.ToString() ??
            AgentMessageNew?.ToString() ??
            AgentMessageDone?.ToString() ??
            CompactionMessageNew?.ToString() ??
            CompactionMessageDone?.ToString() ??
            ConversationTitle?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsUserMessageNew && !IsAgentMessageNew && !IsAgentMessageDone && !IsCompactionMessageNew && !IsCompactionMessageDone && !IsConversationTitle || !IsUserMessageNew && IsAgentMessageNew && !IsAgentMessageDone && !IsCompactionMessageNew && !IsCompactionMessageDone && !IsConversationTitle || !IsUserMessageNew && !IsAgentMessageNew && IsAgentMessageDone && !IsCompactionMessageNew && !IsCompactionMessageDone && !IsConversationTitle || !IsUserMessageNew && !IsAgentMessageNew && !IsAgentMessageDone && IsCompactionMessageNew && !IsCompactionMessageDone && !IsConversationTitle || !IsUserMessageNew && !IsAgentMessageNew && !IsAgentMessageDone && !IsCompactionMessageNew && IsCompactionMessageDone && !IsConversationTitle || !IsUserMessageNew && !IsAgentMessageNew && !IsAgentMessageDone && !IsCompactionMessageNew && !IsCompactionMessageDone && IsConversationTitle;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Dust.PrivateUserMessageNewEvent, TResult>? userMessageNew = null,
            global::System.Func<global::Dust.PrivateAgentMessageNewEvent, TResult>? agentMessageNew = null,
            global::System.Func<global::Dust.PrivateAgentMessageDoneEvent, TResult>? agentMessageDone = null,
            global::System.Func<global::Dust.PrivateCompactionMessageNewEvent, TResult>? compactionMessageNew = null,
            global::System.Func<global::Dust.PrivateCompactionMessageDoneEvent, TResult>? compactionMessageDone = null,
            global::System.Func<global::Dust.PrivateConversationTitleEvent, TResult>? conversationTitle = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUserMessageNew && userMessageNew != null)
            {
                return userMessageNew(UserMessageNew!);
            }
            else if (IsAgentMessageNew && agentMessageNew != null)
            {
                return agentMessageNew(AgentMessageNew!);
            }
            else if (IsAgentMessageDone && agentMessageDone != null)
            {
                return agentMessageDone(AgentMessageDone!);
            }
            else if (IsCompactionMessageNew && compactionMessageNew != null)
            {
                return compactionMessageNew(CompactionMessageNew!);
            }
            else if (IsCompactionMessageDone && compactionMessageDone != null)
            {
                return compactionMessageDone(CompactionMessageDone!);
            }
            else if (IsConversationTitle && conversationTitle != null)
            {
                return conversationTitle(ConversationTitle!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Dust.PrivateUserMessageNewEvent>? userMessageNew = null,

            global::System.Action<global::Dust.PrivateAgentMessageNewEvent>? agentMessageNew = null,

            global::System.Action<global::Dust.PrivateAgentMessageDoneEvent>? agentMessageDone = null,

            global::System.Action<global::Dust.PrivateCompactionMessageNewEvent>? compactionMessageNew = null,

            global::System.Action<global::Dust.PrivateCompactionMessageDoneEvent>? compactionMessageDone = null,

            global::System.Action<global::Dust.PrivateConversationTitleEvent>? conversationTitle = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUserMessageNew)
            {
                userMessageNew?.Invoke(UserMessageNew!);
            }
            else if (IsAgentMessageNew)
            {
                agentMessageNew?.Invoke(AgentMessageNew!);
            }
            else if (IsAgentMessageDone)
            {
                agentMessageDone?.Invoke(AgentMessageDone!);
            }
            else if (IsCompactionMessageNew)
            {
                compactionMessageNew?.Invoke(CompactionMessageNew!);
            }
            else if (IsCompactionMessageDone)
            {
                compactionMessageDone?.Invoke(CompactionMessageDone!);
            }
            else if (IsConversationTitle)
            {
                conversationTitle?.Invoke(ConversationTitle!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Dust.PrivateUserMessageNewEvent>? userMessageNew = null,
            global::System.Action<global::Dust.PrivateAgentMessageNewEvent>? agentMessageNew = null,
            global::System.Action<global::Dust.PrivateAgentMessageDoneEvent>? agentMessageDone = null,
            global::System.Action<global::Dust.PrivateCompactionMessageNewEvent>? compactionMessageNew = null,
            global::System.Action<global::Dust.PrivateCompactionMessageDoneEvent>? compactionMessageDone = null,
            global::System.Action<global::Dust.PrivateConversationTitleEvent>? conversationTitle = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUserMessageNew)
            {
                userMessageNew?.Invoke(UserMessageNew!);
            }
            else if (IsAgentMessageNew)
            {
                agentMessageNew?.Invoke(AgentMessageNew!);
            }
            else if (IsAgentMessageDone)
            {
                agentMessageDone?.Invoke(AgentMessageDone!);
            }
            else if (IsCompactionMessageNew)
            {
                compactionMessageNew?.Invoke(CompactionMessageNew!);
            }
            else if (IsCompactionMessageDone)
            {
                compactionMessageDone?.Invoke(CompactionMessageDone!);
            }
            else if (IsConversationTitle)
            {
                conversationTitle?.Invoke(ConversationTitle!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                UserMessageNew,
                typeof(global::Dust.PrivateUserMessageNewEvent),
                AgentMessageNew,
                typeof(global::Dust.PrivateAgentMessageNewEvent),
                AgentMessageDone,
                typeof(global::Dust.PrivateAgentMessageDoneEvent),
                CompactionMessageNew,
                typeof(global::Dust.PrivateCompactionMessageNewEvent),
                CompactionMessageDone,
                typeof(global::Dust.PrivateCompactionMessageDoneEvent),
                ConversationTitle,
                typeof(global::Dust.PrivateConversationTitleEvent),
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
        public bool Equals(PrivateConversationEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Dust.PrivateUserMessageNewEvent?>.Default.Equals(UserMessageNew, other.UserMessageNew) &&
                global::System.Collections.Generic.EqualityComparer<global::Dust.PrivateAgentMessageNewEvent?>.Default.Equals(AgentMessageNew, other.AgentMessageNew) &&
                global::System.Collections.Generic.EqualityComparer<global::Dust.PrivateAgentMessageDoneEvent?>.Default.Equals(AgentMessageDone, other.AgentMessageDone) &&
                global::System.Collections.Generic.EqualityComparer<global::Dust.PrivateCompactionMessageNewEvent?>.Default.Equals(CompactionMessageNew, other.CompactionMessageNew) &&
                global::System.Collections.Generic.EqualityComparer<global::Dust.PrivateCompactionMessageDoneEvent?>.Default.Equals(CompactionMessageDone, other.CompactionMessageDone) &&
                global::System.Collections.Generic.EqualityComparer<global::Dust.PrivateConversationTitleEvent?>.Default.Equals(ConversationTitle, other.ConversationTitle) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(PrivateConversationEvent obj1, PrivateConversationEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PrivateConversationEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(PrivateConversationEvent obj1, PrivateConversationEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PrivateConversationEvent o && Equals(o);
        }
    }
}
