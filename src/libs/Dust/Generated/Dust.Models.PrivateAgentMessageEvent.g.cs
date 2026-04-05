#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Dust
{
    /// <summary>
    /// Server-Sent Event for agent message streaming. Discriminated on the `type` field. Each event also includes a `step` integer.
    /// </summary>
    public readonly partial struct PrivateAgentMessageEvent : global::System.IEquatable<PrivateAgentMessageEvent>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Dust.PrivateGenerationTokensEvent? GenerationTokens { get; init; }
#else
        public global::Dust.PrivateGenerationTokensEvent? GenerationTokens { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GenerationTokens))]
#endif
        public bool IsGenerationTokens => GenerationTokens != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Dust.PrivateToolCallStartedEvent? ToolCallStarted { get; init; }
#else
        public global::Dust.PrivateToolCallStartedEvent? ToolCallStarted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolCallStarted))]
#endif
        public bool IsToolCallStarted => ToolCallStarted != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Dust.PrivateAgentActionSuccessEvent? AgentActionSuccess { get; init; }
#else
        public global::Dust.PrivateAgentActionSuccessEvent? AgentActionSuccess { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentActionSuccess))]
#endif
        public bool IsAgentActionSuccess => AgentActionSuccess != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Dust.PrivateAgentMessageSuccessEvent? AgentMessageSuccess { get; init; }
#else
        public global::Dust.PrivateAgentMessageSuccessEvent? AgentMessageSuccess { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentMessageSuccess))]
#endif
        public bool IsAgentMessageSuccess => AgentMessageSuccess != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Dust.PrivateAgentErrorEvent? AgentError { get; init; }
#else
        public global::Dust.PrivateAgentErrorEvent? AgentError { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentError))]
#endif
        public bool IsAgentError => AgentError != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Dust.PrivateAgentGenerationCancelledEvent? AgentGenerationCancelled { get; init; }
#else
        public global::Dust.PrivateAgentGenerationCancelledEvent? AgentGenerationCancelled { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentGenerationCancelled))]
#endif
        public bool IsAgentGenerationCancelled => AgentGenerationCancelled != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Dust.PrivateToolErrorEvent? ToolError { get; init; }
#else
        public global::Dust.PrivateToolErrorEvent? ToolError { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolError))]
#endif
        public bool IsToolError => ToolError != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Dust.PrivateToolParamsEvent? ToolParams { get; init; }
#else
        public global::Dust.PrivateToolParamsEvent? ToolParams { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolParams))]
#endif
        public bool IsToolParams => ToolParams != null;

        /// <summary>
        /// Sent when a tool requires user approval before execution.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Dust.PrivateToolApproveExecutionEvent? ToolApproveExecution { get; init; }
#else
        public global::Dust.PrivateToolApproveExecutionEvent? ToolApproveExecution { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolApproveExecution))]
#endif
        public bool IsToolApproveExecution => ToolApproveExecution != null;

        /// <summary>
        /// Progress notification from a running tool.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Dust.PrivateToolNotificationEvent? ToolNotification { get; init; }
#else
        public global::Dust.PrivateToolNotificationEvent? ToolNotification { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolNotification))]
#endif
        public bool IsToolNotification => ToolNotification != null;

        /// <summary>
        /// Sent when a tool requires personal OAuth authentication.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Dust.PrivateToolPersonalAuthRequiredEvent? ToolPersonalAuthRequired { get; init; }
#else
        public global::Dust.PrivateToolPersonalAuthRequiredEvent? ToolPersonalAuthRequired { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolPersonalAuthRequired))]
#endif
        public bool IsToolPersonalAuthRequired => ToolPersonalAuthRequired != null;

        /// <summary>
        /// Sent when a tool requires file access authorization (e.g., Google Drive).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Dust.PrivateToolFileAuthRequiredEvent? ToolFileAuthRequired { get; init; }
#else
        public global::Dust.PrivateToolFileAuthRequiredEvent? ToolFileAuthRequired { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolFileAuthRequired))]
#endif
        public bool IsToolFileAuthRequired => ToolFileAuthRequired != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Dust.PrivateAgentContextPrunedEvent? AgentContextPruned { get; init; }
