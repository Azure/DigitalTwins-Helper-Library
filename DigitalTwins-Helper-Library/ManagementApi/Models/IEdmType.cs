// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace ConnectedGridAccelerator.ManagementApi.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class IEdmType
    {
        /// <summary>
        /// Initializes a new instance of the IEdmType class.
        /// </summary>
        public IEdmType()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IEdmType class.
        /// </summary>
        public IEdmType(int? typeKind = default(int?))
        {
            TypeKind = typeKind;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "typeKind")]
        public int? TypeKind { get; private set; }

    }
}
