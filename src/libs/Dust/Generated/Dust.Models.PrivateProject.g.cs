#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Dust
{
    /// <summary>
    /// A project space with additional metadata.
    /// </summary>
    public readonly partial struct PrivateProject : global::System.IEquatable<PrivateProject>
    {
        /// <summary>
        /// A space in the workspace.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Dust.PrivateSpace? Space { get; init; }
#else
        public global::Dust.PrivateSpace? Space { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Space))]
#endif
        public bool IsSpace => Space != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Dust.PrivateProjectVariant2? PrivateProjectVariant2 { get; init; }
#else
        public global::Dust.PrivateProjectVariant2? PrivateProjectVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PrivateProjectVariant2))]
#endif
        public bool IsPrivateProjectVariant2 => PrivateProjectVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PrivateProject(global::Dust.PrivateSpace value) => new PrivateProject((global::Dust.PrivateSpace?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Dust.PrivateSpace?(PrivateProject @this) => @this.Space;

        /// <summary>
        /// 
        /// </summary>
        public PrivateProject(global::Dust.PrivateSpace? value)
        {
            Space = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PrivateProject(global::Dust.PrivateProjectVariant2 value) => new PrivateProject((global::Dust.PrivateProjectVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Dust.PrivateProjectVariant2?(PrivateProject @this) => @this.PrivateProjectVariant2;

        /// <summary>
        /// 
        /// </summary>
        public PrivateProject(global::Dust.PrivateProjectVariant2? value)
        {
            PrivateProjectVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public PrivateProject(
            global::Dust.PrivateSpace? space,
            global::Dust.PrivateProjectVariant2? privateProjectVariant2
            )
        {
            Space = space;
            PrivateProjectVariant2 = privateProjectVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            PrivateProjectVariant2 as object ??
            Space as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Space?.ToString() ??
            PrivateProjectVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSpace && IsPrivateProjectVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Dust.PrivateSpace?, TResult>? space = null,
            global::System.Func<global::Dust.PrivateProjectVariant2?, TResult>? privateProjectVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSpace && space != null)
            {
                return space(Space!);
            }
            else if (IsPrivateProjectVariant2 && privateProjectVariant2 != null)
            {
                return privateProjectVariant2(PrivateProjectVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Dust.PrivateSpace?>? space = null,
            global::System.Action<global::Dust.PrivateProjectVariant2?>? privateProjectVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSpace)
            {
                space?.Invoke(Space!);
            }
            else if (IsPrivateProjectVariant2)
            {
                privateProjectVariant2?.Invoke(PrivateProjectVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Space,
                typeof(global::Dust.PrivateSpace),
                PrivateProjectVariant2,
                typeof(global::Dust.PrivateProjectVariant2),
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
        public bool Equals(PrivateProject other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Dust.PrivateSpace?>.Default.Equals(Space, other.Space) &&
                global::System.Collections.Generic.EqualityComparer<global::Dust.PrivateProjectVariant2?>.Default.Equals(PrivateProjectVariant2, other.PrivateProjectVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(PrivateProject obj1, PrivateProject obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PrivateProject>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(PrivateProject obj1, PrivateProject obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PrivateProject o && Equals(o);
        }
    }
}
