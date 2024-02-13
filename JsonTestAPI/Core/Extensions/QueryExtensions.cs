using System.Collections;
using System.Linq.Expressions;

namespace JsonTestAPI.Core.Extensions
{
    public static class QueryExtensions
    {
        public static IEnumerable<TSource> WhereIf<TSource, TInput>(this IEnumerable<TSource> source, TInput input, Func<TSource, bool> @then, Func<TSource, bool> @else = null)
        {
            return IsFilled(input) ? source.Where(@then) : @else != null ? source.Where(@else) : source;
        }

        public static IQueryable<TSource> WhereIf<TSource, TInput>(this IQueryable<TSource> source, TInput input, Expression<Func<TSource, bool>> @then, Expression<Func<TSource, bool>> @else = null)
        {
            return IsFilled(input) ? source.Where(@then) : @else != null ? source.Where(@else) : source;
        }

        public static IEnumerable<TSource> WhereIfNot<TSource, TInput>(this IEnumerable<TSource> source, TInput input, Func<TSource, bool> @then, Func<TSource, bool> @else = null)
        {
            return !IsFilled(input) ? source.Where(@then) : @else != null ? source.Where(@else) : source;
        }

        public static IQueryable<TSource> WhereIfNot<TSource, TInput>(this IQueryable<TSource> source, TInput input, Expression<Func<TSource, bool>> @then, Expression<Func<TSource, bool>> @else = null)
        {
            return !IsFilled(input) ? source.Where(@then) : @else != null ? source.Where(@else) : source;
        }

        public static bool IsFilled<TInput>(TInput input)
        {
            switch (input)
            {
                case bool b:
                    return b;
                case string s:
                    return !string.IsNullOrWhiteSpace(s);
                case IEnumerable e:
                    return e.GetEnumerator().MoveNext();
                case DateTime d:
                    return d != DateTime.MinValue;
                default:
                    return !object.Equals(input, default(TInput));
            }
        }
    }
}