#else
        public global::Dust.PrivateAgentContextPrunedEvent? AgentContextPruned { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentContextPruned))]
#endif
        public bool IsAgentContextPruned => AgentContextPruned != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PrivateAgentMessageEvent(global::Dust.PrivateGenerationTokensEvent value) => new PrivateAgentMessageEvent((global::Dust.PrivateGenerationTokensEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Dust.PrivateGenerationTokensEvent?(PrivateAgentMessageEvent @this) => @this.GenerationTokens;

        /// <summary>
        /// 
        /// </summary>
        public PrivateAgentMessageEvent(global::Dust.PrivateGenerationTokensEvent? value)
        {
            GenerationTokens = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PrivateAgentMessageEvent(global::Dust.PrivateToolCallStartedEvent value) => new PrivateAgentMessageEvent((global::Dust.PrivateToolCallStartedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Dust.PrivateToolCallStartedEvent?(PrivateAgentMessageEvent @this) => @this.ToolCallStarted;

        /// <summary>
        /// 
        /// </summary>
        public PrivateAgentMessageEvent(global::Dust.PrivateToolCallStartedEvent? value)
        {
            ToolCallStarted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PrivateAgentMessageEvent(global::Dust.PrivateAgentActionSuccessEvent value) => new PrivateAgentMessageEvent((global::Dust.PrivateAgentActionSuccessEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Dust.PrivateAgentActionSuccessEvent?(PrivateAgentMessageEvent @this) => @this.AgentActionSuccess;

        /// <summary>
        /// 
        /// </summary>
        public PrivateAgentMessageEvent(global::Dust.PrivateAgentActionSuccessEvent? value)
        {
            AgentActionSuccess = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PrivateAgentMessageEvent(global::Dust.PrivateAgentMessageSuccessEvent value) => new PrivateAgentMessageEvent((global::Dust.PrivateAgentMessageSuccessEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Dust.PrivateAgentMessageSuccessEvent?(PrivateAgentMessageEvent @this) => @this.AgentMessageSuccess;

        /// <summary>
        /// 
        /// </summary>
        public PrivateAgentMessageEvent(global::Dust.PrivateAgentMessageSuccessEvent? value)
        {
            AgentMessageSuccess = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PrivateAgentMessageEvent(global::Dust.PrivateAgentErrorEvent value) => new PrivateAgentMessageEvent((global::Dust.PrivateAgentErrorEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Dust.PrivateAgentErrorEvent?(PrivateAgentMessageEvent @this) => @this.AgentError;

        /// <summary>
        /// 
        /// </summary>
        public PrivateAgentMessageEvent(global::Dust.PrivateAgentErrorEvent? value)
        {
            AgentError = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PrivateAgentMessageEvent(global::Dust.PrivateAgentGenerationCancelledEvent value) => new PrivateAgentMessageEvent((global::Dust.PrivateAgentGenerationCancelledEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Dust.PrivateAgentGenerationCancelledEvent?(PrivateAgentMessageEvent @this) => @this.AgentGenerationCancelled;

        /// <summary>
        /// 
        /// </summary>
        public PrivateAgentMessageEvent(global::Dust.PrivateAgentGenerationCancelledEvent? value)
        {
            AgentGenerationCancelled = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PrivateAgentMessageEvent(global::Dust.PrivateToolErrorEvent value) => new PrivateAgentMessageEvent((global::Dust.PrivateToolErrorEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Dust.PrivateToolErrorEvent?(PrivateAgentMessageEvent @this) => @this.ToolError;

        /// <summary>
        /// 
        /// </summary>
        public PrivateAgentMessageEvent(global::Dust.PrivateToolErrorEvent? value)
        {
            ToolError = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PrivateAgentMessageEvent(global::Dust.PrivateToolParamsEvent value) => new PrivateAgentMessageEvent((global::Dust.PrivateToolParamsEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Dust.PrivateToolParamsEvent?(PrivateAgentMessageEvent @this) => @this.ToolParams;

        /// <summary>
        /// 
        /// </summary>
        public PrivateAgentMessageEvent(global::Dust.PrivateToolParamsEvent? value)
        {
            ToolParams = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PrivateAgentMessageEvent(global::Dust.PrivateToolApproveExecutionEvent value) => new PrivateAgentMessageEvent((global::Dust.PrivateToolApproveExecutionEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Dust.PrivateToolApproveExecutionEvent?(PrivateAgentMessageEvent @this) => @this.ToolApproveExecution;

        /// <summary>
        /// 
        /// </summary>
        public PrivateAgentMessageEvent(global::Dust.PrivateToolApproveExecutionEvent? value)
        {
            ToolApproveExecution = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PrivateAgentMessageEvent(global::Dust.PrivateToolNotificationEvent value) => new PrivateAgentMessageEvent((global::Dust.PrivateToolNotificationEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Dust.PrivateToolNotificationEvent?(PrivateAgentMessageEvent @this) => @this.ToolNotification;

        /// <summary>
        /// 
        /// </summary>
        public PrivateAgentMessageEvent(global::Dust.PrivateToolNotificationEvent? value)
        {
            ToolNotification = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PrivateAgentMessageEvent(global::Dust.PrivateToolPersonalAuthRequiredEvent value) => new PrivateAgentMessageEvent((global::Dust.PrivateToolPersonalAuthRequiredEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Dust.PrivateToolPersonalAuthRequiredEvent?(PrivateAgentMessageEvent @this) => @this.ToolPersonalAuthRequired;

        /// <summary>
        /// 
        /// </summary>
        public PrivateAgentMessageEvent(global::Dust.PrivateToolPersonalAuthRequiredEvent? value)
        {
            ToolPersonalAuthRequired = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PrivateAgentMessageEvent(global::Dust.PrivateToolFileAuthRequiredEvent value) => new PrivateAgentMessageEvent((global::Dust.PrivateToolFileAuthRequiredEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Dust.PrivateToolFileAuthRequiredEvent?(PrivateAgentMessageEvent @this) => @this.ToolFileAuthRequired;

        /// <summary>
        /// 
        /// </summary>
        public PrivateAgentMessageEvent(global::Dust.PrivateToolFileAuthRequiredEvent? value)
        {
            ToolFileAuthRequired = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PrivateAgentMessageEvent(global::Dust.PrivateAgentContextPrunedEvent value) => new PrivateAgentMessageEvent((global::Dust.PrivateAgentContextPrunedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Dust.PrivateAgentContextPrunedEvent?(PrivateAgentMessageEvent @this) => @this.AgentContextPruned;

        /// <summary>
        /// 
        /// </summary>
        public PrivateAgentMessageEvent(global::Dust.PrivateAgentContextPrunedEvent? value)
        {
            AgentContextPruned = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public PrivateAgentMessageEvent(
            global::Dust.PrivateGenerationTokensEvent? generationTokens,
            global::Dust.PrivateToolCallStartedEvent? toolCallStarted,
            global::Dust.PrivateAgentActionSuccessEvent? agentActionSuccess,
            global::Dust.PrivateAgentMessageSuccessEvent? agentMessageSuccess,
            global::Dust.PrivateAgentErrorEvent? agentError,
            global::Dust.PrivateAgentGenerationCancelledEvent? agentGenerationCancelled,
            global::Dust.PrivateToolErrorEvent? toolError,
            global::Dust.PrivateToolParamsEvent? toolParams,
            global::Dust.PrivateToolApproveExecutionEvent? toolApproveExecution,
            global::Dust.PrivateToolNotificationEvent? toolNotification,
            global::Dust.PrivateToolPersonalAuthRequiredEvent? toolPersonalAuthRequired,
            global::Dust.PrivateToolFileAuthRequiredEvent? toolFileAuthRequired,
            global::Dust.PrivateAgentContextPrunedEvent? agentContextPruned
            )
        {
            GenerationTokens = generationTokens;
            ToolCallStarted = toolCallStarted;
            AgentActionSuccess = agentActionSuccess;
            AgentMessageSuccess = agentMessageSuccess;
            AgentError = agentError;
            AgentGenerationCancelled = agentGenerationCancelled;
            ToolError = toolError;
            ToolParams = toolParams;
            ToolApproveExecution = toolApproveExecution;
            ToolNotification = toolNotification;
            ToolPersonalAuthRequired = toolPersonalAuthRequired;
            ToolFileAuthRequired = toolFileAuthRequired;
            AgentContextPruned = agentContextPruned;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            AgentContextPruned as object ??
            ToolFileAuthRequired as object ??
            ToolPersonalAuthRequired as object ??
            ToolNotification as object ??
            ToolApproveExecution as object ??
            ToolParams as object ??
            ToolError as object ??
            AgentGenerationCancelled as object ??
            AgentError as object ??
            AgentMessageSuccess as object ??
            AgentActionSuccess as object ??
            ToolCallStarted as object ??
            GenerationTokens as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            GenerationTokens?.ToString() ??
            ToolCallStarted?.ToString() ??
            AgentActionSuccess?.ToString() ??
            AgentMessageSuccess?.ToString() ??
            AgentError?.ToString() ??
            AgentGenerationCancelled?.ToString() ??
            ToolError?.ToString() ??
            ToolParams?.ToString() ??
            ToolApproveExecution?.ToString() ??
            ToolNotification?.ToString() ??
            ToolPersonalAuthRequired?.ToString() ??
            ToolFileAuthRequired?.ToString() ??
            AgentContextPruned?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsGenerationTokens && !IsToolCallStarted && !IsAgentActionSuccess && !IsAgentMessageSuccess && !IsAgentError && !IsAgentGenerationCancelled && !IsToolError && !IsToolParams && !IsToolApproveExecution && !IsToolNotification && !IsToolPersonalAuthRequired && !IsToolFileAuthRequired && !IsAgentContextPruned || !IsGenerationTokens && IsToolCallStarted && !IsAgentActionSuccess && !IsAgentMessageSuccess && !IsAgentError && !IsAgentGenerationCancelled && !IsToolError && !IsToolParams && !IsToolApproveExecution && !IsToolNotification && !IsToolPersonalAuthRequired && !IsToolFileAuthRequired && !IsAgentContextPruned || !IsGenerationTokens && !IsToolCallStarted && IsAgentActionSuccess && !IsAgentMessageSuccess && !IsAgentError && !IsAgentGenerationCancelled && !IsToolError && !IsToolParams && !IsToolApproveExecution && !IsToolNotification && !IsToolPersonalAuthRequired && !IsToolFileAuthRequired && !IsAgentContextPruned || !IsGenerationTokens && !IsToolCallStarted && !IsAgentActionSuccess && IsAgentMessageSuccess && !IsAgentError && !IsAgentGenerationCancelled && !IsToolError && !IsToolParams && !IsToolApproveExecution && !IsToolNotification && !IsToolPersonalAuthRequired && !IsToolFileAuthRequired && !IsAgentContextPruned || !IsGenerationTokens && !IsToolCallStarted && !IsAgentActionSuccess && !IsAgentMessageSuccess && IsAgentError && !IsAgentGenerationCancelled && !IsToolError && !IsToolParams && !IsToolApproveExecution && !IsToolNotification && !IsToolPersonalAuthRequired && !IsToolFileAuthRequired && !IsAgentContextPruned || !IsGenerationTokens && !IsToolCallStarted && !IsAgentActionSuccess && !IsAgentMessageSuccess && !IsAgentError && IsAgentGenerationCancelled && !IsToolError && !IsToolParams && !IsToolApproveExecution && !IsToolNotification && !IsToolPersonalAuthRequired && !IsToolFileAuthRequired && !IsAgentContextPruned || !IsGenerationTokens && !IsToolCallStarted && !IsAgentActionSuccess && !IsAgentMessageSuccess && !IsAgentError && !IsAgentGenerationCancelled && IsToolError && !IsToolParams && !IsToolApproveExecution && !IsToolNotification && !IsToolPersonalAuthRequired && !IsToolFileAuthRequired && !IsAgentContextPruned || !IsGenerationTokens && !IsToolCallStarted && !IsAgentActionSuccess && !IsAgentMessageSuccess && !IsAgentError && !IsAgentGenerationCancelled && !IsToolError && IsToolParams && !IsToolApproveExecution && !IsToolNotification && !IsToolPersonalAuthRequired && !IsToolFileAuthRequired && !IsAgentContextPruned || !IsGenerationTokens && !IsToolCallStarted && !IsAgentActionSuccess && !IsAgentMessageSuccess && !IsAgentError && !IsAgentGenerationCancelled && !IsToolError && !IsToolParams && IsToolApproveExecution && !IsToolNotification && !IsToolPersonalAuthRequired && !IsToolFileAuthRequired && !IsAgentContextPruned || !IsGenerationTokens && !IsToolCallStarted && !IsAgentActionSuccess && !IsAgentMessageSuccess && !IsAgentError && !IsAgentGenerationCancelled && !IsToolError && !IsToolParams && !IsToolApproveExecution && IsToolNotification && !IsToolPersonalAuthRequired && !IsToolFileAuthRequired && !IsAgentContextPruned || !IsGenerationTokens && !IsToolCallStarted && !IsAgentActionSuccess && !IsAgentMessageSuccess && !IsAgentError && !IsAgentGenerationCancelled && !IsToolError && !IsToolParams && !IsToolApproveExecution && !IsToolNotification && IsToolPersonalAuthRequired && !IsToolFileAuthRequired && !IsAgentContextPruned || !IsGenerationTokens && !IsToolCallStarted && !IsAgentActionSuccess && !IsAgentMessageSuccess && !IsAgentError && !IsAgentGenerationCancelled && !IsToolError && !IsToolParams && !IsToolApproveExecution && !IsToolNotification && !IsToolPersonalAuthRequired && IsToolFileAuthRequired && !IsAgentContextPruned || !IsGenerationTokens && !IsToolCallStarted && !IsAgentActionSuccess && !IsAgentMessageSuccess && !IsAgentError && !IsAgentGenerationCancelled && !IsToolError && !IsToolParams && !IsToolApproveExecution && !IsToolNotification && !IsToolPersonalAuthRequired && !IsToolFileAuthRequired && IsAgentContextPruned;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Dust.PrivateGenerationTokensEvent?, TResult>? generationTokens = null,
            global::System.Func<global::Dust.PrivateToolCallStartedEvent?, TResult>? toolCallStarted = null,
            global::System.Func<global::Dust.PrivateAgentActionSuccessEvent?, TResult>? agentActionSuccess = null,
            global::System.Func<global::Dust.PrivateAgentMessageSuccessEvent?, TResult>? agentMessageSuccess = null,
            global::System.Func<global::Dust.PrivateAgentErrorEvent?, TResult>? agentError = null,
            global::System.Func<global::Dust.PrivateAgentGenerationCancelledEvent?, TResult>? agentGenerationCancelled = null,
            global::System.Func<global::Dust.PrivateToolErrorEvent?, TResult>? toolError = null,
            global::System.Func<global::Dust.PrivateToolParamsEvent?, TResult>? toolParams = null,
            global::System.Func<global::Dust.PrivateToolApproveExecutionEvent?, TResult>? toolApproveExecution = null,
            global::System.Func<global::Dust.PrivateToolNotificationEvent?, TResult>? toolNotification = null,
            global::System.Func<global::Dust.PrivateToolPersonalAuthRequiredEvent?, TResult>? toolPersonalAuthRequired = null,
            global::System.Func<global::Dust.PrivateToolFileAuthRequiredEvent?, TResult>? toolFileAuthRequired = null,
            global::System.Func<global::Dust.PrivateAgentContextPrunedEvent?, TResult>? agentContextPruned = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGenerationTokens && generationTokens != null)
            {
                return generationTokens(GenerationTokens!);
            }
            else if (IsToolCallStarted && toolCallStarted != null)
            {
                return toolCallStarted(ToolCallStarted!);
            }
            else if (IsAgentActionSuccess && agentActionSuccess != null)
            {
                return agentActionSuccess(AgentActionSuccess!);
            }
            else if (IsAgentMessageSuccess && agentMessageSuccess != null)
            {
                return agentMessageSuccess(AgentMessageSuccess!);
            }
            else if (IsAgentError && agentError != null)
            {
                return agentError(AgentError!);
            }
            else if (IsAgentGenerationCancelled && agentGenerationCancelled != null)
            {
                return agentGenerationCancelled(AgentGenerationCancelled!);
            }
            else if (IsToolError && toolError != null)
            {
                return toolError(ToolError!);
            }
            else if (IsToolParams && toolParams != null)
            {
                return toolParams(ToolParams!);
            }
            else if (IsToolApproveExecution && toolApproveExecution != null)
            {
                return toolApproveExecution(ToolApproveExecution!);
            }
            else if (IsToolNotification && toolNotification != null)
            {
                return toolNotification(ToolNotification!);
            }
            else if (IsToolPersonalAuthRequired && toolPersonalAuthRequired != null)
            {
                return toolPersonalAuthRequired(ToolPersonalAuthRequired!);
            }
            else if (IsToolFileAuthRequired && toolFileAuthRequired != null)
            {
                return toolFileAuthRequired(ToolFileAuthRequired!);
            }
            else if (IsAgentContextPruned && agentContextPruned != null)
            {
                return agentContextPruned(AgentContextPruned!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Dust.PrivateGenerationTokensEvent?>? generationTokens = null,
            global::System.Action<global::Dust.PrivateToolCallStartedEvent?>? toolCallStarted = null,
            global::System.Action<global::Dust.PrivateAgentActionSuccessEvent?>? agentActionSuccess = null,
            global::System.Action<global::Dust.PrivateAgentMessageSuccessEvent?>? agentMessageSuccess = null,
            global::System.Action<global::Dust.PrivateAgentErrorEvent?>? agentError = null,
            global::System.Action<global::Dust.PrivateAgentGenerationCancelledEvent?>? agentGenerationCancelled = null,
            global::System.Action<global::Dust.PrivateToolErrorEvent?>? toolError = null,
            global::System.Action<global::Dust.PrivateToolParamsEvent?>? toolParams = null,
            global::System.Action<global::Dust.PrivateToolApproveExecutionEvent?>? toolApproveExecution = null,
            global::System.Action<global::Dust.PrivateToolNotificationEvent?>? toolNotification = null,
            global::System.Action<global::Dust.PrivateToolPersonalAuthRequiredEvent?>? toolPersonalAuthRequired = null,
            global::System.Action<global::Dust.PrivateToolFileAuthRequiredEvent?>? toolFileAuthRequired = null,
            global::System.Action<global::Dust.PrivateAgentContextPrunedEvent?>? agentContextPruned = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGenerationTokens)
            {
                generationTokens?.Invoke(GenerationTokens!);
            }
            else if (IsToolCallStarted)
            {
                toolCallStarted?.Invoke(ToolCallStarted!);
            }
            else if (IsAgentActionSuccess)
            {
                agentActionSuccess?.Invoke(AgentActionSuccess!);
            }
            else if (IsAgentMessageSuccess)
            {
                agentMessageSuccess?.Invoke(AgentMessageSuccess!);
            }
            else if (IsAgentError)
            {
                agentError?.Invoke(AgentError!);
            }
            else if (IsAgentGenerationCancelled)
            {
                agentGenerationCancelled?.Invoke(AgentGenerationCancelled!);
            }
            else if (IsToolError)
            {
                toolError?.Invoke(ToolError!);
            }
            else if (IsToolParams)
            {
                toolParams?.Invoke(ToolParams!);
            }
            else if (IsToolApproveExecution)
            {
                toolApproveExecution?.Invoke(ToolApproveExecution!);
            }
            else if (IsToolNotification)
            {
                toolNotification?.Invoke(ToolNotification!);
            }
            else if (IsToolPersonalAuthRequired)
            {
                toolPersonalAuthRequired?.Invoke(ToolPersonalAuthRequired!);
            }
            else if (IsToolFileAuthRequired)
            {
                toolFileAuthRequired?.Invoke(ToolFileAuthRequired!);
            }
            else if (IsAgentContextPruned)
            {
                agentContextPruned?.Invoke(AgentContextPruned!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                GenerationTokens,
                typeof(global::Dust.PrivateGenerationTokensEvent),
                ToolCallStarted,
                typeof(global::Dust.PrivateToolCallStartedEvent),
                AgentActionSuccess,
                typeof(global::Dust.PrivateAgentActionSuccessEvent),
                AgentMessageSuccess,
                typeof(global::Dust.PrivateAgentMessageSuccessEvent),
                AgentError,
                typeof(global::Dust.PrivateAgentErrorEvent),
                AgentGenerationCancelled,
                typeof(global::Dust.PrivateAgentGenerationCancelledEvent),
                ToolError,
                typeof(global::Dust.PrivateToolErrorEvent),
                ToolParams,
                typeof(global::Dust.PrivateToolParamsEvent),
                ToolApproveExecution,
                typeof(global::Dust.PrivateToolApproveExecutionEvent),
                ToolNotification,
                typeof(global::Dust.PrivateToolNotificationEvent),
                ToolPersonalAuthRequired,
                typeof(global::Dust.PrivateToolPersonalAuthRequiredEvent),
                ToolFileAuthRequired,
                typeof(global::Dust.PrivateToolFileAuthRequiredEvent),
                AgentContextPruned,
                typeof(global::Dust.PrivateAgentContextPrunedEvent),
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
        public bool Equals(PrivateAgentMessageEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Dust.PrivateGenerationTokensEvent?>.Default.Equals(GenerationTokens, other.GenerationTokens) &&
                global::System.Collections.Generic.EqualityComparer<global::Dust.PrivateToolCallStartedEvent?>.Default.Equals(ToolCallStarted, other.ToolCallStarted) &&
                global::System.Collections.Generic.EqualityComparer<global::Dust.PrivateAgentActionSuccessEvent?>.Default.Equals(AgentActionSuccess, other.AgentActionSuccess) &&
                global::System.Collections.Generic.EqualityComparer<global::Dust.PrivateAgentMessageSuccessEvent?>.Default.Equals(AgentMessageSuccess, other.AgentMessageSuccess) &&
                global::System.Collections.Generic.EqualityComparer<global::Dust.PrivateAgentErrorEvent?>.Default.Equals(AgentError, other.AgentError) &&
                global::System.Collections.Generic.EqualityComparer<global::Dust.PrivateAgentGenerationCancelledEvent?>.Default.Equals(AgentGenerationCancelled, other.AgentGenerationCancelled) &&
                global::System.Collections.Generic.EqualityComparer<global::Dust.PrivateToolErrorEvent?>.Default.Equals(ToolError, other.ToolError) &&
                global::System.Collections.Generic.EqualityComparer<global::Dust.PrivateToolParamsEvent?>.Default.Equals(ToolParams, other.ToolParams) &&
                global::System.Collections.Generic.EqualityComparer<global::Dust.PrivateToolApproveExecutionEvent?>.Default.Equals(ToolApproveExecution, other.ToolApproveExecution) &&
                global::System.Collections.Generic.EqualityComparer<global::Dust.PrivateToolNotificationEvent?>.Default.Equals(ToolNotification, other.ToolNotification) &&
                global::System.Collections.Generic.EqualityComparer<global::Dust.PrivateToolPersonalAuthRequiredEvent?>.Default.Equals(ToolPersonalAuthRequired, other.ToolPersonalAuthRequired) &&
                global::System.Collections.Generic.EqualityComparer<global::Dust.PrivateToolFileAuthRequiredEvent?>.Default.Equals(ToolFileAuthRequired, other.ToolFileAuthRequired) &&
                global::System.Collections.Generic.EqualityComparer<global::Dust.PrivateAgentContextPrunedEvent?>.Default.Equals(AgentContextPruned, other.AgentContextPruned) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(PrivateAgentMessageEvent obj1, PrivateAgentMessageEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PrivateAgentMessageEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(PrivateAgentMessageEvent obj1, PrivateAgentMessageEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PrivateAgentMessageEvent o && Equals(o);
        }
    }
}
