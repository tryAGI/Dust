#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Dust
{
    /// <summary>
    /// Server-Sent Event for sandbox function invocation streaming. Discriminated on the `type` field.
    /// </summary>
    public readonly partial struct PrivateSandboxFunctionInvocationEvent : global::System.IEquatable<PrivateSandboxFunctionInvocationEvent>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Dust.PrivateSandboxFunctionInvocationEventDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Dust.PrivateSandboxFunctionInvocationCreatedEvent? SandboxFunctionInvocationCreated { get; init; }
#else
        public global::Dust.PrivateSandboxFunctionInvocationCreatedEvent? SandboxFunctionInvocationCreated { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SandboxFunctionInvocationCreated))]
#endif
        public bool IsSandboxFunctionInvocationCreated => SandboxFunctionInvocationCreated != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSandboxFunctionInvocationCreated(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Dust.PrivateSandboxFunctionInvocationCreatedEvent? value)
        {
            value = SandboxFunctionInvocationCreated;
            return IsSandboxFunctionInvocationCreated;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Dust.PrivateSandboxFunctionInvocationCreatedEvent PickSandboxFunctionInvocationCreated() => IsSandboxFunctionInvocationCreated
            ? SandboxFunctionInvocationCreated!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SandboxFunctionInvocationCreated' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Dust.PrivateSandboxFunctionInvocationResultEvent? SandboxFunctionInvocationResult { get; init; }
#else
        public global::Dust.PrivateSandboxFunctionInvocationResultEvent? SandboxFunctionInvocationResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SandboxFunctionInvocationResult))]
