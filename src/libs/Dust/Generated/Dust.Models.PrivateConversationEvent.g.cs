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
#if NET6_0_OR_GREATER
        public global::Dust.PrivateButlerSuggestionCreatedEvent? ButlerSuggestionCreated { get; init; }
#else
        public global::Dust.PrivateButlerSuggestionCreatedEvent? ButlerSuggestionCreated { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ButlerSuggestionCreated))]
#endif
        public bool IsButlerSuggestionCreated => ButlerSuggestionCreated != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Dust.PrivateButlerThinkingEvent? ButlerThinking { get; init; }
#else
        public global::Dust.PrivateButlerThinkingEvent? ButlerThinking { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ButlerThinking))]
#endif
        public bool IsButlerThinking => ButlerThinking != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Dust.PrivateButlerDoneEvent? ButlerDone { get; init; }
#else
        public global::Dust.PrivateButlerDoneEvent? ButlerDone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ButlerDone))]
#endif
        public bool IsButlerDone => ButlerDone != null;
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
        public static implicit operator PrivateConversationEvent(global::Dust.PrivateButlerSuggestionCreatedEvent value) => new PrivateConversationEvent((global::Dust.PrivateButlerSuggestionCreatedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Dust.PrivateButlerSuggestionCreatedEvent?(PrivateConversationEvent @this) => @this.ButlerSuggestionCreated;

        /// <summary>
        /// 
        /// </summary>
        public PrivateConversationEvent(global::Dust.PrivateButlerSuggestionCreatedEvent? value)
        {
            ButlerSuggestionCreated = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PrivateConversationEvent(global::Dust.PrivateButlerThinkingEvent value) => new PrivateConversationEvent((global::Dust.PrivateButlerThinkingEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Dust.PrivateButlerThinkingEvent?(PrivateConversationEvent @this) => @this.ButlerThinking;

        /// <summary>
        /// 
        /// </summary>
        public PrivateConversationEvent(global::Dust.PrivateButlerThinkingEvent? value)
        {
            ButlerThinking = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PrivateConversationEvent(global::Dust.PrivateButlerDoneEvent value) => new PrivateConversationEvent((global::Dust.PrivateButlerDoneEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Dust.PrivateButlerDoneEvent?(PrivateConversationEvent @this) => @this.ButlerDone;

        /// <summary>
        /// 
        /// </summary>
        public PrivateConversationEvent(global::Dust.PrivateButlerDoneEvent? value)
        {
            ButlerDone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public PrivateConversationEvent(
            global::Dust.PrivateUserMessageNewEvent? userMessageNew,
            global::Dust.PrivateAgentMessageNewEvent? agentMessageNew,
            global::Dust.PrivateAgentMessageDoneEvent? agentMessageDone,
            global::Dust.PrivateConversationTitleEvent? conversationTitle,
            global::Dust.PrivateButlerSuggestionCreatedEvent? butlerSuggestionCreated,
            global::Dust.PrivateButlerThinkingEvent? butlerThinking,
            global::Dust.PrivateButlerDoneEvent? butlerDone
            )
        {
            UserMessageNew = userMessageNew;
            AgentMessageNew = agentMessageNew;
            AgentMessageDone = agentMessageDone;
            ConversationTitle = conversationTitle;
            ButlerSuggestionCreated = butlerSuggestionCreated;
            ButlerThinking = butlerThinking;
            ButlerDone = butlerDone;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ButlerDone as object ??
            ButlerThinking as object ??
            ButlerSuggestionCreated as object ??
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
            ConversationTitle?.ToString() ??
            ButlerSuggestionCreated?.ToString() ??
            ButlerThinking?.ToString() ??
            ButlerDone?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsUserMessageNew && !IsAgentMessageNew && !IsAgentMessageDone && !IsConversationTitle && !IsButlerSuggestionCreated && !IsButlerThinking && !IsButlerDone || !IsUserMessageNew && IsAgentMessageNew && !IsAgentMessageDone && !IsConversationTitle && !IsButlerSuggestionCreated && !IsButlerThinking && !IsButlerDone || !IsUserMessageNew && !IsAgentMessageNew && IsAgentMessageDone && !IsConversationTitle && !IsButlerSuggestionCreated && !IsButlerThinking && !IsButlerDone || !IsUserMessageNew && !IsAgentMessageNew && !IsAgentMessageDone && IsConversationTitle && !IsButlerSuggestionCreated && !IsButlerThinking && !IsButlerDone || !IsUserMessageNew && !IsAgentMessageNew && !IsAgentMessageDone && !IsConversationTitle && IsButlerSuggestionCreated && !IsButlerThinking && !IsButlerDone || !IsUserMessageNew && !IsAgentMessageNew && !IsAgentMessageDone && !IsConversationTitle && !IsButlerSuggestionCreated && IsButlerThinking && !IsButlerDone || !IsUserMessageNew && !IsAgentMessageNew && !IsAgentMessageDone && !IsConversationTitle && !IsButlerSuggestionCreated && !IsButlerThinking && IsButlerDone;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Dust.PrivateUserMessageNewEvent?, TResult>? userMessageNew = null,
            global::System.Func<global::Dust.PrivateAgentMessageNewEvent?, TResult>? agentMessageNew = null,
            global::System.Func<global::Dust.PrivateAgentMessageDoneEvent?, TResult>? agentMessageDone = null,
            global::System.Func<global::Dust.PrivateConversationTitleEvent?, TResult>? conversationTitle = null,
            global::System.Func<global::Dust.PrivateButlerSuggestionCreatedEvent?, TResult>? butlerSuggestionCreated = null,
            global::System.Func<global::Dust.PrivateButlerThinkingEvent?, TResult>? butlerThinking = null,
            global::System.Func<global::Dust.PrivateButlerDoneEvent?, TResult>? butlerDone = null,
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
            else if (IsButlerSuggestionCreated && butlerSuggestionCreated != null)
            {
                return butlerSuggestionCreated(ButlerSuggestionCreated!);
            }
            else if (IsButlerThinking && butlerThinking != null)
            {
                return butlerThinking(ButlerThinking!);
            }
            else if (IsButlerDone && butlerDone != null)
            {
                return butlerDone(ButlerDone!);
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
            global::System.Action<global::Dust.PrivateButlerSuggestionCreatedEvent?>? butlerSuggestionCreated = null,
            global::System.Action<global::Dust.PrivateButlerThinkingEvent?>? butlerThinking = null,
            global::System.Action<global::Dust.PrivateButlerDoneEvent?>? butlerDone = null,
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
            else if (IsButlerSuggestionCreated)
            {
                butlerSuggestionCreated?.Invoke(ButlerSuggestionCreated!);
            }
            else if (IsButlerThinking)
            {
                butlerThinking?.Invoke(ButlerThinking!);
            }
            else if (IsButlerDone)
            {
                butlerDone?.Invoke(ButlerDone!);
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
                ButlerSuggestionCreated,
                typeof(global::Dust.PrivateButlerSuggestionCreatedEvent),
                ButlerThinking,
                typeof(global::Dust.PrivateButlerThinkingEvent),
                ButlerDone,
                typeof(global::Dust.PrivateButlerDoneEvent),
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
                global::System.Collections.Generic.EqualityComparer<global::Dust.PrivateConversationTitleEvent?>.Default.Equals(ConversationTitle, other.ConversationTitle) &&
                global::System.Collections.Generic.EqualityComparer<global::Dust.PrivateButlerSuggestionCreatedEvent?>.Default.Equals(ButlerSuggestionCreated, other.ButlerSuggestionCreated) &&
                global::System.Collections.Generic.EqualityComparer<global::Dust.PrivateButlerThinkingEvent?>.Default.Equals(ButlerThinking, other.ButlerThinking) &&
                global::System.Collections.Generic.EqualityComparer<global::Dust.PrivateButlerDoneEvent?>.Default.Equals(ButlerDone, other.ButlerDone) 
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
