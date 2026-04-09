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
        public PrivateConversationEvent(
            global::Dust.PrivateUserMessageNewEvent? userMessageNew,
            global::Dust.PrivateAgentMessageNewEvent? agentMessageNew,
            global::Dust.PrivateAgentMessageDoneEvent? agentMessageDone,
            global::Dust.PrivateConversationTitleEvent? conversationTitle
            )
        {
            UserMessageNew = userMessageNew;
            AgentMessageNew = agentMessageNew;
            AgentMessageDone = agentMessageDone;
            ConversationTitle = conversationTitle;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ConversationTitle as object ??
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
            ConversationTitle?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsUserMessageNew && !IsAgentMessageNew && !IsAgentMessageDone && !IsConversationTitle || !IsUserMessageNew && IsAgentMessageNew && !IsAgentMessageDone && !IsConversationTitle || !IsUserMessageNew && !IsAgentMessageNew && IsAgentMessageDone && !IsConversationTitle || !IsUserMessageNew && !IsAgentMessageNew && !IsAgentMessageDone && IsConversationTitle;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Dust.PrivateUserMessageNewEvent?, TResult>? userMessageNew = null,
            global::System.Func<global::Dust.PrivateAgentMessageNewEvent?, TResult>? agentMessageNew = null,
            global::System.Func<global::Dust.PrivateAgentMessageDoneEvent?, TResult>? agentMessageDone = null,
            global::System.Func<global::Dust.PrivateConversationTitleEvent?, TResult>? conversationTitle = null,
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
            global::System.Action<global::Dust.PrivateUserMessageNewEvent?>? userMessageNew = null,
            global::System.Action<global::Dust.PrivateAgentMessageNewEvent?>? agentMessageNew = null,
            global::System.Action<global::Dust.PrivateAgentMessageDoneEvent?>? agentMessageDone = null,
            global::System.Action<global::Dust.PrivateConversationTitleEvent?>? conversationTitle = null,
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
