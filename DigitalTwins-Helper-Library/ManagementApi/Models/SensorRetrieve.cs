// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace ConnectedGridAccelerator.ManagementApi.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Sensor retrieve model
    /// </summary>
    public partial class SensorRetrieve
    {
        /// <summary>
        /// Initializes a new instance of the SensorRetrieve class.
        /// </summary>
        public SensorRetrieve()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SensorRetrieve class.
        /// </summary>
        /// <param name="pollRate">Poll rate for data collection from the
        /// sensor</param>
        /// <param name="spaceId">Parent space Id</param>
        /// <param name="deviceId">Parent device id</param>
        /// <param name="id">Unique identifier</param>
        /// <param name="portTypeId">Port type identifier</param>
        /// <param name="dataUnitTypeId">Data type unit identifier</param>
        /// <param name="dataTypeId">Data type identifier</param>
        /// <param name="typeId">Type identifier</param>
        /// <param name="port">Serial port the sensor connects to on the
        /// device</param>
        /// <param name="dataType">Type of data reported by the sensor</param>
        /// <param name="dataSubtype">Subtype for the data</param>
        /// <param name="type">Type of sensor</param>
        /// <param name="portType">Type of port; for example AnalogInput.
        /// Defaults to None</param>
        /// <param name="dataUnitType">Type of unit; for example
        /// CelsiusTemperature if DataType is set to Temperature. Defaults to
        /// None</param>
        /// <param name="dataSubtypeId">Data subtype identifier</param>
        /// <param name="device">Parent device</param>
        /// <param name="space">Parent space</param>
        /// <param name="value">Last recorded value</param>
        /// <param name="hardwareId">Hardware unique identifier, such as a MAC
        /// address.</param>
        public SensorRetrieve(int pollRate, System.Guid spaceId, System.Guid deviceId, System.Guid id, int portTypeId, int dataUnitTypeId, int dataTypeId, int typeId, string port = default(string), string dataType = default(string), string dataSubtype = default(string), string type = default(string), string portType = default(string), string dataUnitType = default(string), Location location = default(Location), int? dataSubtypeId = default(int?), DeviceRetrieve device = default(DeviceRetrieve), SpaceRetrieve space = default(SpaceRetrieve), System.Collections.Generic.IList<ExtendedPropertyRetrieve> properties = default(System.Collections.Generic.IList<ExtendedPropertyRetrieve>), Location effectiveLocation = default(Location), string fullName = default(string), System.Collections.Generic.IList<string> spacePaths = default(System.Collections.Generic.IList<string>), SensorValue value = default(SensorValue), string hardwareId = default(string))
        {
            Port = port;
            PollRate = pollRate;
            DataType = dataType;
            DataSubtype = dataSubtype;
            Type = type;
            PortType = portType;
            DataUnitType = dataUnitType;
            SpaceId = spaceId;
            Location = location;
            DeviceId = deviceId;
            Id = id;
            PortTypeId = portTypeId;
            DataUnitTypeId = dataUnitTypeId;
            DataTypeId = dataTypeId;
            DataSubtypeId = dataSubtypeId;
            TypeId = typeId;
            Device = device;
            Space = space;
            Properties = properties;
            EffectiveLocation = effectiveLocation;
            FullName = fullName;
            SpacePaths = spacePaths;
            Value = value;
            HardwareId = hardwareId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets serial port the sensor connects to on the device
        /// </summary>
        [JsonProperty(PropertyName = "port")]
        public string Port { get; set; }

        /// <summary>
        /// Gets or sets poll rate for data collection from the sensor
        /// </summary>
        [JsonProperty(PropertyName = "pollRate")]
        public int PollRate { get; set; }

        /// <summary>
        /// Gets or sets type of data reported by the sensor
        /// </summary>
        [JsonProperty(PropertyName = "dataType")]
        public string DataType { get; set; }

        /// <summary>
        /// Gets or sets subtype for the data
        /// </summary>
        [JsonProperty(PropertyName = "dataSubtype")]
        public string DataSubtype { get; set; }

        /// <summary>
        /// Gets or sets type of sensor
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets type of port; for example AnalogInput. Defaults to
        /// None
        /// </summary>
        [JsonProperty(PropertyName = "portType")]
        public string PortType { get; set; }

        /// <summary>
        /// Gets or sets type of unit; for example CelsiusTemperature if
        /// DataType is set to Temperature. Defaults to None
        /// </summary>
        [JsonProperty(PropertyName = "dataUnitType")]
        public string DataUnitType { get; set; }

        /// <summary>
        /// Gets or sets parent space Id
        /// </summary>
        [JsonProperty(PropertyName = "spaceId")]
        public System.Guid SpaceId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public Location Location { get; set; }

        /// <summary>
        /// Gets or sets parent device id
        /// </summary>
        [JsonProperty(PropertyName = "deviceId")]
        public System.Guid DeviceId { get; set; }

        /// <summary>
        /// Gets or sets unique identifier
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public System.Guid Id { get; set; }

        /// <summary>
        /// Gets or sets port type identifier
        /// </summary>
        [JsonProperty(PropertyName = "portTypeId")]
        public int PortTypeId { get; set; }

        /// <summary>
        /// Gets or sets data type unit identifier
        /// </summary>
        [JsonProperty(PropertyName = "dataUnitTypeId")]
        public int DataUnitTypeId { get; set; }

        /// <summary>
        /// Gets or sets data type identifier
        /// </summary>
        [JsonProperty(PropertyName = "dataTypeId")]
        public int DataTypeId { get; set; }

        /// <summary>
        /// Gets or sets data subtype identifier
        /// </summary>
        [JsonProperty(PropertyName = "dataSubtypeId")]
        public int? DataSubtypeId { get; set; }

        /// <summary>
        /// Gets or sets type identifier
        /// </summary>
        [JsonProperty(PropertyName = "typeId")]
        public int TypeId { get; set; }

        /// <summary>
        /// Gets or sets parent device
        /// </summary>
        [JsonProperty(PropertyName = "device")]
        public DeviceRetrieve Device { get; set; }

        /// <summary>
        /// Gets or sets parent space
        /// </summary>
        [JsonProperty(PropertyName = "space")]
        public SpaceRetrieve Space { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public System.Collections.Generic.IList<ExtendedPropertyRetrieve> Properties { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "effectiveLocation")]
        public Location EffectiveLocation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "fullName")]
        public string FullName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spacePaths")]
        public System.Collections.Generic.IList<string> SpacePaths { get; set; }

        /// <summary>
        /// Gets last recorded value
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public SensorValue Value { get; private set; }

        /// <summary>
        /// Gets or sets hardware unique identifier, such as a MAC address.
        /// </summary>
        [JsonProperty(PropertyName = "hardwareId")]
        public string HardwareId { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Location != null)
            {
                Location.Validate();
            }
            if (Device != null)
            {
                Device.Validate();
            }
            if (Space != null)
            {
                Space.Validate();
            }
            if (EffectiveLocation != null)
            {
                EffectiveLocation.Validate();
            }
        }
    }
}
