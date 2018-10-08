// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace ConnectedGridAccelerator.ManagementApi.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class UserDefinedFunctionUpdate
    {
        /// <summary>
        /// Initializes a new instance of the UserDefinedFunctionUpdate class.
        /// </summary>
        public UserDefinedFunctionUpdate()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UserDefinedFunctionUpdate class.
        /// </summary>
        /// <param name="spaceId">Parent space Id. A UDF is available to all
        /// sensors within the specified space topology that match one of its
        /// linked matchers</param>
        /// <param name="name">Name must be unique for the given space
        /// hierarchy. Can only contain alphanumeric or underscore
        /// characters.</param>
        /// <param name="friendlyName">Optional friendly name</param>
        /// <param name="description">Optional description</param>
        /// <param name="disabled">If disabled, the UDF will not be considered
        /// for execution</param>
        /// <param name="matchers">Linked matchers</param>
        public UserDefinedFunctionUpdate(System.Guid? spaceId = default(System.Guid?), string name = default(string), string friendlyName = default(string), string description = default(string), bool? disabled = default(bool?), System.Collections.Generic.IList<System.Guid?> matchers = default(System.Collections.Generic.IList<System.Guid?>))
        {
            SpaceId = spaceId;
            Name = name;
            FriendlyName = friendlyName;
            Description = description;
            Disabled = disabled;
            Matchers = matchers;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets parent space Id. A UDF is available to all sensors
        /// within the specified space topology that match one of its linked
        /// matchers
        /// </summary>
        [JsonProperty(PropertyName = "spaceId")]
        public System.Guid? SpaceId { get; set; }

        /// <summary>
        /// Gets or sets name must be unique for the given space hierarchy. Can
        /// only contain alphanumeric or underscore characters.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets optional friendly name
        /// </summary>
        [JsonProperty(PropertyName = "friendlyName")]
        public string FriendlyName { get; set; }

        /// <summary>
        /// Gets or sets optional description
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets if disabled, the UDF will not be considered for
        /// execution
        /// </summary>
        [JsonProperty(PropertyName = "disabled")]
        public bool? Disabled { get; set; }

        /// <summary>
        /// Gets or sets linked matchers
        /// </summary>
        [JsonProperty(PropertyName = "matchers")]
        public System.Collections.Generic.IList<System.Guid?> Matchers { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name != null)
            {
                if (Name.Length > 50)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "Name", 50);
                }
                if (Name.Length < 3)
                {
                    throw new ValidationException(ValidationRules.MinLength, "Name", 3);
                }
            }
            if (FriendlyName != null)
            {
                if (FriendlyName.Length > 64)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "FriendlyName", 64);
                }
                if (FriendlyName.Length < 0)
                {
                    throw new ValidationException(ValidationRules.MinLength, "FriendlyName", 0);
                }
            }
            if (Description != null)
            {
                if (Description.Length > 4000)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "Description", 4000);
                }
                if (Description.Length < 0)
                {
                    throw new ValidationException(ValidationRules.MinLength, "Description", 0);
                }
            }
        }
    }
}
