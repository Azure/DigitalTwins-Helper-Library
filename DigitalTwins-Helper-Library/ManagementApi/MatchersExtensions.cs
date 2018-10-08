// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace ConnectedGridAccelerator.ManagementApi
{
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for Matchers.
    /// </summary>
    public static partial class MatchersExtensions
    {
            /// <summary>
            /// Retrieves matchers
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='ids'>
            /// Optional ';' delimited list of ids
            /// </param>
            /// <param name='names'>
            /// Optional ';' delimited list of names
            /// </param>
            /// <param name='includes'>
            /// Comma separated list of what to include, for example "Space,Condition".
            /// Defaults to None. Possible values include: 'None', 'Description',
            /// 'FullPath', 'Space', 'Conditions', 'UserDefinedFunctions'
            /// </param>
            /// <param name='spaceId'>
            /// Optionally filter on objects based on their location in the topology
            /// relative to the specified spaceId
            /// </param>
            /// <param name='traverse'>
            /// None (the default) for the specified spaceId only, Down for space and
            /// descendants, Up for spaceId and ancestors, Any for both. Possible values
            /// include: 'None', 'Down', 'Up', 'Span'
            /// </param>
            /// <param name='minLevel'>
            /// Optional filter on minimum level, inclusive
            /// </param>
            /// <param name='maxLevel'>
            /// Optional filter on maximum level, inclusive
            /// </param>
            /// <param name='minRelative'>
            /// Specify if min level is absolute or relative
            /// </param>
            /// <param name='maxRelative'>
            /// Specify if max level is absolute or relative
            /// </param>
            /// <param name='filter'>
            /// Odata Filter parameter
            /// </param>
            /// <param name='orderby'>
            /// Odata OrderBy parameter
            /// </param>
            /// <param name='skip'>
            /// Odata Skip parameter
            /// </param>
            /// <param name='top'>
            /// Odata Top parameter
            /// </param>
            public static System.Collections.Generic.IList<MatcherRetrieve> Retrieve(this IMatchers operations, string ids = default(string), string names = default(string), string includes = default(string), System.Guid? spaceId = default(System.Guid?), string traverse = default(string), int? minLevel = default(int?), int? maxLevel = default(int?), bool? minRelative = default(bool?), bool? maxRelative = default(bool?), string filter = default(string), string orderby = default(string), int? skip = default(int?), int? top = default(int?))
            {
                return operations.RetrieveAsync(ids, names, includes, spaceId, traverse, minLevel, maxLevel, minRelative, maxRelative, filter, orderby, skip, top).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieves matchers
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='ids'>
            /// Optional ';' delimited list of ids
            /// </param>
            /// <param name='names'>
            /// Optional ';' delimited list of names
            /// </param>
            /// <param name='includes'>
            /// Comma separated list of what to include, for example "Space,Condition".
            /// Defaults to None. Possible values include: 'None', 'Description',
            /// 'FullPath', 'Space', 'Conditions', 'UserDefinedFunctions'
            /// </param>
            /// <param name='spaceId'>
            /// Optionally filter on objects based on their location in the topology
            /// relative to the specified spaceId
            /// </param>
            /// <param name='traverse'>
            /// None (the default) for the specified spaceId only, Down for space and
            /// descendants, Up for spaceId and ancestors, Any for both. Possible values
            /// include: 'None', 'Down', 'Up', 'Span'
            /// </param>
            /// <param name='minLevel'>
            /// Optional filter on minimum level, inclusive
            /// </param>
            /// <param name='maxLevel'>
            /// Optional filter on maximum level, inclusive
            /// </param>
            /// <param name='minRelative'>
            /// Specify if min level is absolute or relative
            /// </param>
            /// <param name='maxRelative'>
            /// Specify if max level is absolute or relative
            /// </param>
            /// <param name='filter'>
            /// Odata Filter parameter
            /// </param>
            /// <param name='orderby'>
            /// Odata OrderBy parameter
            /// </param>
            /// <param name='skip'>
            /// Odata Skip parameter
            /// </param>
            /// <param name='top'>
            /// Odata Top parameter
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<System.Collections.Generic.IList<MatcherRetrieve>> RetrieveAsync(this IMatchers operations, string ids = default(string), string names = default(string), string includes = default(string), System.Guid? spaceId = default(System.Guid?), string traverse = default(string), int? minLevel = default(int?), int? maxLevel = default(int?), bool? minRelative = default(bool?), bool? maxRelative = default(bool?), string filter = default(string), string orderby = default(string), int? skip = default(int?), int? top = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.RetrieveWithHttpMessagesAsync(ids, names, includes, spaceId, traverse, minLevel, maxLevel, minRelative, maxRelative, filter, orderby, skip, top, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a matcher
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='data'>
            /// The matcher information
            /// </param>
            public static System.Guid? Create(this IMatchers operations, MatcherCreate data)
            {
                return operations.CreateAsync(data).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a matcher
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='data'>
            /// The matcher information
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<System.Guid?> CreateAsync(this IMatchers operations, MatcherCreate data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(data, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Retrieves a matcher
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// Matcher identifier
            /// </param>
            /// <param name='includes'>
            /// Comma separated list of what to include. Possible values include: 'None',
            /// 'Description', 'FullPath', 'Space', 'Conditions', 'UserDefinedFunctions'
            /// </param>
            public static MatcherRetrieve RetrieveById(this IMatchers operations, System.Guid id, string includes = default(string))
            {
                return operations.RetrieveByIdAsync(id, includes).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieves a matcher
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// Matcher identifier
            /// </param>
            /// <param name='includes'>
            /// Comma separated list of what to include. Possible values include: 'None',
            /// 'Description', 'FullPath', 'Space', 'Conditions', 'UserDefinedFunctions'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<MatcherRetrieve> RetrieveByIdAsync(this IMatchers operations, System.Guid id, string includes = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.RetrieveByIdWithHttpMessagesAsync(id, includes, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the given matcher
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// Matcher identifier
            /// </param>
            public static void Delete(this IMatchers operations, System.Guid id)
            {
                operations.DeleteAsync(id).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the given matcher
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// Matcher identifier
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task DeleteAsync(this IMatchers operations, System.Guid id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(id, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Update a matcher
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// Matcher identifier
            /// </param>
            /// <param name='data'>
            /// The matcher information
            /// </param>
            public static void Update(this IMatchers operations, System.Guid id, MatcherUpdate data)
            {
                operations.UpdateAsync(id, data).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update a matcher
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// Matcher identifier
            /// </param>
            /// <param name='data'>
            /// The matcher information
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task UpdateAsync(this IMatchers operations, System.Guid id, MatcherUpdate data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                (await operations.UpdateWithHttpMessagesAsync(id, data, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Evaluates the matcher for a sensor
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// Matcher identifier
            /// </param>
            /// <param name='sensorId'>
            /// Sensor identifier
            /// </param>
            /// <param name='enableLogging'>
            /// If true, return verbose logs for the evaluation
            /// </param>
            public static MatcherEvaluationResults Evaluate(this IMatchers operations, System.Guid id, System.Guid sensorId, bool? enableLogging = default(bool?))
            {
                return operations.EvaluateAsync(id, sensorId, enableLogging).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Evaluates the matcher for a sensor
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// Matcher identifier
            /// </param>
            /// <param name='sensorId'>
            /// Sensor identifier
            /// </param>
            /// <param name='enableLogging'>
            /// If true, return verbose logs for the evaluation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<MatcherEvaluationResults> EvaluateAsync(this IMatchers operations, System.Guid id, System.Guid sensorId, bool? enableLogging = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.EvaluateWithHttpMessagesAsync(id, sensorId, enableLogging, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
