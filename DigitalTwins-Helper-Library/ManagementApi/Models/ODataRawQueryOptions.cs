// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace ConnectedGridAccelerator.ManagementApi.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ODataRawQueryOptions
    {
        /// <summary>
        /// Initializes a new instance of the ODataRawQueryOptions class.
        /// </summary>
        public ODataRawQueryOptions()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ODataRawQueryOptions class.
        /// </summary>
        public ODataRawQueryOptions(string filter = default(string), string orderBy = default(string), string top = default(string), string skip = default(string), string select = default(string), string expand = default(string), string inlineCount = default(string), string format = default(string), string skipToken = default(string))
        {
            Filter = filter;
            OrderBy = orderBy;
            Top = top;
            Skip = skip;
            Select = select;
            Expand = expand;
            InlineCount = inlineCount;
            Format = format;
            SkipToken = skipToken;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "filter")]
        public string Filter { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "orderBy")]
        public string OrderBy { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "top")]
        public string Top { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "skip")]
        public string Skip { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "select")]
        public string Select { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "expand")]
        public string Expand { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "inlineCount")]
        public string InlineCount { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "format")]
        public string Format { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "skipToken")]
        public string SkipToken { get; private set; }

    }
}
