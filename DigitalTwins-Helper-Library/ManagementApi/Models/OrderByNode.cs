// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace ConnectedGridAccelerator.ManagementApi.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class OrderByNode
    {
        /// <summary>
        /// Initializes a new instance of the OrderByNode class.
        /// </summary>
        public OrderByNode()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OrderByNode class.
        /// </summary>
        public OrderByNode(int? direction = default(int?))
        {
            Direction = direction;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "direction")]
        public int? Direction { get; private set; }

    }
}
