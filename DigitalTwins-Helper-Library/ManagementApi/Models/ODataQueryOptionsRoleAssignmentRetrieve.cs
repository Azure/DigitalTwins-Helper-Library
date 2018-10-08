// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace ConnectedGridAccelerator.ManagementApi.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ODataQueryOptionsRoleAssignmentRetrieve
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ODataQueryOptionsRoleAssignmentRetrieve class.
        /// </summary>
        public ODataQueryOptionsRoleAssignmentRetrieve()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ODataQueryOptionsRoleAssignmentRetrieve class.
        /// </summary>
        public ODataQueryOptionsRoleAssignmentRetrieve(object ifMatch = default(object), object ifNoneMatch = default(object), ODataQueryContext context = default(ODataQueryContext), object request = default(object), ODataRawQueryOptions rawValues = default(ODataRawQueryOptions), SelectExpandQueryOption selectExpand = default(SelectExpandQueryOption), FilterQueryOption filter = default(FilterQueryOption), OrderByQueryOption orderBy = default(OrderByQueryOption), SkipQueryOption skip = default(SkipQueryOption), TopQueryOption top = default(TopQueryOption), InlineCountQueryOption inlineCount = default(InlineCountQueryOption), object validator = default(object))
        {
            IfMatch = ifMatch;
            IfNoneMatch = ifNoneMatch;
            Context = context;
            Request = request;
            RawValues = rawValues;
            SelectExpand = selectExpand;
            Filter = filter;
            OrderBy = orderBy;
            Skip = skip;
            Top = top;
            InlineCount = inlineCount;
            Validator = validator;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ifMatch")]
        public object IfMatch { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ifNoneMatch")]
        public object IfNoneMatch { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "context")]
        public ODataQueryContext Context { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "request")]
        public object Request { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "rawValues")]
        public ODataRawQueryOptions RawValues { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "selectExpand")]
        public SelectExpandQueryOption SelectExpand { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "filter")]
        public FilterQueryOption Filter { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "orderBy")]
        public OrderByQueryOption OrderBy { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "skip")]
        public SkipQueryOption Skip { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "top")]
        public TopQueryOption Top { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "inlineCount")]
        public InlineCountQueryOption InlineCount { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "validator")]
        public object Validator { get; set; }

    }
}