#endif
        public bool IsSandboxFunctionInvocationResult => SandboxFunctionInvocationResult != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSandboxFunctionInvocationResult(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Dust.PrivateSandboxFunctionInvocationResultEvent? value)
        {
            value = SandboxFunctionInvocationResult;
            return IsSandboxFunctionInvocationResult;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Dust.PrivateSandboxFunctionInvocationResultEvent PickSandboxFunctionInvocationResult() => IsSandboxFunctionInvocationResult
            ? SandboxFunctionInvocationResult!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SandboxFunctionInvocationResult' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PrivateSandboxFunctionInvocationEvent(global::Dust.PrivateSandboxFunctionInvocationCreatedEvent value) => new PrivateSandboxFunctionInvocationEvent((global::Dust.PrivateSandboxFunctionInvocationCreatedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Dust.PrivateSandboxFunctionInvocationCreatedEvent?(PrivateSandboxFunctionInvocationEvent @this) => @this.SandboxFunctionInvocationCreated;

        /// <summary>
        /// 
        /// </summary>
        public PrivateSandboxFunctionInvocationEvent(global::Dust.PrivateSandboxFunctionInvocationCreatedEvent? value)
        {
            SandboxFunctionInvocationCreated = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static PrivateSandboxFunctionInvocationEvent FromSandboxFunctionInvocationCreated(global::Dust.PrivateSandboxFunctionInvocationCreatedEvent? value) => new PrivateSandboxFunctionInvocationEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PrivateSandboxFunctionInvocationEvent(global::Dust.PrivateSandboxFunctionInvocationResultEvent value) => new PrivateSandboxFunctionInvocationEvent((global::Dust.PrivateSandboxFunctionInvocationResultEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Dust.PrivateSandboxFunctionInvocationResultEvent?(PrivateSandboxFunctionInvocationEvent @this) => @this.SandboxFunctionInvocationResult;

        /// <summary>
        /// 
        /// </summary>
        public PrivateSandboxFunctionInvocationEvent(global::Dust.PrivateSandboxFunctionInvocationResultEvent? value)
        {
            SandboxFunctionInvocationResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static PrivateSandboxFunctionInvocationEvent FromSandboxFunctionInvocationResult(global::Dust.PrivateSandboxFunctionInvocationResultEvent? value) => new PrivateSandboxFunctionInvocationEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public PrivateSandboxFunctionInvocationEvent(
            global::Dust.PrivateSandboxFunctionInvocationEventDiscriminatorType? type,
            global::Dust.PrivateSandboxFunctionInvocationCreatedEvent? sandboxFunctionInvocationCreated,
            global::Dust.PrivateSandboxFunctionInvocationResultEvent? sandboxFunctionInvocationResult
            )
        {
            Type = type;

            SandboxFunctionInvocationCreated = sandboxFunctionInvocationCreated;
            SandboxFunctionInvocationResult = sandboxFunctionInvocationResult;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            SandboxFunctionInvocationResult as object ??
            SandboxFunctionInvocationCreated as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            SandboxFunctionInvocationCreated?.ToString() ??
            SandboxFunctionInvocationResult?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSandboxFunctionInvocationCreated && !IsSandboxFunctionInvocationResult || !IsSandboxFunctionInvocationCreated && IsSandboxFunctionInvocationResult;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Dust.PrivateSandboxFunctionInvocationCreatedEvent, TResult>? sandboxFunctionInvocationCreated = null,
            global::System.Func<global::Dust.PrivateSandboxFunctionInvocationResultEvent, TResult>? sandboxFunctionInvocationResult = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSandboxFunctionInvocationCreated && sandboxFunctionInvocationCreated != null)
            {
                return sandboxFunctionInvocationCreated(SandboxFunctionInvocationCreated!);
            }
            else if (IsSandboxFunctionInvocationResult && sandboxFunctionInvocationResult != null)
            {
                return sandboxFunctionInvocationResult(SandboxFunctionInvocationResult!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Dust.PrivateSandboxFunctionInvocationCreatedEvent>? sandboxFunctionInvocationCreated = null,

            global::System.Action<global::Dust.PrivateSandboxFunctionInvocationResultEvent>? sandboxFunctionInvocationResult = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSandboxFunctionInvocationCreated)
            {
                sandboxFunctionInvocationCreated?.Invoke(SandboxFunctionInvocationCreated!);
            }
            else if (IsSandboxFunctionInvocationResult)
            {
                sandboxFunctionInvocationResult?.Invoke(SandboxFunctionInvocationResult!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Dust.PrivateSandboxFunctionInvocationCreatedEvent>? sandboxFunctionInvocationCreated = null,
            global::System.Action<global::Dust.PrivateSandboxFunctionInvocationResultEvent>? sandboxFunctionInvocationResult = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSandboxFunctionInvocationCreated)
            {
                sandboxFunctionInvocationCreated?.Invoke(SandboxFunctionInvocationCreated!);
            }
            else if (IsSandboxFunctionInvocationResult)
            {
                sandboxFunctionInvocationResult?.Invoke(SandboxFunctionInvocationResult!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                SandboxFunctionInvocationCreated,
                typeof(global::Dust.PrivateSandboxFunctionInvocationCreatedEvent),
                SandboxFunctionInvocationResult,
                typeof(global::Dust.PrivateSandboxFunctionInvocationResultEvent),
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
        public bool Equals(PrivateSandboxFunctionInvocationEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Dust.PrivateSandboxFunctionInvocationCreatedEvent?>.Default.Equals(SandboxFunctionInvocationCreated, other.SandboxFunctionInvocationCreated) &&
                global::System.Collections.Generic.EqualityComparer<global::Dust.PrivateSandboxFunctionInvocationResultEvent?>.Default.Equals(SandboxFunctionInvocationResult, other.SandboxFunctionInvocationResult) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(PrivateSandboxFunctionInvocationEvent obj1, PrivateSandboxFunctionInvocationEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PrivateSandboxFunctionInvocationEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(PrivateSandboxFunctionInvocationEvent obj1, PrivateSandboxFunctionInvocationEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PrivateSandboxFunctionInvocationEvent o && Equals(o);
        }
    }
}
