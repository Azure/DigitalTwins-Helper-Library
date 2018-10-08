// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace ConnectedGridAccelerator.ManagementApi.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class IEdmTypeReference
    {
        /// <summary>
        /// Initializes a new instance of the IEdmTypeReference class.
        /// </summary>
        public IEdmTypeReference()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IEdmTypeReference class.
        /// </summary>
        public IEdmTypeReference(bool? isNullable = default(bool?), IEdmType definition = default(IEdmType))
        {
            IsNullable = isNullable;
            Definition = definition;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isNullable")]
        public bool? IsNullable { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "definition")]
        public IEdmType Definition { get; private set; }

    }
}
